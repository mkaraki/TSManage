using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSManage.Shared
{
    public struct TSInfo
    {
        public TSInfo(string content)
        {
            string[] c = content.Split('\0');

            ProgramName = ParseStr(c[0]);

            DateYear = ParseInt(c[1]);
            DateMonth = ParseInt(c[2]);
            DateDay = ParseInt(c[3]);

            TimeHour = ParseInt(c[4]);
            TimeMinute = ParseInt(c[5]);

            ServiceName = ParseStr(c[6]);
        }

        public static string? ParseStr(string? s)
        {
            if (s == null || s == string.Empty)
                return null;
            else
                return s;
        }

        public static int? ParseInt(string i)
        { 
            if (int.TryParse(i, out int number))
                return number;
            else
                return null;
        }

        public string? ProgramName { get; set; }

        public int? DateYear { get; set; }

        public int? DateMonth { get; set; }

        public int? DateDay { get; set; }

        public int? TimeHour { get; set; }

        public int? TimeMinute { get; set; }

        public DateTime DateTime { get => new DateTime(DateYear ?? 1970, DateMonth ?? 1, DateDay ?? 1, TimeHour ?? 0, TimeMinute ?? 0, 0); }

        public int TimeTotalSec { get => (TimeHour ?? 0) * 3600 + (TimeMinute ?? 0) * 60; }

        public string? ServiceName { get; set; }

        private static string IStrNull(int? i)
        {
            if (i == null)
                return "???";
            else
                return i.ToString() ?? "???";
        }

        public override string ToString()
        {
            return $"{ProgramName ?? "???"} ({IStrNull(DateYear)}/{IStrNull(DateMonth)}/{IStrNull(DateDay)} {IStrNull(TimeHour)}:{IStrNull(TimeMinute)} {ServiceName ?? "???"})";
        }
    }
}
