using System;
using System.Collections.Generic;
using System.Text;

namespace Final_project
{
    public class User
    {
        public string Username { get; private set; }
        public string Password { get; private set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public bool CheckPassword(string input)
        {
            return Password == input;
        }

    }
}

