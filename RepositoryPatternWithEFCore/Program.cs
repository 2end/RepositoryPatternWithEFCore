using RepositoryPatternWithEFCore.Core.Domain;
using RepositoryPatternWithEFCore.Persistence;
using System;

namespace RepositoryPatternWithEFCore
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (UnitOfWork db = new UnitOfWork(new PlutoContext()))
            {
                var author = new Author
                {
                    Name = "a1"
                };

                db.Authors.Add(author);
                db.Complete();

                var course = new Course
                {
                    Name = "c1",
                    Description = "d1",
                    AuthorId = author.Id                    
                };

                db.Courses.Add(course);
                db.Complete();

                var courseDb = db.Courses.Get(course.Id);
                Console.WriteLine($"Name: {course.Name}");

                var authorDb = db.Authors.Get(author.Id);
                Console.WriteLine($"Name: {author.Name}");

                db.Courses.Remove(course);
                db.Authors.Remove(author);
                db.Complete();
            }

            Console.ReadLine();
        }
    }
}
