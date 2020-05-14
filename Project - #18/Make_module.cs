using System;

namespace ConsoleApplication1
{
    public interface a
    {
        int TestA();
    }
    // Интерфейс B наследует интерфейс A     
    public interface B : a {
        int TestB();
    }
    // Класс myClass наследует интерфейс B
    // и реализует методы интерфейсов A и B     
    class myClass : B
    {
        public int TestA()
        {
            return 1;         
        }
        public int TestB()
        {
            return 2;
        }
    }
    class Program
    {
        static void Main()
        {
        }
    }
}