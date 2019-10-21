using NavigationLesson.DataAccess;
using NavigationLesson.Models;
using System;
using System.Linq;

namespace NavigationLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new LibraryContext())
            {
                Student student = new Student
                {
                    FullName = "Abay Azat"
                };

                Book book = new Book
                {
                    TitleName = "Над пропастью поржи",
                };

                context.Add(book);
                context.Add(student);
                context.Add(new BookStudent
                {
                    Book = book,
                    Student = student,
                });

                context.SaveChanges();
                var result = context.Books.ToList();
            }
        }
    }
}
