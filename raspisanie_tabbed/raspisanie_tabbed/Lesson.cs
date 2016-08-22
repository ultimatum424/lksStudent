using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raspisanie_tabbed
{
    public enum WeekType
    {
        COMMON = 0,
        RED = 1,
        BLUE = 2
    }

    public class Lesson
    {
        public Lesson(string name = "", string time = "", string roomNumber = "", WeekType weekType = 0)
        {
            this.name = name;
            this.time = time;
            this.roomNumber = roomNumber;
            //this.LessonType = lessonType;
            //Building = building;
            //Week = 
        }

        public string name { get; set; }

        public string time { get; set; }

        public string roomNumber { get; set; }

        public string building { get; set; }

        public string lessonType { get; set; } //lecture or practice : will be changed to images or smth like that soon (not string)

        public WeekType weekType { get; set; }
    }
}
