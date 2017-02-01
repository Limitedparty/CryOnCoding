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
    public partial class Main_Window : Form
    {
        public Main_Window()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        // Клик по кнопке отправить
        private void buttonSend_Click(object sender, EventArgs e)
        {
            //string sendmessage = Utils.MessageGen(textBoxInput.Text);
            //textBoxChat.AppendText("S# ");
            //textBoxChat.AppendText ("[Вы] " + textBoxInput.Text + Environment.NewLine + sendmessage + Environment.NewLine);
            Interface.Send();
        }

        // Обновление поля с ключом
        private void textBoxMasterKey_TextChanged(object sender, EventArgs e)
        {
            //COClib.COC.SetKey(textBoxMasterKey.Text);
            //Console.WriteLine(Convert.ToBase64String(COClib.COC.masterKey));
            Interface.MasterKeyUpdate();
        }

        // Клик по кнопке генерации ключа
        private void buttonGenKey_Click(object sender, EventArgs e)
        {
            //COClib.COC.GenKey();
            //textBoxMasterKey.Text = Encoding.ASCII.GetString(COClib.COC.masterKey);
            Interface.GenerateKey();
        }
    }
}
