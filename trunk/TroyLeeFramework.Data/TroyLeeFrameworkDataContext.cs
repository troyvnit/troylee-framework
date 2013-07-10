using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using TroyLeeFramework.Domain.Entities;

namespace TroyLeeFramework.Data
{
    public class TroyLeeFrameworkDataContext : DbContext
    {
        public TroyLeeFrameworkDataContext(string connStringName) :
            base(connStringName)
        {
            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.ProxyCreationEnabled = false;
        }
        public virtual void Commit()
        {
            base.SaveChanges();
        }
    }
}
