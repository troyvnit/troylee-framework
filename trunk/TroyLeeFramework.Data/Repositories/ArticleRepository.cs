using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TroyLeeFramework.Data.Repositories
{
    using Catel.Data.Repositories;

    using TroyLeeFramework.Domain.Entities;

    public class ArticleRepository : EntityRepositoryBase<Article, long>, IArticleRepository
    {
        public ArticleRepository(TroyLeeFrameworkDataContext context)
            : base(context)
        {
        }
    }
    public interface IArticleRepository : IEntityRepository<Article, long>
    {
        
    }
}
