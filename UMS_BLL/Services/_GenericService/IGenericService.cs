using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_BLL.DTO.Faculty;
using UMS_BLL.Rapping;

namespace UMS_BLL.Services._GenericService
{
    public interface IGenericService<Dto> where Dto : class
    {
       ApiResponse<IEnumerable<Dto>> GetAll();
                                            // for login i dont use async bcz i need to see
                                           // ex if there is username to continue to check the password..
        ApiResponse<Dto> GetById(int id);// if its assync i do GetByIdAsync

        ApiResponse<Dto> Add(Dto faculty);

        ApiResponse<Dto> Update(Dto faculty);

        ApiResponse<bool> Delete(int id);

        ApiResponse<bool> Delete(Dto faculty);
    
}
}
