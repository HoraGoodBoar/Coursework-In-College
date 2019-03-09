using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hostel{
    public static class Adapter{
        // Payment
        private static List<string> sort = new List<string>() {
            "Ід",
            "Курс",
            "Кількість",
            "ЗагальнаКількість",
            "Проживають",
            "Використано",
            "ВсьогоСтудентів",
            "Проплата"
        };
        public static string GetUpDateString(string Value,string Column) {
            return  sort.Contains(Column) ?Value:("'"+Value+"'");
        }
    }
}
