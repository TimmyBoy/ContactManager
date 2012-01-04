using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic.Entities
{
    public class Notes
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public Employee employee { get; set; }
        public string Comment { get; set; }
    }
}
