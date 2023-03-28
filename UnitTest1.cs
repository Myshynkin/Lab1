using PatternLibrary;

namespace PatternsTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void CheckTitle()
        {
           
            BookCreator builder = new BookCreator();
            DirectorBook engineer = new DirectorBook(builder);

          
            Book book = engineer.CreationOfBook();

           
            Assert.That(book.title, Is.EqualTo("The Adventure"));
        }
        [Test]
        public void CheckAuthor()
        {
            
            BookCreator builder = new BookCreator();
            DirectorBook engineer = new DirectorBook(builder);

            
            Book book = engineer.CreationOfBook();

          
            Assert.That(book.author, Is.EqualTo("Conan Doyle"));
        }
        [Test]
        public void CheckCover()
        {

            BookCreator builder = new BookCreator();
            DirectorBook engineer = new DirectorBook(builder);


            Book book = engineer.CreationOfBook();


            Assert.That(book.cover, Is.EqualTo("Softcover"));
        }
        [Test]
        public void CheckPublisher()
        {

            BookCreator builder = new BookCreator();
            DirectorBook engineer = new DirectorBook(builder);


            Book book = engineer.CreationOfBook();


            Assert.That(book.publisher, Is.EqualTo("PRH"));
        }
    }
}