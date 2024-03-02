using System;

namespace _02._Articles
{

    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public string Title { get; private set; }  
        public string Content { get; private set; }   
        public string Author { get; private set; }  

        public void Edit(string newContent)
        {
            this.Content = newContent;
        }
        public void ChangeAuthor (string newAuthor)
        {
            this.Author = newAuthor;
        }
        public void Rename (string newTitle)
        {
            this.Title = newTitle;  
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] articleArgs = Console.ReadLine()
                                  .Split(", ");

            string title = articleArgs[0];
            string content = articleArgs[1];    
            string author = articleArgs[2]; 

            Article article = new Article(title, content, author);

            int commandsNumToCome = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsNumToCome; i++)
            {
                string[] commandArgs = Console.ReadLine()
                                      .Split(": ");
                string command = commandArgs[0];
                switch (command)
                {
                    case "Rename":
                        string newTitle = commandArgs[1];
                        article.Rename(newTitle);
                        break;

                    case "Edit":
                        string newContent = commandArgs[1];
                        article.Edit(newContent);
                        break;

                    case "ChangeAuthor":
                        string newAuthor = commandArgs[1];
                        article.ChangeAuthor(newAuthor);
                        break;
                }
            }
            Console.WriteLine(article);
        }
    }
}
