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
using System.Resources;

namespace CardMaker
{
    public partial class CardControl : UserControl
    {
        private int mLastSelectedIndex = -1;
        private bool mHasEdits = false;

        public CardControl()
        {
            InitializeComponent();

            _InitializeLabels();

            CardEffects_chooser.DisplayMember = "Name";
            CardEffects_listbox.DisplayMember = "Name";

            _RefreshListbox();
        }

        private void _InitializeLabels()
        {
            List<Label> labels = new List<Label>();
            labels.Add(CardName_label);
            labels.Add(Copyright_label);
            labels.Add(Tagline_label);
            labels.Add(Attack_label);
            labels.Add(Defense_label);
            labels.Add(Hitpoints_label);
            labels.Add(Attacktext_label);
            labels.Add(Defensetext_label);
            labels.Add(Hitpointstext_label);

            Point pos;
            
            foreach(Label l in labels)
            {
                pos = this.PointToScreen(l.Location);
                pos = Frame_image.PointToClient(pos);
                l.Parent = Frame_image;
                l.Location = pos;
                l.BackColor = Color.Transparent;
            }
        }

        private void _RefreshListbox()
        {
            Card_listbox.Items.Clear();

            foreach(Card c in CardManager.GetInstance().GetListCards())
            {
                Card_listbox.Items.Add(c.Name);
            }

            Card_listbox.Items.Add("<Create New Card>");
        }

        private void _ReloadEffects()
        {
            CardEffects_chooser.Items.Clear();
            foreach(Effect e in EffectManager.GetInstance().GetAllEffects())
            {
                CardEffects_chooser.Items.Add(e);
            }
        }

        private void Card_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = Card_listbox.SelectedIndex;

            if (index != mLastSelectedIndex)
            {
                mLastSelectedIndex = index;

                _LoadCardDataToForm(index);
            }
        }

        private void _LoadCardDataToForm(int index)
        {
            if (index >= 0 && index < CardManager.GetInstance().GetListCards().Count)
            {
                Card card = CardManager.GetInstance().GetCardAtIndex(index);

                // Populate with card data
                CardName_text.Text = card.Name;
                CardType_chooser.SelectedIndex = Convert.ToInt32(card.Type);
                CardSubtype_chooser.SelectedIndex = Convert.ToInt32(card.SubType);
                CardFrame_chooser.SelectedIndex = 0;
                CardCost_text.Text = card.Cost.ToString();
                CardRarity_chooser.SelectedIndex = Convert.ToInt32(card.Rarity);
                //Factions
                //CardEffects_chooser.SelectedIndex = 0;
                CardEffects_listbox.Items.Clear();
                foreach(uint id in card.GetAllEffectIds())
                {
                    Effect e = EffectManager.GetInstance().GetEffectById(id);
                    if(null != e)
                    {
                        CardEffects_listbox.Items.Add(e);
                    }
                }

                CardAttack_text.Text = card.Attack.ToString();
                CardDefense_text.Text = card.Defense.ToString();
                CardHitpoints_text.Text = card.Hitpoints.ToString();
            }
            else
            {
                // Create new card
                CardName_text.Text = "";
                CardType_chooser.SelectedIndex = 0;
                CardSubtype_chooser.SelectedIndex = 0;
                CardFrame_chooser.SelectedIndex = 0;
                CardCost_text.Text = "0";
                CardRarity_chooser.SelectedIndex = 0;
                //Factions
                //CardEffects_chooser.SelectedIndex = 0;
                CardEffects_listbox.Items.Clear();

                CardAttack_text.Text = "0";
                CardDefense_text.Text = "0";
                CardHitpoints_text.Text = "0";
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            Card card;

            if(-1 == mLastSelectedIndex || mLastSelectedIndex >= CardManager.GetInstance().GetListCards().Count)
            {
                // Build & add new card
                card = new Card();
                _FillOutDataToCard(card);
                CardManager.GetInstance().AddCard(card);
            }
            else
            {
                // Just fill out card with new data and save
                card = CardManager.GetInstance().GetCardAtIndex(mLastSelectedIndex);
                _FillOutDataToCard(card);
            }

            _RefreshListbox();
        }

        private void _FillOutDataToCard(Card card)
        {
            card.Id   = CardManager.GetInstance().GetNextValidId();
            card.Name = CardName_text.Text;
            card.Cost = Convert.ToUInt32(CardCost_text.Text);
            card.Type = (Card.CardType)CardType_chooser.SelectedIndex;
            card.SubType = (Card.CardSubType)CardSubtype_chooser.SelectedIndex;
            card.Attack = Convert.ToInt32(CardAttack_text.Text);
            card.Defense = Convert.ToInt32(CardDefense_text.Text);
            card.Hitpoints = Convert.ToInt32(CardHitpoints_text.Text);

            // Factions
            card.SetFactions(0);
            if (true == FactionHuman_checkbox.Checked) { card.AddFaction(GameEntity.Faction.FACTION_HUMAN); }
            if (true == FactionVampire_checkbox.Checked) { card.AddFaction(GameEntity.Faction.FACTION_VAMPIRE); }
            if (true == FactionScoundrel_checkbox.Checked) { card.AddFaction(GameEntity.Faction.FACTION_SCOUNDREL); }
            if (true == FactionBarbarian_checkbox.Checked) { card.AddFaction(GameEntity.Faction.FACTION_BARBARIAN); }
            if (true == FactionDragon_checkbox.Checked) { card.AddFaction(GameEntity.Faction.FACTION_DRAGON); }
            if (true == FactionOrc_checkbox.Checked) { card.AddFaction(GameEntity.Faction.FACTION_ORC); }

            // Card Effects
            card.RemoveAllEffects();
            foreach(Effect e in CardEffects_listbox.Items)
            {
                card.AddEffectById(e.Id);
            }
        }

        

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            _LoadCardDataToForm(mLastSelectedIndex);
        }

        private void CardControl_Load(object sender, EventArgs e)
        {
            
        }

        private void CardControl_Visible(object sender, EventArgs e)
        {
            if(true == this.Visible)
            {
                _ReloadEffects();
            }
        }

        private void AddEffect_btn_Click(object sender, EventArgs e)
        {
            CardEffects_listbox.Items.Add((Effect)CardEffects_chooser.SelectedItem);
        }

        private void RemoveEffect_btn_Click(object sender, EventArgs e)
        {
            if(CardEffects_listbox.SelectedIndex >= 0 && CardEffects_listbox.SelectedIndex < CardEffects_listbox.Items.Count)
            {
                CardEffects_listbox.Items.RemoveAt(CardEffects_listbox.SelectedIndex);
            }
        }

        private void CardName_text_TextChanged(object sender, EventArgs e)
        {
            CardName_label.Text = CardName_text.Text;
        }

        private void CardTagline_text_TextChanged(object sender, EventArgs e)
        {
            Tagline_label.Text = CardTagline_text.Text;
        }

        private void CardAttack_text_TextChanged(object sender, EventArgs e)
        {
            Attack_label.Text = CardAttack_text.Text;
        }

        private void CardDefense_text_TextChanged(object sender, EventArgs e)
        {
            Defense_label.Text = CardDefense_text.Text;
        }

        private void CardHitpoints_text_TextChanged(object sender, EventArgs e)
        {
            Hitpoints_label.Text = CardHitpoints_text.Text;
        }

        private void CardFrame_chooser_SelectedIndexChanged(object sender, EventArgs e)
        {
            //System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(CardControl));
            switch(CardFrame_chooser.SelectedIndex)
            {
                case 1:
                    {
                        Frame_image.Image = Properties.Resources.card_frame_gray;
                        break;
                    }
                case 2:
                    {
                        Frame_image.Image = Properties.Resources.card_frame_purple;
                        break;
                    }
                case 3:
                    {
                        Frame_image.Image = Properties.Resources.card_frame_black;
                        break;
                    }
                case 4:
                    {
                        Frame_image.Image = Properties.Resources.card_frame_red;
                        break;
                    }
                case 5:
                    {
                        Frame_image.Image = Properties.Resources.card_frame_green;
                        break;
                    }
                case 6:
                    {
                        Frame_image.Image = Properties.Resources.card_frame_orange;
                        break;
                    }
                case 0:
                default:
                    {
                        Frame_image.Image = Properties.Resources.card_frame_default;
                        break;
                    }
            }
        }

    }
}
