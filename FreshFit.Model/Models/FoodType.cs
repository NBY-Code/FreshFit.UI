using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreshFit.Model.Abstract;

namespace FreshFit.Model.Models
{
    public class FoodType : Base
    {

        public string Name { get; set; }
        public virtual ICollection<FoodTypeFood> FoodTypeFoods { get; set; } = new List<FoodTypeFood>();
    }
}
