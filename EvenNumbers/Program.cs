﻿Console.WriteLine("Please, input your number!");
double number = double.Parse(Console.ReadLine());
for (int i = 2; i <= number; i+=2){
    Console.WriteLine("Четное число: " + i);
}
