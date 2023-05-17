using System;
using WebApplication1.Common;

namespace WebApplication1.Entities
{
    public class Employee : BaseEntity
    {
        public Employee()
        {
            DateTime dt = DateTime.Now;
            CreatedOn = dt.ToString();
            IsActive = true;
        }

        public string Name { get; set; }
        public string CreatedOn { get; set; }
        public bool IsActive { get; set; }
        public Guid ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
