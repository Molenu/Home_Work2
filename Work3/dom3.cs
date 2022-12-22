//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
int gump= new Random().Next(1,8);
Console.WriteLine(gump);
if ((gump==6)||(gump==7))
{
    Console.WriteLine("Yes");
}
else
{
    
    Console.WriteLine("No");
}