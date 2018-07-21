using RepositoryPatternWithEFCore.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPatternWithEFCore.Core.Repositories
{
    public interface ICourseRepository: IRepository<Course>
    {
        IEnumerable<Course> GetTopSellingCourses(int count);
        IEnumerable<Course> GetCoursesWithAuthors(int pageIndex, int pageSize);
    }
}
