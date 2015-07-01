using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardMaker
{
    public partial class CreateEffectForm : Form
    {
        private bool mEditMode;

        public CreateEffectForm(bool editMode = false)
        {
            mEditMode = editMode;

            if(true == editMode)
            {
                Title_label.Text = "Edit Effect";
                Create_btn.Text  = "Save Changes";
                Cancel_btn.Text  = "Discard Changes";
            }

            InitializeComponent();
        }



        private void CreateEffectForm_Load(object sender, EventArgs e)
        {

        }

        private void Create_btn_Click(object sender, EventArgs e)
        {
            if(mEditMode) // Save changes to node
            {

            }
            else // Create new
            {

            }
        }
    }
}
