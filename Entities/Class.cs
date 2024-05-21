using System.ComponentModel.DataAnnotations.Schema;

namespace final_exam;

[Table("Class")]
public class Class
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("Id")]
    public int Id { get; set; }

    [Column("Name")]
    public string Name { get; set; }

    [Column("Code")]
    public string Code { get; set; }

    [Column("Quantity")]
    public int Quantity { get; set; }
}
