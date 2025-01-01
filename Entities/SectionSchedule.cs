using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademy.Entities
{
    public class SectionSchedule
    {
        public int Id { get; set; }
        
        public TimeSpan StartTime { get; set; }
        
        public TimeSpan EndTime { get; set; }

        public int ScheduleId { get; set; }
        
        public int SectionId { get; set; }  

    }
}
