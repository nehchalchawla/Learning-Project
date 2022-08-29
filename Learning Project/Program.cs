////Challenge 1 
//string Name = "Nehchal"; 
//Console.WriteLine("Hello!");
////Pascal Case 

////Challenge 3 
//string Name = Console.ReadLine();
//Console.WriteLine("Hello" + Name);

////Challenge 4 
//int X = 7;
//int Y = 3;
//Console.WriteLine(X + Y);

////Challenge 5 
//double X = 5;
//double  Y = 2;
//Console.WriteLine(X / Y);
////double stores a decimal amount 
////int = whole numbers 

////Challenge 6 
//double TemperatureC = 32.5;
//double TemperatureF = TemperatureC * 1.8 + 32;
//Console.WriteLine("TemperatureF");

////Challenge 7 
//Console.WriteLine("Please enter your age.");
//string Input = Console.ReadLine();
//int Age = Convert.ToInt32(Input);
//if (Age > 18)
//{
//    Console.WriteLine("you are old");
//}
//else if (Age < 18)
//{
//    Console.WriteLine("you are young");
//}

////Challenge 8 
//string Input1 = Console.ReadLine();
//string Input2 = Console.ReadLine();

//int Num1 = Convert.ToInt32(Input1);
//int Num2 = Convert.ToInt32(Input2);
//     //  && = AND ||= Or 
//if ((Num1 > 0 && Num2 < 0) || (Num1< 0 && Num2 > 0))
//{
//    Console.WriteLine("TRUE");
//}
//else
//{
//    Console.WriteLine("FAlSE");
//}

////Challenge 9 
//string Input1 = Console.ReadLine();
//string Input2 = Console.ReadLine();

//int Num1 = Convert.ToInt32(Input1);
//int Num2 = Convert.ToInt32(Input2);

//if ((Num1 >= -10 && Num1 <= 10) || (Num2 >= -10 && Num2 <= 10))

//{
//    Console.WriteLine("TRUE");
//}
//else
//{
//    Console.WriteLine("FALSE");
//}

////Challenge 10 
////for count = 1 to 99
//for (int count = 1; count < 100; count = count + 1)
//{
//    Console.WriteLine(count);
//}

////Challenge 11 
//for (int count = 1; count <= 50; count = count + 2)
//{
//    if (count % 5 == 0)
//    {
//        Console.WriteLine(count);
//    }
//}

////Challenge 12
//for (int count = -300; count <= -30; count = count + 3)
//{
//        Console.WriteLine(count);
//}

////Challenge 13 
//int Count = 1;

//string Input = "";
//while (Input != "7")
//{
//    Input = Console.ReadLine();
//}

////Challenge 14 

//string FirstName = "";
//string LastName = "";

//while (!(FirstName == "Santa" || LastName != "Claus"
//{
//    FirstName = Console.ReadLine();
//    LastName = Console.ReadLine(); 
//}

//Arrays Challenges 
//Challenge 1 
//                       0         1       2        3         4 
//string[] Students = { "Pan Pan", "Mahi", "Kav", "Kylen", "Nehchal" };
//for (int i = 0; i < 5; i = i + 1)
//{
//    Console.WriteLine(Students[i]);
//}

////Challenge 2 
//int[] Numbers = { 5, 6, 3, 9, 1 };
//Console.WriteLine(Numbers[0]);
//Console.WriteLine(Numbers[4]);

////Challenge 3 
//int[] Numbers = { 5, 6, 3, 9, 1, 4, 10, 23, 19, 7 }; 
//for(int i = Numbers.Length - 1; i >= 0; i = i - 1 )
//{
//    Console.WriteLine(Numbers[i]);
//}

////Challenge 4 
//int[] Numbers = { 5, 6, 3, 9, 1 };
//int Total = 0;
//for (int i = 0; i < Numbers.Length; i++)
//{
//    Total = Total + Numbers[i];
//}
//double Average = (double)Total / Numbers.Length;
//Console.WriteLine(Average);

////Challenge 5 
//string[] Names = new string[5];
//for (int i = 0; i < 5; i++)
//{
//    Names[i] = Console.ReadLine();
//}
