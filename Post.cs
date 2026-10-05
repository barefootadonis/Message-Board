using System;
using System.Globalization;
using System.Collections.Generic;
using System.IO;

public class Post
{
    // Data
    public DateTime Posted { get; private set; }
    public string Username { get; private set; }
    public string Text { get; private set; }
    public bool Edited { get; private set; }

    // Constructor
    public Post(DateTime posted, string username, string text, bool edited)
    {
        Posted = posted;
        Username = username;
        Text = text;
        Edited = edited;
    }

    public void SetText(string newText)
    {
        Text = newText;
    }

    public void RegisterEdit()
    {
        Edited = true;
    }

    // Display format
    public override string ToString()
    {
        string flag = Edited ? " (edited)" : "";
        return $"{Posted:ddd dd-MM-yyyy HH:mm} - {Username}: \n{Text}{flag}";
    }

    public string ToFileFormat()
    {
        return Posted.ToString("ddd dd-MM-yyyy HH:mm") + "\n" +
               Username + "\n" +
               Text + "\n" +
               Edited.ToString().ToLower();
    }


    public static List<Post> LoadAllPosts(string path)
    {
        List<Post> posts = new List<Post>();

        if (!File.Exists(path)) 
            return posts;

        string[] lines = File.ReadAllLines(path);

        for (int i = 0; i < lines.Length; i += 4)
        {
            DateTime posted = DateTime.Parse(lines[i]);
            string username = lines[i + 1];
            string text = lines[i + 2];
            bool edited = bool.Parse(lines[i + 3]);

            posts.Add(new Post(posted, username, text, edited));
        }

        return posts;
    }
    
    public static void SaveAllPosts(string path, List<Post> posts)
    {
        using (StreamWriter sw = new StreamWriter(path, false))
        {
            foreach (Post p in posts)
            {
                sw.WriteLine(p.Posted.ToString("ddd dd-MM-yyyy HH:mm"));
                sw.WriteLine(p.Username);
                sw.WriteLine(p.Text);
                sw.WriteLine(p.Edited.ToString().ToLower());
            }
        }
    }

}


