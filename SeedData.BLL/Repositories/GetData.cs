using SeedData.DAL.Models;

namespace SeedData.BLL.Repositories
{
    public class GetData
    {
        public static List<CustomerCategory> GetCategories()
        {
            List<CustomerCategory> categories = new List<CustomerCategory>();
            categories.Add(new CustomerCategory() { Id = 1, Name = "normal" });
            categories.Add(new CustomerCategory() { Id = 2, Name = "VIP" });
            categories.Add(new CustomerCategory() { Id = 3, Name = "Blocked" });
            return categories;
        }

        public static List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { id = 101, name = "Emad Hamdy", age = 30, isActive = true, joinDate = new DateOnly(2022, 10, 15), categoryId = 1, spendAverage = 1500.9m, telephone = 123456789 });
            customers.Add(new Customer { id = 102, name = "Salah Ahmed", age = 32, isActive = false, joinDate = new DateOnly(2023, 1, 3), categoryId = 1, spendAverage = 2500.9m, telephone = 987654321 });
            customers.Add(new Customer { id = 103, name = "Mahmoud Samy", age = 22, isActive = true, joinDate = new DateOnly(2023, 5, 17), categoryId = 2, spendAverage = 3000.0m, telephone = 741852963 });
            customers.Add(new Customer { id = 104, name = "Mostafa Kamel", age = 27, isActive = true, joinDate = new DateOnly(2022, 8, 30), categoryId = 1, spendAverage = 4500.11m, telephone = 369852147 });
            customers.Add(new Customer { id = 105, name = "Said Nabil", age = 48, isActive = true, joinDate = new DateOnly(2023, 2, 27), categoryId = 1, spendAverage = 2000.0m, telephone = 102365214 });
            customers.Add(new Customer { id = 106, name = "Fareed Saif", age = 18, isActive = true, joinDate = new DateOnly(2022, 11, 8), categoryId = 1, spendAverage = 8110.9m, telephone = 142563636 });
            customers.Add(new Customer { id = 107, name = "Mohamed Salah", age = 31, isActive = false, joinDate = new DateOnly(2022, 12, 24), categoryId = 1, spendAverage = 1900.0m, telephone = 259874689 });
            customers.Add(new Customer { id = 108, name = "Sayed Samir", age = 39, isActive = true, joinDate = new DateOnly(2023, 4, 8), categoryId = 2, spendAverage = 1800.4m, telephone = 123698789 });
            customers.Add(new Customer { id = 109, name = "Nora Hazem", age = 25, isActive = false, joinDate = new DateOnly(2023, 10, 31), categoryId = 1, spendAverage = 1250.6m, telephone = 121111189 });
            customers.Add(new Customer { id = 110, name = "Samy Tony", age = 29, isActive = true, joinDate = new DateOnly(2021, 8, 18), categoryId = 1, spendAverage = 1854.9m, telephone = 122222289 });
            customers.Add(new Customer { id = 111, name = "Ahmed Galal", age = 37, isActive = true, joinDate = new DateOnly(2021, 6, 13), categoryId = 2, spendAverage = 9632.2m, telephone = 123333339 });
            customers.Add(new Customer { id = 112, name = "Khaled said", age = 20, isActive = true, joinDate = new DateOnly(2021, 5, 12), categoryId = 1, spendAverage = 9932.4m, telephone = 123443339 });
            customers.Add(new Customer { id = 113, name = "Naira Tarek", age = 19, isActive = true, joinDate = new DateOnly(2021, 3, 17), categoryId = 3, spendAverage = 9242.6m, telephone = 123677633 });
            customers.Add(new Customer { id = 114, name = "Ayman Ali", age = 22, isActive = true, joinDate = new DateOnly(2023, 6, 22), categoryId = 2, spendAverage = 3762.9m, telephone = 123498739 });
            customers.Add(new Customer { id = 115, name = "Ahmed Ali", age = 35, isActive = true, joinDate = new DateOnly(2022, 4, 12), categoryId = 2, spendAverage = 8732.1m, telephone = 123487239 });
            customers.Add(new Customer { id = 116, name = "Mostafa Kamel", age = 23, isActive = true, joinDate = new DateOnly(2024, 5, 25), categoryId = 1, spendAverage = 9982.2m, telephone = 123762319 });
            customers.Add(new Customer { id = 117, name = "Kamal Morsy", age = 33, isActive = true, joinDate = new DateOnly(2023, 9, 18), categoryId = 3, spendAverage = 9992.3m, telephone = 123902349 });
            customers.Add(new Customer { id = 118, name = "Said Mohamed", age = 25, isActive = true, joinDate = new DateOnly(2023, 8, 20), categoryId = 1, spendAverage = 9916.1m, telephone = 128723339 });
            customers.Add(new Customer { id = 119, name = "Ali Ahmed", age = 31, isActive = true, joinDate = new DateOnly(2021, 11, 21), categoryId = 2, spendAverage = 9987.7m, telephone = 198135424 });
            customers.Add(new Customer { id = 120, name = "Mariam Ali", age = 26, isActive = true, joinDate = new DateOnly(2023, 12, 23), categoryId = 2, spendAverage = 8132.3m, telephone = 187123339 });
            customers.Add(new Customer { id = 121, name = "Nada Said", age = 30, isActive = true, joinDate = new DateOnly(2021, 3, 17), categoryId = 3, spendAverage = 8742.6m, telephone = 123679123 });
            customers.Add(new Customer { id = 122, name = "Mohamed Khaled", age = 18, isActive = true, joinDate = new DateOnly(2023, 5, 16), categoryId = 3, spendAverage = 9764.9m, telephone = 129823139 });
            customers.Add(new Customer { id = 123, name = "Eslam Ashraf", age = 27, isActive = true, joinDate = new DateOnly(2022, 7, 24), categoryId = 1, spendAverage = 7532.4m, telephone = 123671339 });
            customers.Add(new Customer { id = 124, name = "Abdallah Eid", age = 36, isActive = true, joinDate = new DateOnly(2023, 9, 11), categoryId = 3, spendAverage = 2312.3m, telephone = 127623909 });
            customers.Add(new Customer { id = 125, name = "Ammar Yaser", age = 40, isActive = true, joinDate = new DateOnly(2023, 2, 19), categoryId = 2, spendAverage = 8132.2m, telephone = 123128739 });
            customers.Add(new Customer { id = 126, name = "Mohamed Ali", age = 22, isActive = true, joinDate = new DateOnly(2023, 5, 10), categoryId = 3, spendAverage = 8912.2m, telephone = 123188739 });
            customers.Add(new Customer { id = 127, name = "Sara Ahmed", age = 30, isActive = false, joinDate = new DateOnly(2022, 3, 22), categoryId = 1, spendAverage = 4750.5m, telephone = 987654321 });
            customers.Add(new Customer { id = 128, name = "Omar Hussein", age = 28, isActive = true, joinDate = new DateOnly(2021, 1, 15), categoryId = 2, spendAverage = 1245.67m, telephone = 112233445 });
            customers.Add(new Customer { id = 129, name = "Laila Samir", age = 35, isActive = true, joinDate = new DateOnly(2020, 11, 30), categoryId = 4, spendAverage = 6789.0m, telephone = 998877665 });
            customers.Add(new Customer { id = 130, name = "Ahmed Youssef", age = 40, isActive = false, joinDate = new DateOnly(2019, 7, 5), categoryId = 3, spendAverage = 3456.78m, telephone = 556677889 });
            customers.Add(new Customer { id = 131, name = "Nour El-Din", age = 27, isActive = true, joinDate = new DateOnly(2023, 4, 1), categoryId = 2, spendAverage = 7890.12m, telephone = 445566778 });
            customers.Add(new Customer { id = 132, name = "Hassan Mustafa", age = 45, isActive = false, joinDate = new DateOnly(2018, 2, 18), categoryId = 2, spendAverage = 2345.6m, telephone = 334455667 });
            customers.Add(new Customer { id = 133, name = "Fatma Ezzat", age = 32, isActive = true, joinDate = new DateOnly(2022, 8, 25), categoryId = 3, spendAverage = 6781.23m, telephone = 223344556 });
            customers.Add(new Customer { id = 134, name = "Khaled Mansour", age = 50, isActive = true, joinDate = new DateOnly(2017, 10, 11), categoryId = 1, spendAverage = 8923.45m, telephone = 998877112 });
            customers.Add(new Customer { id = 135, name = "Amina Salah", age = 26, isActive = false, joinDate = new DateOnly(2021, 6, 20), categoryId = 4, spendAverage = 1234.56m, telephone = 667788990 });
            customers.Add(new Customer { id = 136, name = "Hoda Gamal", age = 29, isActive = true, joinDate = new DateOnly(2020, 9, 18), categoryId = 2, spendAverage = 4321.9m, telephone = 334422113 });
            customers.Add(new Customer { id = 137, name = "Mona Farid", age = 33, isActive = false, joinDate = new DateOnly(2021, 5, 14), categoryId = 1, spendAverage = 6543.21m, telephone = 221133445 });
            customers.Add(new Customer { id = 138, name = "Yasser Nabil", age = 37, isActive = true, joinDate = new DateOnly(2019, 3, 22), categoryId = 2, spendAverage = 5678.9m, telephone = 556611223 });
            customers.Add(new Customer { id = 139, name = "Mai Khalil", age = 31, isActive = false, joinDate = new DateOnly(2022, 12, 30), categoryId = 3, spendAverage = 9876.54m, telephone = 112244556 });
            customers.Add(new Customer { id = 140, name = "Salma Rashid", age = 25, isActive = true, joinDate = new DateOnly(2023, 1, 8), categoryId = 4, spendAverage = 3450.67m, telephone = 998844665 });
            customers.Add(new Customer { id = 141, name = "Omar Tarek", age = 29, isActive = false, joinDate = new DateOnly(2021, 4, 12), categoryId = 3, spendAverage = 6789.10m, telephone = 123456789 });
            customers.Add(new Customer { id = 142, name = "Layla Hassan", age = 35, isActive = true, joinDate = new DateOnly(2020, 11, 5), categoryId = 1, spendAverage = 8901.23m, telephone = 987654321 });
            customers.Add(new Customer { id = 143, name = "Ahmed Said", age = 42, isActive = false, joinDate = new DateOnly(2019, 6, 15), categoryId = 2, spendAverage = 4567.89m, telephone = 112233445 });
            customers.Add(new Customer { id = 144, name = "Sara Mostafa", age = 27, isActive = true, joinDate = new DateOnly(2022, 2, 22), categoryId = 3, spendAverage = 2345.67m, telephone = 998877665 });
            customers.Add(new Customer { id = 145, name = "Hassan Ali", age = 50, isActive = true, joinDate = new DateOnly(2018, 8, 30), categoryId = 1, spendAverage = 3456.78m, telephone = 667788990 });
            customers.Add(new Customer { id = 146, name = "Mona Ezzat", age = 31, isActive = false, joinDate = new DateOnly(2023, 3, 19), categoryId = 4, spendAverage = 7890.12m, telephone = 334455667 });
            customers.Add(new Customer { id = 147, name = "Yasser Farid", age = 28, isActive = true, joinDate = new DateOnly(2021, 10, 8), categoryId = 3, spendAverage = 1234.56m, telephone = 223344556 });
            customers.Add(new Customer { id = 148, name = "Nour Mohamed", age = 24, isActive = false, joinDate = new DateOnly(2020, 5, 25), categoryId = 2, spendAverage = 6543.21m, telephone = 445566778 });
            customers.Add(new Customer { id = 149, name = "Khaled Nabil", age = 33, isActive = true, joinDate = new DateOnly(2019, 9, 17), categoryId = 1, spendAverage = 9876.54m, telephone = 556677889 });
            customers.Add(new Customer { id = 150, name = "Hoda Gamal", age = 36, isActive = true, joinDate = new DateOnly(2023, 2, 28), categoryId = 4, spendAverage = 2345.67m, telephone = 667788112 });
            customers.Add(new Customer { id = 151, name = "Adel Mohamed", age = 30, isActive = true, joinDate = new DateOnly(2023, 1, 22), categoryId = 2, spendAverage = 2015.67m, telephone = 660188112 });
            return customers;
        }
    }
}
