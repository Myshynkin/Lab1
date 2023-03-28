using PatternLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTests
{
    [TestFixture]
    public class BookCreatorTests
    {
        [TestCase(Country.GreatBritain, "The Adventure")]
        [TestCase(Country.France, "L'Île mystérieuse")]
        [TestCase(Country.USA, "The Gilded Age")]
        public void SettingUpTitle_ShouldSetTheTitleBasedOnTheCountry(Country country, string expectedTitle)
        {
           
            var bookCreator = new BookCreator(country, TypeOfCover.Hard);

            bookCreator.SettingUpTitle(country);

          
            Assert.That(bookCreator.Title, Is.EqualTo(expectedTitle));
        }

        [TestCase(Country.GreatBritain, "Conan Doyle")]
        [TestCase(Country.France, "Jules Verne")]
        [TestCase(Country.USA, "Mark Twain")]
        public void SettingUpAuthor_ShouldSetTheAuthorBasedOnTheCountry(Country country, string expectedAuthor)
        {
         
            var bookCreator = new BookCreator(country, TypeOfCover.Hard);

       
            bookCreator.SettingUpAuthor(country);

         
            Assert.That(bookCreator.Author, Is.EqualTo(expectedAuthor));
        }

        [TestCase(TypeOfCover.Soft, "Softcover")]
        [TestCase(TypeOfCover.Hard, "Hardcover")]
        public void SettingUpCover_ShouldSetTheCoverBasedOnTheTypeOfCover(TypeOfCover typeOfCover, string expectedCover)
        {
  
            var bookCreator = new BookCreator(Country.GreatBritain, typeOfCover);

            bookCreator.SettingUpCover(typeOfCover);

            Assert.That(bookCreator.Cover, Is.EqualTo(expectedCover));
        }
        [Test]
        public void SettingUpAuthor_ThrowsNotImplementedExceptionForUnsupportedCountry()
        {
            BookCreator bookCreator = new BookCreator(Country.None, TypeOfCover.Soft);


            Assert.Throws<NotImplementedException>(() => bookCreator.SettingUpAuthor(Country.None));
        }

        [Test]
        public void SettingUpCover_ShouldThrowNotImplementedException_WhenInvalidTypeOfCoverIsProvided()
        {
            var bookCreator = new BookCreator(Country.GreatBritain, TypeOfCover.None);

            Assert.Throws<NotImplementedException>(() => bookCreator.SettingUpCover(TypeOfCover.None));
        }

        [Test]
        public void SettingUpPublisher_ShouldSetThePublisherToPRH()
        {
            var bookCreator = new BookCreator(Country.GreatBritain, TypeOfCover.Hard);

            bookCreator.SettingUpPublisher();

            Assert.That(bookCreator.Publisher, Is.EqualTo("PRH"));
        }

        [Test]
        public void Create_ShouldReturnABookObjectWithTheCorrectProperties()
        {
            var bookCreator = new BookCreator(Country.GreatBritain, TypeOfCover.Hard)
                .SettingUpTitle(Country.GreatBritain)
                .SettingUpAuthor(Country.GreatBritain)
                .SettingUpCover(TypeOfCover.Hard)
                .SettingUpPublisher();

            var book = bookCreator.Create();

            Assert.That(book.Title, Is.EqualTo("The Adventure"));
            Assert.That(book.Author, Is.EqualTo("Conan Doyle"));
            Assert.That(book.Cover, Is.EqualTo("Hardcover"));
            Assert.That(book.Publisher, Is.EqualTo("PRH"));
        }
    }
}
