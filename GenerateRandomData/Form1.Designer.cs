﻿namespace GenerateRandomData
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.cboTabelle = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textScript = new System.Windows.Forms.TextBox();
            this.numRecord = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1152, 148);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 121);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connetti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboTabelle
            // 
            this.cboTabelle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTabelle.FormattingEnabled = true;
            this.cboTabelle.Location = new System.Drawing.Point(61, 254);
            this.cboTabelle.Margin = new System.Windows.Forms.Padding(6);
            this.cboTabelle.Name = "cboTabelle";
            this.cboTabelle.Size = new System.Drawing.Size(591, 33);
            this.cboTabelle.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 65);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(710, 31);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Server Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(816, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tabelle";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(64, 148);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1055, 92);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Server=localhost\\fastcodehome;Database=WSSANTEX_SVILUPPO_IMPEXP\r\n;Trusted_Connect" +
    "ion=True;";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Connection String";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(664, 252);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 121);
            this.button2.TabIndex = 7;
            this.button2.Text = "Esegui";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textScript
            // 
            this.textScript.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textScript.Location = new System.Drawing.Point(0, 398);
            this.textScript.Margin = new System.Windows.Forms.Padding(6);
            this.textScript.Multiline = true;
            this.textScript.Name = "textScript";
            this.textScript.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textScript.Size = new System.Drawing.Size(1418, 334);
            this.textScript.TabIndex = 8;
            // 
            // numRecord
            // 
            this.numRecord.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numRecord.Location = new System.Drawing.Point(899, 298);
            this.numRecord.Margin = new System.Windows.Forms.Padding(6);
            this.numRecord.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.numRecord.Name = "numRecord";
            this.numRecord.Size = new System.Drawing.Size(240, 31);
            this.numRecord.TabIndex = 9;
            this.numRecord.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 732);
            this.Controls.Add(this.numRecord);
            this.Controls.Add(this.textScript);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cboTabelle);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboTabelle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textScript;
        private System.Windows.Forms.NumericUpDown numRecord;
    }
}

