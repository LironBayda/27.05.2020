using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace remmberTheNumbers
{
    public partial class RemmberTheNumbersForm : Form
    {
        Random gen = new Random();
        const  int NUM_OF_NUMS = 5;
        //DateTime startTime;
        Stopwatch sw = new Stopwatch();

        public RemmberTheNumbersForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// check if the number in the textbox equal to the number in label
        /// return 1 if true 0 if false.
        /// we use this function to calculate the score therefore it returns int
        /// </summary>
        /// <param name="num"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        private static int Check(Label num, TextBox text)
        {
            int numA, numB;
            Int32.TryParse(num.Text, out numA);
            Int32.TryParse(text.Text, out numB);

            if (numA == numB)
            {
                text.ForeColor = Color.Black;
                return 1;
            }
            else
            {
                text.ForeColor = Color.Red;
                return 0;
            }
        }


        private void removeTextFromTextBox()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private  void AddNumbersToLabel()
        {
            num1.Text = gen.Next(1, 100).ToString();
            num2.Text = gen.Next(1, 100).ToString();
            num3.Text = gen.Next(1, 100).ToString();
            num4.Text = gen.Next(1, 100).ToString();
            num5.Text = gen.Next(1, 100).ToString();
        }

        private  void ChangeLabelVisible(bool visible)
        {
            num1.Visible = visible;
            num2.Visible = visible;
            num3.Visible = visible;
            num4.Visible = visible;
            num5.Visible = visible;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddNumbersToLabel();
        }

        private void start_Click(object sender, EventArgs e)
        {
            ChangeLabelVisible(false);
            sw.Stop();
            sw.Start();
        }
        
        private void finish_Click(object sender, EventArgs e)
        {
            int score = Check(num1, textBox1) + Check(num2, textBox2) + Check(num3, textBox3) + Check(num4, textBox4) + Check(num5, textBox5);
            scoreListBox.Items.Add("score: " + score);
            sw.Stop();
            if (score == NUM_OF_NUMS)
            {
                //int totalTime = startTime.Second - DateTime.Now.Second;
               if (sw.ElapsedMilliseconds / 1000 < 10)
                    MessageBox.Show($"you win! and it take you {sw.ElapsedMilliseconds / 1000.0} second");
               else
                    MessageBox.Show($"it took too long {sw.ElapsedMilliseconds / 1000.0} second"); 
            }
            else
                MessageBox.Show("you worng!");

        }

        private void highScore_Click(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNumbersToLabel();

            ChangeLabelVisible(true);

            removeTextFromTextBox();
        }


        private void ListBoxTextChanged(object sender, EventArgs e)
        {
            int score = Check(num1, textBox1) + Check(num2, textBox2) + Check(num3, textBox3) + Check(num4, textBox4) + Check(num5, textBox5);
            if (score == 5)
                MessageBox.Show("you win");
        }
    }
}
