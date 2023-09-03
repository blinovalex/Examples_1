
using System.Collections.Concurrent;
using System.Runtime.Serialization;
using System.Reflection.Emit;
using System.Data;
using System;
Console.WriteLine("Введите имя пользователя ");
string username = Console.ReadLine();

if(username.ToLower()  == "masha")
{

    Console.WriteLine("Ура, этоже Masha");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
    


}
