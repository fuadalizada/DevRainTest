using AutoMapper;
using DevRainTest.Business.Services.Abstract;
using DevRainTest.DAL.Repositories.Abstract;

namespace DevRainTest.Business.Services.Concrete
{
    public class BaseService<TDto,TEntity,TRepository> : IBaseService<TDto> where TDto : class,new() where TEntity : class,new() where TRepository : IBaseRepository<TEntity>
    {
        private readonly TRepository _repository;
        private readonly IMapper _mapper;
        public BaseService(TRepository repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
    }
}
