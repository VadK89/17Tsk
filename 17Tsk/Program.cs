using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17Tsk
{
    class Program
    {
        /*Создать класс для моделирования счета в банке. Предусмотреть закрытые поля для номера счета, баланса, ФИО владельца. 
         * Класс должен быть объявлен как обобщенный. Универсальный параметр T должен определять тип номера счета. 
         * Разработать  методы  для  доступа  к  данным  –  заполнения  и  чтения. 
         * Создать  несколько экземпляров класса, параметризированного различными типам. 
         * Заполнить его поля и вывести информацию об экземпляре класса на печать.
          */
        static void Main(string[] args)
        {
            //Вызываем классы и задаем иходные данные
            BanAcc<int> banAcc1 = new BanAcc<int>();
            Console.WriteLine("Введите номер счета ");           
            int num1 = Convert.ToInt32(Console.ReadLine());
            banAcc1.Write(num1);
            BanAcc<string> banAcc2 = new BanAcc<string>();
            Console.WriteLine("Введите номер счета");           
            string num2 = Console.ReadLine();
            banAcc2.Write(num2);
            BanAcc<double> banAcc3 = new BanAcc<double>();
            Console.WriteLine("Введите номер счета");             
            double num3 = Convert.ToDouble(Console.ReadLine());
            banAcc3.Write(num3);
            Console.WriteLine();
            //Вывод результатов
            banAcc1.Read();            
            banAcc2.Read();            
            banAcc3.Read();
            Console.ReadKey();


        }
    }
    //Задаем класс для банковского аккаунта
    class BanAcc<T>
    {
        //Задаем закрытые поля номера счета, баланса, ФИО владельца
        private T Num { get; set; }
        private double Bal { get; set; }
        private string Fio { get; set; }
        public BanAcc()
        {
        }
        
        //Задаем метод записи
        public void Write(T num/*, double bal, string fio*/)
        {            
            Console.WriteLine("Введите балланс");
            double bal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ФИО");
            string fio = Console.ReadLine();
            Num = num;
            Bal = bal;
            Fio = fio;
        }  

        //Задаем метод чтения
        public void Read()
        {
            Console.WriteLine("Номер счета {0}  ", Num);
            Console.WriteLine("Балланс счета {0}", Bal);
            Console.WriteLine("ФИО владельца счета {0} ", Fio);
            Console.WriteLine();
        }

        
    }
    
}
