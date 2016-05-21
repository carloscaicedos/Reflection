using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class Book
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string isbn { get; set; }
        public int Books_Id { get; set; }

        public Book(string ID, string Title, string SubTitle, string Description, string Image, string isbn, int Books_Id)
        {
            this.ID = ID;
            this.Title = Title;
            this.Description = Description;
            this.Image = Image;
            this.isbn = isbn;
            this.Books_Id = Books_Id;
        }
    }
}
