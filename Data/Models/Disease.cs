using System.ComponentModel.DataAnnotations;
using Clever.Kindergarten.Data.Models.BaseClass;

namespace Clever.Kindergarten.Data.Models{
    public class Disease : Record
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="يجب تسجيل اسم المرض")]
        public string Name { get; set; }
        public string? EatForbidden { get; set; }
        
        public string? Description { get; set; }
        
    }
}