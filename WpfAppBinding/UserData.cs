using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppBinding
{
    public class UserData
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public DateTime Birth { get; set; }

        public override string ToString()
        {
            return $"{UserId}) {Name}({Login}), {Birth.ToShortDateString()}";
        }
    }
}
