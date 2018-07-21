using RepositoryPatternWithEFCore.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPatternWithEFCore.Core.Repositories
{
    public interface IAuthorRepository: IRepository<Author>
    {
        Author GetAuthorWithCourses(int id);
    }
}
