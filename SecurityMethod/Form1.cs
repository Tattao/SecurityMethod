using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Encrypte_Click(object sender, EventArgs e)
        {
            if (radioBtn_MD5.Checked == true)
            {
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                byte[] ByteString = System.Text.Encoding.ASCII.GetBytes(txt_DecodeOutput.Text);
                ByteString = md5.ComputeHash(ByteString);
                string FinalString = null;
                foreach (byte bt in ByteString)
                {
                    FinalString += bt.ToString("x2");
                }
                txt_EncrypteOutput.Text = FinalString.ToString();
            }
        }
    }
}
