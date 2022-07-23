namespace Clever.Kindergarten.Data.Models.User_{
    public interface IUser
    {
        int Id { get; set; }
        string Name { get; set; }
        string NationalNumber { get; set; }
    }

    public class User : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NationalNumber { get; set; }
    }
}