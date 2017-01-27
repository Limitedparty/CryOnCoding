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
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(listBox1.SelectedIndex);
        }

        private void listBox1_TabIndexChanged(object sender, EventArgs e)
        {
            //Console.WriteLine(listBox1.SelectedIndex);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(listBox1.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            COClib.COC.SetKey("lego");
            string encrypt = COClib.COC.Encrypt("hi world");
            //Console.WriteLine(Encoding.ASCII.GetString(COClib.COC.masterKey.Key));
            Console.WriteLine(Convert.ToBase64String(COClib.COC.masterKey));
            Console.WriteLine(encrypt);
            Console.WriteLine(COClib.COC.Decrypt(encrypt));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            COClib.COC.SetKey("lego");
            Console.WriteLine(Convert.ToBase64String(COClib.COC.masterKey));
            Console.WriteLine(COClib.COC.Decrypt("xd2Ni2mbe9nIfOYU6wkswtp3wyOqsz9BKD0XcR/J03I="));
        }
    }
}
