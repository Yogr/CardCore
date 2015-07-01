namespace CardMaker
{
    partial class CreateCardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateCardForm));
            this.UploadPicture_btn = new System.Windows.Forms.Button();
            this.Card_image = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CardType_chooser = new System.Windows.Forms.ComboBox();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.Create_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CardName_text = new System.Windows.Forms.TextBox();
            this.Title_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CardFrame_chooser = new System.Windows.Forms.ComboBox();
            this.Frame_image = new System.Windows.Forms.PictureBox();
            this.CardName_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CardSubtype_chooser = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.CardRarity_chooser = new System.Windows.Forms.ComboBox();
            this.CardCost_text = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CardEffects_chooser = new System.Windows.Forms.ComboBox();
            this.AddEffect_btn = new System.Windows.Forms.Button();
            this.CardEffects_box = new System.Windows.Forms.ListBox();
            this.RemoveEffect_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Card_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Frame_image)).BeginInit();
            this.SuspendLayout();
            // 
            // UploadPicture_btn
            // 
            this.UploadPicture_btn.Location = new System.Drawing.Point(32, 229);
            this.UploadPicture_btn.Name = "UploadPicture_btn";
            this.UploadPicture_btn.Size = new System.Drawing.Size(130, 23);
            this.UploadPicture_btn.TabIndex = 17;
            this.UploadPicture_btn.Text = "Upload Picture";
            this.UploadPicture_btn.UseVisualStyleBackColor = true;
            // 
            // Card_image
            // 
            this.Card_image.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Card_image.Location = new System.Drawing.Point(219, 175);
            this.Card_image.Name = "Card_image";
            this.Card_image.Size = new System.Drawing.Size(209, 157);
            this.Card_image.TabIndex = 16;
            this.Card_image.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Card Type";
            // 
            // CardType_chooser
            // 
            this.CardType_chooser.FormattingEnabled = true;
            this.CardType_chooser.Items.AddRange(new object[] {
            "No Type",
            "Spell",
            "Defensive Spell",
            "Monster",
            "Relic"});
            this.CardType_chooser.Location = new System.Drawing.Point(204, 79);
            this.CardType_chooser.Name = "CardType_chooser";
            this.CardType_chooser.Size = new System.Drawing.Size(259, 21);
            this.CardType_chooser.TabIndex = 14;
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.BackColor = System.Drawing.Color.DarkRed;
            this.Cancel_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancel_btn.Location = new System.Drawing.Point(257, 600);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(140, 23);
            this.Cancel_btn.TabIndex = 13;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = false;
            // 
            // Create_btn
            // 
            this.Create_btn.Location = new System.Drawing.Point(257, 537);
            this.Create_btn.Name = "Create_btn";
            this.Create_btn.Size = new System.Drawing.Size(140, 57);
            this.Create_btn.TabIndex = 12;
            this.Create_btn.Text = "Create";
            this.Create_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Card Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CardName_text
            // 
            this.CardName_text.Location = new System.Drawing.Point(203, 50);
            this.CardName_text.Name = "CardName_text";
            this.CardName_text.Size = new System.Drawing.Size(362, 20);
            this.CardName_text.TabIndex = 10;
            // 
            // Title_label
            // 
            this.Title_label.AutoSize = true;
            this.Title_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_label.Location = new System.Drawing.Point(18, 16);
            this.Title_label.Name = "Title_label";
            this.Title_label.Size = new System.Drawing.Size(169, 24);
            this.Title_label.TabIndex = 9;
            this.Title_label.Text = "Create a New Card";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Choose Frame";
            // 
            // CardFrame_chooser
            // 
            this.CardFrame_chooser.FormattingEnabled = true;
            this.CardFrame_chooser.Items.AddRange(new object[] {
            "Default"});
            this.CardFrame_chooser.Location = new System.Drawing.Point(12, 188);
            this.CardFrame_chooser.Name = "CardFrame_chooser";
            this.CardFrame_chooser.Size = new System.Drawing.Size(175, 21);
            this.CardFrame_chooser.TabIndex = 19;
            // 
            // Frame_image
            // 
            this.Frame_image.BackColor = System.Drawing.Color.Transparent;
            this.Frame_image.Image = ((System.Drawing.Image)(resources.GetObject("Frame_image.Image")));
            this.Frame_image.Location = new System.Drawing.Point(204, 160);
            this.Frame_image.Name = "Frame_image";
            this.Frame_image.Size = new System.Drawing.Size(240, 360);
            this.Frame_image.TabIndex = 20;
            this.Frame_image.TabStop = false;
            // 
            // CardName_label
            // 
            this.CardName_label.BackColor = System.Drawing.Color.Transparent;
            this.CardName_label.Enabled = false;
            this.CardName_label.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardName_label.ForeColor = System.Drawing.Color.White;
            this.CardName_label.Location = new System.Drawing.Point(216, 160);
            this.CardName_label.Name = "CardName_label";
            this.CardName_label.Size = new System.Drawing.Size(181, 20);
            this.CardName_label.TabIndex = 21;
            this.CardName_label.Text = "Card Name";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Century", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(258, 503);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "2015 Att Rat Entertainment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Card Subtype";
            // 
            // CardSubtype_chooser
            // 
            this.CardSubtype_chooser.FormattingEnabled = true;
            this.CardSubtype_chooser.Items.AddRange(new object[] {
            "No Type"});
            this.CardSubtype_chooser.Location = new System.Drawing.Point(204, 106);
            this.CardSubtype_chooser.Name = "CardSubtype_chooser";
            this.CardSubtype_chooser.Size = new System.Drawing.Size(259, 21);
            this.CardSubtype_chooser.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(462, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Mana Cost";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(462, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Rarity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(462, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Factions";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(520, 219);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(91, 17);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "Human (Gray)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(520, 235);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(103, 17);
            this.checkBox2.TabIndex = 29;
            this.checkBox2.Text = "Vampire (Purple)";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(520, 251);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(110, 17);
            this.checkBox3.TabIndex = 30;
            this.checkBox3.Text = "Scoundrel (Black)";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(520, 267);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(100, 17);
            this.checkBox4.TabIndex = 31;
            this.checkBox4.Text = "Barbarian (Red)";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(520, 283);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(99, 17);
            this.checkBox5.TabIndex = 32;
            this.checkBox5.Text = "Dragon (Green)";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(520, 299);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(87, 17);
            this.checkBox6.TabIndex = 33;
            this.checkBox6.Text = "Orc (Orange)";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // CardRarity_chooser
            // 
            this.CardRarity_chooser.FormattingEnabled = true;
            this.CardRarity_chooser.Items.AddRange(new object[] {
            "Common",
            "Uncommon",
            "Rare",
            "Treasure Rare"});
            this.CardRarity_chooser.Location = new System.Drawing.Point(520, 192);
            this.CardRarity_chooser.Name = "CardRarity_chooser";
            this.CardRarity_chooser.Size = new System.Drawing.Size(121, 21);
            this.CardRarity_chooser.TabIndex = 34;
            // 
            // CardCost_text
            // 
            this.CardCost_text.Location = new System.Drawing.Point(522, 166);
            this.CardCost_text.Name = "CardCost_text";
            this.CardCost_text.Size = new System.Drawing.Size(100, 20);
            this.CardCost_text.TabIndex = 35;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 478);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 64);
            this.textBox1.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 459);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Fun Text";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(462, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Effects";
            // 
            // CardEffects_chooser
            // 
            this.CardEffects_chooser.FormattingEnabled = true;
            this.CardEffects_chooser.Location = new System.Drawing.Point(465, 347);
            this.CardEffects_chooser.Name = "CardEffects_chooser";
            this.CardEffects_chooser.Size = new System.Drawing.Size(165, 21);
            this.CardEffects_chooser.TabIndex = 39;
            // 
            // AddEffect_btn
            // 
            this.AddEffect_btn.Location = new System.Drawing.Point(636, 345);
            this.AddEffect_btn.Name = "AddEffect_btn";
            this.AddEffect_btn.Size = new System.Drawing.Size(67, 23);
            this.AddEffect_btn.TabIndex = 40;
            this.AddEffect_btn.Text = "Add Effect";
            this.AddEffect_btn.UseVisualStyleBackColor = true;
            // 
            // CardEffects_box
            // 
            this.CardEffects_box.FormattingEnabled = true;
            this.CardEffects_box.Location = new System.Drawing.Point(465, 377);
            this.CardEffects_box.Name = "CardEffects_box";
            this.CardEffects_box.ScrollAlwaysVisible = true;
            this.CardEffects_box.Size = new System.Drawing.Size(165, 82);
            this.CardEffects_box.TabIndex = 41;
            // 
            // RemoveEffect_btn
            // 
            this.RemoveEffect_btn.Location = new System.Drawing.Point(555, 465);
            this.RemoveEffect_btn.Name = "RemoveEffect_btn";
            this.RemoveEffect_btn.Size = new System.Drawing.Size(75, 23);
            this.RemoveEffect_btn.TabIndex = 42;
            this.RemoveEffect_btn.Text = "Remove";
            this.RemoveEffect_btn.UseVisualStyleBackColor = true;
            // 
            // CreateCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 625);
            this.Controls.Add(this.RemoveEffect_btn);
            this.Controls.Add(this.CardEffects_box);
            this.Controls.Add(this.AddEffect_btn);
            this.Controls.Add(this.CardEffects_chooser);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CardCost_text);
            this.Controls.Add(this.CardRarity_chooser);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CardSubtype_chooser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CardName_label);
            this.Controls.Add(this.Card_image);
            this.Controls.Add(this.Frame_image);
            this.Controls.Add(this.CardFrame_chooser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UploadPicture_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CardType_chooser);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Create_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CardName_text);
            this.Controls.Add(this.Title_label);
            this.Name = "CreateCardForm";
            this.Text = "CreateCardForm";
            ((System.ComponentModel.ISupportInitialize)(this.Card_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Frame_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UploadPicture_btn;
        private System.Windows.Forms.PictureBox Card_image;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CardType_chooser;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Button Create_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CardName_text;
        private System.Windows.Forms.Label Title_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CardFrame_chooser;
        private System.Windows.Forms.PictureBox Frame_image;
        private System.Windows.Forms.Label CardName_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CardSubtype_chooser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.ComboBox CardRarity_chooser;
        private System.Windows.Forms.TextBox CardCost_text;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CardEffects_chooser;
        private System.Windows.Forms.Button AddEffect_btn;
        private System.Windows.Forms.ListBox CardEffects_box;
        private System.Windows.Forms.Button RemoveEffect_btn;
    }
}