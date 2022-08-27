using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APItoDataGrid
{
    public class Candidate
    {
        public int Id { get; set; }
        public int Order { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Dates { get; set; } = string.Empty;
        public string Duties { get; set; } = string.Empty;
    }
}
