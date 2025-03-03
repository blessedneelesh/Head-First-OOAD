using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1.Book_start
{
    public class BookSpec
    {
        private Format format;
        private Genre genre;
        private Language language;
        private string title;

        public BookSpec(Format _format, Genre _genre, Language _language, string _title)
        {
            this.format = _format;
            this.genre = _genre;
            this.language = _language;
            this.title = _title;
        }


        public string GetTitle()
        {
            return title;
        }

        public Genre GetGenre()
        {
            return genre;
        }

        public Language GetLanguage()
        {
            return language;
        }

        public Format GetFormat()
        {
            return format;
        }

        public bool CompareBookSpec(BookSpec otherSpec)
        {
           

            if (otherSpec.GetFormat() != format)
                return false;
            if (otherSpec.GetGenre() != genre)
                return false;
            if (otherSpec.GetLanguage() != language)
                return false;
            String Title = otherSpec.GetTitle().ToLower();
            if ((Title != null) && (!Title.Equals("")) &&
                    (!Title.Equals(title.ToLower())))
                return false;
            return true;
        }
    }
}
