using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Shared.Entities.Abstract
{
    public abstract class EntityBase
    {
        public virtual int Id { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;//oluşturulma tarihi
        public virtual  DateTime ModifiedDate { get; set; } = DateTime.Now;//Düzenleme Tarihi
        public virtual bool IsDeleted { get; set; } = false;//silindi mi?
        public virtual bool IsActive { get; set; } = true;
        public virtual string CreatedByName { get; set; } = "Admin";
        public virtual  string ModifiedByName { get; set; } = "Admin";
        public virtual string Note { get; set; } 
    }
}
