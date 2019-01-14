
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Runtime.Remoting.Contexts;
using static System.Net.Mime.MediaTypeNames;

namespace AutoLevelDB
{
    class Program
    {
        static void Main(string[] args)
        {
  
            UserContext userContext = new UserContext();
            ArticleContext articleContext = new ArticleContext();
            CommentContext commentContext = new CommentContext();
            AuthorContext authorContext = new AuthorContext();

            Console.WriteLine("1-Login");
            Console.WriteLine("2-Register");
            string chooseStr = Console.ReadLine();
            int choose = int.Parse(chooseStr);

            Console.WriteLine("Login: ");
            string login = Console.ReadLine();
            Console.WriteLine("Password: ");
            string password = Console.ReadLine();
            int ID = 0;
            if (choose == 2)
            {
                User user = new User
                {
                    Login = login,
                    Password = password
                };
                userContext.Users.Add(user);
                ID = user.ID;
                userContext.SaveChanges();
                Console.WriteLine(ID);
                Environment.Exit(0);

            }
            else if (choose == 1)
            {
                var users = userContext.Users.ToList();
                foreach (var user in users)
                {
                    if (user.Login == login && user.Password == password)
                    {
                        ID = user.ID;
                        Console.WriteLine(ID);

                    }

                }
                if (ID == 0)
                {
                    Environment.Exit(0);

                }
            }
            Console.Clear();


            Console.WriteLine("1-Create new");
            Console.WriteLine("2-All news");
            Console.WriteLine("3-Add comment");
            string chooseString = Console.ReadLine();
            int chooseInt = int.Parse(chooseString);

            if (chooseInt == 1)
            {

                Console.WriteLine("Title: ");
                string title = Console.ReadLine();
                Console.WriteLine("Text: ");
                string text = Console.ReadLine();

                Article article = new Article
                {

                    ID_user = ID,
                    Title = title,
                    Text = text,
                    DateTime = DateTime.Now

                };
                articleContext.Articles.Add(article);
                articleContext.SaveChanges();

                Environment.Exit(0);

            }
            else if (chooseInt == 2)
            {
                var articles = articleContext.Articles.ToList();
                var users = userContext.Users.ToList();
                var comments = commentContext.Comments.ToList();


                foreach (var article in articles)
                {
                    foreach (var user in users)
                    {
                        if (user.ID == article.ID_user)
                        {
                            Console.WriteLine("-----------------------------------------------");
                            Console.WriteLine("User: " + user.Login);
                            Console.WriteLine("Title: " + article.Title);
                            Console.WriteLine("Text: " + article.Text);
                            Console.WriteLine("Date and Time: " + article.DateTime);
                            Console.WriteLine("---------------------Comments--------------------");
                            foreach (var comment in comments)
                            {
                                if (comment.ID_new == article.ID)
                                {
                                    foreach (var userItem in users)
                                    {
                                        if (userItem.ID == comment.ID_user) {
                                            Console.WriteLine("User: "+comment.ID_user);
                                        Console.WriteLine("Text: "+comment.Text);
                                        }
                                    }
                                }

                            }
                        }
                    }
                }
            }
            else if (chooseInt == 3)
            {
                var articles = articleContext.Articles.ToList();
                var users = userContext.Users.ToList();
                var comments = commentContext.Comments.ToList();

                int chooseId = 0;
                foreach (var article in articles)
                {
                    foreach (var user in users)
                    {
                        if (user.ID == article.ID_user)
                        {

                            Console.WriteLine("ID: " + article.ID);
                            Console.WriteLine("User: " + user.Login);
                            Console.WriteLine("Title: " + article.Title);
                            Console.WriteLine("Text: " + article.Text);
                            Console.WriteLine("Date and Time: " + article.DateTime);
                            Console.WriteLine("-----------------------------------------------");

                        }
                    }
                }
                Console.WriteLine("Choose id: ");

                string str= Console.ReadLine();
                chooseId = int.Parse(str);

                foreach (var article in articles)
                {
                     
                        if (article.ID == chooseId)
                        {
                   
                        Console.WriteLine("Your comment");
                        string commentText = Console.ReadLine();

                        Comment comment = new Comment()
                        {
                            ID_new = article.ID,
                            ID_user = ID,
                            Text = commentText,
                            DateTime = DateTime.Now
                        };
                        commentContext.Comments.Add(comment);
                        commentContext.SaveChanges();
                        }
                    
                }
               
            }

 
                Console.Read();
            }
        }
    }


