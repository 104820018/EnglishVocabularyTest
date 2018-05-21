using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace EnglishWordSpellingCheckerUITests
{
    [CodedUITest]
    public class ViewFormUITest
    {
        const string FILE_PATH = @"EnglishWordSpellingChecker.exe";
        private const string VIEWFORM_TITLE = "基本能力測驗英文1000字";

        /// <summary>
        /// Launches the Calculator
        /// </summary>
        [TestInitialize()]
        public void Initialize()
        {
            Robot.Initialize(FILE_PATH, VIEWFORM_TITLE);
        }

        /// <summary>
        /// Closes the launched program
        /// </summary>
        [TestCleanup()]
        public void Cleanup()
        {
            Robot.CleanUp();
        }

        // Test ViewForm's Start Button
        [TestMethod]
        public void TestStartButton()
        {
            Robot.AssertButtonEnable("Start", true);
            Robot.ClickButton("Start");
            Robot.AssertButtonEnable("Start", false);
        }

        // Test ViewForm's Next Button
        [TestMethod]
        public void TestNextButton()
        {
            Robot.AssertButtonEnable("Next", false);
            Robot.ClickButton("Start");
            Robot.AssertButtonEnable("Next", true);
            Robot.ClickButton("Next");
        }

        // Test ViewForm's Stop Button
        [TestMethod]
        public void TestStopButton()
        {
            Robot.AssertButtonEnable("Stop", false);
            Robot.ClickButton("Start");
            Robot.AssertButtonEnable("Stop", true);
            Robot.ClickButton("Stop");
            Robot.AssertButtonEnable("Stop", false);
            Robot.AssertWindow("Result & Solution");
        }

        // Test ViewForm's File->Exit MenuItem
        [TestMethod]
        public void TestExitMenuItem()
        {
            Robot.ClickMenuItem(new string[] { "File", "Exit" });
            Initialize();
        }

        // Test ViewForm's Examination->Start MenuItem
        [TestMethod]
        public void TestStartMenuItem()
        {
            Robot.AssertOtherFormButtonEnable("基本能力測驗英文1000字", "Start", true);
            Robot.ClickMenuItem(new string[] { "Examination", "Start" });
            Robot.AssertOtherFormButtonEnable("基本能力測驗英文1000字", "Start", false);
        }

        // Test ViewForm's Examination->Next MenuItem
        [TestMethod]
        public void TestNextMenuItem()
        {
            Robot.AssertOtherFormButtonEnable("基本能力測驗英文1000字", "Next", false);
            Robot.ClickMenuItem(new string[] { "Examination", "Start" });
            Robot.AssertOtherFormButtonEnable("基本能力測驗英文1000字", "Next", true);
            Robot.ClickMenuItem(new string[] { "Examination", "Next" });
        }

        // Test ViewForm's Examination->Stop MenuItem
        [TestMethod]
        public void TestStopMenuItem()
        {
            Robot.AssertOtherFormButtonEnable("基本能力測驗英文1000字", "Stop", false);
            Robot.ClickMenuItem(new string[] { "Examination", "Start" });
            Robot.AssertOtherFormButtonEnable("基本能力測驗英文1000字", "Stop", true);
            Robot.ClickMenuItem(new string[] { "Examination", "Stop" });
            Robot.AssertWindow("Result & Solution");
        }

        // Test ViewForm's Examination->Number Of Questions MenuItems
        [TestMethod]
        public void TestNuberOfQuestionsMenuItem()
        {
            Robot.ClickMenuItem(new string[] { "Examination", "Number Of Questions", "50 Questions" });
            Robot.AssertNumericUpDown("Question Type", "50");
            Robot.ClickMenuItem(new string[] { "Examination", "Number Of Questions", "20 Questions" });
            Robot.AssertNumericUpDown("Question Type", "20");
            Robot.ClickMenuItem(new string[] { "Examination", "Number Of Questions", "10 Questions" });
            Robot.AssertNumericUpDown("Question Type", "10");
        }

        // Test ViewForm's Examination->Question Type MenuItems
        [TestMethod]
        public void TestQuestionTypeMenuItem()
        {
            Robot.ClickMenuItem(new string[] { "Examination", "Question Type", "All fill-in-blanks questions" });
            Robot.AssertComboBox("", "All fill-in-blanks questions");
            Robot.ClickMenuItem(new string[] { "Examination", "Question Type", "All multiple-choices questions" });
            Robot.AssertComboBox("", "All multiple-choices questions");
            Robot.ClickMenuItem(new string[] { "Examination", "Question Type", "Pick up questions randomly" });
            Robot.AssertComboBox("", "Pick up questions randomly");
        }

        // Test ViewForm's Help->About Dictionary MenuItem and Messagebox "About Dictionary"
        [TestMethod]
        public void TestAboutDictionaryMenuItem()
        {
            Robot.ClickMenuItem(new string[] { "Help", "About Dictionary" });
            Robot.SendKeyEnterToMessageBox("About Dictionary");
            Robot.AssertWindow("基本能力測驗英文1000字");
        }

        // Test ViewForm's Help->About Spelling Checker MenuItem and DialogForm's OK Button
        [TestMethod]
        public void TestAboutSpellingCheckerMenuItem()
        {
            Robot.ClickMenuItem(new string[] { "Help", "About Spelling Checker" });
            Robot.AssertWindow("About Spelling Checker.");
            Robot.ClickOtherFormButton("About Spelling Checker.", "OK");
            Robot.AssertWindow("基本能力測驗英文1000字");
        }

        // Test ViewForm's Number Of Questions NumericUpDown
        [TestMethod]
        public void TestNumberOfQuestionsNumericUpDown()
        {
            Robot.SetNumericUpDown("Question Type", "25");
            Robot.AssertNumericUpDown("Question Type", "25");
        }

        // Test ViewForm's Question Type ComboBox
        [TestMethod]
        public void TestQuestionType()
        {
            Robot.SetComboBox("", "All fill-in-blanks questions");
            Robot.AssertComboBox("", "All fill-in-blanks questions");
            Robot.SetComboBox("", "All multiple-choices questions");
            Robot.AssertComboBox("", "All multiple-choices questions");
            Robot.SetComboBox("", "Pick up questions randomly");
            Robot.AssertComboBox("", "Pick up questions randomly");
        }

        // Test having a quiz of 10 questions by using Button
        [TestMethod]
        public void TestQuizOf10QuestionsByButton()
        {
            Robot.ClickButton("Start");
            for (int i = 0; i < 10; i++)
                Robot.ClickButton("Next");
            Robot.AssertWindow("Result & Solution");
            Robot.SendKeyEnterToMessageBox("Result & Solution");
            Robot.AssertWindow("基本能力測驗英文1000字");
        }

        // Test having a quiz of 10 questions by using MenuItem
        [TestMethod]
        public void TestQuizOf10QuestionsByMenuItem()
        {
            Robot.ClickMenuItem(new string[] { "Examination", "Start" });
            for (int i = 0; i < 10; i++)
                Robot.ClickMenuItem(new string[] { "Examination", "Next" });
            Robot.AssertWindow("Result & Solution");
            Robot.SendKeyEnterToMessageBox("Result & Solution");
            Robot.AssertWindow("基本能力測驗英文1000字");
        }

        #region 其他測試屬性

        // 您可以使用下列其他屬性撰寫測試: 

        ////在每項測試執行前先使用 TestInitialize 執行程式碼 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // 若要為這個測試產生程式碼，請在捷徑功能表上選取 [產生自動程式碼 UI 測試的程式碼]，並選取其中一個功能表項目。
        //}

        ////在每項測試執行後使用 TestCleanup 執行程式碼
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // 若要為這個測試產生程式碼，請在捷徑功能表上選取 [產生自動程式碼 UI 測試的程式碼]，並選取其中一個功能表項目。
        //}

        #endregion

        /// <summary>
        ///取得或設定提供目前測試回合
        ///相關資訊與功能的測試內容。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;
    }
}
