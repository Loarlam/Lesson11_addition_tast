/*Используя Visual Studio, создайте проект по шаблону Console Application.  
В коллекцию  ArrayList, через вызов метода Add добавьте элементы структурного и ссылочного типа, переберите данную коллекцию с помощью, цикла for – С какой проблемой вы столкнулись? 
*/
using System;
using System.Collections;

namespace Addition_tast
{
    class MyClass { }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Строка");
            arrayList.Add(new MyClass());
            arrayList.Add(457);
            arrayList.Add(4.5);
            arrayList.Add('a');
            arrayList.Add(6m);

            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }

            Console.ReadLine();
        }
    }
}
