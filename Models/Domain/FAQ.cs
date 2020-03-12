using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CBDistro.Models.Domain
{
    public class FAQ
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
