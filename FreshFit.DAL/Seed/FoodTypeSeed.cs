using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using FreshFit.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace FreshFit.DAL.Seed
{
    public class FoodTypeSeed
    {
        public void AddFoodTypeData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FoodType>().HasData(
            

                new FoodType { ID = 1, Name = "Tahıl ve Ekmek Urunleri" },
                new FoodType { ID = 2, Name = "Sut ve Sut Urunleri" },
                new FoodType { ID = 3, Name = "Meyveler" },
                new FoodType { ID = 5, Name = "Cig Sebzeler" },
                new FoodType { ID = 6, Name = "Yaglı Tohumlar ve Atıştırmalıklar" },
                new FoodType { ID = 8, Name = "Yaglar" },
                new FoodType { ID = 9, Name = "Et ürünleri" },
                new FoodType { ID = 10, Name = "Kümes Hayvanları" },
                new FoodType { ID = 11, Name = "Deniz Ürünleri" },
                new FoodType { ID = 4, Name = "Corbalar" },
                new FoodType { ID = 7, Name = "Salatalar" },
                new FoodType { ID = 12, Name = "Sebze Yemekleri" },
                new FoodType { ID = 13, Name = "Buharda veya Haslama Olarak Tuketilecek Sebzeler" },
                new FoodType { ID = 14, Name = "Kahvaltılıklar" },
                new FoodType { ID = 15, Name = "Tahıl ve Kuru Baklagil Yemekleri" }
              
                );
        }
    }
}
