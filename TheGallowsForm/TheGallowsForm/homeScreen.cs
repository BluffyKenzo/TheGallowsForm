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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_startGame_Click(object sender, EventArgs e)
        {
            startGame  startGame = new startGame();
            startGame.Show();
        }

        private void button_description_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Виселица - словесная игра на отгадывание слов. Первый игрок загадывает слово и в окне формируются столько чёрточек, сколько букв в искомом слове, а второй отгадывает его, вводя каждый раз по одной букве. После каждой неправильно названой буквы рисуется часть виселицы, а потом и часть висящего человечка.", "Описание игры Виселица");
        }
    }
}
