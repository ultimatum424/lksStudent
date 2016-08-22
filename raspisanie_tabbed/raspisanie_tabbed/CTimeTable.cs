using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace raspisanie_tabbed
{
    public class DailyTimeTable
    {
        public DailyTimeTable(string day, List<Lesson> lessons)
        {
            this.day = day;
            this.lessons = lessons;  
        }
        public string day { get; set; }
        public List<Lesson> lessons { get; set; }
    }

    public class CTimeTable
    {
        public List<DailyTimeTable> table  { get; set; }
        public CTimeTable()
        {
            table = new List<DailyTimeTable>();
            table = JsonConvert.DeserializeObject<List<DailyTimeTable>>(JsonTimeTable);
        }
        public static readonly string JsonTimeTable = @"[
  {
    'day': 'ПН',
    'lessons': [
      {
        'name': 'ООП',
        'time': '08:00 - 09:30',
        'roomNumber': '523'
      },
      {
        'name': 'ИИП',
        'time': '09:45 - 11:20',
        'roomNumber': '423'
      },
      {
        'name': 'ППО',
        'time': '11:30 - 13:00',
        'roomNumber': '342'
      }
    ]
  },

  {
    'day': 'ВТ',
    'lessons': [
      {
        'name': 'Физ-ра',
        'time': '08:00 - 09:30',
        'roomNumber': '237'
      },
      {
        'name': 'ОЭВМиА',
        'time': '09:45 - 11:20',
        'roomNumber': '543'
      },
      {
        'name': 'ППО',
        'time': '11:30 - 13:00',
        'roomNumber': '245'
      },
    ]
  },

  {
    'day': 'СР',
    'lessons': [
      {
        'name': 'ТАиФЯ',
        'time': '08:00 - 09:30',
        'roomNumber': '452'
      },
      {
        'name': 'ТАиФЯ',
        'time': '09:45 - 11:20',
        'roomNumber': '452'
      },
      {
        'name': 'Физ-ра',
        'time': '11:30 - 13:00',
        'roomNumber': '237'
      }
    ]
  },

  {
    'day': 'ЧТ',
    'lessons': [
      {
        'name': 'Русский язык',
        'time': '08:00 - 09:30',
        'roomNumber': '342'
      },
      {
        'name': 'Правоведение',
        'time': '09:45 - 11:20',
        'roomNumber': '244'
      },
      {
        'name': 'ООП',
        'time': '11:30 - 13:00',
        'roomNumber': '523'
      }
    ]
  },

  {
    'day': 'ПТ',
    'lessons': [
      {
        'name': 'ТАиФЯ',
        'time': '08:00 - 09:30',
        'roomNumber': '459'
      },
      {
        'name': 'МЛиТА',
        'time': '09:45 - 11:20',
        'roomNumber': '142'
      },
      {
        'name': 'МЛиТА',
        'time': '11:30 - 13:00',
        'roomNumber': '142'
      }
    ]
  },

  {
    'day': 'СБ',
    'lessons': [
      {
        'name': '',
        'time': '',
        'roomNumber': ''
      },
      {
        'name': '',
        'time': '',
        'roomNumber': ''
      },
      {
        'name': '',
        'time': '',
        'roomNumber': ''
      }
    ]
  },
]";
    }

}
