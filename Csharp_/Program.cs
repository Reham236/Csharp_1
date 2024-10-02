namespace Csharp_
{   // STRUCT
    //struct Customer
    //{
    //    private int _id;
    //    private string _name;
    //    public int Id { set { this._id = value; } get { return _id; } }
    //    public string Name { set { this._name = value; } get { return _name; } }
    //     public void Print()
    //    {
    //        Console.WriteLine("ID= {0} & Name= {1} ", this._id, this._name);

    //    }
    //    public Customer(int id, string name)
    //    {
    //        this._id = id;  
    //        this._name = name;
    //    }

    //}


    ////INTERFACES
    //interface I1
    //{
    //    void Print1();
    //}
    //interface I2:I1
    //{
    //    void Print2();
    //}
    //public class Customer:I2  
    //{
    //    public void Print1() {
    //        Console.WriteLine("Print1 Interface Method ");
    //    }
    //    public void Print2()
    //    {
    //        Console.WriteLine("Print2 Interface Method ");
    //    }
    //}


    //// ABSTRACT CLASSES
    //public abstract class Customer1 {
    //    public abstract void PrintMethod();
    //    public void Print()
    //    {
    //        Console.WriteLine("Hello from Instance Print Method");
    //    }
    //}
    //public  class Customer2:Customer1
    //{
    //    public override void PrintMethod()
    //    {
    //        Console.WriteLine("Hello from Abstract Print Method");
    //    }

    //}

    // multiple class inheritance using interfaces
    interface IA
    {
         void Method_A();
       
    }
    class A:IA
    {
        public void Method_A()
        {
            Console.WriteLine("Class A");
        }
    }
    interface IB
    {
         void Method_B();
    }
    class B
    {
        public void Method_B()
        {
            Console.WriteLine("Class B");
        }
    }
    class AB : IA, IB
    {
        A a= new A();
        B b= new B();
        public void Method_A()
        {
            a.Method_A();
        }
        public void Method_B()
        {
            b.Method_B();
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //  // STRUCT
            //    Customer c1 = new Customer(1,"Reham");
            //    c1.Print();
            //    Customer c2 = new Customer();
            //    c2.Id = 2;
            //    c2.Name = "Rana";
            //    c2.Print();
            //    Customer c3 = new Customer()
            //    {
            //        Id = 3,
            //        Name = "Rasha"

            //    };
            //    c3.Print();



            ////INTERFACES
            //Customer c1 = new Customer();
            //c1.Print1();
            //c1.Print2();
            ////interface reference variable points to derived class
            //I1 i1 = new Customer();
            //i1.Print1();

            //I2 i2 = new Customer();
            //i2.Print1();
            //i2.Print2();

            //// ABSTRACT CLASSES
            //Customer2 customer = new Customer2();
            //customer.PrintMethod();
            //customer.Print();

            // multiple class inheritance using interfaces
            AB ab = new AB();
            ab.Method_A();
            ab.Method_B();
        }
    }
}
