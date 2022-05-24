using Liblary.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liblary.Data
{
    public class LiblaryProceduresOfQuery : ILiblaryProceduresOfQuery
    {
        private LiblaryContext _context;

        public LiblaryProceduresOfQuery()
        {
            LiblaryContext context = new LiblaryContext();
            _context = context;
        }
        public void AddData()
        {
            var author = new Author
            {
                FirstName = "Khaled",
                LastName = "Hosseini",
                Books = new List<Book>
                    {
                        new Book { Title = "The Kite Runner"}
                    }
            };

            _context.Add(author);
            _context.SaveChanges();
        }

        public void DeleteData()
        {
            var std = _context.Authors.First<Author>();
            _context.Authors.Remove(std);
            _context.SaveChanges();
        }

        public void UpdateData()
        {
            var std = _context.Authors.First<Author>();
            std.FirstName = "Steve";
            _context.SaveChanges();
        }
    }
}
