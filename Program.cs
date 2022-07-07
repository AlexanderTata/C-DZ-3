//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом
{
int number = 12021;
int ElementOne = number%10;
int ElementTwo = number/10%10;
int ElementThree = number/1000%10;
int ElementFour = number/10000;

if (ElementOne == ElementFour && ElementTwo == ElementThree)
{
Console.WriteLine("Указанное число является палиндромом");
}
else
{
Console.WriteLine("Указанное число не является палиндромом");
}
}                   
//Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
{
int XI = 7;
int YI = 9;
int ZI = 10;
int XII = 15;
int YII = 27;
int ZII = 30;

double distance = Math.Sqrt(Math.Pow(XI - XII, 2) + Math.Pow(YI - YII, 2) + Math.Pow(ZI - ZII, 2));
Console.WriteLine(distance);
}                   

//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
{
int number = 24;


for (int i = 1; i<= number; i++)
{
    Console.WriteLine($"{i}^3 - {Math.Pow(i, 3)}");
}

} 