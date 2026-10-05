using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Final_project
{
    public partial class EditMessages : Form
    {
        private string _username;
        private string _postsPath;
        private static List<Post> _posts = new List<Post>();

        public EditMessages(string username)
        {
            InitializeComponent();
            _username = username;
            _postsPath = Path.Combine(Application.StartupPath, "posts.txt");

            LoadUserMessages();
        }

        public EditMessages()
        {
        }

        private void LoadUserMessages()
        {
            //_posts.Clear();
            lbPastMessages.Items.Clear();

            _posts = Post.LoadAllPosts(_postsPath);

            // show all users past messages

            foreach (Post post in _posts)
            {
                if (post.Username == _username)
                {
                    lbPastMessages.Items.Add(post);
                }
            }

            //string[] lines = File.ReadAllLines(_postsPath);

            //for (int i = 0; i < lines.Length; i += 4)
            //{
            //    // convert datetime to string
            //    DateTime date = DateTime.Parse(lines[i]);
            //    string username = lines[i + 1];
            //    string text = lines[i + 2];
            //    string edited = (lines[i + 3]);
            //    Post post = new Post(date, username, text, false);
            //    _posts.Add(post);
            //    if (username == _username)
            //    {
            //        //string message = $"{date} - {username}\n {text}";
            //        lbPastMessages.Items.Add(post);
            //    }
            //}
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomePage LogOut = new WelcomePage();
            LogOut.ShowDialog();
        }

        private void btnOthersMessages_Click(object sender, EventArgs e)
        {
            this.Hide();
            OthersMessages OthersMessagesForm = string.IsNullOrEmpty(_username) ? new OthersMessages() : new OthersMessages(_username);
            OthersMessagesForm.ShowDialog();
        }

        private void btnMessageBoard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbPastMessages.SelectedItem == null) return;

            Post selectedPost = lbPastMessages.SelectedItem as Post;
            _posts.Remove(selectedPost);

            int index = lbPastMessages.SelectedIndex;
            lbPastMessages.Items.RemoveAt(index);

            Post.SaveAllPosts(_postsPath, _posts);
            //int index = lbPastMessages.SelectedIndex;
            //if (index == -1) return;
            //Post selectedItem = lbPastMessages.SelectedItem as Post;
            //_posts.Remove(selectedItem);
            //lbPastMessages.Items.RemoveAt(index);

            //if (index < lbPastMessages.Items.Count) {
            //    lbPastMessages.SelectedIndex = index;
            //}

            //rewritefile();
        }
        private void lbPastMessages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbPastMessages.SelectedItem == null) return;
            Post p = lbPastMessages.SelectedItem as Post;

            txtEditMessage.Text = p.Text;
            // todo: check for null

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lbPastMessages.SelectedItem == null) return;

            // todo: check for null
            Post p = lbPastMessages.SelectedItem as Post;

            p.SetText(txtEditMessage.Text);
            p.RegisterEdit();

            int index = lbPastMessages.SelectedIndex;
            lbPastMessages.Items[index] = p;

            Post.SaveAllPosts(_postsPath, _posts);
            //lbPastMessages.Items.RemoveAt(index);
            //lbPastMessages.Items.Insert(index, p);
            //p.RegisterEdit();

            //rewritefile();

        }

        private void rewritefile()
        {
            // rewrite the file with the updated messages
            using (StreamWriter sw = new StreamWriter(_postsPath, false))
            {
                foreach (Post item in _posts)
                {
                    sw.WriteLine(item.ToFileFormat());
                }
            }
        }


    }
}
// finish the code in EditMessages.cs
// Add passwords
// finish presentation
// implement classes
// add comments
