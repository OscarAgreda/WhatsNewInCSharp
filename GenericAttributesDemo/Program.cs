using System;

namespace GenericAttributesDemo
{

    // The Generic attributes feature is a new feature in C# 11 that allows attributes to be applied to generic types and methods. This can be useful in scenarios where you want to apply the same attribute to multiple generic types or methods.
    // 
    // In example 1, we have a demonstration of applying an attribute to a generic type. We define a generic class called MyGenericClass<T> and apply an attribute called MyAttribute to it using the square bracket syntax. The MyAttribute attribute is a custom attribute that we define ourselves in this example. We also define a method called MyMethod() inside the generic class and apply another instance of the MyAttribute attribute to it. We then call the MyMethod() method using the generic type int as the type parameter.
    // 
    // In example 2, we have a demonstration of applying an attribute to a generic method. We define the MyAttribute attribute as a custom attribute and apply it to a generic method called MyGenericMethod<U>() inside the generic class MyGenericClass<T>. We then call the MyGenericMethod<U>() method using the generic types float and double as the type parameters.

    class Program
    {
        static void Main(string[] args)
        {
            // Example 1: Apply an attribute to a generic type
            MyGenericClass<int>.MyMethod();

            // Example 2: Apply an attribute to a generic method
            MyGenericClass<float>.MyGenericMethod<double>();
        }
    }

    // Example 1: Apply an attribute to a generic type
    [MyAttribute("Example attribute")]
    class MyGenericClass<T>
    {
        [MyAttribute("Example method attribute")]
        public static void MyMethod()
        {
            Console.WriteLine("My method");
        }

        public static void MyNonGenericMethod()
        {
            Console.WriteLine("My non-generic method");
        }

        public static void MyGenericMethod<U>()
        {
            Console.WriteLine("My generic method");
        }
    }

    // Example 2: Apply an attribute to a generic method
    class MyAttribute : Attribute
    {
        public MyAttribute(string message)
        {
            Message = message;
        }

        public string Message { get; set; }
    }
}