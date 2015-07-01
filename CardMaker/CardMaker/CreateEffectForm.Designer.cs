namespace CardMaker
{
    partial class CreateEffectForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.EffectType_chooser = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EffectName_text = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Effects_listbox = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.Create_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title_label
            // 
            this.Title_label.AutoSize = true;
            this.Title_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_label.Location = new System.Drawing.Point(25, 23);
            this.Title_label.Name = "Title_label";
            this.Title_label.Size = new System.Drawing.Size(175, 24);
            this.Title_label.TabIndex = 1;
            this.Title_label.Text = "Create a New Effect";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Add Effect";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // EffectType_chooser
            // 
            this.EffectType_chooser.FormattingEnabled = true;
            this.EffectType_chooser.Items.AddRange(new object[] {
            "Core Set",
            "Expansion Set",
            "Other"});
            this.EffectType_chooser.Location = new System.Drawing.Point(141, 108);
            this.EffectType_chooser.Name = "EffectType_chooser";
            this.EffectType_chooser.Size = new System.Drawing.Size(201, 21);
            this.EffectType_chooser.TabIndex = 9;
            this.EffectType_chooser.SelectedIndexChanged += new System.EventHandler(this.SetType_chooser_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Effect Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // EffectName_text
            // 
            this.EffectName_text.Location = new System.Drawing.Point(192, 57);
            this.EffectName_text.Name = "EffectName_text";
            this.EffectName_text.Size = new System.Drawing.Size(362, 20);
            this.EffectName_text.TabIndex = 7;
            this.EffectName_text.TextChanged += new System.EventHandler(this.SetName_text_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(349, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "modifier";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Current Effects";
            // 
            // Effects_listbox
            // 
            this.Effects_listbox.FormattingEnabled = true;
            this.Effects_listbox.Location = new System.Drawing.Point(171, 170);
            this.Effects_listbox.Name = "Effects_listbox";
            this.Effects_listbox.ScrollAlwaysVisible = true;
            this.Effects_listbox.Size = new System.Drawing.Size(304, 199);
            this.Effects_listbox.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(364, 375);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Remove";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(218, 375);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(44, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "^";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(268, 375);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 23);
            this.button6.TabIndex = 21;
            this.button6.Text = "v";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(456, 105);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 22);
            this.button7.TabIndex = 22;
            this.button7.Text = "Add Effect";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // Create_btn
            // 
            this.Create_btn.Location = new System.Drawing.Point(247, 453);
            this.Create_btn.Name = "Create_btn";
            this.Create_btn.Size = new System.Drawing.Size(140, 32);
            this.Create_btn.TabIndex = 23;
            this.Create_btn.Text = "Create Effect";
            this.Create_btn.UseVisualStyleBackColor = true;
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.BackColor = System.Drawing.Color.DarkRed;
            this.Cancel_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancel_btn.Location = new System.Drawing.Point(247, 491);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(140, 23);
            this.Cancel_btn.TabIndex = 24;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = false;
            // 
            // CreateEffectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 529);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Create_btn);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Effects_listbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EffectType_chooser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EffectName_text);
            this.Controls.Add(this.Title_label);
            this.Name = "CreateEffectForm";
            this.Text = "CreateEffectForm";
            this.Load += new System.EventHandler(this.CreateEffectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox EffectType_chooser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EffectName_text;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox Effects_listbox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button Create_btn;
        private System.Windows.Forms.Button Cancel_btn;
    }
}