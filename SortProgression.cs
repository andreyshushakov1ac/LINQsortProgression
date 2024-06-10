using System.Collections;

namespace pr4._7
{
    internal class SortProgression : IEnumerable
    {
        //разность арифметической прогрессии
        private int _d;
        //первый член прогрессии
        private int _a0;
        //кол-во элементов
        private static int _k;
        
        // доступ к полям
        public int gs_d
        {
            get { return _d; }
            set { _d = value; }
        }
        public int gs_a0
        {
            get { return _a0; }
            set { _a0 = value; }
        }
        public int gs_k
        {
            get { return _k; }
            set { _k = value; }
        }
        public SortProgression(int a0, int d, int k)
        {
            _d = d;
            _a0 = a0;
            _k = k;
        }



        ///int[] a = new int[_k];
        List<int> ArPr = new List<int>(_k);
        internal void ListAndSortList()
        {
            //создание списка, заполнение элементами и вывод на экран
            ArPr.Insert(0, _a0);

            
            Console.WriteLine("\nАрифметическая прогрессия:");
            Console.WriteLine(_a0);
            int i;
            for (i=1;i<_k;i++)
            {
                ArPr.Insert(i, ArPr.ElementAt(i-1) + _d);
                Console.WriteLine(ArPr.ElementAt(i));
            }


            /*
            int[] a = new int[_k];
            a[0] = _a0; Console.WriteLine(_a0);
            for (int i=1; i<_k; i++) 
            {
                a[i] = a[i-1]+_d;
                Console.WriteLine(a[i]); 
            }
           */


            // сортировка в порядке убывания без 1ого и последнего элемента
            // и вывод нового списка в консоль
            /*Console.WriteLine("\nБез первого и последнего элементов в порядке убывания:");
            var gg1 = from x in a//ArPr
                      where (x != a[0] && x != a[_k-1])//(x != _a0 && x != ArPr.ElementAt(i-1))
                      orderby x descending
                      select x;
            foreach (var g in gg1)
                Console.WriteLine(g);
            */
            Console.WriteLine("\nБез первого и последнего элементов в порядке убывания:");
            var gg1 = from x in ArPr
                      where (x != _a0 && x != ArPr.ElementAt(i-1))
                      orderby x descending
                      select x;
            foreach (var g in gg1)
                Console.WriteLine(g);
        }
        
       public IEnumerator GetEnumerator()
        {
            return ArPr.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        { return GetEnumerator(); }


    }
}
