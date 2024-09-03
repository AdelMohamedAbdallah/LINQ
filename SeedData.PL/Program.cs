using SeedData.BLL.Repositories;
using System.Linq.Expressions;

//var filter = GetData.GetCustomers().Where((x) => x.id > 102).OrderBy(x => x.name).Select(x => new { x.name, x.id, x.age, x.isActive });

//var filter2 = from x in GetData.GetCustomers()
//              where x.id > 102 
//              orderby x.name
//              orderby x.age
//              select new { x.name, x.id, x.age, x.isActive };

//Console.WriteLine("\nUse the frist way\n");

//foreach (var item in filter)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("\nuse the second way\n");
//foreach (var item in filter2)
//{
//    Console.WriteLine(item);
//}

//var filter3 = GetData.GetCustomers().Where(x => x.age > 20 && x.name != null).OrderByDescending(x => x.age).ThenBy(x => x.name).Select(x => new { x.name, x.id, x.age, x.isActive }).Where(x => x.id > 103);

//var filter4 = from customer in GetData.GetCustomers()
//              select new { customer.id, customer.name, customer.age, customer.isActive }
//              into customercondition
//              where customercondition.age > 20
//              orderby customercondition.age descending, customercondition.name
//              select customercondition;


//Console.WriteLine("\nUse the frist way\n");

//foreach (var item in filter3)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine($"\nnumber of Customer = {filter3.Count()}");

//Console.WriteLine("\nuse the second way\n");

//foreach (var item in filter4)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine($"\nnumber of Customer = {filter4.Count()}");


//Console.WriteLine("\n use the method first \n");
//var filter5 = GetData.GetCustomers().Where(x => x.age > 20 && x.name != null).OrderByDescending(x => x.age).ThenBy(x => x.name).Select(x => new { x.name, x.id, x.age, x.isActive }).FirstOrDefault();
//Console.WriteLine(filter5);

//Console.WriteLine("\n use the method Last \n");
//var filter6 = GetData.GetCustomers().Where(x => x.age > 20 && x.name != null).OrderByDescending(x => x.age).ThenBy(x => x.name).Select(x => new { x.name, x.id, x.age, x.isActive }).LastOrDefault();
//Console.WriteLine(filter6);

//Console.WriteLine("\n use the method Single \n");
//var filter7 = GetData.GetCustomers().SingleOrDefault(x => x.id == 102);
//Console.WriteLine(filter7);

//Console.WriteLine("\n use the method Element \n");
//var filter8 = GetData.GetCustomers().ElementAtOrDefault(2);
//Console.WriteLine(filter8);

//Console.WriteLine("\n use the method Max \n");
//var filter9 = GetData.GetCustomers().Max(x => x.id);
//Console.WriteLine($"Max value of id : {filter9}");

//Console.WriteLine("\n use the method Min \n");
//var filter10 = GetData.GetCustomers().Min(x => x.id);
//Console.WriteLine($"Min value of id : {filter10}");

//Console.WriteLine("\n use the method Avarage \n");
//var filter11 = GetData.GetCustomers().Average(x => x.age);
//Console.WriteLine($"Avarage value of age : {filter11}");

//Console.WriteLine("\n use the method Sum \n");
//var filter12 = GetData.GetCustomers().Sum(x => x.spendAverage);
//Console.WriteLine($"Sum of spendAverage : {filter12}");

var category = GetData.GetCategories();
var customer = GetData.GetCustomers();
//Console.WriteLine("\n use the method Join \n");
//var resultjoin1 = Category.Join(Customer, pkid => pkid.Id, fkid => fkid.categoryId, (category, customer) => new { category.Name, category.Id, customer.categoryId, customer.name, customer.age }).OrderByDescending(x => x.age);
//foreach (var item in resultjoin1)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("\n use the Sql Join \n");

//var resultjoin2 = from category in Category
//                  join customer in Customer
//                  on category.Id equals customer.categoryId
//                  orderby customer.age descending
//                  select new { category.Name, category.Id, customer.categoryId, customer.name, customer.age };

//foreach (var item in resultjoin2)
//{
//    Console.WriteLine(item);
//}


//Console.WriteLine("\n use the method Left Join \n");
//var resultleftjoin = Category.GroupJoin(Customer, pkid => pkid.Id, fkid => fkid.categoryId, (category, customer) => new { category.Name, category.Id, customer });
//Console.WriteLine("name\tid");
//foreach (var item in resultleftjoin)
//{
//    Console.WriteLine($"{item.Name}\t{item.Id}");
//    Console.WriteLine("name\t\t\tid\tage\tcategoryId");
//    foreach (var item1 in item.customer)
//    {
//        Console.WriteLine($"{item1.name}\t\t{item1.id}\t{item1.age}\t{item1.categoryId}");
//    }
//}

//Console.WriteLine("\n use the method Right Join \n");
//var resultrightjoin = customer.GroupJoin(category, fkid => fkid.categoryId, pkid => pkid.Id, (customer, category) => new { customer.name, customer.id, customer.age, customer.categoryId, category });
//foreach (var item in resultrightjoin)
//{
//    Console.WriteLine($"{item.name}\t\t{item.id}\t{item.age}\t{item.categoryId}");
//    foreach (var item1 in item.category)
//    {
//        Console.WriteLine($"{item1.Name}\t{item1.Id}");

//    }
//}


//Console.WriteLine("\n use the method GroupBy \n");
//var resultgroupby = customer.GroupBy(x => x.categoryId).ToList();
//foreach (var item in resultgroupby)
//{
//    Console.WriteLine($"The Group of Category id {item.Key} : \n");
//    foreach (var item1 in item)
//    {
//        Console.WriteLine($"{item1.name}\t\t{item1.id}\t{item1.age}\t{item1.categoryId}");
//    }
//    Console.WriteLine($"\nThe number of student have \"{item.Key}\" : {item.Count()}\n");
//}

//Console.WriteLine("\n use the method Repeat \n");
//var repeat = customer.ElementAtOrDefault(9);
//Enumerable.Repeat(repeat, 5).Print();

//Console.WriteLine("\n use the method Range \n");

//var range = Enumerable.Range(1, 100);
//foreach (var item in range)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("\n use the method Contains \n");

//var newcustomer = new Customer { id = 112, name = "Adel Mohamed", age = 37, isActive = true, joinDate = new DateTime(2023, 7, 12), categoryId = 4, spendAverage = 9932.2m, telephone = 123443339 };
//var resultcontain = customer.Contains(newcustomer);
//Console.WriteLine(resultcontain);

//Console.WriteLine("\n use the method Zip \n");

//var num = Enumerable.Range(1, 6);
//var testzip = customer.Zip(num, (x, num) => new { num, x.name, x.id, x.age, x.categoryId });
//foreach (var item in testzip)
//{
//    Console.WriteLine(item);
//}


//Console.WriteLine("\n use the method Aggregate \n");

//var resultaggregate = customer.Aggregate<Customer, String>("The discount for all :\n ", (result, customer) =>
//{
//    var discount = customer.spendAverage * 0.5m;
//    result += $"{customer}\tdiscount : {discount}\n";
//    return result;

//});
//Console.WriteLine(resultaggregate);

//Console.WriteLine("\n use the method Skip \n");
//var resultskip = customer.Skip(4);
//foreach (var item in resultskip)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("\n use the method SkipLast \n");
//var resultskiplast = customer.SkipLast(4);
//foreach (var item in resultskiplast)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("\n use the method Skipwhile \n");
//var resultskipwhile = customer.SkipWhile(x => x.age < 30);
//foreach (var item in resultskipwhile)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("\n use the method Take \n");
//var resulttake = customer.Take(4);
//foreach (var item in resulttake)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("\n use the method TakeLast \n");
//var resulttakelast = customer.TakeLast(4);
//foreach (var item in resulttakelast)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("\n use the method TakeWhile \n");
//var resulttakewhile = customer.TakeWhile(x => x.age > 20);
//foreach (var item in resulttakewhile)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("\n use the method All \n");
//var resultall = customer.All(x => x.age == 30);
//Console.WriteLine(resultall);

//Console.WriteLine("\n use the method All \n");
//var resultany = customer.Any(x => x.age == 30);
//Console.WriteLine(resultany);

//List<string> titles = new List<string>
//        {
//            "Introduction to C#",
//            "Advanced Topics in .NET",
//            "C# 101",
//            "Mastering LINQ",
//            "Regular Expressions 101",
//            "LINQ and Regex"
//        };

//// Regular expression to match titles containing numbers
//Regex regex = new Regex(@"\d+");

//var titlesWithNumbers = titles.Where(title => regex.IsMatch(title));

//foreach (var title in titlesWithNumbers)
//{
//    Console.WriteLine(title);
//}

//string text = "Hello, World! 𠀋";

//StringInfo stringInfo = new StringInfo(text);
//for (int i = 0; i < stringInfo.LengthInTextElements; i++)
//{
//    string textElement = stringInfo.SubstringByTextElements(i, 1);
//    Console.WriteLine($"Text Element: {textElement}, Code Points: {string.Join(", ", textElement.Select(c => ((int)c).ToString("X4")))}");
//} 



//Console.WriteLine("\n use the Keyword into \n");
//var testlet = from cust in customer
//              select new { cust.name, cust.id, cust.age, cust.joinDate, cust.categoryId }
//              into cust2
//              where cust2.age > 30
//              orderby cust2.age descending
//              select new { cust2.name, cust2.id, cust2.age, cust2.joinDate, cust2.categoryId };

//foreach (var item in testlet)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("\n use the Keyword let \n");
//var testlet2 = from cust in customer
//               let cust2 = new { cust.name, cust.id, cust.age, cust.joinDate }
//               where cust2.age > 30
//               orderby cust2.age descending
//               where cust.categoryId == 2
//               select new { cust2.name, cust2.id, cust2.age, cust2.joinDate, cust.categoryId };

//foreach (var item in testlet2)
//{
//    Console.WriteLine(item);
//}



//var testAdd = AccessData.AddCustomer(new Customer { id = 126, name = "Mohamed Ali", age = 22, isActive = true, joinDate = new DateTime(2023, 5, 10), categoryId = 3, spendAverage = 8912.2m, telephone = 123188739 });
//foreach (var item in testAdd)
//{
//    Console.WriteLine(item);
//}

//var order = customer.OrderCustomers();
//order.Print();
//Console.WriteLine(order.Count());

//customer.Where((x) => x.name is not null ? x.name.StartsWith("Ahmed") : x.name == null).Select(x => x).Print();

//int[] array = { 1, 2, 6, 7, 8, 1, 3, 4, 9, 10 };
//var firstnum = array[..3];
//foreach (var item in firstnum)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine("============================");
//var lastnum = array[^3..];
//foreach (var item in lastnum)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine("===========================");
//var numfromend = array[^5];
//Console.WriteLine(numfromend);

//var result1 = customer.ToArray();
//result1[..10].Print();

//customer.TakeLast(10).Print();

//var test1 = customer.TakeAnyElementOrGroup(5, 10);
//test1.Print();

//var test2 = customer.TakeAnyElementOrGroupByCondition(x => x.age == 30);
//test2.Print();

//var test3 = customer.SkipAnyElementOrGroup(5, 10);
//test3.Print();

//Console.WriteLine("========================");
//var test4 = customer.SkipByCondition(x => x.age == 30);
//test4.Print();



//Console.WriteLine("\nuse the method TakeAnyElementOrGroup\n");
//customer.TakeAnyElementOrGroup(1, 10).Print();
//Console.WriteLine("\nuse the method TakeAnyElementOrGroupBy\n");
//customer.TakeAnyElementOrGroupBy(x => x.age == 30).Print();
//Console.WriteLine("\nuse the method SkipAnyElementOrGroup\n");
//customer.SkipAnyElementOrGroup(5, 10).Print();
//Console.WriteLine("\nuse the method SkipAnyElementOrGroupBy\n");
//customer.SkipAnyElementOrGroupBy(x => x.age == 30).Print();

//Console.WriteLine("\nuse the method Chunk\n");
//var chunk = customer.Chunk(10).ToArray();
//for (var i = 0; i < chunk.Length; i++)
//{
//    Console.WriteLine($"\nGroup {i + 1}\n");
//    chunk[i].Print();
//}


//Console.WriteLine("\nuse the method Any\n");
//Console.Write("Enter Search : ");
//string name = Console.ReadLine();
//var resultany = customer.Any(x => x.name.StartsWith(name, StringComparison.OrdinalIgnoreCase));
//if (resultany)
//{
//    customer.Where(x => x.name.StartsWith(name, StringComparison.OrdinalIgnoreCase)).Print();
//}
//else
//{
//    Console.WriteLine("Exit.....");
//}


//Console.WriteLine("\nuse the method GroupBy\n");
//var resultgroup = customer.GroupBy(x => x.categoryId);
//foreach (var item in resultgroup)
//{
//    Console.WriteLine($"\nCustomers in Category \"{item.Key}\"\n");
//    item.Print();
//}

//Console.WriteLine("===================================");
//Console.WriteLine("\nuse the method ToLookup\n");
//var resulttolookup = customer.ToLookup(x => x.categoryId);
//foreach (var item in resulttolookup)
//{
//    Console.WriteLine($"\nCustomers in Category \"{item.Key}\"\n");
//    item.Print();
//}

//Console.WriteLine("\nuse the method join\n");
//var resultjoin = category.GroupJoin(
//    customer,
//    cat => cat.Id,
//    cust => cust.categoryId,
//    (cat, cust) => new CustomerDTO
//    {
//        CategoryName = cat.Name,
//        CustomerName = cust.Select(x => x.name == null ? x.name = "NULL" : x.name).ToList()
//    });

//foreach (var item in resultjoin)
//{
//    Console.WriteLine($"\n{item.CategoryName}\n");
//    if (item.CustomerName != null)
//        item.CustomerName.Print();
//}



//var test = customer.FirstOrDefault(x => x.name.StartsWith("Ahmed", StringComparison.OrdinalIgnoreCase));
//Console.WriteLine(test);

//customer.Where(x => x.name.StartsWith("Ahmed", StringComparison.OrdinalIgnoreCase)).Print();

//var test = customer.LastOrDefault(x => x.name.StartsWith("Ahmed", StringComparison.OrdinalIgnoreCase));
//Console.WriteLine(test);


//Customer[] cust1 =
//{
//    new Customer { id = 1, name = "Adel Mohamed", age = 30, isActive = true, joinDate = new DateTime(2023, 2, 11), categoryId = 2, spendAverage = 2875.17m, telephone = 668788112 },
//    new Customer { id = 2, name = "Ahmed Samy", age = 20, isActive = false, joinDate = new DateTime(2023, 5, 22), categoryId = 3, spendAverage = 2025.62m, telephone = 660988112 },
//    new Customer { id = 3, name = "Emad Hamdy", age = 19, isActive = true, joinDate = new DateTime(2023, 9, 23), categoryId = 1, spendAverage = 2015.67m, telephone = 660188112 }
//};

//Customer[] cust2 =
//{
//    new Customer { id = 4, name = "Adel Mohamed", age = 22, isActive = false, joinDate = new DateTime(2023, 6, 17), categoryId = 2, spendAverage = 2915.37m, telephone = 660188112 },
//    new Customer { id = 5, name = "Ahmed Samy", age = 23, isActive = true, joinDate = new DateTime(2023, 3, 10), categoryId = 1, spendAverage = 2845.68m, telephone = 660188112 },
//    new Customer { id = 6, name = "Emad Hamdy", age = 35, isActive = false, joinDate = new DateTime(2023, 1, 8), categoryId = 2, spendAverage = 2985.97m, telephone = 660188112 }
//};

//Console.WriteLine("\nuse the method SequenceEqual\n");
//var sequance1 = new List<Customer>(cust1);
//var sequance2 = new List<Customer>(cust2);
//var equal = sequance1.SequenceEqual(sequance2);
//Console.WriteLine(equal);

//Console.WriteLine("\nuse the method Concat\n");
//var resultconcat = cust1.Select(x => new { x.name, x.id, x.age }).Concat(cust2.Select(x => new { x.name, x.id, x.age }));
//resultconcat.Print();
//Console.WriteLine("================================");
//Console.WriteLine("\nuse the Another way to Concat\n");
//var concat = new[] { cust1, cust2 }.SelectMany(x => x).Select(x => new { x.name, x.id, x.age });
//concat.Print();

//var sum = customer.Sum(x => x.age);
//Console.WriteLine(sum);
//var avarage = customer.Average(x => x.age);
//Console.WriteLine(avarage);


//Console.WriteLine("\nuse the method Aggregate\n");
//var aggregate = customer.Aggregate("The All names of Customers : \n", (result, name) =>
//    {
//        return result += "\t" + $"\"{name.name}\"" + ",\n";
//    }
//    );
//Console.WriteLine(aggregate);

//var testcount = customer.Where(
//    x =>
//    {
//        var max = customer.MaxBy(x => x.age);
//        return x == max;
//    });

//testcount.Print();

//Console.WriteLine(testcount.Count());

//var testgroup = customer.GroupBy(x => x.categoryId).OrderByDescending(x => x.Count()).FirstOrDefault();

//Console.WriteLine($"Key : {testgroup.Key}\n");
//foreach (var item in testgroup.ToList())
//{
//    Console.WriteLine(item);
//}


// (num) => (num + 5) % 2 == 0
ParameterExpression parameter = Expression.Parameter(typeof(int), "num");
ConstantExpression constant1 = Expression.Constant(5, typeof(int));
ConstantExpression contant2 = Expression.Constant(2, typeof(int));
ConstantExpression constant3 = Expression.Constant(0, typeof(int));

BinaryExpression addbinaryexpression = Expression.Add(parameter, constant1);

BinaryExpression modulbinaryexpression = Expression.Modulo(addbinaryexpression, contant2);

BinaryExpression equalbinaryexpression = Expression.Equal(modulbinaryexpression, constant3);

Expression<Func<int, bool>> IsEvenExpression = Expression.Lambda<Func<int, bool>>(equalbinaryexpression, new ParameterExpression[] { parameter });
var IsEven1 = IsEvenExpression.Compile();
Console.WriteLine($"use by variable : {IsEven1(15)}");
//Console.WriteLine($"use by variable and method invoke() : {IsEven1.Invoke(15)}");
//Console.WriteLine($"use by method invoke() without variable : {IsEvenExpression.Compile().Invoke(15)}");

//Expression<Func<int, bool>> IsEven = (num) => (num + 5) % 2 == 0;
//Console.WriteLine($"use by method invoke() without variable : {IsEven.Compile().Invoke(15)}");

//customer.Print();

//Calendar myCal = new GregorianCalendar();

//DateTime myDate = new DateTime(2024, 7, 6);

//DateTime newDate = myCal.AddDays(myDate, 10);
//Console.WriteLine("Date after 10 days: " + newDate.ToShortDateString());

//int dayOfMonth = myCal.GetDayOfMonth(myDate);
//Console.WriteLine("Day from month: " + dayOfMonth);

//DayOfWeek dayOfWeek = myCal.GetDayOfWeek(myDate);
//Console.WriteLine("Day from Week: " + dayOfWeek);

//int month = myCal.GetMonth(myDate);
//Console.WriteLine("Month: " + month);

//int year = myCal.GetYear(myDate);
//Console.WriteLine("year: " + year);

Console.ReadKey();
