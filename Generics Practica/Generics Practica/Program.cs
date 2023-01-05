


using Generics_Practica;
using Generics_Practica.Models;



#region Fibonacci

//Fibonacci(6);

//static void Fibonacci(int n)
//{
//    int a = 1;
//    int b = 1;
//    int c;

//    Console.WriteLine(a);

//    Console.WriteLine(b);

//    for (int i = 1; i < n; i++)
//    {
//        c = a + b;
//        a = b;
//        b = c;

//        Console.WriteLine(c);
//    }
//}

#endregion

#region Incomplete

//ShowSameNameCount();


//static void ShowSameNameCount()
//{
//    Student stu1 = new Student
//    {
//        Id = 1,
//        Name = "Mizo",

//    };


//    Student stu2 = new Student
//    {
//        Id = 2,
//        Name = "Masan",

//    };



//    Student stu3 = new Student
//    {
//        Id = 3,
//        Name = "Qemlo",

//    };




//    Student stu4 = new Student
//    {
//        Id = 4,
//        Name = "Qemdulla",

//    };

//    Student[] students = { stu1, stu2, stu3, stu4 };

//    for (int i = 0; i < students.Length; i++)
//    {
//        Console.WriteLine(students[i].Name);
//    }



//}



#endregion

#region AZn $

//Manat manat = new Manat(100);

//Dollar dollar = manat;

//Console.WriteLine(dollar.Usd);

#endregion

#region String Int Stu List

//StringList list1 = new StringList();

//list1.Add("Qemlo");

//list1.Add("Qemdulla");

//list1.Add("Masan");

//list1.GetAll();




//IntList list2 = new IntList();

//list2.Add(1);
//list2.Add(2);
//list2.Add(3);
//list2.Add(4);

//list2.GetAll();



//StudentList list3 = new StudentList();

//list3.Add(new Student { Id = 1, Name = "Masan"});
//list3.Add(new Student { Id = 2, Name = "Qemlo" });
//list3.Add(new Student { Id = 3, Name = "Qemdulla" });

//list3.GetAll();

#endregion

#region DataList
//DataList<string> students = new DataList<string>();

//students.Add("Masan");

//students.Add("Qemdulla");

//students.Add("Qemlo");

//students.GetAll();



//DataList<int> numbers = new DataList<int>();

//numbers.Add(123);
//numbers.Add(147);
//numbers.Add(369);
//numbers.Add(987);

//numbers.GetAll();




//DataList<Student> studentlist = new DataList<Student>();

//studentlist.Add(new Student { Id = 1, Name = "Qemlo" });
//studentlist.Add(new Student { Id = 2, Name = "Qemdulla" });
//studentlist.Add(new Student { Id = 3, Name = "Masan" });

//studentlist.GetAll();




//foreach (var item in nums)
//{
//    Console.WriteLine(item);
//}



//List<int> nums = new List<int>();

//nums.Add(100);
//nums.Add(50);


//for (int i = 0; i <= nums.Count; i++)
//{
//	for (int j = i+1; j <= nums.Count -1; j++)
//	{
//		if (nums[i] > nums[j])
//		{
//			Console.WriteLine("Boyukdur");
//			break;
//		}
//	}
//}
#endregion


//Repository<Student> student = new Repository<Student>();
//Repository<int> num = new Repository<int>();
//Repository<string> str = new Repository<string>();
//Repository<bool> married = new Repository<bool>();




Repository<Test1, Test2> data = new Repository<Test1, Test2>();

