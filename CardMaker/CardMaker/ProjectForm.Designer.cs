namespace CardMaker
{
    partial class ProjectForm
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
            this.Tabs_control = new System.Windows.Forms.TabControl();
            this.Sets_page = new System.Windows.Forms.TabPage();
            this.setControl1 = new CardMaker.SetControl();
            this.Cards_page = new System.Windows.Forms.TabPage();
            this.cardControl1 = new CardMaker.CardControl();
            this.Effects_page = new System.Windows.Forms.TabPage();
            this.effectControl1 = new CardMaker.EffectControl();
            this.Tabs_control.SuspendLayout();
            this.Sets_page.SuspendLayout();
            this.Cards_page.SuspendLayout();
            this.Effects_page.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs_control
            // 
            this.Tabs_control.Controls.Add(this.Sets_page);
            this.Tabs_control.Controls.Add(this.Cards_page);
            this.Tabs_control.Controls.Add(this.Effects_page);
            this.Tabs_control.Location = new System.Drawing.Point(0, 0);
            this.Tabs_control.Name = "Tabs_control";
            this.Tabs_control.SelectedIndex = 0;
            this.Tabs_control.Size = new System.Drawing.Size(1179, 661);
            this.Tabs_control.TabIndex = 0;
            // 
            // Sets_page
            // 
            this.Sets_page.BackColor = System.Drawing.SystemColors.Control;
            this.Sets_page.Controls.Add(this.setControl1);
            this.Sets_page.Location = new System.Drawing.Point(4, 22);
            this.Sets_page.Name = "Sets_page";
            this.Sets_page.Padding = new System.Windows.Forms.Padding(3);
            this.Sets_page.Size = new System.Drawing.Size(1171, 635);
            this.Sets_page.TabIndex = 0;
            this.Sets_page.Text = "Sets";
            // 
            // setControl1
            // 
            this.setControl1.Location = new System.Drawing.Point(6, 10);
            this.setControl1.Name = "setControl1";
            this.setControl1.Size = new System.Drawing.Size(1114, 658);
            this.setControl1.TabIndex = 0;
            // 
            // Cards_page
            // 
            this.Cards_page.BackColor = System.Drawing.SystemColors.Control;
            this.Cards_page.Controls.Add(this.cardControl1);
            this.Cards_page.Location = new System.Drawing.Point(4, 22);
            this.Cards_page.Name = "Cards_page";
            this.Cards_page.Padding = new System.Windows.Forms.Padding(3);
            this.Cards_page.Size = new System.Drawing.Size(1171, 635);
            this.Cards_page.TabIndex = 1;
            this.Cards_page.Text = "Cards";
            // 
            // cardControl1
            // 
            this.cardControl1.Location = new System.Drawing.Point(4, 5);
            this.cardControl1.Name = "cardControl1";
            this.cardControl1.Size = new System.Drawing.Size(1160, 671);
            this.cardControl1.TabIndex = 0;
            // 
            // Effects_page
            // 
            this.Effects_page.BackColor = System.Drawing.SystemColors.Control;
            this.Effects_page.Controls.Add(this.effectControl1);
            this.Effects_page.Location = new System.Drawing.Point(4, 22);
            this.Effects_page.Name = "Effects_page";
            this.Effects_page.Padding = new System.Windows.Forms.Padding(3);
            this.Effects_page.Size = new System.Drawing.Size(1171, 635);
            this.Effects_page.TabIndex = 2;
            this.Effects_page.Text = "Effects";
            // 
            // effectControl1
            // 
            this.effectControl1.Location = new System.Drawing.Point(2, 2);
            this.effectControl1.Name = "effectControl1";
            this.effectControl1.Size = new System.Drawing.Size(1144, 706);
            this.effectControl1.TabIndex = 0;
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 665);
            this.Controls.Add(this.Tabs_control);
            this.Name = "ProjectForm";
            this.Text = "ProjectForm";
            this.Load += new System.EventHandler(this.ProjectForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProjectForm_Close);
            this.Tabs_control.ResumeLayout(false);
            this.Sets_page.ResumeLayout(false);
            this.Cards_page.ResumeLayout(false);
            this.Effects_page.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs_control;
        private System.Windows.Forms.TabPage Sets_page;
        private System.Windows.Forms.TabPage Cards_page;
        private System.Windows.Forms.TabPage Effects_page;
        private SetControl setControl1;
        private CardControl cardControl1;
        private EffectControl effectControl1;
    }
}