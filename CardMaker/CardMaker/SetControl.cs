using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardMaker
{
    public partial class SetControl : UserControl
    {
        public SetControl()
        {
            InitializeComponent();

            Set_listbox.Items.Add("<Create New Set>");
        }
    }
}
