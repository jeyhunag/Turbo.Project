using AutoMapper;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.BLL.Exceptions;
using Turbo.BLL.Services.Interfaces;
using Turbo.DAL.Repostory.Interface;

namespace Turbo.BLL.Services
{
    public class GenericService<TDto, TEntity> : IGenericService<TDto, TEntity> where TDto : class where TEntity : class
    {
        private readonly IGenericRepository<TEntity> _genericRepository;
        protected readonly IMapper _mapper;
        private readonly ILogger<GenericService<TDto, TEntity>> _logger;
        public GenericService(IGenericRepository<TEntity> genericRepository, IMapper mapper, ILogger<GenericService<TDto, TEntity>> logger)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<TDto> AddAsync(TDto item)
        {
            try
            {
                TEntity entity = _mapper.Map<TEntity>(item);
                TEntity dbEntity = await _genericRepository.AddAsync(entity);
                _logger.LogInformation($"Uğurla Create edildi");
                return _mapper.Map<TDto>(dbEntity);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Message: {ex.Message} | StackTrace: {ex.StackTrace}");
                throw new BLLAddException("Elavə edillərkən xəta yarandı.");
            }
        }


        public void Delete(int id)
        {
            try
            {
                _logger.LogInformation($"Uğurla Silindi");

                _genericRepository.Delete(id);
            }
            catch (Exception ex)
            {
                _logger.LogError($" Id ilə elementi silərkən xəta baş verdi {id}. Message: {ex.Message} | StackTrace: {ex.StackTrace}");
                throw new BLLDeleteException($"Id {id} ilə obyekt silinərkən xəta yarandı.");
            }
        }


        public async Task<TDto> GetByIdAsync(int id)
        {

            try
            {
                TEntity entity = await _genericRepository.GetByIdAsync(id);

                return _mapper.Map<TDto>(entity);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ID ilə elementi silərkən xəta baş verdi {id}. Message: {ex.Message} | StackTrace: {ex.StackTrace}");
                throw new BLLGetException($"Id axtarılarkən {id} əlavə edillərkən xəta yarandı.");
            }

        }

        public async Task<List<TDto>> GetListAsync()
        {
            try
            {
                var list = await _genericRepository.GetListAsync();
                List<TDto> dtos = _mapper.Map<List<TDto>>(list);
                _logger.LogInformation($"Uğurla  List edildi");

                return dtos;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Elementləri əldə edərkən xəta baş verdi. Message: {ex.Message} | StackTrace: {ex.StackTrace}");
                throw new BLLGetException("Siyahı almağa çalışarkən xəta yarandı.");
            }
        }


        public TDto Update(TDto item)
        {
       
            try
            {
                TEntity entity = _mapper.Map<TEntity>(item);
                TEntity dbEntity = _genericRepository.Update(entity);
                _logger.LogInformation($"Uğurla Update edildi");

                return _mapper.Map<TDto>(dbEntity);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                _logger.LogError(ex.StackTrace);
                throw new BLLUpdateException("Update edillərkən xəta yarandı.");
            }
        }
    }
}
