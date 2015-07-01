namespace CardMaker
{
    partial class CreateSetForm
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
            this.Title_label = new System.Windows.Forms.Label();
            this.SetName_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Create_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.SetType_chooser = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Title_label
            // 
            this.Title_label.AutoSize = true;
            this.Title_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_label.Location = new System.Drawing.Point(21, 24);
            this.Title_label.Name = "Title_label";
            this.Title_label.Size = new System.Drawing.Size(156, 24);
            this.Title_label.TabIndex = 0;
            this.Title_label.Text = "Create a New Set";
            // 
            // SetName_text
            // 
            this.SetName_text.Location = new System.Drawing.Point(206, 58);
            this.SetName_text.Name = "SetName_text";
            this.SetName_text.Size = new System.Drawing.Size(362, 20);
            this.SetName_text.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Set Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Create_btn
            // 
            this.Create_btn.Location = new System.Drawing.Point(261, 360);
            this.Create_btn.Name = "Create_btn";
            this.Create_btn.Size = new System.Drawing.Size(140, 57);
            this.Create_btn.TabIndex = 3;
            this.Create_btn.Text = "Create";
            this.Create_btn.UseVisualStyleBackColor = true;
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.BackColor = System.Drawing.Color.DarkRed;
            this.Cancel_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancel_btn.Location = new System.Drawing.Point(261, 433);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(140, 23);
            this.Cancel_btn.TabIndex = 4;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = false;
            // 
            // SetType_chooser
            // 
            this.SetType_chooser.FormattingEnabled = true;
            this.SetType_chooser.Items.AddRange(new object[] {
            "Core Set",
            "Expansion Set",
            "Other"});
            this.SetType_chooser.Location = new System.Drawing.Point(206, 98);
            this.SetType_chooser.Name = "SetType_chooser";
            this.SetType_chooser.Size = new System.Drawing.Size(259, 21);
            this.SetType_chooser.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Set Type";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(25, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 90);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // CreateSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(670, 468);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SetType_chooser);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Create_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SetName_text);
            this.Controls.Add(this.Title_label);
            this.Name = "CreateSetForm";
            this.Text = "CreateSetForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title_label;
        private System.Windows.Forms.TextBox SetName_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Create_btn;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.ComboBox SetType_chooser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}