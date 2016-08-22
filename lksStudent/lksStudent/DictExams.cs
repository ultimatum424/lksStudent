using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lksStudent
{
    public class DictValue
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public string Сabinet { get; set; }
        public string Teacher { get; set; }

        public DictValue(string name, string date, string cabinet, string teacher)
        {
            this.Name = name;
            this.Date = date;
            this.Сabinet= cabinet;
            this.Teacher = teacher;
        }
    }

    public class DictExam
    {
        public Dictionary<int, DictValue> dict = new Dictionary<int, DictValue>();
    }

}
