using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/users")] // api/users da bi dobio user-e
    public class UsersContoller : ControllerBase // Kontroler mora biti derived from ControllerBase
    {
        private readonly DataContext context; 
        public UsersContoller(DataContext context)
        {
            this.context = context;
        }

        // Adding two endpoints 
        
        // Getting all users
  
        [HttpGet] 
        // Umesto IEnumerable mozemo koristiti i Listu ali ona nam daje i previse funkcionalnosti koje nam ovde nisu potrebne 
        // Potrebna je samo lista koja se vraca klijentu i jednostavna iteracija. ---->>>> Pogledati IEnumerable vs. List
        public async Task <ActionResult<IEnumerable<AppUser>>> GetUsers() 
        {
            var users = await this.context.Users.ToListAsync();
            return users; 
        }

        // Getting one user 
        [HttpGet("{id}")] 
        public async Task<ActionResult<AppUser>> GetUser(int id) 
        {
            var user = await this.context.Users.FindAsync(id);
            return user; 
        }
    }
}