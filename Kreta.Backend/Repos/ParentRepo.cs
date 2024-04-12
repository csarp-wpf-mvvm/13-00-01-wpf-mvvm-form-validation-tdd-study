﻿using Kreta.Shared.Models.SchoolCitizens;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Repos
{
    public class ParentRepo<TDbContext> : RepositoryBase<TDbContext, Parent>, IParentRepo
        where TDbContext : DbContext
    {
        public ParentRepo(IDbContextFactory<TDbContext> dbContextFactory) : base(dbContextFactory)
        {

        }
    }
}
