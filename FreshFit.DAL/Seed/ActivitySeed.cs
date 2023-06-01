using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreshFit.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace FreshFit.DAL.Seed
{
    public class ActivitySeed
    {
        public void AddActivityData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activity>().HasData(
                new Activity { ID = 1, Name = "Yüksek Tempo Kosu", BurnedCalory = 17.9 },
                new Activity { ID = 2, Name = "İp Atlama", BurnedCalory = 17.9 },
                new Activity { ID = 3, Name = "Tekwando", BurnedCalory = 15.6 },
                new Activity { ID = 4, Name = "Yüzme", BurnedCalory = 14.9 },
                new Activity { ID = 5, Name = "Yavaş Tempo Koşu", BurnedCalory = 12.6 },
                new Activity { ID = 6, Name = "Tenis", BurnedCalory = 12.1 },
                new Activity { ID = 7, Name = "Basketbol", BurnedCalory = 12.1 },
                new Activity { ID = 8, Name = "Paten Kayma", BurnedCalory = 11.4 },
                new Activity { ID = 9, Name = "Racketbal", BurnedCalory = 10.6 },
                new Activity { ID = 10, Name = "Kürek Çekme", BurnedCalory = 15 },
                new Activity { ID = 11, Name = "Futbol", BurnedCalory = 12.5 },
                new Activity { ID = 12, Name = "Ağırlık Kaldırma ", BurnedCalory = 7.4 },
                new Activity { ID = 13, Name = "Bisiklet Sürme ", BurnedCalory = 12.3 },
                new Activity { ID = 14, Name = "Voleybol ", BurnedCalory = 6 },
                new Activity { ID = 15, Name = "Dans Etme ", BurnedCalory = 5 },
                new Activity { ID = 16, Name = "Bale ", BurnedCalory = 7 }

                );
        }
    }
}
