using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace quaffinator
{
    public partial class Form1 : Form
    {
        // I'm lazy and didn't use arrays here.  
        string[] player1;
        string[] player2;
        string[] player3;
        string[] player4;
        string[] player5;
        string[] player6;
        string[] player7;
        string[] player8;
        string[] player9;
        string[] player10;
        string[] player11;
        string[] player12;
        string[] player13;
        string[] player14;
        string[] player15;
        string[] player16;

        public Form1()
        {
            InitializeComponent();
        refreshFiles();
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rolllabel.Text = "...";
            label8.Text = "...";
            label9.Text = "...";
            label10.Text = "...";
            label11.Text = "...";
            this.Refresh();
            Application.DoEvents();
            System.Threading.Thread.Sleep(1000);
                
            Random rnd = new Random();
            int dice1 = rnd.Next(-1, 2); 
            int dice2 = rnd.Next(-1, 2); 
            int dice3 = rnd.Next(-1, 2);
            int dice4 = rnd.Next(-1, 2);
            int stat = 0;
            label8.Text = dice1.ToString();
            label9.Text = dice2.ToString();
            label10.Text = dice3.ToString();
            label11.Text = dice4.ToString();
            if (radioButton1.Checked)
            {
                stat= Convert.ToInt32(textBox1.Text.ToString());
            }
            if (radioButton2.Checked)
            {
                stat = Convert.ToInt32(textBox2.Text.ToString());
            }
            if (radioButton3.Checked)
            {
                stat = Convert.ToInt32(textBox3.Text.ToString());
            }
            if (radioButton4.Checked)
            {
                stat = Convert.ToInt32(textBox4.Text.ToString());
            }
            if (radioButton5.Checked)
            {
                stat = Convert.ToInt32(textBox5.Text.ToString());
            }
            if (radioButton6.Checked)
            {
                stat = Convert.ToInt32(textBox6.Text.ToString());
            }

                rolllabel.Text = (stat + dice1 + dice2 + dice3 + dice4 + Convert.ToInt32(modbox.Text.ToString())).ToString();
            modbox.Text = "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void refreshFiles()
        {
            try
            {
                player1 = File.ReadLines("1.txt").ToArray();
                player2 = File.ReadLines("2.txt").ToArray();
                player3 = File.ReadLines("3.txt").ToArray();
                player4 = File.ReadLines("4.txt").ToArray();
                player5 = File.ReadLines("5.txt").ToArray();
                player6 = File.ReadLines("6.txt").ToArray();
                player7 = File.ReadLines("7.txt").ToArray();
                player8 = File.ReadLines("8.txt").ToArray();
                player9 = File.ReadLines("9.txt").ToArray();
                player10 = File.ReadLines("10.txt").ToArray();
                player11 = File.ReadLines("11.txt").ToArray();
                player12 = File.ReadLines("12.txt").ToArray();
                player13 = File.ReadLines("13.txt").ToArray();
                player14 = File.ReadLines("14.txt").ToArray();
                player15 = File.ReadLines("15.txt").ToArray();
                player16 = File.ReadLines("16.txt").ToArray();
            }
            catch
            {
                MessageBox.Show("Please put 16 txt files, numbered 1 through 16.txt, in the same directory as this exe and reload this program.");
                System.Environment.Exit(69);
            }


            listBox1.SelectedIndex = 0;
            listBox1.Items[0] = player1[0];
            listBox1.Items[1] = player2[0];
            listBox1.Items[2] = player3[0];
            listBox1.Items[3] = player4[0];
            listBox1.Items[4] = player5[0];
            listBox1.Items[5] = player6[0];
            listBox1.Items[6] = player7[0];
            listBox1.Items[7] = player8[0];
            listBox1.Items[8] = player9[0];
            listBox1.Items[9] = player10[0];
            listBox1.Items[10] = player11[0];
            listBox1.Items[11] = player12[0];
            listBox1.Items[12] = player13[0];
            listBox1.Items[13] = player14[0];
            listBox1.Items[14] = player15[0];
            listBox1.Items[15] = player16[0];

        }
        private void updateBoxes(string[] player)
        {
            textBox1.Text = player[1].ToString();
            textBox2.Text = player[2].ToString();
            textBox3.Text = player[3].ToString();
            textBox4.Text = player[4].ToString();
            textBox5.Text = player[5].ToString();
            textBox6.Text = player[6].ToString();

            charnamelabel.Text = player[0].ToString();
            pictureBox1.Image = Image.FromFile(player[7].ToString());

        }

        private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            
            if (listBox1.SelectedIndex == 0) {
                updateBoxes(player1); 
            }
            if (listBox1.SelectedIndex == 1)
            {
                updateBoxes(player2);
            }
            if (listBox1.SelectedIndex == 2)
            {
                updateBoxes(player3);
            }
            if (listBox1.SelectedIndex == 3)
            {
                updateBoxes(player4);
            }
            if (listBox1.SelectedIndex == 4)
            {
                updateBoxes(player5);
            }
            if (listBox1.SelectedIndex == 5)
            {
                updateBoxes(player6);
            }
            if (listBox1.SelectedIndex == 6)
            {
                updateBoxes(player7);
            }
            if (listBox1.SelectedIndex == 7)
            {
                updateBoxes(player8);
            }
            if (listBox1.SelectedIndex == 8)
            {
                updateBoxes(player9);
            }
            if (listBox1.SelectedIndex == 9)
            {
                updateBoxes(player10);
            }
            if (listBox1.SelectedIndex == 10)
            {
                updateBoxes(player11);
            }
            if (listBox1.SelectedIndex == 11)
            {
                updateBoxes(player12);
            }
            if (listBox1.SelectedIndex == 12)
            {
                updateBoxes(player13);
            }
            if (listBox1.SelectedIndex == 13)
            {
                updateBoxes(player14);
            }
            if (listBox1.SelectedIndex == 14)
            {
                updateBoxes(player15);
            }
            if (listBox1.SelectedIndex == 15)
            {
                updateBoxes(player16);
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            //Call our function to reload data from files
            refreshFiles();
        }

        private void rolllabel_Click(object sender, System.EventArgs e)
        {

        }
    }
}
