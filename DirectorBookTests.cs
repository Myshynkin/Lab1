using PatternLibrary;

namespace PatternsTests
{
    [TestFixture]
    public class DirectorBookTests
    {
        [Test]
        public void CheckTitle()
        {

            BookCreator builder = new BookCreator(Country.France, TypeOfCover.Hard);
            DirectorBook engineer = new DirectorBook(builder);

          
            Book book = engineer.CreationOfBook(Country.France, TypeOfCover.Hard);

           
            Assert.That(book.Title, Is.EqualTo("The Adventure"));
        }
        [Test]
        public void CheckAuthor()
        {

            BookCreator builder = new BookCreator(Country.France, TypeOfCover.Hard);
            DirectorBook engineer = new DirectorBook(builder);

            
            Book book = engineer.CreationOfBook(Country.France, TypeOfCover.Hard);


            Assert.That(book.Author, Is.EqualTo("Conan Doyle"));
        }
        [Test]
        public void CheckCover()
        {

            BookCreator builder = new BookCreator(Country.France, TypeOfCover.Hard);
            DirectorBook engineer = new DirectorBook(builder);


            Book book = engineer.CreationOfBook(Country.USA, TypeOfCover.Hard);


            Assert.That(book.Cover, Is.EqualTo("Softcover"));
        }
        [Test]
        public void CheckPublisher()
        {

            BookCreator builder = new BookCreator(Country.France, TypeOfCover.Hard);
            DirectorBook engineer = new DirectorBook(builder);


            Book book = engineer.CreationOfBook(Country.France, TypeOfCover.Hard);


            Assert.That(book.Publisher, Is.EqualTo("PRH"));
        }
        [Test]
        public void DirectorBook_ThrowsArgumentException_WhenBuilderIsNull()
        {
            BookCreator builder = null;

            Assert.Throws<ArgumentException>(() => new DirectorBook(builder));
        }
    }
}