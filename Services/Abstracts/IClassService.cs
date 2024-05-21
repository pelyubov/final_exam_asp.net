namespace final_exam;

public interface IClassService
{
    Task<FilterPaginationResponseDto<Class>> GetAllClasses(FilterPaginationDto paginationDto);
    Task<Class> GetClassById(int id);
    Task<Class> AddClass(AddClassDto addClassDto);
    Task<Class> UpdateClass(int id, UpdateClassDto updateClassDto);
    Task<Class> DeleteClass(int id);
}
