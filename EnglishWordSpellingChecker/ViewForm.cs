using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishWordSpellingChecker
{
    public partial class ViewForm : Form
    {
        PresentationModel _presentationModel;
        DialogForm _dialogForm;
        SolutionForm _solutionForm;
        DateTime _counter;
        const string INITIAL_QUESTION_TYPE = "Pick up questions randomly";

        public ViewForm(PresentationModel presentationModel)
        {
            InitializeComponent();
            this._presentationModel = presentationModel;
            _counter = new DateTime();
            RefreshEnabledControls();
            _questionType.Text = INITIAL_QUESTION_TYPE;
        }

        // Refresh every control on viewform
        void RefreshControls()
        {
            RefreshCheckControls();
            RefreshEnabledControls();
            RefreshTextControls();
        }

        // Refresh every check control on viewform
        void RefreshCheckControls()
        {
            _presentationModel.GetAnswer1(_myAnswer.Text.Trim());
            _presentationModel.GetAnswer2Check(_optionButton1.Checked, _optionButton2.Checked, _optionButton3.Checked, _optionButton4.Checked);
            _presentationModel.GetAnswer2(_optionButton1.Text.Trim(), _optionButton2.Text.Trim(), _optionButton3.Text.Trim(), _optionButton4.Text.Trim());
            _checkAnswer.Text = _presentationModel.GetAnswer();
        }

        // Refresh every visible/enabled/checked control on viewform
        void RefreshEnabledControls()
        {
            _startButton.Enabled = _presentationModel.IsStartEnabled();
            _startMenuItem.Enabled = _presentationModel.IsStartEnabled();
            _nextButton.Enabled = _presentationModel.IsNextEnabled();
            _nextMenuItem.Enabled = _presentationModel.IsNextEnabled();
            _stopButton.Enabled = _presentationModel.IsNextEnabled();
            _stopMenuItem.Enabled = _presentationModel.IsNextEnabled();
            _startBox.Visible = _presentationModel.IsStartBoxVisible();
            _questionType1Box.Visible = _presentationModel.IsType1Visible();
            _myAnswer.Enabled = _presentationModel.IsMyAnswerEnabled();
            _questionType2Box.Visible = _presentationModel.IsType2Visible();
            _optionButton1.Checked = _presentationModel.IsOptionChecked();
            _optionButton2.Checked = _presentationModel.IsOptionChecked();
            _optionButton3.Checked = _presentationModel.IsOptionChecked();
            _optionButton4.Checked = _presentationModel.IsOptionChecked();
        }

        // Refresh every text control on viewform
        void RefreshTextControls()
        {
            _questionType1Box.Text = _presentationModel.GetQuestionTitle();
            _question.Text = _presentationModel.GetQuestion();
            _myAnswer.Text = _presentationModel.GetMyAnswer();
            _questionType2Box.Text = _presentationModel.GetQuestionTitle();
            _question2.Text = _presentationModel.GetQuestion();
            _presentationModel.GetOptionArray();
            _optionButton1.Text = _presentationModel.GetOption(1);
            _optionButton2.Text = _presentationModel.GetOption(2);
            _optionButton3.Text = _presentationModel.GetOption(3);
            _optionButton4.Text = _presentationModel.GetOption(4);
        }

        // Print out solution form
        void GetSolutionForm()
        {
            _solutionForm.SetResult(_presentationModel.GetResult());
            _solutionForm.SetScore(_presentationModel.GetScore(Decimal.ToInt32(_numberOfQuestions.Value)));
            _solutionForm.GetSolutionList(_presentationModel.GetSolutionList());
            _solutionForm.Show();
        }

        // Refresh every control which need to be updated every second on viewform
        void RefreshImmediateControl()
        {
            _progressBar.Value = _presentationModel.GetProgressBarValue();
            _time.Text = _counter.ToString("HH:mm:ss");
            _score.Text = _presentationModel.GetScore(Decimal.ToInt32(_numberOfQuestions.Value));
        }

        // Click Start button and start the quiz
        private void ClickStartButton(object sender, EventArgs e)
        {
            _solutionForm = new SolutionForm();
            _presentationModel.ClickStart(Decimal.ToInt32(_numberOfQuestions.Value), _questionType.Text);
            _timer.Start();
            _counter = new DateTime();
            RefreshImmediateControl();
            RefreshControls();
        }

        // Click Next button, check the answer, and show next question
        private void ClickNextButton(object sender, EventArgs e)
        {
            _presentationModel.ClickNext();
            RefreshImmediateControl();
            RefreshControls();
            _presentationModel.GetFinished(_counter);
            RefreshImmediateControl();
            if (_presentationModel.IsFinished())
            {
                _timer.Stop();
                GetSolutionForm();
            }
            _presentationModel.GetNewQuiz();
            RefreshEnabledControls();            
            
        }

        // Click Stop button and end the quiz
        private void ClickStopButton(object sender, EventArgs e)
        {
            _presentationModel.ClickStop();
            RefreshCheckControls();
            _presentationModel.GetFinished(_counter);
            _timer.Stop();
            RefreshImmediateControl();
            GetSolutionForm();
            _presentationModel.GetNewQuiz();
            RefreshEnabledControls();
        }

        // File->Exit : Closed the ViewForm window
        private void ClickExitMenuItem(object sender, EventArgs e)
        {
            Close();
        }

        // Examination->Start : Start the quiz
        private void ClickStartMenuItem(object sender, EventArgs e)
        {
            _startButton.PerformClick();
        }

        // Examination->Next : Check the answer and show next question
        private void ClickNextMenuItem(object sender, EventArgs e)
        {
            _nextButton.PerformClick();
        }

        // Examination->Stop : End the quiz
        private void ClickStopMenuItem(object sender, EventArgs e)
        {
            _stopButton.PerformClick();
        }

        // Examination->Number of Questions->10 Questions : Set number of questions = 10
        private void ClickQuestions10MenuItem(object sender, EventArgs e)
        {
            _numberOfQuestions.Value = 10;
        }

        // Examination->Number of Questions->20 Questions : Set number of questions = 20
        private void ClickQuestions20MenuItem(object sender, EventArgs e)
        {
            _numberOfQuestions.Value = 20;
        }

        // Examination->Number of Questions->50 Questions : Set number of questions = 50
        private void ClickQuestions50MenuItem(object sender, EventArgs e)
        {
            _numberOfQuestions.Value = 50;
        }

        // Examination->Question Type->All fill-in-blanks questions : Set question type = "All fill-in-blanks questions"
        private void ClickAllFillInBlankQuestionsMenuItem(object sender, EventArgs e)
        {
            _questionType.Text = "All fill-in-blanks questions";
            _allMultipleChoiceQuestionsMenuItem.Checked = false;
            _pickUpQuestionsRandomlyMenuItem.Checked = false;
        }

        // Examination->Question Type->All multiple-choices questions : Set question type = "All multiple-choices questions"
        private void ClickAllMultipleChoiceQuestionsMenuItem(object sender, EventArgs e)
        {
            _questionType.Text = "All multiple-choices questions";
            _allFillInBlankQuestionsMenuItem.Checked = false;
            _pickUpQuestionsRandomlyMenuItem.Checked = false;
        }

        // Examination->Question Type->Pick up questions randomly : Set question type = "Pick up questions randomly"
        private void ClickPickUpQuestionsRandomlyMenuItem(object sender, EventArgs e)
        {
            _questionType.Text = "Pick up questions randomly";
            _allFillInBlankQuestionsMenuItem.Checked = false;
            _allMultipleChoiceQuestionsMenuItem.Checked = false;
        }

        // Help->AboutDictionary : Pop out a form which tells dictionary's information
        private void ClickAboutDictionaryMenuItem(object sender, EventArgs e)
        {
            MessageBox.Show("Total 1081 words in the dictionary.");
        }

        // Help->AboutSpellingChecker : Pop out a form which tells program's information
        private void ClickAboutSpellingCheckerMenuItem(object sender, EventArgs e)
        {
            _dialogForm = new DialogForm();
            _dialogForm.Show();
        }

        // Functions which run every second
        private void TickEventHandler(object sender, EventArgs e)
        {
            _counter = _counter.AddSeconds(1);
            _presentationModel.AddProgressBarValue();
            RefreshImmediateControl();
        }
    }
}
