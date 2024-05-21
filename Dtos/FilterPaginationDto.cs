using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace final_exam;

public class FilterPaginationDto
{
    [
        Required(ErrorMessage = "Page is required"),
        Range(1, int.MaxValue, ErrorMessage = "Page must be greater than 0")
    ]
    [DefaultValue(1)]
    public int PageIndex { get; set; }

    [
        Required(ErrorMessage = "PageSize is required"),
        Range(1, int.MaxValue, ErrorMessage = "PageSize must be greater than 0")
    ]
    [DefaultValue(10)]
    public int PageSize { get; set; }

    public string Keyword { get; set; } = string.Empty;

    public int Skip() => (PageIndex - 1) * PageSize;
}
