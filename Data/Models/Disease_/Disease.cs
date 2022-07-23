using Clever.Kindergarten.Data.Models.BaseClass;

namespace Clever.Kindergarten.Data.Models.Disease_{
    public class Disease : Record
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? EatForbidden { get; set; }
        public string? Description { get; set; }
        
    }
}