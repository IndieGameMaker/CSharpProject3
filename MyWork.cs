using System;

namespace MyWork
{
    public class TypeDemo
    {
        //다형성
        void CalExp(int exp)
        {
            Console.WriteLine($"integer exp = {exp}");
        }

        void CalExp(float exp)
        {
            Console.WriteLine($"float exp = {exp}");
        }

        void CalExp(string exp)
        {
            Console.WriteLine($"string exp = {exp}");
        }

        //형식 매개변수 타입
        void CalExp<T>(T exp)
        {
            var a = GetCount();

            Console.WriteLine($"{typeof(T)} exp = {exp}");
        }

        public void Work01()
        {
            CalExp(10);
            CalExp(25.3f);
            CalExp("Gold Level");

            CalExp<int>(10);
            CalExp<float>(35.8f);
            CalExp<string>("Silver Level");
        }
    }

    public class DelegateDemo
    {
        //델리게이트 (Delegate) : 대리자 - 변수의 타입일종
        //함수(메서드) 저장할 수 있는 변수
        /*
            void Sum()
            void Sum(int a, int b)
            int Sum(int a, int b)
        */
        //delegate {저장할 함수의 형식}
        delegate void SumHandler (int a, int b);
        SumHandler sumHandler;

        void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void Work02()
        {
            sumHandler += Sum;
            sumHandler(10, 5);
        }

    }
}