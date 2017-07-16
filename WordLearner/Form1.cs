using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WordLearner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            label.Text = "You must have Microsoft Excel \n Please Choose your dictionary xlsx file.";
           
        }


        public bool FileChecked = false;
        public static string Path;
       

        private void browse_Click(object sender, EventArgs e)
        {
            
           if(openFile.ShowDialog() == DialogResult.OK && openFile.FileName.Substring(openFile.FileName.Length - 4, 4)=="xlsx")
            {
                Path = openFile.FileName;
                pathFinder.Text = Path;
                FileChecked = true;
            }
            else
            {
                MessageBox.Show("Please select .xlsx file");
            }
        }

        private void pathFinder_TextChanged(object sender, EventArgs e)
        {
            Path = pathFinder.Text;
        }

        private void FileChoosed_Click(object sender, EventArgs e)
        {
            if(FileChecked == true)
            {

                label.Text = "Please  \n \t \t \t  Wait";
                Game game = new Game();
                game.Show();
              
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Copyright_Click(object sender, EventArgs e)
        {
            Process.Start("http://mruben0.github.io");
        }
    }
}
