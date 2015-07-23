namespace CardMaker
{
    partial class EffectControl
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
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.Save_btn = new System.Windows.Forms.Button();
            this.AddModifier_btn = new System.Windows.Forms.Button();
            this.RemoveModifier_btn = new System.Windows.Forms.Button();
            this.Modifiers_listbox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ModValue_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BaseMod_chooser = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EffectName_text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Effect_listbox = new System.Windows.Forms.ListBox();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.TargetRange_chooser = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TargetPlayer_checkBox = new System.Windows.Forms.CheckBox();
            this.TargetCreature_checkBox = new System.Windows.Forms.CheckBox();
            this.TargetRelic_checkBox = new System.Windows.Forms.CheckBox();
            this.TargetSpell_checkBox = new System.Windows.Forms.CheckBox();
            this.TargetDefSpell_checkBox = new System.Windows.Forms.CheckBox();
            this.TargetLibrary_checkBox = new System.Windows.Forms.CheckBox();
            this.TargetHand_checkBox = new System.Windows.Forms.CheckBox();
            this.TargetGraveyard_checkBox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.BackColor = System.Drawing.Color.DarkRed;
            this.Cancel_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancel_btn.Location = new System.Drawing.Point(473, 595);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(140, 23);
            this.Cancel_btn.TabIndex = 40;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = false;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(473, 557);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(140, 32);
            this.Save_btn.TabIndex = 39;
            this.Save_btn.Text = "Save Effect";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // AddModifier_btn
            // 
            this.AddModifier_btn.Location = new System.Drawing.Point(573, 128);
            this.AddModifier_btn.Name = "AddModifier_btn";
            this.AddModifier_btn.Size = new System.Drawing.Size(75, 22);
            this.AddModifier_btn.TabIndex = 38;
            this.AddModifier_btn.Text = "Add Modifier";
            this.AddModifier_btn.UseVisualStyleBackColor = true;
            this.AddModifier_btn.Click += new System.EventHandler(this.AddModifier_btn_Click);
            // 
            // RemoveModifier_btn
            // 
            this.RemoveModifier_btn.Location = new System.Drawing.Point(581, 372);
            this.RemoveModifier_btn.Name = "RemoveModifier_btn";
            this.RemoveModifier_btn.Size = new System.Drawing.Size(103, 23);
            this.RemoveModifier_btn.TabIndex = 35;
            this.RemoveModifier_btn.Text = "Remove Modifier";
            this.RemoveModifier_btn.UseVisualStyleBackColor = true;
            this.RemoveModifier_btn.Click += new System.EventHandler(this.RemoveModifier_btn_Click);
            // 
            // Modifiers_listbox
            // 
            this.Modifiers_listbox.FormattingEnabled = true;
            this.Modifiers_listbox.Location = new System.Drawing.Point(390, 171);
            this.Modifiers_listbox.Name = "Modifiers_listbox";
            this.Modifiers_listbox.ScrollAlwaysVisible = true;
            this.Modifiers_listbox.Size = new System.Drawing.Size(304, 199);
            this.Modifiers_listbox.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Current Modifiers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "modifier";
            // 
            // ModValue_text
            // 
            this.ModValue_text.Location = new System.Drawing.Point(454, 129);
            this.ModValue_text.Name = "ModValue_text";
            this.ModValue_text.Size = new System.Drawing.Size(100, 20);
            this.ModValue_text.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(421, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Add Modifiers";
            // 
            // BaseMod_chooser
            // 
            this.BaseMod_chooser.FormattingEnabled = true;
            this.BaseMod_chooser.Location = new System.Drawing.Point(455, 100);
            this.BaseMod_chooser.Name = "BaseMod_chooser";
            this.BaseMod_chooser.Size = new System.Drawing.Size(201, 21);
            this.BaseMod_chooser.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Effect Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EffectName_text
            // 
            this.EffectName_text.Location = new System.Drawing.Point(390, 39);
            this.EffectName_text.Name = "EffectName_text";
            this.EffectName_text.Size = new System.Drawing.Size(362, 20);
            this.EffectName_text.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 454);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Target Types:";
            // 
            // Effect_listbox
            // 
            this.Effect_listbox.FormattingEnabled = true;
            this.Effect_listbox.Location = new System.Drawing.Point(9, 16);
            this.Effect_listbox.Name = "Effect_listbox";
            this.Effect_listbox.ScrollAlwaysVisible = true;
            this.Effect_listbox.Size = new System.Drawing.Size(227, 485);
            this.Effect_listbox.TabIndex = 43;
            this.Effect_listbox.SelectedIndexChanged += new System.EventHandler(this.Effect_listbox_SelectedIndexChanged);
            // 
            // Delete_btn
            // 
            this.Delete_btn.Location = new System.Drawing.Point(156, 506);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(75, 23);
            this.Delete_btn.TabIndex = 91;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = true;
            // 
            // TargetRange_chooser
            // 
            this.TargetRange_chooser.FormattingEnabled = true;
            this.TargetRange_chooser.Location = new System.Drawing.Point(455, 522);
            this.TargetRange_chooser.Name = "TargetRange_chooser";
            this.TargetRange_chooser.Size = new System.Drawing.Size(203, 21);
            this.TargetRange_chooser.TabIndex = 93;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(384, 526);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 92;
            this.label7.Text = "Target Range";
            // 
            // TargetPlayer_checkBox
            // 
            this.TargetPlayer_checkBox.AutoSize = true;
            this.TargetPlayer_checkBox.Location = new System.Drawing.Point(401, 434);
            this.TargetPlayer_checkBox.Name = "TargetPlayer_checkBox";
            this.TargetPlayer_checkBox.Size = new System.Drawing.Size(55, 17);
            this.TargetPlayer_checkBox.TabIndex = 94;
            this.TargetPlayer_checkBox.Text = "Player";
            this.TargetPlayer_checkBox.UseVisualStyleBackColor = true;
            // 
            // TargetCreature_checkBox
            // 
            this.TargetCreature_checkBox.AutoSize = true;
            this.TargetCreature_checkBox.Location = new System.Drawing.Point(400, 456);
            this.TargetCreature_checkBox.Name = "TargetCreature_checkBox";
            this.TargetCreature_checkBox.Size = new System.Drawing.Size(66, 17);
            this.TargetCreature_checkBox.TabIndex = 95;
            this.TargetCreature_checkBox.Text = "Creature";
            this.TargetCreature_checkBox.UseVisualStyleBackColor = true;
            // 
            // TargetRelic_checkBox
            // 
            this.TargetRelic_checkBox.AutoSize = true;
            this.TargetRelic_checkBox.Location = new System.Drawing.Point(400, 480);
            this.TargetRelic_checkBox.Name = "TargetRelic_checkBox";
            this.TargetRelic_checkBox.Size = new System.Drawing.Size(50, 17);
            this.TargetRelic_checkBox.TabIndex = 96;
            this.TargetRelic_checkBox.Text = "Relic";
            this.TargetRelic_checkBox.UseVisualStyleBackColor = true;
            // 
            // TargetSpell_checkBox
            // 
            this.TargetSpell_checkBox.AutoSize = true;
            this.TargetSpell_checkBox.Location = new System.Drawing.Point(495, 434);
            this.TargetSpell_checkBox.Name = "TargetSpell_checkBox";
            this.TargetSpell_checkBox.Size = new System.Drawing.Size(49, 17);
            this.TargetSpell_checkBox.TabIndex = 97;
            this.TargetSpell_checkBox.Text = "Spell";
            this.TargetSpell_checkBox.UseVisualStyleBackColor = true;
            // 
            // TargetDefSpell_checkBox
            // 
            this.TargetDefSpell_checkBox.AutoSize = true;
            this.TargetDefSpell_checkBox.Location = new System.Drawing.Point(495, 456);
            this.TargetDefSpell_checkBox.Name = "TargetDefSpell_checkBox";
            this.TargetDefSpell_checkBox.Size = new System.Drawing.Size(92, 17);
            this.TargetDefSpell_checkBox.TabIndex = 98;
            this.TargetDefSpell_checkBox.Text = "Defense Spell";
            this.TargetDefSpell_checkBox.UseVisualStyleBackColor = true;
            // 
            // TargetLibrary_checkBox
            // 
            this.TargetLibrary_checkBox.AutoSize = true;
            this.TargetLibrary_checkBox.Location = new System.Drawing.Point(625, 456);
            this.TargetLibrary_checkBox.Name = "TargetLibrary_checkBox";
            this.TargetLibrary_checkBox.Size = new System.Drawing.Size(57, 17);
            this.TargetLibrary_checkBox.TabIndex = 99;
            this.TargetLibrary_checkBox.Text = "Library";
            this.TargetLibrary_checkBox.UseVisualStyleBackColor = true;
            // 
            // TargetHand_checkBox
            // 
            this.TargetHand_checkBox.AutoSize = true;
            this.TargetHand_checkBox.Location = new System.Drawing.Point(625, 433);
            this.TargetHand_checkBox.Name = "TargetHand_checkBox";
            this.TargetHand_checkBox.Size = new System.Drawing.Size(52, 17);
            this.TargetHand_checkBox.TabIndex = 100;
            this.TargetHand_checkBox.Text = "Hand";
            this.TargetHand_checkBox.UseVisualStyleBackColor = true;
            // 
            // TargetGraveyard_checkBox
            // 
            this.TargetGraveyard_checkBox.AutoSize = true;
            this.TargetGraveyard_checkBox.Location = new System.Drawing.Point(625, 479);
            this.TargetGraveyard_checkBox.Name = "TargetGraveyard_checkBox";
            this.TargetGraveyard_checkBox.Size = new System.Drawing.Size(75, 17);
            this.TargetGraveyard_checkBox.TabIndex = 101;
            this.TargetGraveyard_checkBox.Text = "Graveyard";
            this.TargetGraveyard_checkBox.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(388, 413);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 102;
            this.label8.Text = "Permanents";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(500, 412);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 103;
            this.label9.Text = "Spells";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(623, 412);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 104;
            this.label10.Text = "Cards";
            // 
            // EffectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TargetGraveyard_checkBox);
            this.Controls.Add(this.TargetHand_checkBox);
            this.Controls.Add(this.TargetLibrary_checkBox);
            this.Controls.Add(this.TargetDefSpell_checkBox);
            this.Controls.Add(this.TargetSpell_checkBox);
            this.Controls.Add(this.TargetRelic_checkBox);
            this.Controls.Add(this.TargetCreature_checkBox);
            this.Controls.Add(this.TargetPlayer_checkBox);
            this.Controls.Add(this.TargetRange_chooser);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Effect_listbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.AddModifier_btn);
            this.Controls.Add(this.RemoveModifier_btn);
            this.Controls.Add(this.Modifiers_listbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ModValue_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BaseMod_chooser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EffectName_text);
            this.Name = "EffectControl";
            this.Size = new System.Drawing.Size(991, 629);
            this.Load += new System.EventHandler(this.EffectControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Button AddModifier_btn;
        private System.Windows.Forms.Button RemoveModifier_btn;
        private System.Windows.Forms.ListBox Modifiers_listbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ModValue_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox BaseMod_chooser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EffectName_text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox Effect_listbox;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.ComboBox TargetRange_chooser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox TargetPlayer_checkBox;
        private System.Windows.Forms.CheckBox TargetCreature_checkBox;
        private System.Windows.Forms.CheckBox TargetRelic_checkBox;
        private System.Windows.Forms.CheckBox TargetSpell_checkBox;
        private System.Windows.Forms.CheckBox TargetDefSpell_checkBox;
        private System.Windows.Forms.CheckBox TargetLibrary_checkBox;
        private System.Windows.Forms.CheckBox TargetHand_checkBox;
        private System.Windows.Forms.CheckBox TargetGraveyard_checkBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}
