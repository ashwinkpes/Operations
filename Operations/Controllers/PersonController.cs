using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Operations.Models;

namespace Operations.Controllers
{
    [Produces("application/json")]
    [Route("api/Person")]
    public class PersonController : Controller
    {
        private readonly PersonDbContext personDbContext;

        public PersonController(PersonDbContext personDbContext)
        {
            this.personDbContext = personDbContext;
        }

        public async Task<IEnumerable<Person>> GetPeople()
        {
            var people = await this.personDbContext.People.ToListAsync().ConfigureAwait(false);
            return people;
        }
    }
}