using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Components.Forms;

namespace DataAnotation.Models
{
    
    public class StudentModel
    {
        [ScaffoldColumn(false)] /*Specifies a field for hiding from editor forms.*/
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email ID is Required")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Incorrect Email Format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Confirm Email is Required")]
        [DataType(DataType.EmailAddress)]
        [System.ComponentModel.DataAnnotations.Compare("Email", ErrorMessage = "Email Not Matched")]
        public string ConfirmEmail { get; set; }

        [Required(ErrorMessage ="Enter proper Age")]
        [Range(1,100,ErrorMessage ="Age must be Between 1-100 in years")]
        public int Age { get; set; }

       
    }
}
