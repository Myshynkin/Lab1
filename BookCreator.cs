using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace PatternLibrary
{
    public class BookCreator : IBookCreator
    {
        private string title;
        private string author;
        private string cover;
        private string publisher;

  

        public BookCreator SettingUpTitle()
        {
        
            title = "The Adventure";
            return this;
        }

        public BookCreator SettingUpAuthor()
        {

            author = "Conan Doyle";
            return this;
        }

        public BookCreator SettingUpCover()
        {

            cover = "Softcover";
            return this;
        }

        public BookCreator SettingUpPublisher()
        {
            publisher = "PRH";
            return this;
        }

        public Book Create()
        {
            Book book = new Book(title, author, cover, publisher);
          
                return book;
        
        }
    }
}
