using PatternLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTests
{
    [TestFixture]
    public class BookTests
    {
        [Test]
        public void TestConstructor()
        {
          
            string title = "The Adventure";
            string author = "Conan Doile";
            string cover = "Hardcover";
            string publisher = "PHR";

            Book book = new Book(title, author, cover, publisher);

            
            Assert.That(book.Title, Is.EqualTo(title));
            Assert.That(book.Author, Is.EqualTo(author));
            Assert.That(book.Cover, Is.EqualTo(cover));
            Assert.That(book.Publisher, Is.EqualTo(publisher));
        }

        [Test]
        public void TestTitle()
        {
            
            Book book = new Book("The Adventure", "Conan Doile", "Hardcover", "PHR");
            string newTitle = "CheckTitle";

            
            book.Title = newTitle;

       
            Assert.That(book.Title, Is.EqualTo(newTitle));
        }

        [Test]
        public void TestAuthor()
        {
         
            Book book = new Book("The Adventure", "Conan Doile", "Hardcover", "PHR");
            string newAuthor = "CheckAuthor";

         
            book.Author = newAuthor;

            Assert.That(book.Author, Is.EqualTo(newAuthor));
        }

        [Test]
        public void TestCover()
        {
         
            Book book = new Book("The Adventure", "Conan Doile", "Hardcover", "PHR");
            string newCover = "CheckCover";

           
            book.Cover = newCover;

          
            Assert.That(book.Cover, Is.EqualTo(newCover));
        }

        [Test]
        public void TestPublisher()
        {
           
            Book book = new Book("The Great Gatsby", "Conan Doile", "Hardcover", "PHR");
            string newPublisher = "CheckPublicher";

         
            book.Publisher = newPublisher;

          
            Assert.That(book.Publisher, Is.EqualTo(newPublisher));
        }

        [Test]
        public void TestToString()
        {
            
            Book book = new Book("The Adventure", "Conan Doile", "Hardcover", "PHR");
            string expectedString = "Book title=The Adventre, author=Conan Doile, cover=Hardcover, publisher=PHR";

            
            string actualString = book.ToString();

            Assert.That(actualString, Is.EqualTo(expectedString));
        }
    }
}
