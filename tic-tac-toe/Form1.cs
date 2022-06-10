using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        int[,] XO = new int[3, 3];
        public Form1()
        {
            InitializeComponent();
        }

        private void lblclick(object sender, MouseEventArgs e)
        {
            int i, j;
            i =int.Parse(((Label)sender).Name[3].ToString());
            j =int.Parse(((Label)sender).Name[4].ToString());
            if (e.Button == MouseButtons.Left)
            {
                ((Label)sender).Text="X";
                XO[i, j] = 1;
                check(i, j, 1);
            }
            else
            {
                ((Label)sender).Text="O";
                XO[i, j] = 2;
                check(i, j, 2);
            }
        }
        public void check(int i, int j, int person) {
            rowCheck(i, j, person);
            columnCheck(i, j, person);
            mainDiameterCheck(person);
            DiameterCheck(person);
        }
        public void rowCheck(int i, int j, int person) {
            if (XO[i, 0]==person && XO[i, 1] == person && XO[i, 2] == person)
            MessageBox.Show($"person {person} won!");
            
        }
        public void columnCheck(int i, int j, int person) {
            if (XO[0, j]==person && XO[1, j] == person && XO[2, j] == person)
                MessageBox.Show($"person {person} won!");
        }
        public void mainDiameterCheck(int person) {
            if (XO[0, 0]==person && XO[1, 1] == person && XO[2, 2] == person)
                MessageBox.Show($"person {person} won!");
        }
        public void DiameterCheck(int person) {
            if (XO[0, 2]==person && XO[1, 1] == person && XO[2, 0] == person)
                MessageBox.Show($"person {person} won!");
        }
    }
}
