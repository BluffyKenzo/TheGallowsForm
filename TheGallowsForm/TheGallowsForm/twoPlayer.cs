using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGallowsForm
{
    public partial class twoPlayer : Form
    {
        public twoPlayer()
        {
            InitializeComponent();
        }

        public string text;
        public char[] word;
        public int HP;
        public int HPtrue;

        private void button_MakeAWish_Click(object sender, EventArgs e)
        {
            text = textBox1.Text;
            HP = 0;
            label2.Text = null;
            textBox1.Text = null;
            word = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                label2.Text += '_';
                word[i] = '_';
            }
        }

        private void button_Guess_Click(object sender, EventArgs e)
        {
            bool receivedWord = false;

            if (textBox2.Text.Length == 1)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (textBox2.Text[0] == text[i])
                    {
                        receivedWord = true;
                        HPtrue++;
                        word[i] = text[i];
                        label2.Text = null;
                    }
                }

                if (receivedWord == true)
                {
                    for (int i = 0; i < text.Length; i++)
                    {
                        label2.Text += word[i];
                    }

                    if (HPtrue == text.Length)
                    {
                        MessageBox.Show("Ты победил!", "Виселица");
                    }
                }
                else
                {
                    HP++;
                    string hpbuff = HP.ToString() + ".png";
                    pictureBox1.Image = new Bitmap(hpbuff);
                    if (HP == 10)
                    {
                        MessageBox.Show("Ты проиграл!");
                        label2.Text = null;
                        label2.Text = text;
                    }
                }
            }
            else if (textBox2.Text.Length > 1)
            {
                if (textBox2.Text == text)
                {
                    label2.Text = null;
                    for (int i = 0; i < text.Length; i++)
                    {
                        label2.Text += text[i];
                    }
                    MessageBox.Show("Ты победил!", "Виселица");
                }
                else
                {
                    HP = 10;
                    string hpbuff = HP.ToString() + ".png";
                    pictureBox1.Image = new Bitmap(hpbuff);
                    MessageBox.Show("Ты проиграл!", "Виселица");
                    label2.Text = null;
                    label2.Text= text;
                }
            }
            textBox2.Text = null;
        }
    }
}
