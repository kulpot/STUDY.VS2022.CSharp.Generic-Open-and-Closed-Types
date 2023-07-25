using System;

//ref link:https://www.youtube.com/watch?v=VXCUp-qE9bU&list=PLRwVmtr-pp05ETzLYQ8kv1cI5v9ddT8er&index=7
//

class MyClass<Tahahah>    // open type
{
    public static int Value;
    static MyClass()
    {
        Console.WriteLine(typeof(MyClass<Tahahah>));
    }
}

class MainClass
{
    static void Main()
    {
        MyClass<string>.Value = 10; // closed type
        Console.WriteLine(typeof(MyClass<>));
        //MyClass<MyClass<string>>.Value = 10;    // two closed type
        //MyClass<string>.Value = 20; // closed type
    }
}