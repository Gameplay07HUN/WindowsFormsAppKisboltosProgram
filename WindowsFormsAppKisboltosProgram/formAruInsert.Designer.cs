namespace WindowsFormsAppKisboltosProgram
{
    partial class formAruInsert
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAruneve = new System.Windows.Forms.TextBox();
            this.textBoxMarka = new System.Windows.Forms.TextBox();
            this.buttonUj = new System.Windows.Forms.Button();
            this.numericUpDownEladasiar = new System.Windows.Forms.NumericUpDown();
            this.textBoxKategória = new System.Windows.Forms.TextBox();
            this.textBoxCikkszam = new System.Windows.Forms.TextBox();
            this.dataGridViewKisBolt = new System.Windows.Forms.DataGridView();
            this.groupBoxKisBolt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEladasiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKisBolt)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxKisBolt
            // 
            this.groupBoxKisBolt.AccessibleDescription = "c";
            this.groupBoxKisBolt.Controls.Add(this.label5);
            this.groupBoxKisBolt.Controls.Add(this.label4);
            this.groupBoxKisBolt.Controls.Add(this.label3);
            this.groupBoxKisBolt.Controls.Add(this.label2);
            this.groupBoxKisBolt.Controls.Add(this.label1);
            this.groupBoxKisBolt.Controls.Add(this.textBoxAruneve);
            this.groupBoxKisBolt.Controls.Add(this.textBoxMarka);
            this.groupBoxKisBolt.Controls.Add(this.buttonUj);
            this.groupBoxKisBolt.Controls.Add(this.numericUpDownEladasiar);
            this.groupBoxKisBolt.Controls.Add(this.textBoxKategória);
            this.groupBoxKisBolt.Controls.Add(this.textBoxCikkszam);
            this.groupBoxKisBolt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxKisBolt.Location = new System.Drawing.Point(0, 0);
            this.groupBoxKisBolt.Name = "groupBoxKisBolt";
            this.groupBoxKisBolt.Size = new System.Drawing.Size(800, 127);
            this.groupBoxKisBolt.TabIndex = 9;
            this.groupBoxKisBolt.TabStop = false;
            this.groupBoxKisBolt.Text = "Kiválasztott termék adatai";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(710, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Márka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(566, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Eladási ár";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Áru neve";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kategória";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cikkszám";
            // 
            // textBoxAruneve
            // 
            this.textBoxAruneve.AccessibleDescription = "c";
            this.textBoxAruneve.Location = new System.Drawing.Point(276, 31);
            this.textBoxAruneve.Name = "textBoxAruneve";
            this.textBoxAruneve.Size = new System.Drawing.Size(253, 20);
            this.textBoxAruneve.TabIndex = 8;
            // 
            // textBoxMarka
            // 
            this.textBoxMarka.AccessibleDescription = "c";
            this.textBoxMarka.Location = new System.Drawing.Point(661, 31);
            this.textBoxMarka.Name = "textBoxMarka";
            this.textBoxMarka.Size = new System.Drawing.Size(127, 20);
            this.textBoxMarka.TabIndex = 7;
            // 
            // buttonUj
            // 
            this.buttonUj.AccessibleDescription = "c";
            this.buttonUj.Location = new System.Drawing.Point(364, 58);
            this.buttonUj.Name = "buttonUj";
            this.buttonUj.Size = new System.Drawing.Size(75, 23);
            this.buttonUj.TabIndex = 4;
            this.buttonUj.Text = "Új áru";
            this.buttonUj.UseVisualStyleBackColor = true;
            this.buttonUj.Click += new System.EventHandler(this.buttonUj_Click);
            // 
            // numericUpDownEladasiar
            // 
            this.numericUpDownEladasiar.AccessibleDescription = "c";
            this.numericUpDownEladasiar.Location = new System.Drawing.Point(535, 32);
            this.numericUpDownEladasiar.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDownEladasiar.Name = "numericUpDownEladasiar";
            this.numericUpDownEladasiar.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownEladasiar.TabIndex = 2;
            // 
            // textBoxKategória
            // 
            this.textBoxKategória.AccessibleDescription = "c";
            this.textBoxKategória.Location = new System.Drawing.Point(155, 31);
            this.textBoxKategória.Name = "textBoxKategória";
            this.textBoxKategória.Size = new System.Drawing.Size(115, 20);
            this.textBoxKategória.TabIndex = 1;
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
            this.dataGridViewKisBolt.TabIndex = 8;
            this.dataGridViewKisBolt.SelectionChanged += new System.EventHandler(this.dataGridViewKisBolt_SelectionChanged);
            // 
            // formAruInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxKisBolt);
            this.Controls.Add(this.dataGridViewKisBolt);
            this.Name = "formAruInsert";
            this.Text = "formAruInsert";
            this.Load += new System.EventHandler(this.formAruInsert_Load);
            this.groupBoxKisBolt.ResumeLayout(false);
            this.groupBoxKisBolt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEladasiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKisBolt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxKisBolt;
        private System.Windows.Forms.Button buttonUj;
        private System.Windows.Forms.NumericUpDown numericUpDownEladasiar;
        private System.Windows.Forms.TextBox textBoxKategória;
        private System.Windows.Forms.TextBox textBoxCikkszam;
        private System.Windows.Forms.DataGridView dataGridViewKisBolt;
        private System.Windows.Forms.TextBox textBoxAruneve;
        private System.Windows.Forms.TextBox textBoxMarka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}