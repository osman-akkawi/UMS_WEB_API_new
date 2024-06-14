﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using UMS_BLL.DTO.Faculty;
using UMS_BLL.Rapping;
using UMS_DAL.Repositories._GenericRepository;
using UMS_DAL.Repositories.Majors;

namespace UMS_BLL.Services._GenericService
{
    public class GenericService<Entity, Dto> : IGenericService<Dto>
        where Entity : class
        where Dto : class
    {
        public readonly IGenericRepository<Entity> _repository;
        public readonly IMapper _mapper;

        public GenericService(IGenericRepository<Entity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper; 
        }

        public ApiResponse<Dto> Add(Dto dto)
        {
            var response = new ApiResponse<Dto>();
            var entity = _mapper.Map<Entity>(dto);

            if(entity == null)
            {
                throw new Exception("Null");
            }
            var result = _repository.Add(entity);
            response.Data = _mapper.Map<Dto>(result);
            return response;
        }

        public virtual ApiResponse<bool> Delete(int id)
        {
            var response = new ApiResponse<bool>();
            response.Data = _repository.Delete(id);  
            return response;
        }

        public virtual ApiResponse<bool> Delete(Dto dto) //virtual is giving permission to do 
                                             //override
        {
            var response = new ApiResponse<bool>();
            var entity = _mapper.Map<Entity>(dto);
            response.Data =  _repository.Delete(entity);
            return response;
        }


        public ApiResponse<Dto> GetById(int id)
        {
            var response = new ApiResponse<Dto>();
            var result = _repository.GetById(id);
            response.Data = _mapper.Map<Dto>(result);
            return response;
        }

        public ApiResponse<Dto> Update(Dto dto)
        {
            var response = new ApiResponse<Dto>();
            var entity = _mapper.Map<Entity>(dto);
            var result = _repository.Update(entity);
            response.Data =  _mapper.Map<Dto>(result);
            return response;
        }

        public ApiResponse<IEnumerable<Dto>> GetAll()
        {
            var response = new ApiResponse<IEnumerable<Dto>>();
            var result = _repository.GetAll();
            response.Data = _mapper.Map<IEnumerable<Dto>>(result);
            return response; 
        }
    }
}
