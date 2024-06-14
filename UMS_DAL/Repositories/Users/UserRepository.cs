using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_DAL.Models;
using UMS_DAL.Repositories._GenericRepository;
using UMS_DAL.Repositories.Majors;

namespace UMS_DAL.Repositories.Users
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(UmsContext umsContext) : base(umsContext)
        {
          
        }

      
        public User GetUserByUsername(string name)
        {
            return _dbSet.Where(x => x.Username == name).FirstOrDefault();
        }
    }
}
