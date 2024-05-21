namespace final_exam;

public class StudentFriendlyException : Exception
{
    public StudentFriendlyException(string message)
        : base(message) { }
}
