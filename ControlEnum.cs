using System.ComponentModel.DataAnnotations;

namespace SwitchCaseEnum
{
    public enum ControlEnum
    {
        [Display(Name = "Add")]
        Add = 1,

        [Display(Name = "Subtract")]
        Subtract,

        [Display(Name = "Mulptiply")]
        Mulptiply,

        [Display(Name = "Divide")]
        Divide,

        [Display(Name = "Square")]
        Square
    }
}
