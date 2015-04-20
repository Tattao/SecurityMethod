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
        private static
            string salt;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Encrypte_Click(object sender, EventArgs e)
        { 
            if (radioBtn_MD5.Checked == true)
            {
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                byte[] ByteString = System.Text.Encoding.ASCII.GetBytes(txt_Input.Text);
                ByteString = md5.ComputeHash(ByteString);
                string FinalString = null;
                foreach (byte bt in ByteString)
                {
                    FinalString += bt.ToString("x2");
                }
                txt_EncrypteOutput.Text = FinalString.ToString();
            }
            if (radioBtn_SHA512Hash.Checked == true)
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(txt_Input.Text);
                SHA512Managed sha512 = new SHA512Managed();
                byte[] outputBytes = sha512.ComputeHash(inputBytes);
                txt_EncrypteOutput.Text = Convert.ToBase64String(outputBytes);
            }
           
            
            if(radioBtn_SHA512HashPlusSalt.Checked==true)
            {
                salt=GetSalt(64,128);
                CaculateSHA512Hash(this.txt_Input.Text,salt);
            }

        }
        private  void  CaculateSHA512Hash(string input,string salt)
        {
            input = txt_Input.Text;
            byte[] saltBytes = Convert.FromBase64String(salt);
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] inputWithSaltBytes = new byte[saltBytes.Length + inputBytes.Length];
            Array.Copy(inputBytes, 0, inputWithSaltBytes, 0, inputBytes.Length);
            Array.Copy(saltBytes, 0, inputWithSaltBytes,  inputBytes.Length,saltBytes.Length);
            SHA512Managed sha512 = new SHA512Managed();
            byte[] outputBytes = sha512.ComputeHash(inputWithSaltBytes);
            txt_EncrypteOutput.Text = Convert.ToBase64String(outputBytes);
        }
        private static string GetSalt(int minSaltSize,int maxSaltSize)
        {
            Random random = new Random();
            int saltSize = random.Next(minSaltSize, maxSaltSize);
            byte[] saltBytes = new byte[saltSize];
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            rng.GetNonZeroBytes(saltBytes);
            return Convert.ToBase64String(saltBytes);
        }
    }
}
