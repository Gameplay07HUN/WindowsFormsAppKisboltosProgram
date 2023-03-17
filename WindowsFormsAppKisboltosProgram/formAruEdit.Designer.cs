namespace WindowsFormsAppKisboltosProgram
{
    partial class formAruEdit
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
            this.textBoxAruneve = new System.Windows.Forms.TextBox();
            this.textBoxMarka = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.numericUpDownEladasiar = new System.Windows.Forms.NumericUpDown();
            this.textBoxKategória = new System.Windows.Forms.TextBox();
            this.textBoxCikkszam = new System.Windows.Forms.TextBox();
            this.termékToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modosítToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törölToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewKisBolt = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBoxKisBolt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEladasiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKisBolt)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxKisBolt
            // 
            this.groupBoxKisBolt.AccessibleDescription = "c";
            this.groupBoxKisBolt.Controls.Add(this.textBoxAruneve);
            this.groupBoxKisBolt.Controls.Add(this.textBoxMarka);
            this.groupBoxKisBolt.Controls.Add(this.buttonEdit);
            this.groupBoxKisBolt.Controls.Add(this.numericUpDownEladasiar);
            this.groupBoxKisBolt.Controls.Add(this.textBoxKategória);
            this.groupBoxKisBolt.Controls.Add(this.textBoxCikkszam);
            this.groupBoxKisBolt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxKisBolt.Location = new System.Drawing.Point(0, 24);
            this.groupBoxKisBolt.Name = "groupBoxKisBolt";
            this.groupBoxKisBolt.Size = new System.Drawing.Size(800, 103);
            this.groupBoxKisBolt.TabIndex = 15;
            this.groupBoxKisBolt.TabStop = false;
            this.groupBoxKisBolt.Text = "Kiválasztott termék adatai";
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
            // buttonEdit
            // 
            this.buttonEdit.AccessibleDescription = "c";
            this.buttonEdit.Location = new System.Drawing.Point(364, 58);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(91, 23);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Áru módosítása";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
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
            // termékToolStripMenuItem
            // 
            this.termékToolStripMenuItem.AccessibleDescription = "c";
            this.termékToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újToolStripMenuItem,
            this.modosítToolStripMenuItem,
            this.törölToolStripMenuItem});
            this.termékToolStripMenuItem.Name = "termékToolStripMenuItem";
            this.termékToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.termékToolStripMenuItem.Text = "Termék";
            // 
            // újToolStripMenuItem
            // 
            this.újToolStripMenuItem.AccessibleDescription = "c";
            this.újToolStripMenuItem.Name = "újToolStripMenuItem";
            this.újToolStripMenuItem.ShowShortcutKeys = false;
            this.újToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.újToolStripMenuItem.Text = "Új";
            // 
            // modosítToolStripMenuItem
            // 
            this.modosítToolStripMenuItem.AccessibleDescription = "c";
            this.modosítToolStripMenuItem.Checked = true;
            this.modosítToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.modosítToolStripMenuItem.Enabled = false;
            this.modosítToolStripMenuItem.Name = "modosítToolStripMenuItem";
            this.modosítToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.modosítToolStripMenuItem.Text = "Modosít";
            // 
            // törölToolStripMenuItem
            // 
            this.törölToolStripMenuItem.AccessibleDescription = "c";
            this.törölToolStripMenuItem.Name = "törölToolStripMenuItem";
            this.törölToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.törölToolStripMenuItem.Text = "Töröl";
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
            this.dataGridViewKisBolt.TabIndex = 14;
            this.dataGridViewKisBolt.SelectionChanged += new System.EventHandler(this.dataGridViewKisBolt_SelectionChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AccessibleDescription = "c";
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.termékToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formAruEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxKisBolt);
            this.Controls.Add(this.dataGridViewKisBolt);
            this.Controls.Add(this.menuStrip1);
            this.Name = "formAruEdit";
            this.Text = "formAruEdit";
            this.Load += new System.EventHandler(this.formAruEdit_Load);
            this.groupBoxKisBolt.ResumeLayout(false);
            this.groupBoxKisBolt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEladasiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKisBolt)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxKisBolt;
        private System.Windows.Forms.TextBox textBoxAruneve;
        private System.Windows.Forms.TextBox textBoxMarka;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.NumericUpDown numericUpDownEladasiar;
        private System.Windows.Forms.TextBox textBoxKategória;
        private System.Windows.Forms.TextBox textBoxCikkszam;
        private System.Windows.Forms.ToolStripMenuItem termékToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modosítToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törölToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewKisBolt;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}