using Clever.Kindergarten.Data.Models.User_;

namespace Clever.Kindergarten.Data.Models.BaseClass
{
    public class Record
    {
        public int? AddedUserId { get; set; }
        public int? UpdatedUserId { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public TimeOnly AddedTime { get; set; }
        public TimeOnly UpdatedTime { get; set; }
    }

    
}