using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static PatternLibrary.BookCreator;

namespace PatternLibrary
{
    public interface IBookCreator
    {
        IBookCreator SettingUpTitle(Country country);
        IBookCreator SettingUpAuthor(Country country);
        IBookCreator SettingUpCover(TypeOfCover typecover);
        IBookCreator SettingUpPublisher();
        Book Create();
    }
  
}
