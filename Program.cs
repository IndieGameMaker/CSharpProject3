using System;
using MyWork;

namespace CSharpProject3
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeDemo typeDemo = new TypeDemo();
            typeDemo.Work01();

            DelegateDemo delegateDemo = new DelegateDemo();
            delegateDemo.Work02();
        }
    }
}
