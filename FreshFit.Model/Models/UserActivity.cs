using FreshFit.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshFit.Model.Models
{
    public class UserActivity : Base
    {
        public int UserID { get; set; }
        public int ActivityID { get; set; }
        public double LoseCalory { get; set; }
        public DateTime Date { get; set; }

        public virtual Activity Activity { get; set; }
        public virtual User User { get; set; }


    }
}
