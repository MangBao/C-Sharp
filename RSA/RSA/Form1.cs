using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace RSA
{
    public partial class Form1 : Form
    {
        UTF8Encoding ByteConvert = new UTF8Encoding();
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        private void CreateKey_Click(object sender, EventArgs e)
        { 
            //RSAParameters RSAP = new RSAParameters();
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(1024);

            txtPublic.Text = RSA.ToXmlString(false);
            txtPrivate.Text = RSA.ToXmlString(true);

        }

        private void btEncrypted_Click(object sender, EventArgs e)
        {
            try
            {
                RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
                RSA.FromXmlString(txtPublic.Text);
                byte[] decrypted = System.Text.Encoding.Unicode.GetBytes(txtPlain.Text);
                byte[] encrypted = RSA.Encrypt(decrypted, false);
                txtEncrypted.Text = System.Convert.ToBase64String(encrypted);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btDecripted_Click(object sender, EventArgs e)
        {
            if (txtDecrypted.Text == "")
            {
                MessageBox.Show("Empty input", "ERROR !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CspParameters cspParam = new CspParameters();
                cspParam.Flags = CspProviderFlags.UseMachineKeyStore;
                RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(cspParam);
                RSA.FromXmlString(txtPrivate.Text);
                byte[] encryted = System.Convert.FromBase64String(txtDecrypted.Text);
                byte[] decrypted = RSA.Decrypt(encryted, false);
                txtPlain2.Text = System.Text.Encoding.Unicode.GetString(decrypted);
            }
        }
        private void btReset_Click(object sender, EventArgs e)
        {
            txtPublic.Clear();
            txtDecrypted.Clear();
            txtEncrypted.Clear();
            txtPlain.Clear();
            txtPlain2.Clear();
            txtPrivate.Clear();

        }
        /*public static byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                //Create a new instance of RSACryptoServiceProvider.
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {

                    //Import the RSA Key information. This only needs
                    //toinclude the public key information.
                    RSA.ImportParameters(RSAKeyInfo);

                    //Encrypt the passed byte array and specify OAEP padding.  
                    //OAEP padding is only available on Microsoft Windows XP or
                    //later.  
                    encryptedData = RSA.Encrypt(DataToEncrypt, DoOAEPPadding);
                }
                return encryptedData;
            }
            //Catch and display a CryptographicException  
            //to the console.
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);

                return null;
            }
        }

        public static byte[] RSADecrypt(byte[] DataToDecrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;
                //Create a new instance of RSACryptoServiceProvider.
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    //Import the RSA Key information. This needs
                    //to include the private key information.
                    RSA.ImportParameters(RSAKeyInfo);

                    //Decrypt the passed byte array and specify OAEP padding.  
                    //OAEP padding is only available on Microsoft Windows XP or
                    //later.  
                    decryptedData = RSA.Decrypt(DataToDecrypt, DoOAEPPadding);
                }
                return decryptedData;
            }
            //Catch and display a CryptographicException  
            //to the console.
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());

                return null;
            }
        }*/

        
    }
}
