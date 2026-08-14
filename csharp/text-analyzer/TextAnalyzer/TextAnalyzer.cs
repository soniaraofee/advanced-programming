using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextAnalyzer
{
    public partial class TextAnalyzer : Form
    {
        public TextAnalyzer()
        {
            InitializeComponent();
            this.ActiveControl = TB1;
        }


        private void ChCount_Click(object sender, EventArgs e)
        {
            TB2.Clear();
            string text = TB1.Text.ToLower();
            if (string.IsNullOrWhiteSpace(text)) return;

            if (!string.IsNullOrEmpty(TBCh.Text))
            {
                char target = TBCh.Text.ToLower()[0];
                int count = 0;

                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == target)
                        count++;
                }

                TB2.AppendText(string.Format("Search Results for '{0}'{1}", target, Environment.NewLine));
                TB2.AppendText(string.Format("----------------------{0}", Environment.NewLine));
                TB2.AppendText(string.Format("Found: {0} times", count));
            }
            else
            {
                TB2.AppendText(string.Format("Letter | Count{0}", Environment.NewLine));
                TB2.AppendText(string.Format("--------------{0}", Environment.NewLine));

                for (char letter = 'a'; letter <= 'z'; letter++)
                {
                    int count = 0;

                    for (int i = 0; i < text.Length; i++)
                    {
                        if (text[i] == letter)
                            count++;
                    }

                    if (count > 0)
                    {
                        TB2.AppendText(
                        string.Format("{0,-6}| {1}{2}", letter, count, Environment.NewLine));
                    }
                }
            }
        }

        private void WCount_Click(object sender, EventArgs e)
        {
            TB2.Clear();

            string text = TB1.Text;
            if (string.IsNullOrWhiteSpace(text)) return;

            string[] words = text.Split(new char[] { ' ', '\n', '\r', '\t' },
            StringSplitOptions.RemoveEmptyEntries);

            if (TBWo.Text != "")
            {
                string target = TBWo.Text.Trim();
                int count = 0;

                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].Equals(target, StringComparison.OrdinalIgnoreCase))
                        count++;
                }

                TB2.AppendText(string.Format("Search Results for \"{0}\"{1}", target, Environment.NewLine));
                TB2.AppendText(string.Format("------------------------{0}", Environment.NewLine));
                TB2.AppendText(string.Format("Total words: {0}{1}", words.Length, Environment.NewLine));
                TB2.AppendText(string.Format("Found: {0} times", count));
            }
             else
            {
                TB2.AppendText(string.Format("Word Analysis{0}", Environment.NewLine));
                TB2.AppendText(string.Format("------------------------{0}", Environment.NewLine));
                TB2.AppendText(string.Format("Total Words: {0}{1}{1}", words.Length, Environment.NewLine));

                for (int i = 0; i < words.Length; i++)
                {
                    TB2.AppendText(string.Format("{0}{1}", words[i], Environment.NewLine));
                }
            }
        }
        
    }
}


       
