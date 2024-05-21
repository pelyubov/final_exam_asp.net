using System.ComponentModel.DataAnnotations;

namespace final_exam;

public class UpdateStudentDto
{
    public int Id { get; set; }

    private string _name;

    [
        Required(AllowEmptyStrings = false, ErrorMessage = "Name is required"),
        StringLength(
            50,
            MinimumLength = 3,
            ErrorMessage = "Name must be between 3 and 50 characters"
        )
    ]
    public string Name
    {
        get => _name;
        set { _name = value.Trim(); }
    }

    private string _code;

    [
        Required(AllowEmptyStrings = false, ErrorMessage = "Code is required"),
        StringLength(
            50,
            MinimumLength = 3,
            ErrorMessage = "Code must be between 3 and 50 characters"
        )
    ]
    public string Code
    {
        get => _code;
        set { _code = value.Trim(); }
    }

    public DateOnly Birthday { get; set; } = DateOnly.FromDateTime(DateTime.Now);
}
