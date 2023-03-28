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
        private Country _country;
        private TypeOfCover _typeOfCover;

        public BookCreator(Country country, TypeOfCover typeOfCover)
        {
            _country = country;
            _typeOfCover = typeOfCover;
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

        public  IBookCreator SettingUpTitle(Country country)
        {
            if (country == Country.GreatBritain)
            {
                title = "The Adventure";
                return this;
            }
            else if (country == Country.France)
            {
                title = "L'Île mystérieuse";
                return this;
            }
            else if (country == Country.USA)
            {
                title = "The Gilded Age";
                return this;
            }

            else
            {
                throw new NotImplementedException("Not supported country");
            }
        }

        public IBookCreator SettingUpAuthor(Country country)
        {
            if (country == Country.GreatBritain)
            {
                author = "Conan Doyle";
                return this;
            }
            else if (country == Country.France)
            {
                author = "Jules Verne";
                return this;
            }
            else if (country == Country.USA)
            {
                author = "Mark Twain";
                return this;
            }
            else
            {
                throw new NotImplementedException("Not supported country");
            }
        }

        public IBookCreator SettingUpCover(TypeOfCover typecover)
        {
            if (typecover == TypeOfCover.Soft)
            {
                cover = "Softcover";
                return this;
            }
            if (typecover == TypeOfCover.Hard)
            {
                cover = "Hardcover";
                return this;
            }
            else
            {
              throw new NotImplementedException("No cover");
            }
        }

        public IBookCreator SettingUpPublisher()
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
