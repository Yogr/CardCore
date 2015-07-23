namespace CardMaker
{
    partial class SetControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Set_listbox = new System.Windows.Forms.ListBox();
            this.SendAllToSet_btn = new System.Windows.Forms.Button();
            this.SendAllToPool_btn = new System.Windows.Forms.Button();
            this.SendToPool_btn = new System.Windows.Forms.Button();
            this.SendToSet_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AllCards_listBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SetCards_listBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UploadBoxImage_btn = new System.Windows.Forms.Button();
            this.SetBox_image = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SetType_chooser = new System.Windows.Forms.ComboBox();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.Save_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SetName_text = new System.Windows.Forms.TextBox();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.SetBlock_listbox = new System.Windows.Forms.ListBox();
            this.AddBlock_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.RemoveBlock_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SetBox_image)).BeginInit();
            this.SuspendLayout();
            // 
            // Set_listbox
            // 
            this.Set_listbox.FormattingEnabled = true;
            this.Set_listbox.Location = new System.Drawing.Point(6, 13);
            this.Set_listbox.Name = "Set_listbox";
            this.Set_listbox.ScrollAlwaysVisible = true;
            this.Set_listbox.Size = new System.Drawing.Size(211, 407);
            this.Set_listbox.TabIndex = 57;
            this.Set_listbox.SelectedIndexChanged += new System.EventHandler(this.Set_listbox_SelectedIndexChanged);
            // 
            // SendAllToSet_btn
            // 
            this.SendAllToSet_btn.Location = new System.Drawing.Point(522, 237);
            this.SendAllToSet_btn.Name = "SendAllToSet_btn";
            this.SendAllToSet_btn.Size = new System.Drawing.Size(49, 23);
            this.SendAllToSet_btn.TabIndex = 56;
            this.SendAllToSet_btn.Text = "< All";
            this.SendAllToSet_btn.UseVisualStyleBackColor = true;
            this.SendAllToSet_btn.Click += new System.EventHandler(this.SendAllToSet_btn_Click);
            // 
            // SendAllToPool_btn
            // 
            this.SendAllToPool_btn.Location = new System.Drawing.Point(522, 334);
            this.SendAllToPool_btn.Name = "SendAllToPool_btn";
            this.SendAllToPool_btn.Size = new System.Drawing.Size(49, 23);
            this.SendAllToPool_btn.TabIndex = 55;
            this.SendAllToPool_btn.Text = "All >";
            this.SendAllToPool_btn.UseVisualStyleBackColor = true;
            this.SendAllToPool_btn.Click += new System.EventHandler(this.SendAllToPool_btn_Click);
            // 
            // SendToPool_btn
            // 
            this.SendToPool_btn.Location = new System.Drawing.Point(522, 305);
            this.SendToPool_btn.Name = "SendToPool_btn";
            this.SendToPool_btn.Size = new System.Drawing.Size(49, 23);
            this.SendToPool_btn.TabIndex = 54;
            this.SendToPool_btn.Text = ">>";
            this.SendToPool_btn.UseVisualStyleBackColor = true;
            this.SendToPool_btn.Click += new System.EventHandler(this.SendToPool_btn_Click);
            // 
            // SendToSet_btn
            // 
            this.SendToSet_btn.Location = new System.Drawing.Point(522, 208);
            this.SendToSet_btn.Name = "SendToSet_btn";
            this.SendToSet_btn.Size = new System.Drawing.Size(49, 23);
            this.SendToSet_btn.TabIndex = 53;
            this.SendToSet_btn.Text = "<<";
            this.SendToSet_btn.UseVisualStyleBackColor = true;
            this.SendToSet_btn.Click += new System.EventHandler(this.SendToSet_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(677, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Not In Set";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "In Set";
            // 
            // AllCards_listBox
            // 
            this.AllCards_listBox.FormattingEnabled = true;
            this.AllCards_listBox.Location = new System.Drawing.Point(586, 146);
            this.AllCards_listBox.Name = "AllCards_listBox";
            this.AllCards_listBox.ScrollAlwaysVisible = true;
            this.AllCards_listBox.Size = new System.Drawing.Size(254, 277);
            this.AllCards_listBox.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(544, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Set Box Image";
            // 
            // SetCards_listBox
            // 
            this.SetCards_listBox.FormattingEnabled = true;
            this.SetCards_listBox.Location = new System.Drawing.Point(270, 146);
            this.SetCards_listBox.Name = "SetCards_listBox";
            this.SetCards_listBox.ScrollAlwaysVisible = true;
            this.SetCards_listBox.Size = new System.Drawing.Size(238, 277);
            this.SetCards_listBox.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Set Cards";
            // 
            // UploadBoxImage_btn
            // 
            this.UploadBoxImage_btn.Location = new System.Drawing.Point(635, 440);
            this.UploadBoxImage_btn.Name = "UploadBoxImage_btn";
            this.UploadBoxImage_btn.Size = new System.Drawing.Size(130, 23);
            this.UploadBoxImage_btn.TabIndex = 46;
            this.UploadBoxImage_btn.Text = "Upload";
            this.UploadBoxImage_btn.UseVisualStyleBackColor = true;
            // 
            // SetBox_image
            // 
            this.SetBox_image.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SetBox_image.Location = new System.Drawing.Point(524, 465);
            this.SetBox_image.Name = "SetBox_image";
            this.SetBox_image.Size = new System.Drawing.Size(256, 186);
            this.SetBox_image.TabIndex = 45;
            this.SetBox_image.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Set Type";
            // 
            // SetType_chooser
            // 
            this.SetType_chooser.FormattingEnabled = true;
            this.SetType_chooser.Items.AddRange(new object[] {
            "Core Set",
            "Expansion Set",
            "Other"});
            this.SetType_chooser.Location = new System.Drawing.Point(325, 69);
            this.SetType_chooser.Name = "SetType_chooser";
            this.SetType_chooser.Size = new System.Drawing.Size(196, 21);
            this.SetType_chooser.TabIndex = 43;
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.BackColor = System.Drawing.Color.DarkRed;
            this.Cancel_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancel_btn.Location = new System.Drawing.Point(312, 539);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(140, 23);
            this.Cancel_btn.TabIndex = 42;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = false;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(312, 466);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(140, 57);
            this.Save_btn.TabIndex = 41;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Set Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SetName_text
            // 
            this.SetName_text.Location = new System.Drawing.Point(324, 42);
            this.SetName_text.Name = "SetName_text";
            this.SetName_text.Size = new System.Drawing.Size(238, 20);
            this.SetName_text.TabIndex = 39;
            // 
            // Delete_btn
            // 
            this.Delete_btn.Location = new System.Drawing.Point(136, 426);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(75, 23);
            this.Delete_btn.TabIndex = 91;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = true;
            // 
            // SetBlock_listbox
            // 
            this.SetBlock_listbox.FormattingEnabled = true;
            this.SetBlock_listbox.Location = new System.Drawing.Point(605, 25);
            this.SetBlock_listbox.Name = "SetBlock_listbox";
            this.SetBlock_listbox.ScrollAlwaysVisible = true;
            this.SetBlock_listbox.Size = new System.Drawing.Size(237, 95);
            this.SetBlock_listbox.TabIndex = 92;
            // 
            // AddBlock_btn
            // 
            this.AddBlock_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBlock_btn.Location = new System.Drawing.Point(881, 49);
            this.AddBlock_btn.Name = "AddBlock_btn";
            this.AddBlock_btn.Size = new System.Drawing.Size(107, 23);
            this.AddBlock_btn.TabIndex = 93;
            this.AddBlock_btn.Text = "Add New Block";
            this.AddBlock_btn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(882, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 20);
            this.textBox1.TabIndex = 94;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(884, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 95;
            this.label7.Text = "Block name";
            // 
            // RemoveBlock_btn
            // 
            this.RemoveBlock_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveBlock_btn.Location = new System.Drawing.Point(863, 87);
            this.RemoveBlock_btn.Name = "RemoveBlock_btn";
            this.RemoveBlock_btn.Size = new System.Drawing.Size(87, 23);
            this.RemoveBlock_btn.TabIndex = 96;
            this.RemoveBlock_btn.Text = "Remove Block";
            this.RemoveBlock_btn.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(605, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 97;
            this.label8.Text = "Block";
            // 
            // SetControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RemoveBlock_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AddBlock_btn);
            this.Controls.Add(this.SetBlock_listbox);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Set_listbox);
            this.Controls.Add(this.SendAllToSet_btn);
            this.Controls.Add(this.SendAllToPool_btn);
            this.Controls.Add(this.SendToPool_btn);
            this.Controls.Add(this.SendToSet_btn);
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
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SetName_text);
            this.Name = "SetControl";
            this.Size = new System.Drawing.Size(1047, 658);
            ((System.ComponentModel.ISupportInitialize)(this.SetBox_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Set_listbox;
        private System.Windows.Forms.Button SendAllToSet_btn;
        private System.Windows.Forms.Button SendAllToPool_btn;
        private System.Windows.Forms.Button SendToPool_btn;
        private System.Windows.Forms.Button SendToSet_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox AllCards_listBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox SetCards_listBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button UploadBoxImage_btn;
        private System.Windows.Forms.PictureBox SetBox_image;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SetType_chooser;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SetName_text;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.ListBox SetBlock_listbox;
        private System.Windows.Forms.Button AddBlock_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button RemoveBlock_btn;
        private System.Windows.Forms.Label label8;
    }
}
