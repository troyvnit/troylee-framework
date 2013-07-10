using System.Collections.Generic;

namespace TroyLeeFramework.Domain.Entities
{
    public class ArticleCategory : BaseEntity
    {
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool IsDeleted { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
    }
}
