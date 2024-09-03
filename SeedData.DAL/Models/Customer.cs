namespace SeedData.DAL.Models
{

    public class Customer
    {

        public int id { get; set; }
        public string name { get; set; }
        public long telephone { get; set; }
        public int age { get; set; }
        public decimal spendAverage { get; set; }
        public int categoryId { get; set; }
        public bool isActive { get; set; }
        public DateOnly joinDate { get; set; }

        public override bool Equals(object? obj)
        {
            var customer = obj as Customer;
            if (obj == null) return false;
            if (customer == null) return false;
            return
                   id == customer.id &&
                   name == customer.name &&
                   telephone == customer.telephone &&
                   age == customer.age &&
                   spendAverage == customer.spendAverage &&
                   categoryId == customer.categoryId &&
                   isActive == customer.isActive &&
                   joinDate == customer.joinDate;
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + id.GetHashCode();
            hash = hash * 23 + name.GetHashCode();
            hash = hash * 23 + telephone.GetHashCode();
            hash = hash * 23 + age.GetHashCode();
            hash = hash * 23 + spendAverage.GetHashCode();
            hash = hash * 23 + categoryId.GetHashCode();
            hash = hash * 23 + isActive.GetHashCode();
            hash = hash * 23 + joinDate.GetHashCode();

            return hash;

        }

        public override string ToString()
        {
            return String.Format($"{id}\t{name}\t\t{age}\t" +
            $"{isActive}\t{joinDate.ToString("dd/MM/yyyy")}\t" +
            $"{spendAverage}\t\t{categoryId}\t" +
            $"{telephone}");

        }


    }
}
