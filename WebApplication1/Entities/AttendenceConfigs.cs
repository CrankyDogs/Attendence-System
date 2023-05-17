using System;
using WebApplication1.Common;

namespace WebApplication1.Entities
{
    public class AttendenceConfigs : BaseEntity
    {
        public TimeSpan MaxPunchIn { get; set; }

        public TimeSpan MinPunchOut { get; set; }

        public bool IsActive { get; set; }
    }
}
