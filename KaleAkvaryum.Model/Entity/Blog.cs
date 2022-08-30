using System;
using System.Collections.Generic;
using System.Text;

namespace KaleAkvaryum.Model.Entity
{
    public class Blog:Base
    {
        public string BlogName { get; set; }
        public DateTime? BlogDate { get; set; }
        public string BlogImg { get; set; }
        public string BlogText { get; set; }
    }
}
