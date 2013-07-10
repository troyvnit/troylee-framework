using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TroyLeeFramework.Domain.Entities
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            CreateOn = DateTime.Now;
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreateOn { get; set; }
        public long? CreateBy { get; set; }
    }
}
