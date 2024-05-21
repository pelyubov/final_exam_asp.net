using System.ComponentModel.DataAnnotations;

namespace final_exam;

public class UpdateClassDto
{
    public int Code { get; set; }

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
}
