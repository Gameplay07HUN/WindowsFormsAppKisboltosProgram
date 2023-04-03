namespace WindowsFormsAppKisboltosProgram
{
    partial class formRendelesEdit
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
            this.groupBoxKisBolt = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDatum = new System.Windows.Forms.DateTimePicker();
            this.textBoxMennyiseg = new System.Windows.Forms.TextBox();
            this.buttonModosit = new System.Windows.Forms.Button();
            this.numericUpDownBeszerzesiar = new System.Windows.Forms.NumericUpDown();
            this.textBoxVevoKod = new System.Windows.Forms.TextBox();
            this.textBoxCikkszam = new System.Windows.Forms.TextBox();
            this.dataGridViewKisBolt = new System.Windows.Forms.DataGridView();
            this.groupBoxKisBolt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeszerzesiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKisBolt)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxKisBolt
            // 
            this.groupBoxKisBolt.AccessibleDescription = "c";
            this.groupBoxKisBolt.Controls.Add(this.dateTimePickerDatum);
            this.groupBoxKisBolt.Controls.Add(this.textBoxMennyiseg);
            this.groupBoxKisBolt.Controls.Add(this.buttonModosit);
            this.groupBoxKisBolt.Controls.Add(this.numericUpDownBeszerzesiar);
            this.groupBoxKisBolt.Controls.Add(this.textBoxVevoKod);
            this.groupBoxKisBolt.Controls.Add(this.textBoxCikkszam);
            this.groupBoxKisBolt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxKisBolt.Location = new System.Drawing.Point(0, 0);
            this.groupBoxKisBolt.Name = "groupBoxKisBolt";
            this.groupBoxKisBolt.Size = new System.Drawing.Size(800, 127);
            this.groupBoxKisBolt.TabIndex = 13;
            this.groupBoxKisBolt.TabStop = false;
            this.groupBoxKisBolt.Text = "Kiválasztott termék adatai";
            // 
            // dateTimePickerDatum
            // 
            this.dateTimePickerDatum.Location = new System.Drawing.Point(276, 31);
            this.dateTimePickerDatum.Name = "dateTimePickerDatum";
            this.dateTimePickerDatum.Size = new System.Drawing.Size(253, 20);
            this.dateTimePickerDatum.TabIndex = 8;
            // 
            // textBoxMennyiseg
            // 
            this.textBoxMennyiseg.AccessibleDescription = "c";
            this.textBoxMennyiseg.Location = new System.Drawing.Point(535, 31);
            this.textBoxMennyiseg.Name = "textBoxMennyiseg";
            this.textBoxMennyiseg.Size = new System.Drawing.Size(127, 20);
            this.textBoxMennyiseg.TabIndex = 7;
            // 
            // buttonModosit
            // 
            this.buttonModosit.AccessibleDescription = "c";
            this.buttonModosit.Location = new System.Drawing.Point(323, 58);
            this.buttonModosit.Name = "buttonModosit";
            this.buttonModosit.Size = new System.Drawing.Size(116, 23);
            this.buttonModosit.TabIndex = 4;
            this.buttonModosit.Text = "Rendeles módosítás";
            this.buttonModosit.UseVisualStyleBackColor = true;
            this.buttonModosit.Click += new System.EventHandler(this.buttonModosit_Click);
            // 
            // numericUpDownBeszerzesiar
            // 
            this.numericUpDownBeszerzesiar.AccessibleDescription = "c";
            this.numericUpDownBeszerzesiar.Location = new System.Drawing.Point(668, 31);
            this.numericUpDownBeszerzesiar.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDownBeszerzesiar.Name = "numericUpDownBeszerzesiar";
            this.numericUpDownBeszerzesiar.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownBeszerzesiar.TabIndex = 2;
            // 
            // textBoxVevoKod
            // 
            this.textBoxVevoKod.AccessibleDescription = "c";
            this.textBoxVevoKod.Location = new System.Drawing.Point(155, 31);
            this.textBoxVevoKod.Name = "textBoxVevoKod";
            this.textBoxVevoKod.Size = new System.Drawing.Size(115, 20);
            this.textBoxVevoKod.TabIndex = 1;
            // 
            // textBoxCikkszam
            // 
            this.textBoxCikkszam.AccessibleDescription = "c";
            this.textBoxCikkszam.Location = new System.Drawing.Point(6, 32);
            this.textBoxCikkszam.Name = "textBoxCikkszam";
            this.textBoxCikkszam.Size = new System.Drawing.Size(143, 20);
            this.textBoxCikkszam.TabIndex = 0;
            // 
            // dataGridViewKisBolt
            // 
            this.dataGridViewKisBolt.AccessibleDescription = "c";
            this.dataGridViewKisBolt.AllowUserToDeleteRows = false;
            this.dataGridViewKisBolt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKisBolt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewKisBolt.Location = new System.Drawing.Point(0, 127);
            this.dataGridViewKisBolt.Name = "dataGridViewKisBolt";
            this.dataGridViewKisBolt.ReadOnly = true;
            this.dataGridViewKisBolt.Size = new System.Drawing.Size(800, 323);
            this.dataGridViewKisBolt.TabIndex = 12;
            this.dataGridViewKisBolt.SelectionChanged += new System.EventHandler(this.dataGridViewKisBolt_SelectionChanged);
            // 
            // formRendelesEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxKisBolt);
            this.Controls.Add(this.dataGridViewKisBolt);
            this.Name = "formRendelesEdit";
            this.Text = "formRendelesEdit";
            this.Load += new System.EventHandler(this.formRendelesEdit_Load);
            this.groupBoxKisBolt.ResumeLayout(false);
            this.groupBoxKisBolt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeszerzesiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKisBolt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxKisBolt;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatum;
        private System.Windows.Forms.TextBox textBoxMennyiseg;
        private System.Windows.Forms.Button buttonModosit;
        private System.Windows.Forms.NumericUpDown numericUpDownBeszerzesiar;
        private System.Windows.Forms.TextBox textBoxVevoKod;
        private System.Windows.Forms.TextBox textBoxCikkszam;
        private System.Windows.Forms.DataGridView dataGridViewKisBolt;
    }
}