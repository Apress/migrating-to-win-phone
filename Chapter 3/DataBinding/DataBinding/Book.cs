using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.Generic;

namespace DataBinding
{
    public class Book
    {
        public string Title { get; set; }
        public string Authors { get; set; }
        public string Publisher { get; set; }
        public string ISBN { get; set; }


        public static Book ABook
        {
            get
            {
                return new Book()
                {
                    Title = "Programming Windows Phone",
                    Authors = "Jesse Liberty and Jeff Blankenburg",
                    ISBN = "143023816X",
                    Publisher = "APress"
                };
            }
        }

        public static List<Book> Books
        {
            get
            {
                return new List<Book>()
                {
                    new Book() 
                    { 
                        Title = "Programming Windows Phone",
                        Authors = "Jesse Liberty and Jeff Blankenburg",
                        ISBN="143023816X",
                        Publisher = "APress"
                    },
                    new Book()
                    {
                        Title = "Programming Reactive Extensions and LINQ",
                        Authors = "Jesse Liberty and Paul Betts",
                        ISBN = "1430237473",
                        Publisher = "APress"
                    },
                    new Book()
                    {
                        Title = "Programming Windows 8 with HTML 5",
                        Authors = "Jesse Liberty",
                        ISBN = "TBD",
                        Publisher = "APress"
                    },
                };
            }
        }
    }
}
