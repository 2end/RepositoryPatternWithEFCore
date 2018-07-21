using System.Collections.Generic;

namespace RepositoryPatternWithEFCore.Core.Domain
{
    public class Course
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Level { get; set; }

        public float FullPrice { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }
                               
        public bool IsBeginnerCourse
        {
            get { return Level == 1; }
        }
    }
}
