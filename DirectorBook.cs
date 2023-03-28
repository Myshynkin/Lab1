using PatternLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace PatternLibrary
{
    public class DirectorBook
    {

        private BookCreator builder;


        public DirectorBook(BookCreator builder)
        {
            if (builder == null)
            {
                throw new ArgumentException("DirectorBook can't work without Book Creator!");
            }
            this.builder = builder;
        }

        public Book CreationOfBook(Country country, TypeOfCover typeOfCover)
    {
            return builder.SettingUpTitle(country).SettingUpAuthor(country).SettingUpCover(typeOfCover).SettingUpPublisher().Create();
        }
    }
}
