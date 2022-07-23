namespace Clever.Kindergarten.Data.Models
{

    public class Hobby : IHobby
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Mohamed";
        public bool isAccessible { get; set; } = true;
    }
}