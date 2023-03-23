namespace WindowsFormsAppKisboltosProgram
{
    partial class formRaktarozasUj
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
            this.textBoxRaktarkod = new System.Windows.Forms.TextBox();
            this.buttonUj = new System.Windows.Forms.Button();
            this.textBoxCikkszam = new System.Windows.Forms.TextBox();
            this.dataGridViewKisBolt1 = new System.Windows.Forms.DataGridView();
            this.groupBoxKisBolt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKisBolt1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxKisBolt
            // 
            this.groupBoxKisBolt.AccessibleDescription = "c";
            this.groupBoxKisBolt.Controls.Add(this.textBoxRaktarkod);
            this.groupBoxKisBolt.Controls.Add(this.buttonUj);
            this.groupBoxKisBolt.Controls.Add(this.textBoxCikkszam);
            this.groupBoxKisBolt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxKisBolt.Location = new System.Drawing.Point(0, 0);
            this.groupBoxKisBolt.Name = "groupBoxKisBolt";
            this.groupBoxKisBolt.Size = new System.Drawing.Size(800, 127);
            this.groupBoxKisBolt.TabIndex = 12;
            this.groupBoxKisBolt.TabStop = false;
            this.groupBoxKisBolt.Text = "Kiválasztott termék adatai";
            // 
            // textBoxRaktarkod
            // 
            this.textBoxRaktarkod.AccessibleDescription = "c";
            this.textBoxRaktarkod.Location = new System.Drawing.Point(155, 32);
            this.textBoxRaktarkod.Name = "textBoxRaktarkod";
            this.textBoxRaktarkod.Size = new System.Drawing.Size(143, 20);
            this.textBoxRaktarkod.TabIndex = 5;
            // 
            // buttonUj
            // 
            this.buttonUj.AccessibleDescription = "c";
            this.buttonUj.Location = new System.Drawing.Point(364, 58);
            this.buttonUj.Name = "buttonUj";
            this.buttonUj.Size = new System.Drawing.Size(104, 23);
            this.buttonUj.TabIndex = 4;
            this.buttonUj.Text = "Új raktározás";
            this.buttonUj.UseVisualStyleBackColor = true;
            this.buttonUj.Click += new System.EventHandler(this.buttonUj_Click_1);
            // 
            // textBoxCikkszam
            // 
            this.textBoxCikkszam.AccessibleDescription = "c";
            this.textBoxCikkszam.Location = new System.Drawing.Point(6, 32);
            this.textBoxCikkszam.Name = "textBoxCikkszam";
            this.textBoxCikkszam.Size = new System.Drawing.Size(143, 20);
            this.textBoxCikkszam.TabIndex = 0;
            // 
            // dataGridViewKisBolt1
            // 
            this.dataGridViewKisBolt1.AccessibleDescription = "c";
            this.dataGridViewKisBolt1.AllowUserToDeleteRows = false;
            this.dataGridViewKisBolt1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKisBolt1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewKisBolt1.Location = new System.Drawing.Point(0, 127);
            this.dataGridViewKisBolt1.Name = "dataGridViewKisBolt1";
            this.dataGridViewKisBolt1.ReadOnly = true;
            this.dataGridViewKisBolt1.Size = new System.Drawing.Size(800, 323);
            this.dataGridViewKisBolt1.TabIndex = 11;
            this.dataGridViewKisBolt1.SelectionChanged += new System.EventHandler(this.dataGridViewKisBolt1_SelectionChanged);
            // 
            // formRaktarozasUj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxKisBolt);
            this.Controls.Add(this.dataGridViewKisBolt1);
            this.Name = "formRaktarozasUj";
            this.Text = "formRaktarozasUj";
            this.Load += new System.EventHandler(this.formRaktarozasUj_Load);
            this.groupBoxKisBolt.ResumeLayout(false);
            this.groupBoxKisBolt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKisBolt1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxKisBolt;
        private System.Windows.Forms.Button buttonUj;
        private System.Windows.Forms.TextBox textBoxCikkszam;
        private System.Windows.Forms.DataGridView dataGridViewKisBolt1;
        private System.Windows.Forms.TextBox textBoxRaktarkod;
    }
}