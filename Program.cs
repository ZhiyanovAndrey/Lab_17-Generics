using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_17_Generics
{
    /*Создать класс для моделирования счета в банке. 
    Предусмотреть закрытые поля для номера счета, баланса, ФИО владельца.  
     * Класс должен быть объявлен как обобщенный. 
     Универсальный параметр T должен определять тип номера счета. 
     * Разработать  методы  для  доступа  к  данным  –  заполнения  и  чтения. 
     * Создать  несколько экземпляров класса, параметризированного различными типам.
     * Заполнить его поля и вывести информацию об экземпляре класса на печать.*/

    class Program
    {
        static void Main(string[] args)
        {
            Bill<int> bill1 = new Bill<int>();
            bill1.SetNumber(98754788);
            bill1.SetBalance(650360.56);
            bill1.SetName("Власов Радислав Евгеньевич");
            bill1.Print();

            Bill<string> bill2 = new Bill<string>();
            bill2.SetNumber("№ 09871453");
            bill2.SetBalance(5036875.23);
            bill2.SetName("Авдеев Андрей Андреевич");
            bill2.Print();

        }
    }
    class Bill<T>
    {
        private T Number { get; set; }
        private double Balance { get; set; }
        private string Name { get; set; }

        public void SetNumber(T number)
        {
            Number = number;
        }
        public void SetBalance(double balance)
        {
            Balance = balance;
        }

        public void SetName(string name)
        {
            Name = name;
        }
        public void Print()
        {
            Console.WriteLine($"Имя владельца счета: {Name}");
            Console.WriteLine($"Номер счета: {Number}");
            Console.WriteLine($"Баланс: {Balance:n2}");
            Console.ReadKey();

        }

    }
}
