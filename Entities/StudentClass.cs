using System.ComponentModel.DataAnnotations.Schema;

namespace final_exam;

[Table("StudentClass")]
public class StudentClass
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("Id")]
    public int Id { get; set; }

    [Column("StudentId")]
    public int StudentId { get; set; }

    [Column("ClassId")]
    public int ClassId { get; set; }
}
