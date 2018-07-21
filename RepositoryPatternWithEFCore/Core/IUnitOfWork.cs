using RepositoryPatternWithEFCore.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPatternWithEFCore.Core
{
    public interface IUnitOfWork: IDisposable
    {
        ICourseRepository Courses { get; }
        IAuthorRepository Authors { get; }
        int Complete();
    }
}
