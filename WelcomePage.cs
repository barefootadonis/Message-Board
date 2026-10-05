namespace Final_project
{
    public partial class WelcomePage : Form
    {
        private string _usersPath;
        private static List<User> _users = new List<User>();
        private bool _isSigningUp = false;
        public WelcomePage()
        {
            InitializeComponent();
            _usersPath = Path.Combine(Application.StartupPath, "UserInformation.txt");

            LoadUsers();

            // Hide password and security question fields
            lblQuestion.Visible = false;
            lblPassword.Visible = false;
            txtPassword.Visible = false;
            txtUsername.Visible = false;
            btnEnter.Visible = false;
            btnBack.Visible = false;
            this.KeyPreview = true;
        }

        private void LoadUsers()
        {
            if (!File.Exists(_usersPath))
            {
                // Create the file if it doesn't exist
                File.Create(_usersPath).Close();
                return;
            }


            string[] lines = File.ReadAllLines(_usersPath);

            for (int i = 0; i < lines.Length; i += 2)
            {
                string username = lines[i];
                string password = lines[i + 1];

                User user = new User(username, password);
                _users.Add(user);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            makeSigninDetailsVisible();
            _isSigningUp = false;
            hideMainMenuAfterUse();
            lblWarning.Text = "Please enter your username and password.";
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            makeSigninDetailsVisible();
            _isSigningUp = true;
            hideMainMenuAfterUse();
            lblWarning.Text = "Create your new username and password.";
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            ResetToMainMenu();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            lblWarning.Text = "";

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();


            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                lblWarning.Text = "Please enter a username.";
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblWarning.Text = "Please enter a password.";
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtUsername.Text) && string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblWarning.Text = "Please enter a username and password.";
                return;
            }

            // Check if user exists
            User existingUser = _users.Find(u => u.Username == username);


                if (_isSigningUp)
            {
                // Sign Up process
                if (existingUser != null)
                {
                    lblWarning.Text = "Username already exists.";
                    return;
                }

                // Create new user
                User newUser = new User(username, password);
                _users.Add(newUser);

                // Append new user to file
                using (StreamWriter sw = new StreamWriter(_usersPath, true))
                {
                    sw.WriteLine(username);
                    sw.WriteLine(password);
                }

                lblWarning.Text = "Sign up successful! You can now log in.";
                _isSigningUp = false;
            }
            else
            {
                // Login process
                if (existingUser == null)
                {
                    lblWarning.Text = "Username does not exist.";
                    txtUsername.Clear();
                    return;
                }

                if (!existingUser.CheckPassword(password))
                {
                    lblWarning.Text = "Incorrect password.";
                    txtPassword.Clear();
                    return;
                }
            }

            this.Hide();
            MessageBoard messageBoard = new MessageBoard(txtUsername.Text.Trim());
            messageBoard.ShowDialog();
        }

        private void makeSigninDetailsVisible()
        {
            lblQuestion.Visible = true;
            lblPassword.Visible = true;
            txtPassword.Visible = true;
            txtUsername.Visible = true;
            btnEnter.Visible = true;
            btnBack.Visible = true;
        }

        private void hideMainMenuAfterUse()
        {
            btnLogin.Visible = false;
            btnSignUp.Visible = false;
        }

        private void ResetToMainMenu()
        {
            lblQuestion.Visible = false;
            lblPassword.Visible = false;
            txtPassword.Visible = false;
            txtUsername.Visible = false;
            btnEnter.Visible = false;
            btnBack.Visible = false;

            btnLogin.Visible = true;
            btnSignUp.Visible = true;

            txtUsername.Text = "";
            txtPassword.Text = "";

            lblWarning.Text = "";

            _isSigningUp = false;
        }

        private void WelcomePage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && btnEnter.Visible)
            {
                btnEnter.PerformClick();
            }
            if (e.KeyCode == Keys.Escape && btnBack.Visible)
            {
                btnBack.PerformClick();
            }
        }
    }
}
