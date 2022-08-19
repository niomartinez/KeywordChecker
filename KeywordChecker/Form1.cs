using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeywordChecker
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        string[] lines;

        private void txtAvoid_TextChanged(object sender, EventArgs e)
        {
            lines = txtAvoid.Text.Split(new string[] { "\r\n", "\r", "\n" },StringSplitOptions.None);
            lblKeywords.Text = lines.Length.ToString();
            lblStatus.Text = Check();
        }

        private void txtToCheck_TextChanged(object sender, EventArgs e)
        {
            lblStatus.Text = Check();
        }
        private string Check()
        {
            List<string> matches = new List<string>();
            if ((txtToCheck.Text != "" | !String.IsNullOrEmpty(txtToCheck.Text)) && (txtAvoid.Text != "" | !String.IsNullOrEmpty(txtAvoid.Text)))
            {
                int matchCounter = 0;
                string[] words = txtToCheck.Text.Split(' ');
                foreach (string word in words)
                {
                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (word == lines[i])
                        {
                            matches.Add(word);
                            matchCounter++;
                        }
                    }
                }
                txtMatch.Text = "";
                foreach (string match in matches)
                {
                    txtMatch.Text += match + Environment.NewLine;
                }
                lblMatches.Text = matchCounter.ToString();
                return matchCounter <= 0 ? "Passed" : "Failed";
            }
            else
            {
                return " ";
            }
        }
    }
}
