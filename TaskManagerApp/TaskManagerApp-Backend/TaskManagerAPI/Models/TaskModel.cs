using System.ComponentModel.DataAnnotations;
using TaskManagerAPI.Data;

public class TaskModel : BaseEntity
{
	[Required(ErrorMessage = "O campo Title é obrigatório.")]
	[StringLength(100, ErrorMessage = "O campo Title deve ter no máximo {1} caracteres.")]
	public string Title { get; set; }

	[StringLength(500, ErrorMessage = "O campo Description deve ter no máximo {1} caracteres.")]
	public string Description { get; set; }

	[RegularExpression("^(pending|in-progress|completed)$", ErrorMessage = "O campo Status deve ser 'pending', 'in-progress' ou 'completed'.")]
	public string Status { get; set; }

	[Required(ErrorMessage = "O campo DueDate é obrigatório.")]
	[Display(Name = "Due Date")]
	public DateTime DueDate { get; set; }
}
