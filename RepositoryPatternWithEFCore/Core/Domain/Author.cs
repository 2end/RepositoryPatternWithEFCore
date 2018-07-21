using System.Collections.Generic;

namespace RepositoryPatternWithEFCore.Core.Domain
{
    public class Author
    {
        public Author()
        {
            Courses = new List<Course>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public List<Course> Courses { get; set; }
    }
}
