
namespace SeedData.DAL.Models
{
    public class CustomerCategory
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            return obj is CustomerCategory category &&
                   Id == category.Id &&
                   Name == category.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }
        public override string ToString()
        {
            return string.Format($"{Name}\t{Id}");
        }
    }
}
