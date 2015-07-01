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
            this.SetBox_image = new System.Windows.Forms.PictureBox();
            this.UploadBoxImage_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SetCards_listBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AllCards_listBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SetBox_image)).BeginInit();
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
            this.SetName_text.Location = new System.Drawing.Point(271, 44);
            this.SetName_text.Name = "SetName_text";
            this.SetName_text.Size = new System.Drawing.Size(238, 20);
            this.SetName_text.TabIndex = 1;
            this.SetName_text.TextChanged += new System.EventHandler(this.SetName_text_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Set Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Create_btn
            // 
            this.Create_btn.Location = new System.Drawing.Point(254, 512);
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
            this.Cancel_btn.Location = new System.Drawing.Point(254, 585);
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
            this.SetType_chooser.Location = new System.Drawing.Point(272, 71);
            this.SetType_chooser.Name = "SetType_chooser";
            this.SetType_chooser.Size = new System.Drawing.Size(196, 21);
            this.SetType_chooser.TabIndex = 5;
            this.SetType_chooser.SelectedIndexChanged += new System.EventHandler(this.SetType_chooser_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Set Type";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SetBox_image
            // 
            this.SetBox_image.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SetBox_image.Location = new System.Drawing.Point(560, 35);
            this.SetBox_image.Name = "SetBox_image";
            this.SetBox_image.Size = new System.Drawing.Size(130, 90);
            this.SetBox_image.TabIndex = 7;
            this.SetBox_image.TabStop = false;
            // 
            // UploadBoxImage_btn
            // 
            this.UploadBoxImage_btn.Location = new System.Drawing.Point(560, 132);
            this.UploadBoxImage_btn.Name = "UploadBoxImage_btn";
            this.UploadBoxImage_btn.Size = new System.Drawing.Size(130, 23);
            this.UploadBoxImage_btn.TabIndex = 8;
            this.UploadBoxImage_btn.Text = "Upload";
            this.UploadBoxImage_btn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Set Cards";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // SetCards_listBox
            // 
            this.SetCards_listBox.FormattingEnabled = true;
            this.SetCards_listBox.Location = new System.Drawing.Point(47, 180);
            this.SetCards_listBox.Name = "SetCards_listBox";
            this.SetCards_listBox.ScrollAlwaysVisible = true;
            this.SetCards_listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.SetCards_listBox.Size = new System.Drawing.Size(238, 277);
            this.SetCards_listBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(560, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Set Box Image";
            // 
            // AllCards_listBox
            // 
            this.AllCards_listBox.FormattingEnabled = true;
            this.AllCards_listBox.Location = new System.Drawing.Point(363, 180);
            this.AllCards_listBox.Name = "AllCards_listBox";
            this.AllCards_listBox.ScrollAlwaysVisible = true;
            this.AllCards_listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.AllCards_listBox.Size = new System.Drawing.Size(254, 277);
            this.AllCards_listBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "In Set";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(454, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Not In Set";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(299, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = ">>";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(299, 368);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "All >";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(299, 271);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "< All";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // CreateSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(755, 618);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AllCards_listBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SetCards_listBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UploadBoxImage_btn);
            this.Controls.Add(this.SetBox_image);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SetType_chooser);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Create_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SetName_text);
            this.Controls.Add(this.Title_label);
            this.Name = "CreateSetForm";
            this.Text = "CreateSetForm";
            ((System.ComponentModel.ISupportInitialize)(this.SetBox_image)).EndInit();
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
        private System.Windows.Forms.PictureBox SetBox_image;
        private System.Windows.Forms.Button UploadBoxImage_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox SetCards_listBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox AllCards_listBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}