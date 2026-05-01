using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP.NETCoreD04.ViewModels.Department
{
    public class DepartmentCreateVM
    {
        /*------------------------------------------------------------------*/
        [Display(Name = "Department Name")]
        public required string Name { get; set; }
        /*------------------------------------------------------------------*/
    }
}
