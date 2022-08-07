using System.ComponentModel.DataAnnotations;
using Clever.Kindergarten.Data.Models.BaseClass;

namespace Clever.Kindergarten.Data.Models{
    public class ChildDisease : Record
    {
        [Required(ErrorMessage ="يجب تسجيل معرف الطالب ")]
        public int ChildID { get; set; }
        [Required(ErrorMessage ="يجب تسجيل معرف المرض ")]
        public int DiseaseID { get; set; }
    }
}