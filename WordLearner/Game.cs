using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordLearner
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();


            
            DictManager dm = new DictManager(Form1.Path);
            dm.FindFromExcel();
            D.wordList = dm.wordList;

            Random rand = new Random();
            T = rand.Next(1, dm.wordList.Count);
            asking.Text = dm.wordList[T].Translation;

            trCount.Text = r.ToString();
            flCount.Text = w.ToString();


        }

        public DictManager D = new DictManager(Form1.Path);
    

        public int T = 0;
        public int r = 0;
        public int w = 0;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void Checkbutton_Click(object sender, EventArgs e)
        {
          if(answer.Text == D.wordList[T].Word)
            {
                Saylabel.Text = "Right";
                r++;
                trCount.Text = r.ToString();
                this.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                Saylabel.Text = $"Wrong ";
                w++;
                flCount.Text = w.ToString();
                this.BackColor = System.Drawing.Color.Red;
            }
            RightAnswer.Text = D.wordList[T].Word;
            Random rand = new Random();
            T = rand.Next(1, D.wordList.Count);
            asking.Text = D.wordList[T].Translation;
        }

        private void answer_TextChanged(object sender, EventArgs e)
        {

        }

        private void answer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                if (answer.Text == D.wordList[T].Word)
                {
                    Saylabel.Text = "Right";
                    r++;
                    trCount.Text = r.ToString();
                    this.BackColor = System.Drawing.Color.Green;
                }
                else
                {
                    Saylabel.Text = $"Wrong ";
                    w++;
                    flCount.Text = w.ToString();
                    this.BackColor = System.Drawing.Color.Red;
                }
                RightAnswer.Text = D.wordList[T].Word;
                Random rand = new Random();
                T = rand.Next(1, D.wordList.Count);
                asking.Text = D.wordList[T].Translation;
            }
        }
    }
}
