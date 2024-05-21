using Microsoft.AspNetCore.Http.Features;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace final_exam;

public class ClassService : IClassService
{
    private readonly ApplicationDbContext _dbContext;

    public ClassService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    private DbSet<Class> _classes => _dbContext.Classes;

    public Task<Class> AddClass(AddClassDto addClassDto)
    {
        if (_classes.FirstOrDefault((c) => c.Name == addClassDto.Name) != null)
        {
            throw new ClassFriendlyException("Class name already exists");
        }

        var @class = new Class
        {
            Name = addClassDto.Name,
            Code = addClassDto.Code,
            Quantity = addClassDto.Quantity
        };

        _classes.Add(@class);

        _dbContext.SaveChanges();
        return Task.FromResult(@class);
    }

    public Task<Class> DeleteClass(int id)
    {
        throw new NotImplementedException();
    }

    public Task<FilterPaginationResponseDto<Class>> GetAllClasses(FilterPaginationDto paginationDto)
    {
        var query = _classes.Where(e =>
            paginationDto.Keyword.IsNullOrEmpty() || e.Name.Contains(paginationDto.Keyword)
        );

        var result = new FilterPaginationResponseDto<Class>
        {
            Items = [.. query.Skip(paginationDto.Skip()).Take(paginationDto.PageSize)],
            TotalItems = query.Count()
        };
        return Task.FromResult(result);
    }

    public Task<Class> GetClassById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Class> UpdateClass(int id, UpdateClassDto updateClassDto)
    {
        throw new NotImplementedException();
    }
}
