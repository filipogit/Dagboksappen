using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diaryentry
{
    internal class Diaryentry
    {
        public DateTime Datum { get; set; }
        public string Text { get; set; }

        public override string ToString()
        {
            return $"{Datum:yyyy-MM-dd HH:mm} - {Text}";
        }
    }
}