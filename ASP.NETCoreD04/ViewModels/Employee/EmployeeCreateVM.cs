using ASP.NETCoreD04.CustomValidators;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace ASP.NETCoreD04.ViewModels.Employee
{
    public class EmployeeCreateVM
    {
        #region Get From User
        [MinLength(3,ErrorMessage = "Min Length is 3")]
        [MaxLength(20)]
        [Required]
        //[RegularExpression]
        public string Name { get; set; }

        [Required]
        [Range(18, 50)]
        public int Age { get; set; }

        [Required]
        [Range(1000, 100000)]
        public decimal Salary { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(50)]
        // Ob Chnage Email Validate
        [Remote(action: "IsEmailAvailable", controller:"Employee", ErrorMessage = "This Email Is Already Exist")] 
        public string? Email { get; set; }

        [Required]
        [StringLength(250)]
        public string? Address { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Compare("Password")]
        [DataType(DataType.Password)]
        public string? ConfirmPassword { get; set; }

        [MinAge(18)]
        public DateOnly? DateOfBirth { get; set; }

        [Required]
        public int DepartmentId { get; set; }
        #endregion

        #region Send To User
        public List<SelectListItem>? Departments { get; set; }
        #endregion
    }
}
