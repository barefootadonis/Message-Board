using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Final_project
{
    public partial class OthersMessages : Form
    {
        private string _postsPath;
        private string _username;

        public OthersMessages()
        {
            InitializeComponent();
            _postsPath = Path.Combine(Application.StartupPath, "posts.txt");
            LoadAllMessages();

        }
        public OthersMessages(string username)
        {
            InitializeComponent();
            _username = username;
            _postsPath = Path.Combine(Application.StartupPath, "posts.txt");
            LoadAllMessages();
        }

        

        private void LoadAllMessages()
        {
            List<Post> posts = Post.LoadAllPosts(_postsPath);

            if (posts.Count == 0)
            {
                txtMessages.Text = "No messages available.";
                return;
            }

            StringBuilder sb = new StringBuilder();

            foreach (Post p in posts)
            {
                sb.AppendLine(p.ToString());
                sb.AppendLine(); // blank line between messages
            }

            txtMessages.Text = sb.ToString();
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditMessages EditForm = new EditMessages(_username);
            EditForm.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomePage LogOut = new WelcomePage();
            LogOut.ShowDialog();
        }

        private void btnMessageBoard_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBoard messageBoardForm = new MessageBoard(_username);
            messageBoardForm.ShowDialog();
        }
    }
}
