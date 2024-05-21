namespace final_exam;

public class FilterPaginationResponseDto<T>
{
    public IEnumerable<T> Items { get; set; }
    public int TotalItems { get; set; }
}
