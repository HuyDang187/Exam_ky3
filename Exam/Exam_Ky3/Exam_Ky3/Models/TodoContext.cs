using Microsoft.EntityFrameworkCore;
namespace Exam_Ky3.Models
{
	public class TodoContext : DbContext
	{
		public TodoContext(DbContextOptions<TodoContext> options)
			: base(options)
		{
		}

		public DbSet<Employee> Employees { get; set; } = null!;
	}
}
