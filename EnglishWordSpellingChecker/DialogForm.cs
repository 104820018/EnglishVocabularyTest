using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace EnglishWordSpellingChecker
{
    public class DialogForm : Form
    {
        private Button _ok;
        private Label _programName;
        private Label _myName;
        private Label _rights;
        private Label _comma;
        private LinkLabel _universityName;
        private LinkLabel _departmentName;
        private PictureBox _icon;
        private Bitmap _image;
        // Constants
        private const int ICON_WIDTH = 50;
        private const int ICON_HEIGHT = 50;
        private const int INITIAL_X_POINT = 10;
        private const int INITIAL_Y_POINT = 10; 

        public DialogForm()
        {
            InitializeComponent();
            ControlBox = false;
            MaximizeBox = false;
            MinimizeBox = false;
            Text = "About Spelling Checker.";

            AddIcon();      

            _programName.Location = new Point(_icon.Right, _icon.Top);
            AddLabel(_programName, "Spelling Checker 1000 Words");

            _departmentName.Location = new Point(_programName.Left, _programName.Bottom);
            AddLinkLabel(_departmentName, "CSIE");
            _departmentName.LinkClicked += new LinkLabelLinkClickedEventHandler(ClickDepartmentNameLinkLabel);

            _comma.Location = new Point(_departmentName.Right, _departmentName.Top);
            AddLabel(_comma, ", ");

            _universityName.Location = new Point(_comma.Right, _comma.Top);
            AddLinkLabel(_universityName, "NTUT");
            _universityName.LinkClicked += new LinkLabelLinkClickedEventHandler(ClickUniversityNameLinkLabel);

            _rights.Location = new Point(_departmentName.Left, _departmentName.Bottom);
            AddLabel(_rights, "All rights reserved.");

            _myName.Location = new Point(_rights.Left, _rights.Bottom);
            AddLabel(_myName, "Ivy Tuan (段寶鈞)");

            AcceptButton = _ok;
            _ok.Location = new Point(_programName.Right - _ok.Width, _myName.Bottom);
            AddButton(_ok, "OK");
            _ok.Click += new EventHandler(ClickOkButton);

            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        // Initialize every component in this form
        private void InitializeComponent()
        {
            _icon = new PictureBox();
            _programName = new Label();
            _departmentName = new LinkLabel();
            _comma = new Label();
            _universityName = new LinkLabel();
            _rights = new Label();
            _myName = new Label();
            _ok = new Button();
        }

        // Add Icon
        private void AddIcon()
        {
            _icon.SizeMode = PictureBoxSizeMode.StretchImage;
            _image = new Bitmap("../../../Source/Dictionary_ICON.png");
            _icon.ClientSize = new Size(ICON_WIDTH, ICON_HEIGHT);
            _icon.Location = new Point(INITIAL_X_POINT, INITIAL_Y_POINT);
            _icon.Image = (Image)_image;
            Controls.Add(_icon);
        }

        // Add Label
        private void AddLabel(Label label, string name)
        {
            label.Text = name;
            Controls.Add(label);
            label.AutoSize = true;
        }

        // Add LinkLabel
        private void AddLinkLabel(LinkLabel linkLabel, string name)
        {
            linkLabel.Text = name;
            Controls.Add(linkLabel);
            linkLabel.AutoSize = true;
        }

        // Add Button
        private void AddButton(Button button, string name)
        {
            button.Text = name;
            button.AutoSize = true;
            Controls.Add(button);
        }

        // Click department label, a browser will be opened and the homepage of department is shown
        private void ClickDepartmentNameLinkLabel(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _departmentName.LinkVisited = true;
            System.Diagnostics.Process.Start("http://csie.ntut.edu.tw/csie/index_i.htm");
        }

        // Click university label, a browser will be opened and the homepage of university is shown
        private void ClickUniversityNameLinkLabel(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _universityName.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.ntut.edu.tw/bin/home.php");
        }

        // Click Ok button and close this form
        private void ClickOkButton(object sender, EventArgs e)
        {
            Close();
        }
    }
}
