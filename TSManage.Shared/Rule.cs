using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSManage.Shared
{
    public class Rule
    {
        public string FromDir { get; set; } = string.Empty;

        public string Regex { get; set; } = string.Empty;

        public string Destination { get; set; } = string.Empty;

        public string ProgramNameFilterType { get; set; } = string.Empty;

        public string ProgramNameFilter { get; set; } = string.Empty;

        public int TimeStart { get; set; } = 0;

        public int TimeEnd { get; set; } = 86340;

        public DateTime DateStart { get; set; } = DateTime.MinValue;

        public DateTime DateEnd { get; set; } = DateTime.MaxValue;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public IEnumerable<string> ServiceNames { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    }
}
