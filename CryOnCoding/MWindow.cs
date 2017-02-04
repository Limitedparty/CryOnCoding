using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryOnCoding
{
    public partial class MWindow : Form
    {
        public MWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            Interface.Send();
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            Interface.Decrypt();
        }

        private void textBoxKey_TextChanged(object sender, EventArgs e)
        {
            Interface.MasterKeyUpdate();
        }

        private void buttonGenerateKey_Click(object sender, EventArgs e)
        {
            Interface.GenerateKey();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Program.autoEncrypt = checkBoxAutoEncrypt.Checked;
        }

        private void textBoxMessage_TextChanged(object sender, EventArgs e)
        {
            if (Program.autoEncrypt)
                Interface.Send();
        }
    }
}
