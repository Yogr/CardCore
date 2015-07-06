namespace CardMaker
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileNew_menuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileLoad_menuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSave_menuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSaveAs_menuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileQuit_menuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1308, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileNew_menuitem,
            this.FileLoad_menuitem,
            this.FileSave_menuitem,
            this.FileSaveAs_menuitem,
            this.FileQuit_menuitem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // FileNew_menuitem
            // 
            this.FileNew_menuitem.Name = "FileNew_menuitem";
            this.FileNew_menuitem.Size = new System.Drawing.Size(152, 22);
            this.FileNew_menuitem.Text = "New";
            this.FileNew_menuitem.Click += new System.EventHandler(this.FileNew_menuitem_Click);
            // 
            // FileLoad_menuitem
            // 
            this.FileLoad_menuitem.Name = "FileLoad_menuitem";
            this.FileLoad_menuitem.Size = new System.Drawing.Size(152, 22);
            this.FileLoad_menuitem.Text = "Load";
            this.FileLoad_menuitem.Click += new System.EventHandler(this.FileLoad_menuitem_Click);
            // 
            // FileSave_menuitem
            // 
            this.FileSave_menuitem.Name = "FileSave_menuitem";
            this.FileSave_menuitem.Size = new System.Drawing.Size(152, 22);
            this.FileSave_menuitem.Text = "Save";
            this.FileSave_menuitem.Click += new System.EventHandler(this.FileSave_menuitem_Click);
            // 
            // FileSaveAs_menuitem
            // 
            this.FileSaveAs_menuitem.Name = "FileSaveAs_menuitem";
            this.FileSaveAs_menuitem.Size = new System.Drawing.Size(152, 22);
            this.FileSaveAs_menuitem.Text = "Save As";
            // 
            // FileQuit_menuitem
            // 
            this.FileQuit_menuitem.Name = "FileQuit_menuitem";
            this.FileQuit_menuitem.Size = new System.Drawing.Size(152, 22);
            this.FileQuit_menuitem.Text = "Quit";
            this.FileQuit_menuitem.Click += new System.EventHandler(this.FileQuit_menuitem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::CardMaker.Properties.Resources.card_maker_logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1308, 743);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "CardMaker v1.0 by Att Rat Entertainment";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileNew_menuitem;
        private System.Windows.Forms.ToolStripMenuItem FileLoad_menuitem;
        private System.Windows.Forms.ToolStripMenuItem FileSave_menuitem;
        private System.Windows.Forms.ToolStripMenuItem FileSaveAs_menuitem;
        private System.Windows.Forms.ToolStripMenuItem FileQuit_menuitem;
    }
}

