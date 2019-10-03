using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Message_Encryption
{
    public partial class FrmMessage : Form
    {
        Encryption.DES encDES = null;
        Encryption.AES encAES = null;

        bool messageEncrypted, messageDecrypted = false;
        bool modeDES, modeAES = false;

        public FrmMessage()
        {
            InitializeComponent();

            encDES = new Encryption.DES();
            encAES = new Encryption.AES();
        }

        private void btnSendBob_Click(object sender, EventArgs e)
        {
            if (this.txtBoxBobKey.Text.Trim().Length.Equals(8) && !this.txtBoxMessageBob.Text.Trim().Equals("") && (modeDES || modeAES))
            {
                messageEncrypted = true;

                if (modeAES) this.txtBoxMessageAlice.Text = encAES.Encrypt(this.txtBoxMessageBob.Text.Trim(), this.txtBoxBobKey.Text.Trim());
                else if (modeDES) this.txtBoxMessageAlice.Text = encDES.Encrypt(this.txtBoxMessageBob.Text.Trim(), this.txtBoxBobKey.Text.Trim());

                this.picBoxMail.Image = Image.FromFile(Application.StartupPath + "\\" + "Mail-IN.png");
            }
            else
            {
                if (!modeDES && !modeAES) MessageBox.Show("Please choose encryption mode !", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (this.txtBoxBobKey.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Please input 'KEY' !", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtBoxBobKey.Focus();
                }
                else if (this.txtBoxBobKey.Text.Trim().Length < 8)
                {
                    MessageBox.Show("Please input 8 character of 'KEY' !", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtBoxBobKey.Focus();
                }
                else if (this.txtBoxMessageBob.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Please add a 'MESSAGE' !", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtBoxMessageBob.Focus();
                }
            }
        }

        private void btnDecryptAlice_Click(object sender, EventArgs e)
        {
            if (messageEncrypted && !messageDecrypted)
            {
                try
                {
                    if (modeAES) this.txtBoxMessageAlice.Text = encAES.Decrypt(this.txtBoxMessageAlice.Text.Trim(), this.txtBoxAliceKey.Text.Trim());
                    else if (modeDES) this.txtBoxMessageAlice.Text = encDES.Decrypt(this.txtBoxMessageAlice.Text.Trim(), this.txtBoxAliceKey.Text.Trim());

                    messageDecrypted = true;

                    this.picBoxMail.Image = Image.FromFile(Application.StartupPath + "\\" + "Mail-Open.png");
                }
                catch (Exception)
                {
                    MessageBox.Show("Your key is wrong !\nPlease input another key...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (messageDecrypted)
            {
                MessageBox.Show("Message Decrypted...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("There is no message...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAES_Click(object sender, EventArgs e)
        {
            modeDES = false;
            modeAES = true;

            this.lblMode.Text = "Mode : AES";

            refresh();
        }

        private void btnDES_Click(object sender, EventArgs e)
        {
            modeDES = true;
            modeAES = false;

            this.lblMode.Text = "Mode : DES";

            refresh();
        }

        private void refresh()
        {
            this.txtBoxAliceKey.Text = "";
            this.txtBoxBobKey.Text = "";
            this.txtBoxMessageAlice.Text = "";
            this.txtBoxMessageBob.Text = "";
            this.picBoxMail.Image = Image.FromFile(Application.StartupPath + "\\" + "Mail-NO.png");

            messageEncrypted = false;
            messageDecrypted = false;
        }
    }
}
