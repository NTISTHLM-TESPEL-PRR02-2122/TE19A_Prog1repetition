using System;

Enemy goomba = new Enemy();

Console.WriteLine($"Goombans X-värde är {goomba.x}");

goomba.x += goomba.speed;


// string teacherName = "";
// DogeCoin();

// static void DogeCoin()
// {
//   Console.WriteLine("Poof goes money");
// }

// int[] numbers = { 4, 5, 112, 89 };

// for (int i = 0; i < numbers.Length; i++)
// {
//   Console.WriteLine(numbers[i]);
// }


// while (teacherName != "Micke")
// {
//   System.Console.WriteLine("Vad heter du?");
//   teacherName = Console.ReadLine();

//   Console.WriteLine($"Hello {teacherName}!");

//   if (teacherName == "Micke")
//   {
//     Console.WriteLine("yay!");
//   }

//   int age = 0;
//   while (age <= 0 || age > 100)
//   {
//     Console.WriteLine("Ålder?");
//     string ageS = Console.ReadLine();
//     int.TryParse(ageS, out age);
//   }

// }


Console.ReadLine();