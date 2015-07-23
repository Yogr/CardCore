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
    public partial class SetControl : UserControl
    {
        private int mLastSelectedIndex = -1;

        public SetControl()
        {
            InitializeComponent();

            AllCards_listBox.DisplayMember = "Name";
            SetCards_listBox.DisplayMember = "Name";

            _RefreshListbox();
            _LoadSetTypes();
            _ReloadAllCards();
        }

        private void _RefreshListbox()
        {
            Set_listbox.Items.Clear();

            foreach(Set s in SetManager.GetInstance().GetAllSets())
            {
                Set_listbox.Items.Add(s.Name);
            }

            Set_listbox.Items.Add("<Create New Set>");
        }

        private void _LoadSetTypes()
        {
            SetType_chooser.Items.Clear();
            for(int i = 0; i < Convert.ToInt32(Set.SetType.SETTYPE_COUNT); ++i)
            {
                SetType_chooser.Items.Add((Set.SetType)i);
            }
        }

        private void _ReloadAllCards()
        {
            AllCards_listBox.Items.Clear();
            SetCards_listBox.Items.Clear();
            
            foreach(Card c in CardManager.GetInstance().GetListCards())
            {
                AllCards_listBox.Items.Add(c);
            }

            if(-1 != Set_listbox.SelectedIndex)
            {
                Set currentSet = SetManager.GetInstance().GetSetByIndex(Set_listbox.SelectedIndex);

                if(null != currentSet)
                {
                    foreach (uint id in currentSet.GetCardIds())
                    {
                        _MoveCardToSet(id);
                    }
                }
            }
        }

        private void _LoadSetDataToForm(int index)
        {

            if (index >= 0 && index < SetManager.GetInstance().GetAllSets().Count)
            {
                Set set = SetManager.GetInstance().GetSetByIndex(index);

                SetName_text.Text = set.Name;
                SetType_chooser.SelectedIndex = Convert.ToInt32(set.GetSetType());

                //SetBlock_listbox.SelectedIndex = set.Block;
                //SetBox_image

                _ReloadAllCards();
            }
            else // Create new Set
            {
                SetName_text.Text = "";
                SetType_chooser.SelectedIndex = 0;

                _ReloadAllCards();
            }
        }

        private void _MoveCardToSet(uint id)
        {
            Card c = CardManager.GetInstance().GetCardById(id);
            _MoveCardToSet(c);
        }

        private void _MoveCardToSet(Card c)
        {
            SetCards_listBox.Items.Add(c);
            AllCards_listBox.Items.Remove(c);
        }

        private void _RemoveCardFromSet(int index)
        {
            Card c = (Card)SetCards_listBox.Items[index];
            _RemoveCardFromSet(c);
        }

        private void _RemoveCardFromSet(Card c)
        {
            SetCards_listBox.Items.Remove(c);
            AllCards_listBox.Items.Add(c);
        }

        private void Set_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = Set_listbox.SelectedIndex;

            if (index != mLastSelectedIndex)
            {
                mLastSelectedIndex = index;

                _LoadSetDataToForm(index);
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            Set set;

            if (-1 == mLastSelectedIndex || mLastSelectedIndex >= SetManager.GetInstance().GetAllSets().Count)
            {
                // Build & add new card
                set = new Set();
                _FillOutDataToSet(set);
                SetManager.GetInstance().AddSet(set);
            }
            else
            {
                // Just fill out card with new data and save
                set = SetManager.GetInstance().GetSetByIndex(mLastSelectedIndex);
                _FillOutDataToSet(set);
            }

            _RefreshListbox();
        }

        private void _FillOutDataToSet(Set set)
        {
            set.Name = SetName_text.Text;
            set.SetSetType((Set.SetType)SetType_chooser.SelectedIndex);
            //set.Block = (Set.SetBlock)SetBlock_listbox.SelectedItem;

            set.RemoveAllCards();
            foreach(Card c in SetCards_listBox.Items)
            {
                set.AddCard(c.Id);
            }
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            _LoadSetDataToForm(mLastSelectedIndex);
        }

        private void SetControl_Visible(object sender, EventArgs e)
        {
            if (true == this.Visible)
            {
                _ReloadAllCards();
            }
        }

        private void SendToSet_btn_Click(object sender, EventArgs e)
        {
            if (-1 != AllCards_listBox.SelectedIndex)
            {
                _MoveCardToSet((Card)AllCards_listBox.SelectedItem);
            }
        }

        private void SendAllToSet_btn_Click(object sender, EventArgs e)
        {
            foreach(Card c in AllCards_listBox.Items)
            {
                SetCards_listBox.Items.Add(c);
            }
            AllCards_listBox.Items.Clear();
        }

        private void SendToPool_btn_Click(object sender, EventArgs e)
        {
            if (-1 != SetCards_listBox.SelectedIndex)
            {
                _RemoveCardFromSet((Card)SetCards_listBox.SelectedItem);
            }
        }

        private void SendAllToPool_btn_Click(object sender, EventArgs e)
        {
            foreach(Card c in SetCards_listBox.Items)
            {
                AllCards_listBox.Items.Add(c);
            }
            SetCards_listBox.Items.Clear();
        }
    }
}
