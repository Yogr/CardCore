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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void _CreateNewCardFile(string name)
        {
            Console.WriteLine(name);
        }

        private void CreateSet_menuitem_Click(object sender, EventArgs e)
        {
            CreateSetForm form = new CreateSetForm();
            form.MdiParent = this;
            form.Show();
        }

        private void CreateCard_menuitem_Click(object sender, EventArgs e)
        {
            CreateCardForm form = new CreateCardForm();
            form.MdiParent = this;
            form.Show();
        }

        private void CreateEffect_menuitem_Click(object sender, EventArgs e)
        {
            CreateEffectForm form = new CreateEffectForm();
            form.MdiParent = this;
            form.Show();
        }

        private void FileNew_menuitem_Click(object sender, EventArgs e)
        {
            string newFileName = "";

            Form form = new Form();
            form.Width = 500;
            form.Height = 150;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.Text = "New Wizard CardFile";
            form.StartPosition = FormStartPosition.WindowsDefaultLocation;
            Label textLabel = new Label() { Left = 50, Top = 20, Text = "Name:" };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (formsender, forme) => { newFileName = textBox.Text; form.Close(); };
            form.Controls.Add(textBox);
            form.Controls.Add(confirmation);
            form.Controls.Add(textLabel);
            form.AcceptButton = confirmation;

            DialogResult result = form.ShowDialog();

            if(DialogResult.OK == result) // Create new file
            {
                _CreateNewCardFile(newFileName);
            }
            form.Close();
        }

        private void FileSave_menuitem_Click(object sender, EventArgs e)
        {

        }

        private void FileQuit_menuitem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
