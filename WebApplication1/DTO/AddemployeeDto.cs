using System.ComponentModel.DataAnnotations;

namespace WebApplication1.DTO
{
    public class AddemployeeDto
    {
        [Required]       
        public string Email { get; set; }


        [Required]
        public string Name { get; set; }
    }
}
