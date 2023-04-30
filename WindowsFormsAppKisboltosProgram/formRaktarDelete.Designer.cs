namespace WindowsFormsAppKisboltosProgram
{
    partial class formRaktarDelete
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRaktarnev = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxRaktarkod = new System.Windows.Forms.TextBox();
            this.dataGridViewKisBolt1 = new System.Windows.Forms.DataGridView();
            this.groupBoxKisBolt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKisBolt1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxKisBolt
            // 
            this.groupBoxKisBolt.AccessibleDescription = "c";
            this.groupBoxKisBolt.Controls.Add(this.label2);
            this.groupBoxKisBolt.Controls.Add(this.label1);
            this.groupBoxKisBolt.Controls.Add(this.textBoxRaktarnev);
            this.groupBoxKisBolt.Controls.Add(this.buttonDelete);
            this.groupBoxKisBolt.Controls.Add(this.textBoxRaktarkod);
            this.groupBoxKisBolt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxKisBolt.Location = new System.Drawing.Point(0, 0);
            this.groupBoxKisBolt.Name = "groupBoxKisBolt";
            this.groupBoxKisBolt.Size = new System.Drawing.Size(800, 127);
            this.groupBoxKisBolt.TabIndex = 18;
            this.groupBoxKisBolt.TabStop = false;
            this.groupBoxKisBolt.Text = "Kiválasztott raktár adatai";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Raktárnév";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Raktárkód";
            // 
            // textBoxRaktarnev
            // 
            this.textBoxRaktarnev.AccessibleDescription = "c";
            this.textBoxRaktarnev.Location = new System.Drawing.Point(155, 32);
            this.textBoxRaktarnev.Name = "textBoxRaktarnev";
            this.textBoxRaktarnev.Size = new System.Drawing.Size(143, 20);
            this.textBoxRaktarnev.TabIndex = 5;
            // 
            // buttonDelete
            // 
            this.buttonDelete.AccessibleDescription = "c";
            this.buttonDelete.Location = new System.Drawing.Point(364, 58);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(104, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Raktár törlése";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxRaktarkod
            // 
            this.textBoxRaktarkod.AccessibleDescription = "c";
            this.textBoxRaktarkod.Location = new System.Drawing.Point(6, 32);
            this.textBoxRaktarkod.Name = "textBoxRaktarkod";
            this.textBoxRaktarkod.ReadOnly = true;
            this.textBoxRaktarkod.Size = new System.Drawing.Size(143, 20);
            this.textBoxRaktarkod.TabIndex = 0;
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
            this.dataGridViewKisBolt1.TabIndex = 17;
            this.dataGridViewKisBolt1.SelectionChanged += new System.EventHandler(this.dataGridViewKisBolt1_SelectionChanged);
            // 
            // formRaktarDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxKisBolt);
            this.Controls.Add(this.dataGridViewKisBolt1);
            this.Name = "formRaktarDelete";
            this.Text = "formRaktarDelete";
            this.Load += new System.EventHandler(this.formRaktarDelete_Load);
            this.groupBoxKisBolt.ResumeLayout(false);
            this.groupBoxKisBolt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKisBolt1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxKisBolt;
        private System.Windows.Forms.TextBox textBoxRaktarnev;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxRaktarkod;
        private System.Windows.Forms.DataGridView dataGridViewKisBolt1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}