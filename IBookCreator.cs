using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace PatternLibrary
{
    public interface IBookCreator
    {

        BookCreator SettingUpTitle();

        BookCreator SettingUpAuthor();

        BookCreator SettingUpCover();

     
        BookCreator SettingUpPublisher();

        Book Create();
    }
}
