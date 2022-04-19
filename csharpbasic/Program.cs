// using LearningBasic;
// using Task;
using assignment2;

using assignment2final;

// List<Order> orders = AddSampleData();
// CustomerModel customer=GetCustomer();
// foreach (Order order in orders)
// {
//     order.totalamount(customer);
//     if (order is Order ord)
//     {
//         Console.WriteLine($"Hey {customer.name} your bill amount is {ord.totalamount}");
//     }
// }

// Console.ReadLine();

// static CustomerModel GetCustomer()
// {
//     return new CustomerModel
//     {
//         cid=1,
//         name="jidesh",
//         email="jideshvaidya@gmail.com",
//         city="lalitpur",
//         phone="9860637891"

//     };
// }

// static List<IProductModel> AddSampleData()
// {
//     List<IProductModel> output = new List<IProductModel>();

//     output.Add(new Order { cid=1,name="Jidesh",email="jideshvaidya@gmail.com",city="lalitpur",phone="9860637891",pid=1,pname="gas",prate=1600,pqty=2});
   
//     return output;
// }


//assignment2final

// assignment2
// List<IProductModel> cart = AddSampleData();
// CustomerModel customer = GetCustomer();
// foreach (IProductModel prod in cart)
// {
//     prod.ShipItem(customer);
//     if (prod is IDigitalProductModel digital)
//     {
//         Console.WriteLine($"For the {digital.Title} you have {digital.TotalDownloadsLeft} download left");
//     }
// }

// Console.ReadLine();


// static CustomerModel GetCustomer()
// {
//     return new CustomerModel
//     {
//         name = "Jidesh",
//         email = "jideshvaidya@gmail.com",

//         city = "Lalitpur",
//         phone = "9860637891"
//     };
// }

// static List<IProductModel> AddSampleData()
// {
//     List<IProductModel> output = new List<IProductModel>();

//     output.Add(new PhysicalProductModel { Title = "Liverpool FC" });
//     output.Add(new PhysicalProductModel { Title = "KGF" });
//     output.Add(new PhysicalProductModel { Title = "KGF" });
//     output.Add(new DigitalProductModel { Title = "Lesson source code" });
//     output.Add(new CourseProductModel { Title = ".NET core start to finish" });
//     return output;
// }

//assignment 1
// Student std=new Student();
// Console.WriteLine(std.name);
// Console.WriteLine("enter your name");
// string name = Console.ReadLine();
// Console.WriteLine("hello {0}",name);
// Console.WriteLine("enter number of number from which you want find sum and average");
// int n=Convert.ToInt32(Console.ReadLine());
// int[] arr=new int[n];
// for(int i=0;i<n;i++)
// {
//   Console.Write("enter element number {0} : ",i);
//   arr[i] = Convert.ToInt32(Console.ReadLine()); 
// }
// Assignment a=new Assignment();
// Console.Write(a.sumandavg(arr));

// Console.WriteLine("Hello press 1 for calculating sum and average using array");
// Console.WriteLine("Hello press 2 for calculating sum and average using multiple params");
// int a= Convert.ToInt32(Console.ReadLine());
// switch(a)
// {
//     case 1:


//     break;
//     case 2:

//     break;
//     default:
//     Console.Write("1 or 2 is only acceptable");
//     break;
// }