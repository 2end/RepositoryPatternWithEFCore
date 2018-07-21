using Microsoft.EntityFrameworkCore;
using RepositoryPatternWithEFCore.Core.Domain;
using RepositoryPatternWithEFCore.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepositoryPatternWithEFCore.Persistence.Repositories
{
    public class AuthorRepository: Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(PlutoContext context) : base(context)
        {
        }               

        public PlutoContext PlutoContext
        {
            get { return Context as PlutoContext; }
        }

        public Author GetAuthorWithCourses(int id)
        {
            return PlutoContext.Authors.Include(a => a.Courses).SingleOrDefault(a => a.Id == id);
        }
    }
}
