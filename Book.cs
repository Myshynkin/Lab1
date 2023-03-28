using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace PatternLibrary
{
    public class Book
    {
        private string title;
        private string author;
        private string cover;
        private string publisher;

  
        public Book(string title, string author, string cover, string publisher)
        {
            this.title = title;
            this.author = author;
            this.cover = cover;
            this.publisher = publisher;
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string Cover
        {
            get { return cover; }
            set { cover = value; }
        }

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Book title=").Append(title).Append(", author=").Append(author).Append(", cover=").Append(cover).Append(", publisher=").Append(publisher);
            return builder.ToString();
        }

       
    }
}