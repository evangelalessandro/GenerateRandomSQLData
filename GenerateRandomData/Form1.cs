using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerateRandomData
{
    public partial class Form1 : Form
    {
        List<IdentityObject> _columns = null;
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var sqlconn = new System.Data.SqlClient.SqlConnection(textBox2.Text))
            {
                try
                {
                    sqlconn.Open();
                    var allColumnsSchemaTable = sqlconn.GetSchema("Columns");

                    var query =
                        from order in allColumnsSchemaTable.AsEnumerable()
                        select new 
                        {
                            NomeTabella =
                                order.Field<string>("TABLE_NAME"),
                            NomeColonna =
                                order.Field<string>("COLUMN_NAME"),
                            TipoDato =
                                order.Field<string>("DATA_TYPE") ,
                            MaxLenght =
                                order.Field<Nullable<int>>("CHARACTER_MAXIMUM_LENGTH") 
                    };  



                    _columns = query.ToList().Select( a=>new IdentityObject
                    { NomeColonna = a.NomeColonna, NomeTabella = 
                    a.NomeTabella, MaxLenght = a.MaxLenght.GetValueOrDefault(0),
                        TipoDato = a.TipoDato }).ToList();

                    sqlconn.Close();
                    button2.Enabled = true;
                    FillComboTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }


        private void FillComboTable()
        {
            cboTabelle.Items.Clear();
            cboTabelle.Items.Add("<Seleziona tabella>");
            string sqltext = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' and TABLE_NAME<>'sysdiagrams'";

            foreach (DataRow item in getDataTable(sqltext).Rows)
            {
                cboTabelle.Items.Add(item[0].ToString());
            }

            cboTabelle.SelectedIndex = 0;
        }

        private DataTable getDataTable(string sqltext)
        {
            using (var sqlconn = new System.Data.SqlClient.SqlConnection(textBox2.Text))
            {
                sqlconn.Open();
               
                using (var da = new System.Data.SqlClient.SqlDataAdapter(sqltext, sqlconn))
                {

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreaScript();

        }

        private void CreaScript()
        {
            System.Text.StringBuilder script = new StringBuilder();
            script.Append("DECLARE @RowCount INT \r\nDECLARE @RowString VARCHAR(10) \r\nDECLARE @Random INT \r\n");


            script.AppendLine("SET @RowCount = 0");
            script.AppendLine("WHILE @RowCount < " + numRecord.Value);
            script.AppendLine("BEGIN");
            script.AppendLine("    INSERT INTO " + cboTabelle.Text);
            script.AppendLine("    (");

            UpdateListTableColIdentity();
            bool first = false;
            var colonne = _columns.Where(a => a.NomeTabella == cboTabelle.Text && a.IsIdentity == false && a.IsRowGuid == false).ToList();
            var maxColonnaNameLenght= colonne.Select(a => a.NomeColonna.Length).Max();
            foreach (var item in colonne)
            {
                formartVirgola(script, first);
                first = true;
                //if (identityList.Where(a=>a.NomeTabella==cboTabelle.Text && a.NomeColonna==)
                script.Append(item.NomeColonna.PadRight(maxColonnaNameLenght));
            }
            script.AppendLine("    )");
            script.AppendLine("    VALUES (");
            first = false;
            foreach (var item in colonne)
            {
                formartVirgola(script, first);

                first = true;
                if (item.TipoDato == "nvarchar")
                {
                    var str = "";
                    for (int i = 0; i < item.MaxLenght; i++)
                    {
                        str += "A";
                        if (i > 10)
                            break;
                    }
                    script.Append("'" + str + "'");
                }
                else if (item.TipoDato == "int")
                {
                    script.Append("1");
                }
                else if (item.TipoDato == "datetime")
                {
                    script.Append("getdate()");
                }
                else if (item.TipoDato == "decimal")
                {
                    script.Append("0");
                }
                else if (item.TipoDato == "bit")
                {
                    script.Append("0");
                }
                else
                {

                }
            }
            script.AppendLine("    )");


            script.AppendLine("SET @RowCount = @RowCount + 1");
            script.AppendLine("END");
            textScript.Text = script.ToString();

        }

        private static void formartVirgola(StringBuilder script, bool first)
        {
            if (first)
            {
                script.Append("    ,");
            }
            else
            {
                script.Append("    ");
            }
        }

        private void UpdateListTableColIdentity()
        {
            var dt = getDataTable(
                 "SELECT obj.name as TABLE_NAME,	col.name as COLUMN_NAME,[is_rowguidcol] ,[is_identity] " +
                " FROM[WSSANTEX_SVILUPPO_IMPEXP].[sys].[all_objects] " +
                " obj inner join sys.all_columns col  " +
                " on obj.object_id= col.object_id " +
                " where is_rowguidcol = 1 or is_identity = 1 ");


            var query =
                from order in dt.AsEnumerable()
                select new IdentityObject
                {
                    NomeTabella =
                        order.Field<string>("TABLE_NAME"),
                    NomeColonna =
                        order.Field<string>("COLUMN_NAME"),
                    IsRowGuid =
                        order.Field<bool>("is_rowguidcol"),
                    IsIdentity =
                        order.Field<bool>("is_identity")
                };
            var dati= query.ToList();

            foreach (var item in dati)
            {
                var itemSel=_columns.Where(a => a.NomeTabella == item.NomeTabella && a.NomeColonna == item.NomeColonna).FirstOrDefault();
                if (itemSel!=null)
                { 
                    itemSel.IsIdentity = item.IsIdentity;
                    itemSel.IsRowGuid = item.IsRowGuid;
                }
            }
            

        }
        
           

       

    }

}
