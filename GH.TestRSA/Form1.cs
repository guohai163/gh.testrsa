using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace GH.TestRSA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
  

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            //包含传递给执行加密计算的加密服务提供程序 (CSP) 的参数
            //其中KeyContainerName为容易的名称，加密方只需要有公钥即可
            CspParameters csp = new CspParameters() { KeyContainerName = "UseKey" };
            //初始化RSA非对称加密
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(csp);
            try
            {
                string input = this.tbInput.Text;
                byte[] source = Encoding.UTF8.GetBytes(input);
                byte[] bs = rsa.Encrypt(source, true);
                this.tbOutput.Text = Convert.ToBase64String(bs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {

            CspParameters csp = new CspParameters() { KeyContainerName = "UseKey" };

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(csp);
            try
            {
                string input = this.tbInput.Text;
                byte[] bs = rsa.Decrypt(Convert.FromBase64String(input), true);
                this.tbOutput.Text = Encoding.UTF8.GetString(bs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
