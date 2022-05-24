using Liblary.Data;
using Liblary.Data.Entities;
using System;
using System.Collections.Generic;

namespace Liblary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //LiblaryProceduresOfQuery liblaryProcedures = new LiblaryProceduresOfQuery();
            ILiblaryProceduresOfQuery liblaryProcedures = new LiblaryProceduresOfQuery();

            liblaryProcedures.DeleteData();
            liblaryProcedures.AddData();
            liblaryProcedures.UpdateData();

            //using (var context = new LiblaryContext())
            //{
            //    var author = new Author
            //    {
            //        FirstName = "William",
            //        LastName = "Shakespeare",
            //        Books = new List<Book>
            //        {
            //            new Book { Title = "Hamlet"},
            //            new Book { Title = "Othello" },
            //            new Book { Title = "MacBeth" }
            //        }
            //    };
            //    context.Add(author);
            //    context.SaveChanges();
            //}

        }
    }
}
