using System.ComponentModel.DataAnnotations;

namespace ASP.NETCoreD04.CustomValidators
{
    public class MinAgeAttribute : ValidationAttribute
    {
        private readonly int _minAge;
        public MinAgeAttribute(int minAge)
        {
            _minAge = minAge;
        }
        public override bool IsValid(object? value)
        {
            // To Do Make Validation

            return true;
        }
    }
}
