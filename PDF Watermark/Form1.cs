using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PDF_Watermark
{
    public partial class Watermark_Form : Form
    {
        #region variable and properties
        private string watermarkText;
        private string password;
        private bool unlock;

        public string WatermarkText
        {
            get { return watermarkText; }
        }
        public string Password
        {
            get { return password; }
        }
        public bool Unlock
        {
            get { return unlock; }
        }

        private ToolTip passwordTip;
        #endregion

        public Watermark_Form()
        {
            InitializeComponent();
            watermarkText = "";
            password = "";
            Password_TextBox.Enabled = false;

            passwordTip = new ToolTip();
            passwordTip.IsBalloon = true;
            passwordTip.SetToolTip(Password_TextBox, $@"The password required to unlock the document. {Environment.NewLine}*Try the Windows username of the person who signed the document.");
        }

        private void Go_Click(object sender, EventArgs e)
        {
            watermarkText = Watermark_TextBox.Text;
            password = Password_TextBox.Text;

            if (watermarkText == "" && Password_CheckBox.Checked && password == "")
            {
                MessageBox.Show("Please enter Watermark Text and Password");
            }
            else if (watermarkText == "")
            {
                MessageBox.Show("Please enter Watermark Text");
            }
            else if (Password_CheckBox.Checked && password == "")
            {
                MessageBox.Show("Please enter Password");
            }
            else
            {
                Close();
            }

        }

        private void Password_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Password_TextBox.Enabled = Password_CheckBox.Checked;
            unlock = Password_CheckBox.Checked;
        }
    }
}
