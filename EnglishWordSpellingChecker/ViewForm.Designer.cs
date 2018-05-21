namespace EnglishWordSpellingChecker
{
    partial class ViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._menuStrip = new System.Windows.Forms.MenuStrip();
            this._fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._examinationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._startMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._nextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._stopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._separateLine = new System.Windows.Forms.ToolStripSeparator();
            this._numberOfQuestionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._questions10MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._questions20MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._questions50MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._questionTypeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._allFillInBlankQuestionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._allMultipleChoiceQuestionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._pickUpQuestionsRandomlyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._aboutDictionaryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._aboutSpellingCheckerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._questionType1Box = new System.Windows.Forms.GroupBox();
            this._questionType1Table = new System.Windows.Forms.TableLayoutPanel();
            this._myAnswer = new System.Windows.Forms.TextBox();
            this._chineseLabel = new System.Windows.Forms.Label();
            this._englishLabel = new System.Windows.Forms.Label();
            this._question = new System.Windows.Forms.Label();
            this._table = new System.Windows.Forms.TableLayoutPanel();
            this._questionType2Box = new System.Windows.Forms.GroupBox();
            this._questionType2Table = new System.Windows.Forms.TableLayoutPanel();
            this._optionButton1 = new System.Windows.Forms.RadioButton();
            this._optionButton2 = new System.Windows.Forms.RadioButton();
            this._optionButton3 = new System.Windows.Forms.RadioButton();
            this._optionButton4 = new System.Windows.Forms.RadioButton();
            this._question2 = new System.Windows.Forms.Label();
            this._bottomTable = new System.Windows.Forms.TableLayoutPanel();
            this._checkBox = new System.Windows.Forms.StatusStrip();
            this._checkAnswer = new System.Windows.Forms.ToolStripStatusLabel();
            this._startButton = new System.Windows.Forms.Button();
            this._stopButton = new System.Windows.Forms.Button();
            this._nextButton = new System.Windows.Forms.Button();
            this._progressBar = new System.Windows.Forms.ProgressBar();
            this._time = new System.Windows.Forms.Label();
            this._score = new System.Windows.Forms.Label();
            this._startBox = new System.Windows.Forms.GroupBox();
            this._startTable = new System.Windows.Forms.TableLayoutPanel();
            this._numberOfQuestionsLabel = new System.Windows.Forms.Label();
            this._questionTypeLabel = new System.Windows.Forms.Label();
            this._numberOfQuestions = new System.Windows.Forms.NumericUpDown();
            this._questionType = new System.Windows.Forms.ComboBox();
            this._timer = new System.Windows.Forms.Timer(this.components);
            this._menuStrip.SuspendLayout();
            this._questionType1Box.SuspendLayout();
            this._questionType1Table.SuspendLayout();
            this._table.SuspendLayout();
            this._questionType2Box.SuspendLayout();
            this._questionType2Table.SuspendLayout();
            this._bottomTable.SuspendLayout();
            this._checkBox.SuspendLayout();
            this._startBox.SuspendLayout();
            this._startTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numberOfQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // _menuStrip
            // 
            this._menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this._menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._fileMenuItem,
            this._examinationMenuItem,
            this._helpMenuItem});
            this._menuStrip.Location = new System.Drawing.Point(0, 0);
            this._menuStrip.Name = "_menuStrip";
            this._menuStrip.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this._menuStrip.Size = new System.Drawing.Size(295, 24);
            this._menuStrip.TabIndex = 2;
            this._menuStrip.Text = "menuStrip1";
            // 
            // _fileMenuItem
            // 
            this._fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._exitMenuItem});
            this._fileMenuItem.Name = "_fileMenuItem";
            this._fileMenuItem.Size = new System.Drawing.Size(38, 22);
            this._fileMenuItem.Text = "File";
            // 
            // _exitMenuItem
            // 
            this._exitMenuItem.Name = "_exitMenuItem";
            this._exitMenuItem.Size = new System.Drawing.Size(94, 22);
            this._exitMenuItem.Text = "Exit";
            this._exitMenuItem.Click += new System.EventHandler(this.ClickExitMenuItem);
            // 
            // _examinationMenuItem
            // 
            this._examinationMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._startMenuItem,
            this._nextMenuItem,
            this._stopMenuItem,
            this._separateLine,
            this._numberOfQuestionsMenuItem,
            this._questionTypeMenuItem});
            this._examinationMenuItem.Name = "_examinationMenuItem";
            this._examinationMenuItem.Size = new System.Drawing.Size(89, 22);
            this._examinationMenuItem.Text = "Examination";
            // 
            // _startMenuItem
            // 
            this._startMenuItem.Name = "_startMenuItem";
            this._startMenuItem.Size = new System.Drawing.Size(195, 22);
            this._startMenuItem.Text = "Start";
            this._startMenuItem.Click += new System.EventHandler(this.ClickStartMenuItem);
            // 
            // _nextMenuItem
            // 
            this._nextMenuItem.Name = "_nextMenuItem";
            this._nextMenuItem.Size = new System.Drawing.Size(195, 22);
            this._nextMenuItem.Text = "Next";
            this._nextMenuItem.Click += new System.EventHandler(this.ClickNextMenuItem);
            // 
            // _stopMenuItem
            // 
            this._stopMenuItem.Name = "_stopMenuItem";
            this._stopMenuItem.Size = new System.Drawing.Size(195, 22);
            this._stopMenuItem.Text = "Stop";
            this._stopMenuItem.Click += new System.EventHandler(this.ClickStopMenuItem);
            // 
            // _separateLine
            // 
            this._separateLine.Name = "_separateLine";
            this._separateLine.Size = new System.Drawing.Size(192, 6);
            // 
            // _numberOfQuestionsMenuItem
            // 
            this._numberOfQuestionsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._questions10MenuItem,
            this._questions20MenuItem,
            this._questions50MenuItem});
            this._numberOfQuestionsMenuItem.Name = "_numberOfQuestionsMenuItem";
            this._numberOfQuestionsMenuItem.Size = new System.Drawing.Size(195, 22);
            this._numberOfQuestionsMenuItem.Text = "Number of Questions";
            // 
            // _questions10MenuItem
            // 
            this._questions10MenuItem.Name = "_questions10MenuItem";
            this._questions10MenuItem.Size = new System.Drawing.Size(147, 22);
            this._questions10MenuItem.Text = "10 Questions";
            this._questions10MenuItem.Click += new System.EventHandler(this.ClickQuestions10MenuItem);
            // 
            // _questions20MenuItem
            // 
            this._questions20MenuItem.Name = "_questions20MenuItem";
            this._questions20MenuItem.Size = new System.Drawing.Size(147, 22);
            this._questions20MenuItem.Text = "20 Questions";
            this._questions20MenuItem.Click += new System.EventHandler(this.ClickQuestions20MenuItem);
            // 
            // _questions50MenuItem
            // 
            this._questions50MenuItem.Name = "_questions50MenuItem";
            this._questions50MenuItem.Size = new System.Drawing.Size(147, 22);
            this._questions50MenuItem.Text = "50 Questions";
            this._questions50MenuItem.Click += new System.EventHandler(this.ClickQuestions50MenuItem);
            // 
            // _questionTypeMenuItem
            // 
            this._questionTypeMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._allFillInBlankQuestionsMenuItem,
            this._allMultipleChoiceQuestionsMenuItem,
            this._pickUpQuestionsRandomlyMenuItem});
            this._questionTypeMenuItem.Name = "_questionTypeMenuItem";
            this._questionTypeMenuItem.Size = new System.Drawing.Size(195, 22);
            this._questionTypeMenuItem.Text = "Question Type";
            // 
            // _allFillInBlankQuestionsMenuItem
            // 
            this._allFillInBlankQuestionsMenuItem.CheckOnClick = true;
            this._allFillInBlankQuestionsMenuItem.Name = "_allFillInBlankQuestionsMenuItem";
            this._allFillInBlankQuestionsMenuItem.Size = new System.Drawing.Size(241, 22);
            this._allFillInBlankQuestionsMenuItem.Text = "All fill-in-blanks questions";
            this._allFillInBlankQuestionsMenuItem.Click += new System.EventHandler(this.ClickAllFillInBlankQuestionsMenuItem);
            // 
            // _allMultipleChoiceQuestionsMenuItem
            // 
            this._allMultipleChoiceQuestionsMenuItem.CheckOnClick = true;
            this._allMultipleChoiceQuestionsMenuItem.Name = "_allMultipleChoiceQuestionsMenuItem";
            this._allMultipleChoiceQuestionsMenuItem.Size = new System.Drawing.Size(241, 22);
            this._allMultipleChoiceQuestionsMenuItem.Text = "All multiple-choices questions";
            this._allMultipleChoiceQuestionsMenuItem.Click += new System.EventHandler(this.ClickAllMultipleChoiceQuestionsMenuItem);
            // 
            // _pickUpQuestionsRandomlyMenuItem
            // 
            this._pickUpQuestionsRandomlyMenuItem.CheckOnClick = true;
            this._pickUpQuestionsRandomlyMenuItem.Name = "_pickUpQuestionsRandomlyMenuItem";
            this._pickUpQuestionsRandomlyMenuItem.Size = new System.Drawing.Size(236, 22);
            this._pickUpQuestionsRandomlyMenuItem.Text = "Pick up questions randomly";
            this._pickUpQuestionsRandomlyMenuItem.Click += new System.EventHandler(this.ClickPickUpQuestionsRandomlyMenuItem);
            // 
            // _helpMenuItem
            // 
            this._helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._aboutDictionaryMenuItem,
            this._aboutSpellingCheckerMenuItem});
            this._helpMenuItem.Name = "_helpMenuItem";
            this._helpMenuItem.Size = new System.Drawing.Size(46, 22);
            this._helpMenuItem.Text = "Help";
            // 
            // _aboutDictionaryMenuItem
            // 
            this._aboutDictionaryMenuItem.Name = "_aboutDictionaryMenuItem";
            this._aboutDictionaryMenuItem.Size = new System.Drawing.Size(206, 22);
            this._aboutDictionaryMenuItem.Text = "About Dictionary";
            this._aboutDictionaryMenuItem.Click += new System.EventHandler(this.ClickAboutDictionaryMenuItem);
            // 
            // _aboutSpellingCheckerMenuItem
            // 
            this._aboutSpellingCheckerMenuItem.Name = "_aboutSpellingCheckerMenuItem";
            this._aboutSpellingCheckerMenuItem.Size = new System.Drawing.Size(206, 22);
            this._aboutSpellingCheckerMenuItem.Text = "About Spelling Checker";
            this._aboutSpellingCheckerMenuItem.Click += new System.EventHandler(this.ClickAboutSpellingCheckerMenuItem);
            // 
            // _questionType1Box
            // 
            this._questionType1Box.AutoSize = true;
            this._questionType1Box.Controls.Add(this._questionType1Table);
            this._questionType1Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this._questionType1Box.Location = new System.Drawing.Point(2, 99);
            this._questionType1Box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._questionType1Box.Name = "_questionType1Box";
            this._questionType1Box.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._questionType1Box.Size = new System.Drawing.Size(291, 75);
            this._questionType1Box.TabIndex = 2;
            this._questionType1Box.TabStop = false;
            // 
            // _questionType1Table
            // 
            this._questionType1Table.AutoSize = true;
            this._questionType1Table.ColumnCount = 3;
            this._questionType1Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._questionType1Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._questionType1Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._questionType1Table.Controls.Add(this._myAnswer, 1, 1);
            this._questionType1Table.Controls.Add(this._chineseLabel, 0, 0);
            this._questionType1Table.Controls.Add(this._englishLabel, 0, 1);
            this._questionType1Table.Controls.Add(this._question, 1, 0);
            this._questionType1Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this._questionType1Table.Location = new System.Drawing.Point(2, 17);
            this._questionType1Table.Name = "_questionType1Table";
            this._questionType1Table.RowCount = 2;
            this._questionType1Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._questionType1Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._questionType1Table.Size = new System.Drawing.Size(287, 56);
            this._questionType1Table.TabIndex = 2;
            // 
            // _myAnswer
            // 
            this._questionType1Table.SetColumnSpan(this._myAnswer, 2);
            this._myAnswer.Location = new System.Drawing.Point(51, 31);
            this._myAnswer.Name = "_myAnswer";
            this._myAnswer.Size = new System.Drawing.Size(236, 22);
            this._myAnswer.TabIndex = 4;
            // 
            // _chineseLabel
            // 
            this._chineseLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._chineseLabel.AutoSize = true;
            this._chineseLabel.Location = new System.Drawing.Point(3, 8);
            this._chineseLabel.Name = "_chineseLabel";
            this._chineseLabel.Size = new System.Drawing.Size(42, 12);
            this._chineseLabel.TabIndex = 7;
            this._chineseLabel.Text = "Chinese";
            // 
            // _englishLabel
            // 
            this._englishLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._englishLabel.AutoSize = true;
            this._englishLabel.Location = new System.Drawing.Point(5, 36);
            this._englishLabel.Name = "_englishLabel";
            this._englishLabel.Size = new System.Drawing.Size(40, 12);
            this._englishLabel.TabIndex = 8;
            this._englishLabel.Text = "English";
            // 
            // _question
            // 
            this._question.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._question.AutoSize = true;
            this._questionType1Table.SetColumnSpan(this._question, 2);
            this._question.Location = new System.Drawing.Point(51, 8);
            this._question.Name = "_question";
            this._question.Size = new System.Drawing.Size(0, 12);
            this._question.TabIndex = 9;
            // 
            // _table
            // 
            this._table.AutoSize = true;
            this._table.ColumnCount = 1;
            this._table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._table.Controls.Add(this._questionType2Box, 0, 2);
            this._table.Controls.Add(this._bottomTable, 0, 3);
            this._table.Controls.Add(this._questionType1Box, 0, 1);
            this._table.Controls.Add(this._startBox, 0, 0);
            this._table.Dock = System.Windows.Forms.DockStyle.Fill;
            this._table.Location = new System.Drawing.Point(0, 24);
            this._table.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._table.Name = "_table";
            this._table.RowCount = 4;
            this._table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._table.Size = new System.Drawing.Size(295, 376);
            this._table.TabIndex = 5;
            // 
            // _questionType2Box
            // 
            this._questionType2Box.AutoSize = true;
            this._questionType2Box.Controls.Add(this._questionType2Table);
            this._questionType2Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this._questionType2Box.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._questionType2Box.Location = new System.Drawing.Point(2, 178);
            this._questionType2Box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._questionType2Box.Name = "_questionType2Box";
            this._questionType2Box.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._questionType2Box.Size = new System.Drawing.Size(291, 104);
            this._questionType2Box.TabIndex = 6;
            this._questionType2Box.TabStop = false;
            // 
            // _questionType2Table
            // 
            this._questionType2Table.AutoScroll = true;
            this._questionType2Table.AutoSize = true;
            this._questionType2Table.ColumnCount = 1;
            this._questionType2Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._questionType2Table.Controls.Add(this._optionButton1, 0, 1);
            this._questionType2Table.Controls.Add(this._optionButton2, 0, 2);
            this._questionType2Table.Controls.Add(this._optionButton3, 0, 3);
            this._questionType2Table.Controls.Add(this._optionButton4, 0, 4);
            this._questionType2Table.Controls.Add(this._question2, 0, 0);
            this._questionType2Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this._questionType2Table.Location = new System.Drawing.Point(2, 17);
            this._questionType2Table.Name = "_questionType2Table";
            this._questionType2Table.RowCount = 5;
            this._questionType2Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._questionType2Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._questionType2Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._questionType2Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._questionType2Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._questionType2Table.Size = new System.Drawing.Size(287, 85);
            this._questionType2Table.TabIndex = 1;
            // 
            // _optionButton1
            // 
            this._optionButton1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._optionButton1.AutoSize = true;
            this._optionButton1.Location = new System.Drawing.Point(2, 19);
            this._optionButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._optionButton1.Name = "_optionButton1";
            this._optionButton1.Size = new System.Drawing.Size(14, 13);
            this._optionButton1.TabIndex = 11;
            this._optionButton1.TabStop = true;
            this._optionButton1.UseVisualStyleBackColor = true;
            // 
            // _optionButton2
            // 
            this._optionButton2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._optionButton2.AutoSize = true;
            this._optionButton2.Location = new System.Drawing.Point(2, 36);
            this._optionButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._optionButton2.Name = "_optionButton2";
            this._optionButton2.Size = new System.Drawing.Size(14, 13);
            this._optionButton2.TabIndex = 12;
            this._optionButton2.TabStop = true;
            this._optionButton2.UseVisualStyleBackColor = true;
            // 
            // _optionButton3
            // 
            this._optionButton3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._optionButton3.AutoSize = true;
            this._optionButton3.Location = new System.Drawing.Point(2, 53);
            this._optionButton3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._optionButton3.Name = "_optionButton3";
            this._optionButton3.Size = new System.Drawing.Size(14, 13);
            this._optionButton3.TabIndex = 13;
            this._optionButton3.TabStop = true;
            this._optionButton3.UseVisualStyleBackColor = true;
            // 
            // _optionButton4
            // 
            this._optionButton4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._optionButton4.AutoSize = true;
            this._optionButton4.Location = new System.Drawing.Point(2, 70);
            this._optionButton4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._optionButton4.Name = "_optionButton4";
            this._optionButton4.Size = new System.Drawing.Size(14, 13);
            this._optionButton4.TabIndex = 14;
            this._optionButton4.TabStop = true;
            this._optionButton4.UseVisualStyleBackColor = true;
            // 
            // _question2
            // 
            this._question2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._question2.AutoSize = true;
            this._question2.Location = new System.Drawing.Point(2, 2);
            this._question2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._question2.Name = "_question2";
            this._question2.Size = new System.Drawing.Size(0, 12);
            this._question2.TabIndex = 16;
            // 
            // _bottomTable
            // 
            this._bottomTable.ColumnCount = 3;
            this._bottomTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this._bottomTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this._bottomTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this._bottomTable.Controls.Add(this._checkBox, 0, 2);
            this._bottomTable.Controls.Add(this._startButton, 0, 0);
            this._bottomTable.Controls.Add(this._stopButton, 2, 0);
            this._bottomTable.Controls.Add(this._nextButton, 1, 0);
            this._bottomTable.Controls.Add(this._progressBar, 1, 1);
            this._bottomTable.Controls.Add(this._time, 0, 1);
            this._bottomTable.Controls.Add(this._score, 2, 1);
            this._bottomTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._bottomTable.Location = new System.Drawing.Point(2, 297);
            this._bottomTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._bottomTable.Name = "_bottomTable";
            this._bottomTable.RowCount = 3;
            this._bottomTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this._bottomTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this._bottomTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._bottomTable.Size = new System.Drawing.Size(291, 77);
            this._bottomTable.TabIndex = 5;
            // 
            // _checkBox
            // 
            this._checkBox.AutoSize = false;
            this._bottomTable.SetColumnSpan(this._checkBox, 3);
            this._checkBox.ImageScalingSize = new System.Drawing.Size(24, 24);
            this._checkBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._checkAnswer});
            this._checkBox.Location = new System.Drawing.Point(0, 54);
            this._checkBox.Name = "_checkBox";
            this._checkBox.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this._checkBox.Size = new System.Drawing.Size(291, 23);
            this._checkBox.TabIndex = 4;
            this._checkBox.Text = "statusStrip1";
            // 
            // _checkAnswer
            // 
            this._checkAnswer.Name = "_checkAnswer";
            this._checkAnswer.Size = new System.Drawing.Size(0, 18);
            // 
            // _startButton
            // 
            this._startButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._startButton.AutoSize = true;
            this._startButton.Location = new System.Drawing.Point(2, 2);
            this._startButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._startButton.Name = "_startButton";
            this._startButton.Size = new System.Drawing.Size(92, 22);
            this._startButton.TabIndex = 0;
            this._startButton.Text = "Start";
            this._startButton.UseVisualStyleBackColor = true;
            this._startButton.Click += new System.EventHandler(this.ClickStartButton);
            // 
            // _stopButton
            // 
            this._stopButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._stopButton.AutoSize = true;
            this._stopButton.Location = new System.Drawing.Point(195, 2);
            this._stopButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._stopButton.Name = "_stopButton";
            this._stopButton.Size = new System.Drawing.Size(94, 22);
            this._stopButton.TabIndex = 2;
            this._stopButton.Text = "Stop";
            this._stopButton.UseVisualStyleBackColor = true;
            this._stopButton.Click += new System.EventHandler(this.ClickStopButton);
            // 
            // _nextButton
            // 
            this._nextButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._nextButton.AutoSize = true;
            this._nextButton.Location = new System.Drawing.Point(98, 2);
            this._nextButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._nextButton.Name = "_nextButton";
            this._nextButton.Size = new System.Drawing.Size(93, 22);
            this._nextButton.TabIndex = 1;
            this._nextButton.Text = "Next";
            this._nextButton.UseVisualStyleBackColor = true;
            this._nextButton.Click += new System.EventHandler(this.ClickNextButton);
            // 
            // _progressBar
            // 
            this._progressBar.Location = new System.Drawing.Point(98, 29);
            this._progressBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._progressBar.Maximum = 10;
            this._progressBar.Name = "_progressBar";
            this._progressBar.Size = new System.Drawing.Size(93, 23);
            this._progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this._progressBar.TabIndex = 5;
            // 
            // _time
            // 
            this._time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._time.AutoSize = true;
            this._time.Location = new System.Drawing.Point(24, 34);
            this._time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._time.Name = "_time";
            this._time.Size = new System.Drawing.Size(47, 12);
            this._time.TabIndex = 6;
            this._time.Text = "00:00:00";
            // 
            // _score
            // 
            this._score.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._score.AutoSize = true;
            this._score.Location = new System.Drawing.Point(219, 34);
            this._score.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._score.Name = "_score";
            this._score.Size = new System.Drawing.Size(46, 12);
            this._score.TabIndex = 7;
            this._score.Text = "Score : 0";
            // 
            // _startBox
            // 
            this._startBox.Controls.Add(this._startTable);
            this._startBox.Location = new System.Drawing.Point(2, 2);
            this._startBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._startBox.Name = "_startBox";
            this._startBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._startBox.Size = new System.Drawing.Size(289, 93);
            this._startBox.TabIndex = 7;
            this._startBox.TabStop = false;
            this._startBox.Text = "Customize Your Examination";
            // 
            // _startTable
            // 
            this._startTable.ColumnCount = 2;
            this._startTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this._startTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._startTable.Controls.Add(this._numberOfQuestionsLabel, 0, 0);
            this._startTable.Controls.Add(this._questionTypeLabel, 0, 1);
            this._startTable.Controls.Add(this._numberOfQuestions, 1, 0);
            this._startTable.Controls.Add(this._questionType, 1, 1);
            this._startTable.Location = new System.Drawing.Point(2, 17);
            this._startTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._startTable.Name = "_startTable";
            this._startTable.RowCount = 2;
            this._startTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._startTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._startTable.Size = new System.Drawing.Size(283, 67);
            this._startTable.TabIndex = 0;
            // 
            // _numberOfQuestionsLabel
            // 
            this._numberOfQuestionsLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._numberOfQuestionsLabel.AutoSize = true;
            this._numberOfQuestionsLabel.Location = new System.Drawing.Point(4, 10);
            this._numberOfQuestionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._numberOfQuestionsLabel.Name = "_numberOfQuestionsLabel";
            this._numberOfQuestionsLabel.Size = new System.Drawing.Size(104, 12);
            this._numberOfQuestionsLabel.TabIndex = 0;
            this._numberOfQuestionsLabel.Text = "Number of Questions";
            // 
            // _questionTypeLabel
            // 
            this._questionTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._questionTypeLabel.AutoSize = true;
            this._questionTypeLabel.Location = new System.Drawing.Point(35, 44);
            this._questionTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._questionTypeLabel.Name = "_questionTypeLabel";
            this._questionTypeLabel.Size = new System.Drawing.Size(73, 12);
            this._questionTypeLabel.TabIndex = 1;
            this._questionTypeLabel.Text = "Question Type";
            // 
            // _numberOfQuestions
            // 
            this._numberOfQuestions.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._numberOfQuestions.Location = new System.Drawing.Point(112, 5);
            this._numberOfQuestions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._numberOfQuestions.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this._numberOfQuestions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._numberOfQuestions.Name = "_numberOfQuestions";
            this._numberOfQuestions.Size = new System.Drawing.Size(169, 22);
            this._numberOfQuestions.TabIndex = 2;
            this._numberOfQuestions.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // _questionType
            // 
            this._questionType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._questionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._questionType.FormattingEnabled = true;
            this._questionType.Items.AddRange(new object[] {
            "All fill-in-blanks questions",
            "All multiple-choices questions",
            "Pick up questions randomly"});
            this._questionType.Location = new System.Drawing.Point(112, 40);
            this._questionType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._questionType.Name = "_questionType";
            this._questionType.Size = new System.Drawing.Size(169, 20);
            this._questionType.TabIndex = 3;
            // 
            // _timer
            // 
            this._timer.Interval = 1000;
            this._timer.Tick += new System.EventHandler(this.TickEventHandler);
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(295, 400);
            this.Controls.Add(this._table);
            this.Controls.Add(this._menuStrip);
            this.MainMenuStrip = this._menuStrip;
            this.Name = "ViewForm";
            this.Text = "基本能力測驗英文1000字";
            this._menuStrip.ResumeLayout(false);
            this._menuStrip.PerformLayout();
            this._questionType1Box.ResumeLayout(false);
            this._questionType1Box.PerformLayout();
            this._questionType1Table.ResumeLayout(false);
            this._questionType1Table.PerformLayout();
            this._table.ResumeLayout(false);
            this._table.PerformLayout();
            this._questionType2Box.ResumeLayout(false);
            this._questionType2Box.PerformLayout();
            this._questionType2Table.ResumeLayout(false);
            this._questionType2Table.PerformLayout();
            this._bottomTable.ResumeLayout(false);
            this._bottomTable.PerformLayout();
            this._checkBox.ResumeLayout(false);
            this._checkBox.PerformLayout();
            this._startBox.ResumeLayout(false);
            this._startTable.ResumeLayout(false);
            this._startTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numberOfQuestions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip _menuStrip;
        private System.Windows.Forms.ToolStripMenuItem _fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _examinationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _startMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _nextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _stopMenuItem;
        private System.Windows.Forms.ToolStripSeparator _separateLine;
        private System.Windows.Forms.ToolStripMenuItem _numberOfQuestionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _questionTypeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _aboutDictionaryMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _aboutSpellingCheckerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _questions10MenuItem;
        private System.Windows.Forms.ToolStripMenuItem _questions20MenuItem;
        private System.Windows.Forms.ToolStripMenuItem _questions50MenuItem;
        private System.Windows.Forms.ToolStripMenuItem _allFillInBlankQuestionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _allMultipleChoiceQuestionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _pickUpQuestionsRandomlyMenuItem;
        private System.Windows.Forms.GroupBox _questionType1Box;
        private System.Windows.Forms.TableLayoutPanel _questionType1Table;
        private System.Windows.Forms.Label _chineseLabel;
        private System.Windows.Forms.Label _englishLabel;
        private System.Windows.Forms.TextBox _myAnswer;
        private System.Windows.Forms.Label _question;
        private System.Windows.Forms.TableLayoutPanel _table;
        private System.Windows.Forms.GroupBox _questionType2Box;
        private System.Windows.Forms.TableLayoutPanel _questionType2Table;
        private System.Windows.Forms.RadioButton _optionButton1;
        private System.Windows.Forms.RadioButton _optionButton2;
        private System.Windows.Forms.RadioButton _optionButton3;
        private System.Windows.Forms.RadioButton _optionButton4;
        private System.Windows.Forms.Label _question2;
        private System.Windows.Forms.TableLayoutPanel _bottomTable;
        private System.Windows.Forms.StatusStrip _checkBox;
        private System.Windows.Forms.ToolStripStatusLabel _checkAnswer;
        private System.Windows.Forms.Button _startButton;
        private System.Windows.Forms.Button _stopButton;
        private System.Windows.Forms.Button _nextButton;
        private System.Windows.Forms.GroupBox _startBox;
        private System.Windows.Forms.TableLayoutPanel _startTable;
        private System.Windows.Forms.Label _numberOfQuestionsLabel;
        private System.Windows.Forms.Label _questionTypeLabel;
        private System.Windows.Forms.NumericUpDown _numberOfQuestions;
        private System.Windows.Forms.ComboBox _questionType;
        private System.Windows.Forms.ProgressBar _progressBar;
        private System.Windows.Forms.Timer _timer;
        private System.Windows.Forms.Label _time;
        private System.Windows.Forms.Label _score;
    }
}