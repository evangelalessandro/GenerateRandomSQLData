using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateRandomData
{
    public class IdentityObject
    {
        public string NomeTabella { get; set; }
        public string NomeColonna { get; set; }
        public bool IsRowGuid { get; set; }
        public bool IsIdentity { get; set; }
        public string TipoDato { get; set; }

        public enTypeData Tipo {
            get {

                if (TipoDato == "nvarchar")
                {
                    return enTypeData.nvarcharD;
                }
                else if (TipoDato == "int")
                {
                    return enTypeData.intD;
                }
                else if (TipoDato == "datetime")
                {
                    return enTypeData.datetimeD;
                }
                else if (TipoDato == "decimal")
                {
                    return enTypeData.decimalD;
                }
                else if (TipoDato == "bit")
                {
                    return enTypeData.bitD;
                }
                else
                {
                    throw new Exception("Tipo dato non gestito");
                }
            }
        }
        public int MaxLenght { get; set; }
    }
}
