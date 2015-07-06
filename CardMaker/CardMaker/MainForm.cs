using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using CardCore;

namespace CardMaker
{
    public partial class MainForm : Form
    {
        private ProjectForm mCurrentProjectForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void _CreateNewMasterFile(string name)
        {
            if(ProjectManager.GetInstance().CreateNewFile(name))
            {
                _SetActiveProject(ProjectManager.GetInstance().GetActiveProject());
            }
        }

        private void _SetActiveProject(string name)
        {
            //this.CurProject_label.Text = name;
            mCurrentProjectForm = new ProjectForm();
            mCurrentProjectForm.Text = name + " Project";
            mCurrentProjectForm.MdiParent = this;
            mCurrentProjectForm.Focus();
            mCurrentProjectForm.Show();
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
                _CreateNewMasterFile(newFileName);
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

        private void FileLoad_menuitem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.CheckPathExists = true;
            ofd.Filter = "XML Files (*.xml)|*.xml";

            DialogResult result = ofd.ShowDialog();

            if (DialogResult.OK == result) // Load file
            {
                if(ProjectManager.GetInstance().LoadProject(ofd.FileName))
                {
                    _SetActiveProject(ProjectManager.GetInstance().GetActiveProject());
                }
            }
        }

    }
}
