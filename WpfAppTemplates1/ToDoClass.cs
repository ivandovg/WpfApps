using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTemplates1
{
    internal class ToDoClass
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Deadline { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{Title}, {Deadline.ToShortDateString()} {Deadline.ToShortTimeString()}";
        }
    }
}
