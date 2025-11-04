using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Typing_Game
{
    public partial class Form1 : Form
    {
        private string[] words = { "812", "Skyrim", "Яп", "Deadlock", "Kotlin", "C++", "C#", "Java", "Python", "Rust"};
        private int correct;
        private int incorrect;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            StartGame();
        }

        private void StartGame()
        {
            correctLabel.Text = $"Правильных слов: {correct}";
            incorrectLabel.Text = $"Неправильных слов: {incorrect}";

            GetWord();
        }

        private void GetWord()
        {
            if (words.Length > 0)
            {
                textLabel.Text = words[random.Next(words.Length)];
                inputBox.Clear();
            }
        }

        private void CheckWord()
        {   
            string input = inputBox.Text.ToLower();
            string word = textLabel.Text.ToLower();

            if (input == word)
            {
                correct++;
                correctLabel.Text = $"Правильных слов: {correct}";
                GetWord();
            }
            else
            {
                incorrect++;
                incorrectLabel.Text = $"Неправильных слов: {incorrect}";
                GetWord();
            }

        }

        private void inputBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckWord();
            }
        }

    }
}
