/*
    Есть одна прогрессия.
    Спрашиваем сколько элементов, какой первый, разность прогрессии.
    В классе SortProgression, который реализует интерфейс шаблонный IEnumerable,
заполнить коллекцию элементами. Выводит на экран
    +метод там. В нём реализую через LINQ сортировку по убыванию 
без первого и последнего элементов. 
    И выводим новую отсортированную коллекцию.

 */

namespace pr4._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первый элемент арифметической прогрессии:");
            int a0 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите разность прогрессии");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество элементов");
            int k = int.Parse(Console.ReadLine());

            SortProgression sortProgression1 = new SortProgression(a0, d, k);
            sortProgression1.ListAndSortList();  



            




        }  
    }
}