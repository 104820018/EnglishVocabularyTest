using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishWordSpellingChecker
{
    public partial class SolutionForm : Form
    {
        private List<string> _solution;
        private string _result;
        private string _score;

        public SolutionForm()
        {
            InitializeComponent();
        }

        // Get solution list from quiz
        public void GetSolutionList(List<string> solution)
        {
            _solution = solution;
            _listBox.MultiColumn = true;
            _listBox.SelectionMode = SelectionMode.MultiExtended;
            _listBox.BeginUpdate();
            _listBox.Items.Add(_result);
            _listBox.Items.Add(_score);
            for (int i = 0; i < _solution.Count; i++)
                _listBox.Items.Add(_solution[i]);
            _listBox.EndUpdate();
            _listBox.AutoSize = true;
        }

        // Get result (pass how many questions) from quiz
        public void SetResult(string result)
        {
            _result = result;
        }

        // Get Score from quiz
        public void SetScore(string score)
        {
            _score = score;
        }

        // Click Ok button and close this form
        private void ClickOkButton(object sender, EventArgs e)
        {
            Close();
        }
    }
}
