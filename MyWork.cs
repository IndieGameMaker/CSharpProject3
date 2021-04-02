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
}