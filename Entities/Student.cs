using System.ComponentModel.DataAnnotations.Schema;

namespace final_exam;

[Table("Students")]
public class Student
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("Id")]
    public int Id { get; set; }

    [Column("Name")]
    public string Name { get; set; }

    [Column("Code")]
    public string Code { get; set; }

    [Column("BirthDate")]
    public DateOnly BirthDate { get; set; }
}
