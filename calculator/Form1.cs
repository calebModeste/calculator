using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {   private string strNb1, strNb2;
        private char sign;
        public Form1()
        {
            InitializeComponent();
            this.sign='&';
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonChiffre_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (this.sign == '&')
            {
                strNb1 += b.Text;
                afficheur.Text = strNb1;

            }
            else
            {
                strNb2 += b.Text;
                afficheur.Text = strNb2;
            }

        }
        private void buttonSignPlus_Click(object sender, EventArgs e)
        {
            this.sign = '+';
        }
        private void buttonSignMoin_Click(object sender, EventArgs e)
        {
            this.sign = '-';
        }
        private void buttonSignFois_Click(object sender, EventArgs e)
        {
            this.sign = '*';
        }
        private void buttonSignDivision_Click(object sender, EventArgs e)
        {
            this.sign = '/';
        }
        private void buttonSignEgale_Click(object sender, EventArgs e)
        {
            double nb1 = Convert.ToDouble(strNb1);
            double nb2 = Convert.ToDouble(strNb2);
            double nbS = 0;
            
            if (this.sign == '+'){
                nbS=nb1+ nb2;
            }
            if (this.sign == '-')
            {
                nbS = nb1 - nb2;
            }
            if (this.sign == '*')
            {
                nbS = nb1 * nb2;
            }
            if (this.sign == '/')
            {
                try
                {
                    nbS = nb1 / nb2;

                } catch(DivideByZeroException) {
                    MessageBox.Show("division non pris on charge");
                }
            }
            afficheur.Text=nbS.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSignEffacer_Click(object sender, EventArgs e)
        {   
            strNb1 = "";
            strNb2 = "";
            afficheur.Text = strNb1;

            this.sign = '&';

        }
    }
}
