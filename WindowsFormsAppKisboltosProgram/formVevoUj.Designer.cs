﻿namespace WindowsFormsAppKisboltosProgram
{
    partial class formVevoUj
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
            this.textBoxVevonev = new System.Windows.Forms.TextBox();
            this.buttonUj = new System.Windows.Forms.Button();
            this.textBoxVevokod = new System.Windows.Forms.TextBox();
            this.dataGridViewKisBolt1 = new System.Windows.Forms.DataGridView();
            this.groupBoxKisBolt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKisBolt1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxKisBolt
            // 
            this.groupBoxKisBolt.AccessibleDescription = "c";
            this.groupBoxKisBolt.Controls.Add(this.textBoxVevonev);
            this.groupBoxKisBolt.Controls.Add(this.buttonUj);
            this.groupBoxKisBolt.Controls.Add(this.textBoxVevokod);
            this.groupBoxKisBolt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxKisBolt.Location = new System.Drawing.Point(0, 0);
            this.groupBoxKisBolt.Name = "groupBoxKisBolt";
            this.groupBoxKisBolt.Size = new System.Drawing.Size(800, 127);
            this.groupBoxKisBolt.TabIndex = 16;
            this.groupBoxKisBolt.TabStop = false;
            this.groupBoxKisBolt.Text = "Kiválasztott termék adatai";
            // 
            // textBoxVevonev
            // 
            this.textBoxVevonev.AccessibleDescription = "c";
            this.textBoxVevonev.Location = new System.Drawing.Point(155, 32);
            this.textBoxVevonev.Name = "textBoxVevonev";
            this.textBoxVevonev.Size = new System.Drawing.Size(143, 20);
            this.textBoxVevonev.TabIndex = 5;
            // 
            // buttonUj
            // 
            this.buttonUj.AccessibleDescription = "c";
            this.buttonUj.Location = new System.Drawing.Point(364, 58);
            this.buttonUj.Name = "buttonUj";
            this.buttonUj.Size = new System.Drawing.Size(104, 23);
            this.buttonUj.TabIndex = 4;
            this.buttonUj.Text = "Új vevő";
            this.buttonUj.UseVisualStyleBackColor = true;
            this.buttonUj.Click += new System.EventHandler(this.buttonUj_Click);
            // 
            // textBoxVevokod
            // 
            this.textBoxVevokod.AccessibleDescription = "c";
            this.textBoxVevokod.Location = new System.Drawing.Point(6, 32);
            this.textBoxVevokod.Name = "textBoxVevokod";
            this.textBoxVevokod.Size = new System.Drawing.Size(143, 20);
            this.textBoxVevokod.TabIndex = 0;
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
            this.dataGridViewKisBolt1.TabIndex = 15;
            this.dataGridViewKisBolt1.SelectionChanged += new System.EventHandler(this.dataGridViewKisBolt1_SelectionChanged);
            // 
            // formVevoUj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxKisBolt);
            this.Controls.Add(this.dataGridViewKisBolt1);
            this.Name = "formVevoUj";
            this.Text = "formVevoUj";
            this.Load += new System.EventHandler(this.formVevoUj_Load);
            this.groupBoxKisBolt.ResumeLayout(false);
            this.groupBoxKisBolt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKisBolt1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxKisBolt;
        private System.Windows.Forms.TextBox textBoxVevonev;
        private System.Windows.Forms.Button buttonUj;
        private System.Windows.Forms.TextBox textBoxVevokod;
        private System.Windows.Forms.DataGridView dataGridViewKisBolt1;
    }
}