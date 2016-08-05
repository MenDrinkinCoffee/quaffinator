using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace quaffinator
{
    public partial class Form1 : Form
    {
        // Too lazy to make a players object.
        private readonly List<string[]> _players = new List<string[]>();

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
            Refresh();
            Application.DoEvents();
            Thread.Sleep(1000);

            var rnd = new Random();
            var dice1 = rnd.Next(-1, 2);
            var dice2 = rnd.Next(-1, 2);
            var dice3 = rnd.Next(-1, 2);
            var dice4 = rnd.Next(-1, 2);
            var stat = 0;
            label8.Text = dice1.ToString();
            label9.Text = dice2.ToString();
            label10.Text = dice3.ToString();
            label11.Text = dice4.ToString();
            if (radioButton1.Checked)
                stat = Convert.ToInt32(textBox1.Text);
            if (radioButton2.Checked)
                stat = Convert.ToInt32(textBox2.Text);
            if (radioButton3.Checked)
                stat = Convert.ToInt32(textBox3.Text);
            if (radioButton4.Checked)
                stat = Convert.ToInt32(textBox4.Text);
            if (radioButton5.Checked)
                stat = Convert.ToInt32(textBox5.Text);
            if (radioButton6.Checked)
                stat = Convert.ToInt32(textBox6.Text);

            rolllabel.Text = (stat + dice1 + dice2 + dice3 + dice4 + Convert.ToInt32(modbox.Text)).ToString();
            modbox.Text = "0";
        }

        private void refreshFiles()
        {
            for (var i = 0; i <= 15; i++)
                try
                {
                    var fileExists = File.Exists($"{i + 1}.txt");
                    if (fileExists)
                    {
                        _players.Add(File.ReadLines($"{i + 1}.txt").ToArray());
                    }
                    else
                    {
                        var player = new string[8];
                        player[0] = $"Player {i + 1}";
                        player[1] = "0";
                        player[2] = "0";
                        player[3] = "0";
                        player[4] = "0";
                        player[5] = "0";
                        player[6] = "0";
                        player[7] = "default_logo.png";
                        File.WriteAllLines($"{i + 1}.txt", player);
                        _players.Add(player);
                    }
                }
                catch (Exception)
                {
                    Debug.WriteLine("Failed to read in players file");
                }

            listBox1.SelectedIndex = 0;
            for (var i = 0; i <= 15; i++)
                listBox1.Items[i] = _players[i][0];
        }

        private void updateBoxes(string[] player)
        {
            textBox1.Text = player[1];
            textBox2.Text = player[2];
            textBox3.Text = player[3];
            textBox4.Text = player[4];
            textBox5.Text = player[5];
            textBox6.Text = player[6];

            charnamelabel.Text = player[0];
            pictureBox1.Image = Image.FromFile(player[7]);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_players[listBox1.SelectedIndex].Length > 0)
                updateBoxes(_players[listBox1.SelectedIndex]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Call our function to reload data from files
            refreshFiles();
        }
    }
}