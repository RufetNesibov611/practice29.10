



using practice29._10;
using practice29._10.Helpers;
using System.Threading.Channels;

//string email = Console.ReadLine();

//var result = email.CheckEmail();

//if (result == true)
//{
//    Console.WriteLine(" Success");

//}
//else
//{
//    Console.WriteLine("Wrong");
//}

//Console.WriteLine("Please add your email address");

//string email = Console.ReadLine();

//var res = email.CheckTrimEmail(@" ");

//if(res == true)
//{
//    Console.WriteLine("Yes");
//}
//else
//{
//    Console.WriteLine("No");
//}

//Person person = new Person();

//person.Id = 1;
//person.Name = "Cavid";
//person.Surname = "Bashirov";

//Console.WriteLine(person.GetFullName());


//int[] arr = { 1, 2, 3, 4, 5 };

//Console.WriteLine(arr.GetMultiplyArray());



//IntList list = new IntList();

//list.Add(1);
//list.Add(2);        
//list.Add(3);

//list.GetAll();


//StringList list = new();
//list.Add("Oruc");
//list.Add("Semed");
//list.Add("Nurlan");

//list.GetAll();

//PersonList list = new PersonList();

//list.Add(new Person { Id = 1, Name = "Test1", Surname = "Test1" });
//list.Add(new Person { Id = 2, Name = "Test2", Surname = "Test3" });
//list.Add(new Person { Id = 3, Name = "Test3", Surname = "Test3" });

//list.GetAll();


//DataList<int> datas = new();
//datas.Add(5);
//datas.Add(10);
//datas.Add(20);

//datas.GetAll();

//DataList<string> stringList = new();

//stringList.Add("asdv");
//stringList.Add("bsbdshb");

//stringList.GetAll();

//DataList<Person> students = new();

//students.Add(new Person { Name = "Test1", Id = 1, Surname = "test1"});
//students.Add(new Person { Name = "Test2", Id = 2, Surname = "test2" });

//var res = students.GetAll();

//foreach (var item in res)
//{
//    Console.WriteLine(item.Name);
//}

List<Person> people = new();
people.Add(new Person { Name = "Test1", Id = 1, Surname = "test1" });

foreach(Person person in people)
{
    Console.WriteLine(person.Name);
}