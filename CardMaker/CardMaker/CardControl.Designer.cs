namespace CardMaker
{
    partial class CardControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardControl));
            this.CardHitpoints_text = new System.Windows.Forms.TextBox();
            this.CardDefense_text = new System.Windows.Forms.TextBox();
            this.CardAttack_text = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.RemoveEffect_btn = new System.Windows.Forms.Button();
            this.CardEffects_listbox = new System.Windows.Forms.ListBox();
            this.AddEffect_btn = new System.Windows.Forms.Button();
            this.CardEffects_chooser = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CardTagline_text = new System.Windows.Forms.TextBox();
            this.CardCost_text = new System.Windows.Forms.TextBox();
            this.CardRarity_chooser = new System.Windows.Forms.ComboBox();
            this.FactionOrc_checkbox = new System.Windows.Forms.CheckBox();
            this.FactionDragon_checkbox = new System.Windows.Forms.CheckBox();
            this.FactionBarbarian_checkbox = new System.Windows.Forms.CheckBox();
            this.FactionScoundrel_checkbox = new System.Windows.Forms.CheckBox();
            this.FactionVampire_checkbox = new System.Windows.Forms.CheckBox();
            this.FactionHuman_checkbox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CardSubtype_chooser = new System.Windows.Forms.ComboBox();
            this.Copyright_label = new System.Windows.Forms.Label();
            this.CardName_label = new System.Windows.Forms.Label();
            this.Card_image = new System.Windows.Forms.PictureBox();
            this.Frame_image = new System.Windows.Forms.PictureBox();
            this.CardFrame_chooser = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UploadPicture_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CardType_chooser = new System.Windows.Forms.ComboBox();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.Save_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CardName_text = new System.Windows.Forms.TextBox();
            this.Card_listbox = new System.Windows.Forms.ListBox();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Attacktext_label = new System.Windows.Forms.Label();
            this.Defensetext_label = new System.Windows.Forms.Label();
            this.Hitpointstext_label = new System.Windows.Forms.Label();
            this.Attack_label = new System.Windows.Forms.Label();
            this.Defense_label = new System.Windows.Forms.Label();
            this.Hitpoints_label = new System.Windows.Forms.Label();
            this.Tagline_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Card_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Frame_image)).BeginInit();
            this.SuspendLayout();
            // 
            // CardHitpoints_text
            // 
            this.CardHitpoints_text.Location = new System.Drawing.Point(357, 325);
            this.CardHitpoints_text.Name = "CardHitpoints_text";
            this.CardHitpoints_text.Size = new System.Drawing.Size(62, 20);
            this.CardHitpoints_text.TabIndex = 88;
            this.CardHitpoints_text.TextChanged += new System.EventHandler(this.CardHitpoints_text_TextChanged);
            // 
            // CardDefense_text
            // 
            this.CardDefense_text.Location = new System.Drawing.Point(358, 296);
            this.CardDefense_text.Name = "CardDefense_text";
            this.CardDefense_text.Size = new System.Drawing.Size(61, 20);
            this.CardDefense_text.TabIndex = 87;
            this.CardDefense_text.TextChanged += new System.EventHandler(this.CardDefense_text_TextChanged);
            // 
            // CardAttack_text
            // 
            this.CardAttack_text.Location = new System.Drawing.Point(358, 266);
            this.CardAttack_text.Name = "CardAttack_text";
            this.CardAttack_text.Size = new System.Drawing.Size(61, 20);
            this.CardAttack_text.TabIndex = 86;
            this.CardAttack_text.TextChanged += new System.EventHandler(this.CardAttack_text_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(297, 329);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 85;
            this.label13.Text = "Hitpoints";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(297, 299);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 84;
            this.label12.Text = "Defense";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(306, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 83;
            this.label11.Text = "Attack";
            // 
            // RemoveEffect_btn
            // 
            this.RemoveEffect_btn.Location = new System.Drawing.Point(811, 440);
            this.RemoveEffect_btn.Name = "RemoveEffect_btn";
            this.RemoveEffect_btn.Size = new System.Drawing.Size(75, 23);
            this.RemoveEffect_btn.TabIndex = 82;
            this.RemoveEffect_btn.Text = "Remove";
            this.RemoveEffect_btn.UseVisualStyleBackColor = true;
            this.RemoveEffect_btn.Click += new System.EventHandler(this.RemoveEffect_btn_Click);
            // 
            // CardEffects_listbox
            // 
            this.CardEffects_listbox.FormattingEnabled = true;
            this.CardEffects_listbox.Location = new System.Drawing.Point(721, 352);
            this.CardEffects_listbox.Name = "CardEffects_listbox";
            this.CardEffects_listbox.ScrollAlwaysVisible = true;
            this.CardEffects_listbox.Size = new System.Drawing.Size(165, 82);
            this.CardEffects_listbox.TabIndex = 81;
            // 
            // AddEffect_btn
            // 
            this.AddEffect_btn.Location = new System.Drawing.Point(892, 320);
            this.AddEffect_btn.Name = "AddEffect_btn";
            this.AddEffect_btn.Size = new System.Drawing.Size(67, 23);
            this.AddEffect_btn.TabIndex = 80;
            this.AddEffect_btn.Text = "Add Effect";
            this.AddEffect_btn.UseVisualStyleBackColor = true;
            this.AddEffect_btn.Click += new System.EventHandler(this.AddEffect_btn_Click);
            // 
            // CardEffects_chooser
            // 
            this.CardEffects_chooser.FormattingEnabled = true;
            this.CardEffects_chooser.Location = new System.Drawing.Point(721, 322);
            this.CardEffects_chooser.Name = "CardEffects_chooser";
            this.CardEffects_chooser.Size = new System.Drawing.Size(165, 21);
            this.CardEffects_chooser.TabIndex = 79;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(718, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 78;
            this.label10.Text = "Effects";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(285, 434);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 77;
            this.label9.Text = "Tagline";
            // 
            // CardTagline_text
            // 
            this.CardTagline_text.Location = new System.Drawing.Point(285, 453);
            this.CardTagline_text.Multiline = true;
            this.CardTagline_text.Name = "CardTagline_text";
            this.CardTagline_text.Size = new System.Drawing.Size(155, 64);
            this.CardTagline_text.TabIndex = 76;
            this.CardTagline_text.TextChanged += new System.EventHandler(this.CardTagline_text_TextChanged);
            // 
            // CardCost_text
            // 
            this.CardCost_text.Location = new System.Drawing.Point(778, 141);
            this.CardCost_text.Name = "CardCost_text";
            this.CardCost_text.Size = new System.Drawing.Size(100, 20);
            this.CardCost_text.TabIndex = 75;
            // 
            // CardRarity_chooser
            // 
            this.CardRarity_chooser.FormattingEnabled = true;
            this.CardRarity_chooser.Items.AddRange(new object[] {
            "Common",
            "Uncommon",
            "Rare",
            "Treasure Rare"});
            this.CardRarity_chooser.Location = new System.Drawing.Point(776, 167);
            this.CardRarity_chooser.Name = "CardRarity_chooser";
            this.CardRarity_chooser.Size = new System.Drawing.Size(121, 21);
            this.CardRarity_chooser.TabIndex = 74;
            // 
            // FactionOrc_checkbox
            // 
            this.FactionOrc_checkbox.AutoSize = true;
            this.FactionOrc_checkbox.Location = new System.Drawing.Point(776, 274);
            this.FactionOrc_checkbox.Name = "FactionOrc_checkbox";
            this.FactionOrc_checkbox.Size = new System.Drawing.Size(87, 17);
            this.FactionOrc_checkbox.TabIndex = 73;
            this.FactionOrc_checkbox.Text = "Orc (Orange)";
            this.FactionOrc_checkbox.UseVisualStyleBackColor = true;
            // 
            // FactionDragon_checkbox
            // 
            this.FactionDragon_checkbox.AutoSize = true;
            this.FactionDragon_checkbox.Location = new System.Drawing.Point(776, 258);
            this.FactionDragon_checkbox.Name = "FactionDragon_checkbox";
            this.FactionDragon_checkbox.Size = new System.Drawing.Size(99, 17);
            this.FactionDragon_checkbox.TabIndex = 72;
            this.FactionDragon_checkbox.Text = "Dragon (Green)";
            this.FactionDragon_checkbox.UseVisualStyleBackColor = true;
            // 
            // FactionBarbarian_checkbox
            // 
            this.FactionBarbarian_checkbox.AutoSize = true;
            this.FactionBarbarian_checkbox.Location = new System.Drawing.Point(776, 242);
            this.FactionBarbarian_checkbox.Name = "FactionBarbarian_checkbox";
            this.FactionBarbarian_checkbox.Size = new System.Drawing.Size(100, 17);
            this.FactionBarbarian_checkbox.TabIndex = 71;
            this.FactionBarbarian_checkbox.Text = "Barbarian (Red)";
            this.FactionBarbarian_checkbox.UseVisualStyleBackColor = true;
            // 
            // FactionScoundrel_checkbox
            // 
            this.FactionScoundrel_checkbox.AutoSize = true;
            this.FactionScoundrel_checkbox.Location = new System.Drawing.Point(776, 226);
            this.FactionScoundrel_checkbox.Name = "FactionScoundrel_checkbox";
            this.FactionScoundrel_checkbox.Size = new System.Drawing.Size(110, 17);
            this.FactionScoundrel_checkbox.TabIndex = 70;
            this.FactionScoundrel_checkbox.Text = "Scoundrel (Black)";
            this.FactionScoundrel_checkbox.UseVisualStyleBackColor = true;
            // 
            // FactionVampire_checkbox
            // 
            this.FactionVampire_checkbox.AutoSize = true;
            this.FactionVampire_checkbox.Location = new System.Drawing.Point(776, 210);
            this.FactionVampire_checkbox.Name = "FactionVampire_checkbox";
            this.FactionVampire_checkbox.Size = new System.Drawing.Size(103, 17);
            this.FactionVampire_checkbox.TabIndex = 69;
            this.FactionVampire_checkbox.Text = "Vampire (Purple)";
            this.FactionVampire_checkbox.UseVisualStyleBackColor = true;
            // 
            // FactionHuman_checkbox
            // 
            this.FactionHuman_checkbox.AutoSize = true;
            this.FactionHuman_checkbox.Location = new System.Drawing.Point(776, 194);
            this.FactionHuman_checkbox.Name = "FactionHuman_checkbox";
            this.FactionHuman_checkbox.Size = new System.Drawing.Size(91, 17);
            this.FactionHuman_checkbox.TabIndex = 68;
            this.FactionHuman_checkbox.Text = "Human (Gray)";
            this.FactionHuman_checkbox.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(718, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 67;
            this.label8.Text = "Factions";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(718, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 66;
            this.label7.Text = "Rarity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(718, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "Mana Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "Card Subtype";
            // 
            // CardSubtype_chooser
            // 
            this.CardSubtype_chooser.FormattingEnabled = true;
            this.CardSubtype_chooser.Items.AddRange(new object[] {
            "No Type"});
            this.CardSubtype_chooser.Location = new System.Drawing.Point(460, 81);
            this.CardSubtype_chooser.Name = "CardSubtype_chooser";
            this.CardSubtype_chooser.Size = new System.Drawing.Size(259, 21);
            this.CardSubtype_chooser.TabIndex = 63;
            // 
            // Copyright_label
            // 
            this.Copyright_label.BackColor = System.Drawing.Color.Black;
            this.Copyright_label.Enabled = false;
            this.Copyright_label.Font = new System.Drawing.Font("Century", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copyright_label.ForeColor = System.Drawing.Color.White;
            this.Copyright_label.Location = new System.Drawing.Point(525, 481);
            this.Copyright_label.Name = "Copyright_label";
            this.Copyright_label.Size = new System.Drawing.Size(113, 12);
            this.Copyright_label.TabIndex = 62;
            this.Copyright_label.Text = "2015 Att Rat Entertainment";
            // 
            // CardName_label
            // 
            this.CardName_label.BackColor = System.Drawing.Color.Black;
            this.CardName_label.Enabled = false;
            this.CardName_label.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardName_label.ForeColor = System.Drawing.Color.White;
            this.CardName_label.Location = new System.Drawing.Point(467, 134);
            this.CardName_label.Name = "CardName_label";
            this.CardName_label.Size = new System.Drawing.Size(181, 14);
            this.CardName_label.TabIndex = 61;
            this.CardName_label.Text = "Card Name";
            // 
            // Card_image
            // 
            this.Card_image.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Card_image.Location = new System.Drawing.Point(475, 150);
            this.Card_image.Name = "Card_image";
            this.Card_image.Size = new System.Drawing.Size(209, 157);
            this.Card_image.TabIndex = 56;
            this.Card_image.TabStop = false;
            // 
            // Frame_image
            // 
            this.Frame_image.BackColor = System.Drawing.Color.Transparent;
            this.Frame_image.Image = ((System.Drawing.Image)(resources.GetObject("Frame_image.Image")));
            this.Frame_image.Location = new System.Drawing.Point(460, 135);
            this.Frame_image.Name = "Frame_image";
            this.Frame_image.Size = new System.Drawing.Size(240, 360);
            this.Frame_image.TabIndex = 60;
            this.Frame_image.TabStop = false;
            // 
            // CardFrame_chooser
            // 
            this.CardFrame_chooser.FormattingEnabled = true;
            this.CardFrame_chooser.Items.AddRange(new object[] {
            "Default",
            "Gray",
            "Purple",
            "Black",
            "Red",
            "Green",
            "Orange"});
            this.CardFrame_chooser.Location = new System.Drawing.Point(268, 163);
            this.CardFrame_chooser.Name = "CardFrame_chooser";
            this.CardFrame_chooser.Size = new System.Drawing.Size(175, 21);
            this.CardFrame_chooser.TabIndex = 59;
            this.CardFrame_chooser.SelectedIndexChanged += new System.EventHandler(this.CardFrame_chooser_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Choose Frame";
            // 
            // UploadPicture_btn
            // 
            this.UploadPicture_btn.Location = new System.Drawing.Point(288, 204);
            this.UploadPicture_btn.Name = "UploadPicture_btn";
            this.UploadPicture_btn.Size = new System.Drawing.Size(130, 23);
            this.UploadPicture_btn.TabIndex = 57;
            this.UploadPicture_btn.Text = "Upload Picture";
            this.UploadPicture_btn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Card Type";
            // 
            // CardType_chooser
            // 
            this.CardType_chooser.FormattingEnabled = true;
            this.CardType_chooser.Items.AddRange(new object[] {
            "No Type",
            "Spell",
            "Defensive Spell",
            "Creature",
            "Relic"});
            this.CardType_chooser.Location = new System.Drawing.Point(460, 54);
            this.CardType_chooser.Name = "CardType_chooser";
            this.CardType_chooser.Size = new System.Drawing.Size(259, 21);
            this.CardType_chooser.TabIndex = 54;
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.BackColor = System.Drawing.Color.DarkRed;
            this.Cancel_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancel_btn.Location = new System.Drawing.Point(513, 575);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(140, 23);
            this.Cancel_btn.TabIndex = 53;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = false;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(513, 512);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(140, 57);
            this.Save_btn.TabIndex = 52;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Card Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CardName_text
            // 
            this.CardName_text.Location = new System.Drawing.Point(459, 25);
            this.CardName_text.Name = "CardName_text";
            this.CardName_text.Size = new System.Drawing.Size(260, 20);
            this.CardName_text.TabIndex = 50;
            this.CardName_text.TextChanged += new System.EventHandler(this.CardName_text_TextChanged);
            // 
            // Card_listbox
            // 
            this.Card_listbox.FormattingEnabled = true;
            this.Card_listbox.Location = new System.Drawing.Point(12, 12);
            this.Card_listbox.Name = "Card_listbox";
            this.Card_listbox.ScrollAlwaysVisible = true;
            this.Card_listbox.Size = new System.Drawing.Size(219, 511);
            this.Card_listbox.TabIndex = 89;
            this.Card_listbox.SelectedIndexChanged += new System.EventHandler(this.Card_listbox_SelectedIndexChanged);
            // 
            // Delete_btn
            // 
            this.Delete_btn.Location = new System.Drawing.Point(142, 528);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(75, 23);
            this.Delete_btn.TabIndex = 90;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = true;
            // 
            // Attacktext_label
            // 
            this.Attacktext_label.BackColor = System.Drawing.Color.Black;
            this.Attacktext_label.Enabled = false;
            this.Attacktext_label.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attacktext_label.ForeColor = System.Drawing.Color.White;
            this.Attacktext_label.Location = new System.Drawing.Point(484, 428);
            this.Attacktext_label.Name = "Attacktext_label";
            this.Attacktext_label.Size = new System.Drawing.Size(49, 14);
            this.Attacktext_label.TabIndex = 91;
            this.Attacktext_label.Text = "Attack";
            // 
            // Defensetext_label
            // 
            this.Defensetext_label.BackColor = System.Drawing.Color.Black;
            this.Defensetext_label.Enabled = false;
            this.Defensetext_label.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Defensetext_label.ForeColor = System.Drawing.Color.White;
            this.Defensetext_label.Location = new System.Drawing.Point(560, 427);
            this.Defensetext_label.Name = "Defensetext_label";
            this.Defensetext_label.Size = new System.Drawing.Size(56, 14);
            this.Defensetext_label.TabIndex = 92;
            this.Defensetext_label.Text = "Defense";
            // 
            // Hitpointstext_label
            // 
            this.Hitpointstext_label.BackColor = System.Drawing.Color.Black;
            this.Hitpointstext_label.Enabled = false;
            this.Hitpointstext_label.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hitpointstext_label.ForeColor = System.Drawing.Color.White;
            this.Hitpointstext_label.Location = new System.Drawing.Point(643, 426);
            this.Hitpointstext_label.Name = "Hitpointstext_label";
            this.Hitpointstext_label.Size = new System.Drawing.Size(25, 14);
            this.Hitpointstext_label.TabIndex = 93;
            this.Hitpointstext_label.Text = "HP";
            // 
            // Attack_label
            // 
            this.Attack_label.BackColor = System.Drawing.Color.Black;
            this.Attack_label.Enabled = false;
            this.Attack_label.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attack_label.ForeColor = System.Drawing.Color.White;
            this.Attack_label.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Attack_label.Location = new System.Drawing.Point(485, 442);
            this.Attack_label.Name = "Attack_label";
            this.Attack_label.Size = new System.Drawing.Size(46, 33);
            this.Attack_label.TabIndex = 94;
            this.Attack_label.Text = "0";
            this.Attack_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Defense_label
            // 
            this.Defense_label.BackColor = System.Drawing.Color.Black;
            this.Defense_label.Enabled = false;
            this.Defense_label.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Defense_label.ForeColor = System.Drawing.Color.White;
            this.Defense_label.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Defense_label.Location = new System.Drawing.Point(563, 439);
            this.Defense_label.Name = "Defense_label";
            this.Defense_label.Size = new System.Drawing.Size(50, 33);
            this.Defense_label.TabIndex = 95;
            this.Defense_label.Text = "0";
            this.Defense_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Hitpoints_label
            // 
            this.Hitpoints_label.BackColor = System.Drawing.Color.Black;
            this.Hitpoints_label.Enabled = false;
            this.Hitpoints_label.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hitpoints_label.ForeColor = System.Drawing.Color.White;
            this.Hitpoints_label.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Hitpoints_label.Location = new System.Drawing.Point(632, 439);
            this.Hitpoints_label.Name = "Hitpoints_label";
            this.Hitpoints_label.Size = new System.Drawing.Size(48, 33);
            this.Hitpoints_label.TabIndex = 96;
            this.Hitpoints_label.Text = "0";
            this.Hitpoints_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tagline_label
            // 
            this.Tagline_label.BackColor = System.Drawing.Color.Black;
            this.Tagline_label.Enabled = false;
            this.Tagline_label.Font = new System.Drawing.Font("Century", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tagline_label.ForeColor = System.Drawing.Color.Gainsboro;
            this.Tagline_label.Location = new System.Drawing.Point(480, 387);
            this.Tagline_label.Name = "Tagline_label";
            this.Tagline_label.Size = new System.Drawing.Size(199, 33);
            this.Tagline_label.TabIndex = 97;
            // 
            // CardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Tagline_label);
            this.Controls.Add(this.Hitpoints_label);
            this.Controls.Add(this.Defense_label);
            this.Controls.Add(this.Attack_label);
            this.Controls.Add(this.Hitpointstext_label);
            this.Controls.Add(this.Defensetext_label);
            this.Controls.Add(this.Attacktext_label);
            this.Controls.Add(this.CardName_label);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Card_listbox);
            this.Controls.Add(this.CardHitpoints_text);
            this.Controls.Add(this.CardDefense_text);
            this.Controls.Add(this.CardAttack_text);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.RemoveEffect_btn);
            this.Controls.Add(this.CardEffects_listbox);
            this.Controls.Add(this.AddEffect_btn);
            this.Controls.Add(this.CardEffects_chooser);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CardTagline_text);
            this.Controls.Add(this.CardCost_text);
            this.Controls.Add(this.CardRarity_chooser);
            this.Controls.Add(this.FactionOrc_checkbox);
            this.Controls.Add(this.FactionDragon_checkbox);
            this.Controls.Add(this.FactionBarbarian_checkbox);
            this.Controls.Add(this.FactionScoundrel_checkbox);
            this.Controls.Add(this.FactionVampire_checkbox);
            this.Controls.Add(this.FactionHuman_checkbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CardSubtype_chooser);
            this.Controls.Add(this.Copyright_label);
            this.Controls.Add(this.Card_image);
            this.Controls.Add(this.Frame_image);
            this.Controls.Add(this.CardFrame_chooser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UploadPicture_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CardType_chooser);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CardName_text);
            this.Name = "CardControl";
            this.Size = new System.Drawing.Size(987, 671);
            this.Load += new System.EventHandler(this.CardControl_Load);
            this.VisibleChanged += new System.EventHandler(this.CardControl_Visible);
            ((System.ComponentModel.ISupportInitialize)(this.Card_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Frame_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CardHitpoints_text;
        private System.Windows.Forms.TextBox CardDefense_text;
        private System.Windows.Forms.TextBox CardAttack_text;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button RemoveEffect_btn;
        private System.Windows.Forms.ListBox CardEffects_listbox;
        private System.Windows.Forms.Button AddEffect_btn;
        private System.Windows.Forms.ComboBox CardEffects_chooser;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CardTagline_text;
        private System.Windows.Forms.TextBox CardCost_text;
        private System.Windows.Forms.ComboBox CardRarity_chooser;
        private System.Windows.Forms.CheckBox FactionOrc_checkbox;
        private System.Windows.Forms.CheckBox FactionDragon_checkbox;
        private System.Windows.Forms.CheckBox FactionBarbarian_checkbox;
        private System.Windows.Forms.CheckBox FactionScoundrel_checkbox;
        private System.Windows.Forms.CheckBox FactionVampire_checkbox;
        private System.Windows.Forms.CheckBox FactionHuman_checkbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CardSubtype_chooser;
        private System.Windows.Forms.Label Copyright_label;
        private System.Windows.Forms.Label CardName_label;
        private System.Windows.Forms.PictureBox Card_image;
        private System.Windows.Forms.PictureBox Frame_image;
        private System.Windows.Forms.ComboBox CardFrame_chooser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button UploadPicture_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CardType_chooser;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CardName_text;
        private System.Windows.Forms.ListBox Card_listbox;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Label Attacktext_label;
        private System.Windows.Forms.Label Defensetext_label;
        private System.Windows.Forms.Label Hitpointstext_label;
        private System.Windows.Forms.Label Attack_label;
        private System.Windows.Forms.Label Defense_label;
        private System.Windows.Forms.Label Hitpoints_label;
        private System.Windows.Forms.Label Tagline_label;
    }
}
