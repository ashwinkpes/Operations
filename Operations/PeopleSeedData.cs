using Operations.Models;
using System.Linq;

namespace Operations
{
    public static class PeopleSeedData
    {
        public static void EnsureSeedData(this PersonDbContext db)
        {
            if (!db.People.Any())
            {
                db.People.Add(new Person { FirstName = "Ashwin" , LastName = "Kumar", Age = 37, Gender = Gender.Male  });
                db.SaveChanges();
            }
        }
    }
}
