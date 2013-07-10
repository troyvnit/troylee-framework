using System;
using System.Collections.Generic;

namespace TroyLeeFramework.Domain.Entities
{
    public class Article : BaseEntity
    {
        public string Description { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public int OrderID { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsPublished { get; set; }
        public bool IsNew { get; set; }
        public DateTime UpdatedOn { get; set; }
        public long UpdatedBy { get; set; }
        public virtual ICollection<ArticleCategory> ArticleCategories { get; set; }
    }
}
