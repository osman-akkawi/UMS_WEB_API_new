using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS_DAL.Repositories._GenericRepository
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

                                                 // for login i dont use async bcz i need to see
                                                 // ex if there is username to continue to check the password..
        T GetById(int id);// if its assync i do GetByIdAsync

        T Add(T faculty);

        T Update(T faculty);

        bool Delete(int id);

        bool Delete(T faculty);
    }
}
