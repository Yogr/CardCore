using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardCore;

namespace CardMaker
{
    public partial class EffectControl : UserControl
    {
        private class ListModifierObject : Effect.Modifier
        {
            private string mDisplay;

            public string Display
            {
                get { return this.mDisplay; }
                set { this.mDisplay = value; }
            }

            public void SetDisplay()
            {
                mDisplay = this.Type.ToString() + " : " + this.Value.ToString();
            }
        }

        private int mLastSelectedIndex = -1;

        public EffectControl()
        {
            InitializeComponent();

            for (int i = 0; i < Convert.ToInt32(Effect.ModifierType.MODTYPE_COUNT); ++i )
            {
                BaseMod_chooser.Items.Add((Effect.ModifierType)i);
            }

            for (int i = 0; i < Convert.ToInt32(Effect.TargetRange.TARGETRANGE_COUNT); ++i )
            {
                TargetRange_chooser.Items.Add((Effect.TargetRange)i);
            }

            Modifiers_listbox.DisplayMember = "Display";
            Effect_listbox.DisplayMember = "Name";

            _RefreshListbox();
        }

        /// <summary>
        ///  Called when you want to refresh the listbox on the left
        /// </summary>
        private void _RefreshListbox()
        {
            Effect_listbox.Items.Clear();

            foreach (Effect e in EffectManager.GetInstance().GetAllEffects())
            {
                Effect_listbox.Items.Add(e);
            }

            Effect_listbox.Items.Add("<Create New Effect>");
        }

        private void Effect_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Grab current selected index
            int index = Effect_listbox.SelectedIndex;

            // Make sure it differs from last selected index
            if (index != mLastSelectedIndex)
            {
                mLastSelectedIndex = index;

                _LoadEffectDataToForm(index);
            }
        }

        /// <summary>
        /// Called when you want to load selected effect data to the form
        /// </summary>
        /// <param name="index">Currently selected index</param>
        private void _LoadEffectDataToForm(int index)
        {
            // Is this an existing effect to edit?
            if (index >= 0 && index < EffectManager.GetInstance().GetAllEffects().Count)
            {
                Effect e = EffectManager.GetInstance().GetEffectByIndex(index);

                // Name
                EffectName_text.Text = e.Name;

                // Modifiers
                Modifiers_listbox.Items.Clear();
                foreach(Effect.Modifier mod in e.GetModifiers())
                {
                    ListModifierObject modobj = new ListModifierObject();
                    modobj.Type = mod.Type;
                    modobj.Value = mod.Value;
                    modobj.SetDisplay();

                    Modifiers_listbox.Items.Add(modobj);
                }

                // Target options
                TargetPlayer_checkBox.Checked = e.CanTargetEntity(GameEntity.EntityType.TYPE_PLAYER);
                TargetCreature_checkBox.Checked = e.CanTargetEntity(GameEntity.EntityType.TYPE_CREATURE);
                TargetRelic_checkBox.Checked = e.CanTargetEntity(GameEntity.EntityType.TYPE_RELIC);
                TargetSpell_checkBox.Checked = e.CanTargetEntity(GameEntity.EntityType.TYPE_SPELL);
                TargetDefSpell_checkBox.Checked = e.CanTargetEntity(GameEntity.EntityType.TYPE_DEFSPELL);
                TargetHand_checkBox.Checked = e.CanTargetEntity(GameEntity.EntityType.TYPE_HAND);
                TargetLibrary_checkBox.Checked = e.CanTargetEntity(GameEntity.EntityType.TYPE_LIBRARY);
                TargetGraveyard_checkBox.Checked = e.CanTargetEntity(GameEntity.EntityType.TYPE_GRAVEYARD);

                // Target range
                TargetRange_chooser.SelectedIndex = Convert.ToInt32(e.Range);
            }
            else // Create new effect
            {
                // Name
                EffectName_text.Text = "";

                // Modifiers
                Modifiers_listbox.Items.Clear();

                // Target options
                TargetPlayer_checkBox.Checked = false;
                TargetCreature_checkBox.Checked = false;
                TargetRelic_checkBox.Checked = false;
                TargetSpell_checkBox.Checked = false;
                TargetDefSpell_checkBox.Checked = false;
                TargetHand_checkBox.Checked = false;
                TargetLibrary_checkBox.Checked = false;
                TargetGraveyard_checkBox.Checked = false;

                // Target range
                TargetRange_chooser.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Takes an effect reference and populates it with the current form data
        /// </summary>
        /// <param name="effect">Reference to effect</param>
        private void _FillOutDataToEffect(Effect effect)
        {
            effect.Id = EffectManager.GetInstance().GetNextValidId();
            effect.Name = EffectName_text.Text;
            effect.Range = (Effect.TargetRange)TargetRange_chooser.SelectedIndex;

            // Target Types
            effect.SetTargetTypes(0);
            if (true == TargetPlayer_checkBox.Checked) { effect.AddTargetType(GameEntity.EntityType.TYPE_PLAYER); }
            if (true == TargetCreature_checkBox.Checked) { effect.AddTargetType(GameEntity.EntityType.TYPE_CREATURE); }
            if (true == TargetRelic_checkBox.Checked) { effect.AddTargetType(GameEntity.EntityType.TYPE_RELIC); }
            if (true == TargetSpell_checkBox.Checked) { effect.AddTargetType(GameEntity.EntityType.TYPE_SPELL); }
            if (true == TargetDefSpell_checkBox.Checked) { effect.AddTargetType(GameEntity.EntityType.TYPE_DEFSPELL); }
            if (true == TargetHand_checkBox.Checked) { effect.AddTargetType(GameEntity.EntityType.TYPE_HAND); }
            if (true == TargetLibrary_checkBox.Checked) { effect.AddTargetType(GameEntity.EntityType.TYPE_LIBRARY); }
            if (true == TargetGraveyard_checkBox.Checked) { effect.AddTargetType(GameEntity.EntityType.TYPE_GRAVEYARD); }

            // Modifiers
            effect.RemoveAllModifiers();
            foreach(Effect.Modifier mod in Modifiers_listbox.Items)
            {
                effect.AddModifier((Effect.Modifier)mod);
            }
        }

        private void AddModifier_btn_Click(object sender, EventArgs e)
        {
            ListModifierObject mod = new ListModifierObject();
            mod.Type = (Effect.ModifierType)BaseMod_chooser.SelectedIndex;
            if(ModValue_text.Text != "")
            {
                mod.Value = Convert.ToInt32(ModValue_text.Text);
            }
            
            mod.SetDisplay();

            Modifiers_listbox.Items.Add(mod);
        }

        private void RemoveModifier_btn_Click(object sender, EventArgs e)
        {
            if(Modifiers_listbox.Items.Count > Modifiers_listbox.SelectedIndex && Modifiers_listbox.SelectedIndex >= 0)
            {
                Modifiers_listbox.Items.RemoveAt(Modifiers_listbox.SelectedIndex);
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            Effect effect;

            if(-1 == mLastSelectedIndex || mLastSelectedIndex >= EffectManager.GetInstance().GetAllEffects().Count )
            {
                // Build new effect
                effect = new Effect();
                _FillOutDataToEffect(effect);
                EffectManager.GetInstance().AddEffect(effect);
            }
            else
            {
                // Override existing effect
                effect = EffectManager.GetInstance().GetEffectByIndex(mLastSelectedIndex);
                _FillOutDataToEffect(effect);
            }

            _RefreshListbox();
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            _LoadEffectDataToForm(mLastSelectedIndex);
        }

        private void EffectControl_Load(object sender, EventArgs e)
        {
            _RefreshListbox();
        }


    }
}
