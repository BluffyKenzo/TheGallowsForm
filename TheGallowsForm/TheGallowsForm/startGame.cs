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
    public partial class startGame : Form
    {
        public startGame()
        {
            InitializeComponent();
        }

        private void button_description_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 игрок - слова будут генерироваться рандомно\n2 игрока - один игрок загадывает слово, второй его отгадывает","Описание");
        }

        private void button_onePlayer_Click(object sender, EventArgs e)
        {
            onePlayer onePlayer = new onePlayer();
            onePlayer.Show();
            Close();
        }

        private void button_twoPlayer_Click(object sender, EventArgs e)
        {
            twoPlayer twoPlayer = new twoPlayer();
            twoPlayer.Show();
            Close();
        }
    }
}
