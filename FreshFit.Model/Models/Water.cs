using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreshFit.Model.Abstract;

namespace FreshFit.Model.Models
{
    public class Water : Base
    {
        public int Quantity { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }
        public DateTime Date { get; set; }
    }
}
