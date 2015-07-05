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
            this.Create_menuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateSet_menuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateCard_menuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateEffect_menuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_menuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditSet_menuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditCard_menuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditEffect_menuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete_menuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteSet_menuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteCard_menuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteEffect_menuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.CurProject_label = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.Create_menuitem,
            this.Edit_menuitem,
            this.Delete_menuitem});
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
            this.FileNew_menuitem.Size = new System.Drawing.Size(114, 22);
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
            this.FileSave_menuitem.Size = new System.Drawing.Size(114, 22);
            this.FileSave_menuitem.Text = "Save";
            this.FileSave_menuitem.Click += new System.EventHandler(this.FileSave_menuitem_Click);
            // 
            // FileSaveAs_menuitem
            // 
            this.FileSaveAs_menuitem.Name = "FileSaveAs_menuitem";
            this.FileSaveAs_menuitem.Size = new System.Drawing.Size(114, 22);
            this.FileSaveAs_menuitem.Text = "Save As";
            // 
            // FileQuit_menuitem
            // 
            this.FileQuit_menuitem.Name = "FileQuit_menuitem";
            this.FileQuit_menuitem.Size = new System.Drawing.Size(114, 22);
            this.FileQuit_menuitem.Text = "Quit";
            this.FileQuit_menuitem.Click += new System.EventHandler(this.FileQuit_menuitem_Click);
            // 
            // Create_menuitem
            // 
            this.Create_menuitem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateSet_menuitem,
            this.CreateCard_menuitem,
            this.CreateEffect_menuitem});
            this.Create_menuitem.Name = "Create_menuitem";
            this.Create_menuitem.Size = new System.Drawing.Size(53, 20);
            this.Create_menuitem.Text = "Create";
            // 
            // CreateSet_menuitem
            // 
            this.CreateSet_menuitem.Name = "CreateSet_menuitem";
            this.CreateSet_menuitem.Size = new System.Drawing.Size(104, 22);
            this.CreateSet_menuitem.Text = "Set";
            this.CreateSet_menuitem.Click += new System.EventHandler(this.CreateSet_menuitem_Click);
            // 
            // CreateCard_menuitem
            // 
            this.CreateCard_menuitem.Name = "CreateCard_menuitem";
            this.CreateCard_menuitem.Size = new System.Drawing.Size(104, 22);
            this.CreateCard_menuitem.Text = "Card";
            this.CreateCard_menuitem.Click += new System.EventHandler(this.CreateCard_menuitem_Click);
            // 
            // CreateEffect_menuitem
            // 
            this.CreateEffect_menuitem.Name = "CreateEffect_menuitem";
            this.CreateEffect_menuitem.Size = new System.Drawing.Size(104, 22);
            this.CreateEffect_menuitem.Text = "Effect";
            this.CreateEffect_menuitem.Click += new System.EventHandler(this.CreateEffect_menuitem_Click);
            // 
            // Edit_menuitem
            // 
            this.Edit_menuitem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditSet_menuitem,
            this.EditCard_menuitem,
            this.EditEffect_menuitem});
            this.Edit_menuitem.Name = "Edit_menuitem";
            this.Edit_menuitem.Size = new System.Drawing.Size(39, 20);
            this.Edit_menuitem.Text = "Edit";
            // 
            // EditSet_menuitem
            // 
            this.EditSet_menuitem.Name = "EditSet_menuitem";
            this.EditSet_menuitem.Size = new System.Drawing.Size(104, 22);
            this.EditSet_menuitem.Text = "Set";
            // 
            // EditCard_menuitem
            // 
            this.EditCard_menuitem.Name = "EditCard_menuitem";
            this.EditCard_menuitem.Size = new System.Drawing.Size(104, 22);
            this.EditCard_menuitem.Text = "Card";
            // 
            // EditEffect_menuitem
            // 
            this.EditEffect_menuitem.Name = "EditEffect_menuitem";
            this.EditEffect_menuitem.Size = new System.Drawing.Size(104, 22);
            this.EditEffect_menuitem.Text = "Effect";
            // 
            // Delete_menuitem
            // 
            this.Delete_menuitem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteSet_menuitem,
            this.DeleteCard_menuitem,
            this.DeleteEffect_menuitem});
            this.Delete_menuitem.Name = "Delete_menuitem";
            this.Delete_menuitem.Size = new System.Drawing.Size(52, 20);
            this.Delete_menuitem.Text = "Delete";
            // 
            // DeleteSet_menuitem
            // 
            this.DeleteSet_menuitem.Name = "DeleteSet_menuitem";
            this.DeleteSet_menuitem.Size = new System.Drawing.Size(104, 22);
            this.DeleteSet_menuitem.Text = "Set";
            // 
            // DeleteCard_menuitem
            // 
            this.DeleteCard_menuitem.Name = "DeleteCard_menuitem";
            this.DeleteCard_menuitem.Size = new System.Drawing.Size(104, 22);
            this.DeleteCard_menuitem.Text = "Card";
            // 
            // DeleteEffect_menuitem
            // 
            this.DeleteEffect_menuitem.Name = "DeleteEffect_menuitem";
            this.DeleteEffect_menuitem.Size = new System.Drawing.Size(104, 22);
            this.DeleteEffect_menuitem.Text = "Effect";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Current Project: ";
            // 
            // CurProject_label
            // 
            this.CurProject_label.AutoSize = true;
            this.CurProject_label.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CurProject_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurProject_label.ForeColor = System.Drawing.Color.Yellow;
            this.CurProject_label.Location = new System.Drawing.Point(136, 36);
            this.CurProject_label.Name = "CurProject_label";
            this.CurProject_label.Size = new System.Drawing.Size(63, 20);
            this.CurProject_label.TabIndex = 15;
            this.CurProject_label.Text = "<none>";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::CardMaker.Properties.Resources.card_maker_logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1308, 743);
            this.Controls.Add(this.CurProject_label);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.ToolStripMenuItem Create_menuitem;
        private System.Windows.Forms.ToolStripMenuItem CreateSet_menuitem;
        private System.Windows.Forms.ToolStripMenuItem CreateCard_menuitem;
        private System.Windows.Forms.ToolStripMenuItem CreateEffect_menuitem;
        private System.Windows.Forms.ToolStripMenuItem Edit_menuitem;
        private System.Windows.Forms.ToolStripMenuItem EditSet_menuitem;
        private System.Windows.Forms.ToolStripMenuItem EditCard_menuitem;
        private System.Windows.Forms.ToolStripMenuItem EditEffect_menuitem;
        private System.Windows.Forms.ToolStripMenuItem Delete_menuitem;
        private System.Windows.Forms.ToolStripMenuItem DeleteSet_menuitem;
        private System.Windows.Forms.ToolStripMenuItem DeleteCard_menuitem;
        private System.Windows.Forms.ToolStripMenuItem DeleteEffect_menuitem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileNew_menuitem;
        private System.Windows.Forms.ToolStripMenuItem FileLoad_menuitem;
        private System.Windows.Forms.ToolStripMenuItem FileSave_menuitem;
        private System.Windows.Forms.ToolStripMenuItem FileSaveAs_menuitem;
        private System.Windows.Forms.ToolStripMenuItem FileQuit_menuitem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CurProject_label;
    }
}

