//Task 1

// Console.Write("Eded daxil edin:");
// var number = Convert.ToInt32(Console.ReadLine());

// var sum = 0;

// while (number > 0)
// {
//     sum += number % 10;
//     number /= 10;
// }

// Console.WriteLine(sum);


//Task 2

// Console.Write("3 reqemli eded daxil: ");
// int n = int.Parse(Console.ReadLine());
// int a = n / 100;
// int c = n % 10;
// int b = n % 100 / 10;
// if (a == b && b == c)
// {
//     Console.WriteLine("Mertebeler eynidir");
// }
// else
// {
//     Console.WriteLine("Mertebeler ferqlidir");
// }


//Task 3

// int num1, num2;
// num1 = 11;
// num2 = 10;
// num1= num1+ num2;
// num2 = num1- num2;
// num1 = num1- num2;  
// Console.WriteLine(num1);
// Console.WriteLine(num2);


//Task 4

        int age;
        bool isStudent;
        double price;

        Console.Write("Yashinizi daxil edin: ");
        age = int.Parse(Console.ReadLine());

        Console.Write("Telebe biletiniz var? (y/n): ");
        isStudent = Console.ReadLine().ToLower() == "y";

        if (age <= 12)
        {
            price = 5.0 ;
        }
        else if (age >= 60)
        {
            price = 5.0 ;
        }
        else if (isStudent)
        
            price = 7.5;
        }
        else
        
            price = 10.0;
        }

        Console.WriteLine("Sizin biletinizin qiymeti {0:C}", price);