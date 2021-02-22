using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager productManager = new CarManager(new InMemoryDAL());
            foreach (var item in productManager.GetAll())
            {
                Console.WriteLine(item.CarDescription);
            }
        }
    }
}
