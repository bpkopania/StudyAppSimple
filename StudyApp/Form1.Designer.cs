namespace StudyApp
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ustawieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wybierzZagadnieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawieniaApliakcjiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetujBiezacaNaukeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.findNewBtn = new System.Windows.Forms.Button();
            this.Termin = new System.Windows.Forms.Label();
            this.knowBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ustawieniaToolStripMenuItem,
            this.resetujBiezacaNaukeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ustawieniaToolStripMenuItem
            // 
            this.ustawieniaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wybierzZagadnieniaToolStripMenuItem,
            this.ustawieniaApliakcjiToolStripMenuItem});
            this.ustawieniaToolStripMenuItem.Enabled = false;
            this.ustawieniaToolStripMenuItem.Name = "ustawieniaToolStripMenuItem";
            this.ustawieniaToolStripMenuItem.Size = new System.Drawing.Size(95, 26);
            this.ustawieniaToolStripMenuItem.Text = "Ustawienia";
            // 
            // wybierzZagadnieniaToolStripMenuItem
            // 
            this.wybierzZagadnieniaToolStripMenuItem.Name = "wybierzZagadnieniaToolStripMenuItem";
            this.wybierzZagadnieniaToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.wybierzZagadnieniaToolStripMenuItem.Text = "Wybierz zagadnienia";
            // 
            // ustawieniaApliakcjiToolStripMenuItem
            // 
            this.ustawieniaApliakcjiToolStripMenuItem.Name = "ustawieniaApliakcjiToolStripMenuItem";
            this.ustawieniaApliakcjiToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.ustawieniaApliakcjiToolStripMenuItem.Text = "Ustawienia apliakcji";
            // 
            // resetujBiezacaNaukeToolStripMenuItem
            // 
            this.resetujBiezacaNaukeToolStripMenuItem.Enabled = false;
            this.resetujBiezacaNaukeToolStripMenuItem.Name = "resetujBiezacaNaukeToolStripMenuItem";
            this.resetujBiezacaNaukeToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.resetujBiezacaNaukeToolStripMenuItem.Text = "Resetuj biezącą naukę";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.findNewBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Termin, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.knowBtn, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 158);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(203, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wybierz temat do nauki";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // findNewBtn
            // 
            this.findNewBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.findNewBtn.Location = new System.Drawing.Point(203, 32);
            this.findNewBtn.Name = "findNewBtn";
            this.findNewBtn.Size = new System.Drawing.Size(394, 44);
            this.findNewBtn.TabIndex = 1;
            this.findNewBtn.Text = "Losuj";
            this.findNewBtn.UseVisualStyleBackColor = true;
            this.findNewBtn.Click += new System.EventHandler(this.findNewBtn_Click);
            // 
            // Termin
            // 
            this.Termin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Termin.Location = new System.Drawing.Point(203, 79);
            this.Termin.Name = "Termin";
            this.Termin.Size = new System.Drawing.Size(394, 29);
            this.Termin.TabIndex = 2;
            this.Termin.Text = "Termin";
            this.Termin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // knowBtn
            // 
            this.knowBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.knowBtn.Location = new System.Drawing.Point(203, 111);
            this.knowBtn.Name = "knowBtn";
            this.knowBtn.Size = new System.Drawing.Size(394, 44);
            this.knowBtn.TabIndex = 3;
            this.knowBtn.Text = "Oznacz jako nauczone";
            this.knowBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wybierzZagadnieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaApliakcjiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetujBiezacaNaukeToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button findNewBtn;
        private System.Windows.Forms.Label Termin;
        private System.Windows.Forms.Button knowBtn;
    }
}

