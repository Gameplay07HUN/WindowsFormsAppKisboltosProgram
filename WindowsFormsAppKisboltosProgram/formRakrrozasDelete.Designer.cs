namespace WindowsFormsAppKisboltosProgram
{
    partial class formRakrrozasDelete
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
            this.textBoxRaktarkod = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxCikkszam = new System.Windows.Forms.TextBox();
            this.groupBoxKisBolt = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewKisBolt1 = new System.Windows.Forms.DataGridView();
            this.groupBoxKisBolt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKisBolt1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxRaktarkod
            // 
            this.textBoxRaktarkod.AccessibleDescription = "c";
            this.textBoxRaktarkod.Location = new System.Drawing.Point(155, 32);
            this.textBoxRaktarkod.Name = "textBoxRaktarkod";
            this.textBoxRaktarkod.Size = new System.Drawing.Size(143, 20);
            this.textBoxRaktarkod.TabIndex = 5;
            // 
            // buttonDelete
            // 
            this.buttonDelete.AccessibleDescription = "c";
            this.buttonDelete.Location = new System.Drawing.Point(364, 58);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(104, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Raktározás törlése";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxCikkszam
            // 
            this.textBoxCikkszam.AccessibleDescription = "c";
            this.textBoxCikkszam.Location = new System.Drawing.Point(6, 32);
            this.textBoxCikkszam.Name = "textBoxCikkszam";
            this.textBoxCikkszam.Size = new System.Drawing.Size(143, 20);
            this.textBoxCikkszam.TabIndex = 0;
            // 
            // groupBoxKisBolt
            // 
            this.groupBoxKisBolt.AccessibleDescription = "c";
            this.groupBoxKisBolt.Controls.Add(this.dataGridViewKisBolt1);
            this.groupBoxKisBolt.Controls.Add(this.label1);
            this.groupBoxKisBolt.Controls.Add(this.label2);
            this.groupBoxKisBolt.Controls.Add(this.textBoxRaktarkod);
            this.groupBoxKisBolt.Controls.Add(this.buttonDelete);
            this.groupBoxKisBolt.Controls.Add(this.textBoxCikkszam);
            this.groupBoxKisBolt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxKisBolt.Location = new System.Drawing.Point(0, 0);
            this.groupBoxKisBolt.Name = "groupBoxKisBolt";
            this.groupBoxKisBolt.Size = new System.Drawing.Size(800, 450);
            this.groupBoxKisBolt.TabIndex = 15;
            this.groupBoxKisBolt.TabStop = false;
            this.groupBoxKisBolt.Text = "Kiválasztott raktározás adatai";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Raktárkód";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cikkszám";
            // 
            // dataGridViewKisBolt1
            // 
            this.dataGridViewKisBolt1.AccessibleDescription = "c";
            this.dataGridViewKisBolt1.AllowUserToDeleteRows = false;
            this.dataGridViewKisBolt1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKisBolt1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewKisBolt1.Location = new System.Drawing.Point(3, 124);
            this.dataGridViewKisBolt1.Name = "dataGridViewKisBolt1";
            this.dataGridViewKisBolt1.ReadOnly = true;
            this.dataGridViewKisBolt1.Size = new System.Drawing.Size(794, 323);
            this.dataGridViewKisBolt1.TabIndex = 15;
            // 
            // formRakrrozasDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxKisBolt);
            this.Name = "formRakrrozasDelete";
            this.Text = "formRakrrozasDelete";
            this.Load += new System.EventHandler(this.formRakrrozasDelete_Load);
            this.groupBoxKisBolt.ResumeLayout(false);
            this.groupBoxKisBolt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKisBolt1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxRaktarkod;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxCikkszam;
        private System.Windows.Forms.GroupBox groupBoxKisBolt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewKisBolt1;
    }
}