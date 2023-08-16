using System.ComponentModel.DataAnnotations;

namespace StudentManagment_Jquery.Models
{
	public class student
	{
		public int student_id { get; set; }
		[Required] public string? FirstName { get; set; }
		[Required] public string? LastName { get; set; }
		public DateTime? dob { get; set; }
		[Required] public string? Email { get; set; }
		public string? Phone { get; set; }
	}
}
