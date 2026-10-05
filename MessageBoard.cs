using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Final_project
{
    public partial class MessageBoard : Form
    {
        private string _username;
        private string _postsPath;

        public MessageBoard(string username)
        {
            InitializeComponent();
            _username = username;
            _postsPath = Path.Combine(Application.StartupPath, "posts.txt");

            LoadUserMessages();
        }

        public MessageBoard()
        {
            InitializeComponent();
            _postsPath = Path.Combine(Application.StartupPath, "posts.txt");
        }

        private void LoadUserMessages()
        {
            // sHOW LAST 3 MESSAGES FROM THE USER

            string[] lines = File.ReadAllLines(_postsPath);

            for (int i = 0; i < lines.Length; i += 4)
            {
                string date = lines[i];
                string username = lines[i + 1];
                string text = lines[i + 2];
                if (username == _username)
                {
                    string message = $"{date} - {username}\n {text}";
                    lbPastMessages.Items.Add(message);
                }
            }

            int excessMessages = lbPastMessages.Items.Count - 3;
            for (int i = 0; i < excessMessages; i++)
            {
                lbPastMessages.Items.RemoveAt(0);
            }
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            lblWarning.Text = "";

            if (string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                lblWarning.Text = "Please type a message.";
                return;
            }

            //string message = $"{DateTime.Now:ddd dd-MM-yyyy HH:mm} - {_username}\n {txtMessage.Text}";
            Post post = new Post(DateTime.Now, _username, txtMessage.Text, false);

            lbPastMessages.Items.Add(post);
            while (lbPastMessages.Items.Count > 3)
            {
                lbPastMessages.Items.RemoveAt(0);
            }

            storePost(_username, txtMessage.Text.Trim());

            txtMessage.Clear();
            lblWarning.Text = "";
        }

        private void storePost(string username, string text)
        {
            string path = _postsPath;
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(DateTime.Now.ToString("ddd dd-MM-yyyy HH:mm"));
                sw.WriteLine(username);
                sw.WriteLine(text);
                sw.WriteLine("False");
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditMessages EditForm = new EditMessages(_username);
            EditForm.ShowDialog();
            this.Show();
        }

        private void btnOthersMessages_Click(object sender, EventArgs e)
        {
            this.Hide();
            OthersMessages OthersMessagesForm = new OthersMessages(_username);
            OthersMessagesForm.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomePage LogOut = new WelcomePage();
            LogOut.ShowDialog();
        }
    }
}
