namespace DevRainTest.Business.Services.Abstract
{
    public interface IBaseService<TDto>where TDto : class,new()
    {
        Task<IQueryable<TDto>> GetAllAsync();
    }
}
