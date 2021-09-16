using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encrypt_Decrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            int[] asciiArr = new int[txtInput.Text.Length];
            int jump = 1;

            if((int)txtJump.Text[0] - 48 <= -1 || (int)txtJump.Text[0] - 48 >= 10)
            {
                MessageBox.Show("Invalid number for jump!");
            }
            else
            {
                jump = (int)txtJump.Text[0] - 48;
            }

            lblOutput.Text = "";

            for (int i = 0; i <= txtInput.Text.Length - 1; i++)
            {
                if ((int)txtInput.Text[i] + jump >= 58 && ((int)txtInput.Text[i] >= 48 && (int)txtInput.Text[i] <= 57))
                {
                    asciiArr[i] = (int)txtInput.Text[i] + jump - 10;
                }
                else if ((int)txtInput.Text[i] + jump >= 91 && ((int)txtInput.Text[i] >= 65 && (int)txtInput.Text[i] <= 90))
                {
                    asciiArr[i] = (int)txtInput.Text[i] + jump - 26;
                }
                else if((int)txtInput.Text[i] + jump >= 123 && ((int)txtInput.Text[i] >= 97 && (int)txtInput.Text[i] <= 122))
                {
                    asciiArr[i] = (int)txtInput.Text[i] + jump - 26;
                }
                else if ((int)txtInput.Text[i] == 32)
                {
                    asciiArr[i] = (int)txtInput.Text[i];
                }
                else
                {
                    asciiArr[i] = (int)txtInput.Text[i] + jump;
                }
            }

            foreach (int asciiCode in asciiArr)
            {
                lblOutput.Text += ((char)asciiCode).ToString();
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            int[] asciiArr = new int[txtInput.Text.Length];
            int jump = 1;

            if ((int)txtJump.Text[0] - 48 <= -1 || (int)txtJump.Text[0] - 48 >= 10)
            {
                MessageBox.Show("Invalid number for jump!");
            }
            else
            {
                jump = (int)txtJump.Text[0] - 48;
            }

            lblOutput.Text = "";

            for (int i = 0; i <= txtInput.Text.Length - 1; i++)
            {
                if ((int)txtInput.Text[i] - jump <= 47 && ((int)txtInput.Text[i] >= 48 && (int)txtInput.Text[i] <= 57))
                {
                    asciiArr[i] = (int)txtInput.Text[i] - jump + 10;
                }
                else if ((int)txtInput.Text[i] - jump <= 64 && ((int)txtInput.Text[i] >= 65 && (int)txtInput.Text[i] <= 90))
                {
                    asciiArr[i] = (int)txtInput.Text[i] - jump + 26;
                }
                else if ((int)txtInput.Text[i] - jump <= 96 && ((int)txtInput.Text[i] >= 97 && (int)txtInput.Text[i] <= 122))
                {
                    asciiArr[i] = (int)txtInput.Text[i] - jump + 26;
                }
                else if((int)txtInput.Text[i] == 32)
                {
                    asciiArr[i] = (int)txtInput.Text[i];
                }
                else
                {
                    asciiArr[i] = (int)txtInput.Text[i] - jump;
                }
            }

            foreach (int asciiCode in asciiArr)
            {
                lblOutput.Text += ((char)asciiCode).ToString();
            }
        }
    }
}
