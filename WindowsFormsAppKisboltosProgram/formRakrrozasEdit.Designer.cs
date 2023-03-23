namespace WindowsFormsAppKisboltosProgram
{
    partial class formRakrrozasEdit
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
            this.dataGridViewKisBolt1 = new System.Windows.Forms.DataGridView();
            this.textBoxRaktarkod = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxCikkszam = new System.Windows.Forms.TextBox();
            this.groupBoxKisBolt = new System.Windows.Forms.GroupBox();
            this.button1Edit = new System.Windows.Forms.Button();
            this.buttonEdit1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKisBolt1)).BeginInit();
            this.groupBoxKisBolt.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridViewKisBolt1.TabIndex = 14;
            this.dataGridViewKisBolt1.SelectionChanged += new System.EventHandler(this.dataGridViewKisBolt1_SelectionChanged);
            // 
            // textBoxRaktarkod
            // 
            this.textBoxRaktarkod.AccessibleDescription = "c";
            this.textBoxRaktarkod.Location = new System.Drawing.Point(155, 32);
            this.textBoxRaktarkod.Name = "textBoxRaktarkod";
            this.textBoxRaktarkod.Size = new System.Drawing.Size(143, 20);
            this.textBoxRaktarkod.TabIndex = 5;
            // 
            // buttonEdit
            // 
            this.buttonEdit.AccessibleDescription = "c";
            this.buttonEdit.Location = new System.Drawing.Point(364, 58);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(124, 23);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Raktározás módoítása";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
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
            this.groupBoxKisBolt.Controls.Add(this.textBoxRaktarkod);
            this.groupBoxKisBolt.Controls.Add(this.buttonEdit);
            this.groupBoxKisBolt.Controls.Add(this.textBoxCikkszam);
            this.groupBoxKisBolt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxKisBolt.Location = new System.Drawing.Point(0, 0);
            this.groupBoxKisBolt.Name = "groupBoxKisBolt";
            this.groupBoxKisBolt.Size = new System.Drawing.Size(800, 450);
            this.groupBoxKisBolt.TabIndex = 15;
            this.groupBoxKisBolt.TabStop = false;
            this.groupBoxKisBolt.Text = "Kiválasztott termék adatai";
            // 
            // button1Edit
            // 
            this.button1Edit.AccessibleDescription = "c";
            this.button1Edit.Location = new System.Drawing.Point(364, 58);
            this.button1Edit.Name = "button1Edit";
            this.button1Edit.Size = new System.Drawing.Size(124, 23);
            this.button1Edit.TabIndex = 4;
            this.button1Edit.Text = "Raktározás módoítása";
            this.button1Edit.UseVisualStyleBackColor = true;
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.AccessibleDescription = "c";
            this.buttonEdit1.Location = new System.Drawing.Point(364, 58);
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.Size = new System.Drawing.Size(124, 23);
            this.buttonEdit1.TabIndex = 4;
            this.buttonEdit1.Text = "Raktározás módoítása";
            this.buttonEdit1.UseVisualStyleBackColor = true;
            // 
            // formRakrrozasEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewKisBolt1);
            this.Controls.Add(this.groupBoxKisBolt);
            this.Name = "formRakrrozasEdit";
            this.Text = "formRakrrozasEdit";
            this.Load += new System.EventHandler(this.formRakrrozasEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKisBolt1)).EndInit();
            this.groupBoxKisBolt.ResumeLayout(false);
            this.groupBoxKisBolt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewKisBolt1;
        private System.Windows.Forms.TextBox textBoxRaktarkod;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBoxCikkszam;
        private System.Windows.Forms.GroupBox groupBoxKisBolt;
        private System.Windows.Forms.Button button1Edit;
        private System.Windows.Forms.Button buttonEdit1;
    }
}