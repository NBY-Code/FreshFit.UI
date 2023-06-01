using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreshFit.Model.Abstract;

namespace FreshFit.Model.Models
{
    public class Activity : Base
    {
        public string Name { get; set; }
        public double BurnedCalory { get; set; }

        public virtual ICollection<UserActivity> UserActivities { get; set; } = new List<UserActivity>();
    }
}
