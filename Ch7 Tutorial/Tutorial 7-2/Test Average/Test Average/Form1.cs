using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const int SIZE = 40;

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            int[] scores = new int[SIZE];
            int highestScore = 0;
            int lowestScore = 0;
            double averageScore = 0;
            int MediumScore = 0;
            GetScoresFromFile(scores);

            for (int i = 0; i < scores.Length; i++)
            { testScoresListBox.Items.Add(scores[i]); }

            highestScore = Highest(scores);
            highScoreLabel.Text = highestScore.ToString();

            lowestScore = Lowest(scores);
            lowScoreLabel.Text = lowestScore.ToString();

            averageScore = Average(scores);
            averageScoreLabel.Text = averageScore.ToString();

            MediumScore = Medium(scores);
            MediumLbl.Text = MediumScore.ToString();
        }

        private int Highest(int[] scores)
        {
            int highest = scores[0];
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] > highest)
                    highest = scores[i];
            }
            return highest;
        }
        private int Lowest(int[] scores)
        {
            int lowest = scores[0];
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] < lowest)
                    lowest = scores[i];
            }
            return lowest;
        }
        private double Average(int[] scores)
        {
            double average = 0;
            foreach (int x in scores)
            { average += x; }
            return (double)average / scores.Length;
        }
        private int Medium(int[] score)
        {
            Array.Sort(score);
            return score[score.Length / 2];
        }
        private void GetScoresFromFile(int[] scores)
        {
            StreamReader inputFile = null;
            int index = 0;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                inputFile = File.OpenText(openFile.FileName);
                while (!inputFile.EndOfStream  && index < scores.Length)
                {
                    scores[index] = int.Parse(inputFile.ReadLine());
                    index++;
                }
            }
            else
                MessageBox.Show("已取消");
            inputFile.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
