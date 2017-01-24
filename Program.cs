using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsAsign
{  //interface 
    public interface IApple
    {
        void HelloMsg();
    }
    public class Mango : IApple
    {
        public void HelloMsg()
        {
            Console.WriteLine("This is interface method");
        }
    }
 //inheritance:single,multilevel
    public class Face
    {
        public int idEmp = 121;
    }
    public class Id : Face
    {
        public int salEmp = 5;

    }
    public class Name:Id
        {
        public int noEmp = 4;
        }
   //inheritance:multiple interface
   public interface IAdd
    {
        void Addtion();
    }
    public interface ISub
    {
        void Subtraction();
    }
    public class Calculator:IAdd,ISub
    {
        public void Addtion()
        {
            int addEmp = 2 + 3;
            Console.WriteLine("multiple Inheritance add=" + addEmp);
        }

      

        public void Subtraction()
        {
            int subEmp = 3 - 2;
            Console.WriteLine("multiple Inheritance sub=" + subEmp);
        }
    }
  //Runtime Polymorphism
    public class Promact
    {
        public virtual void Employe()
        {
            Console.WriteLine("Base class");
        }
    }
    public class Profile:Promact
    {
        public override void Employe()
        {
            Console.WriteLine("Runtime polymorphism    :Derive class");
        }
    }
    //Runtime Polymorphism using new
    public class Employee
    {
        public void Add()
        {
            Console.WriteLine("Runtime polymorphism new:Base class");
        }
    }
    public class Manager:Employee
    {
        public new void Add()
        {
            Console.WriteLine("Runtime polymorphism new:Derive class");
        }
    }
  // main class
    public class Program
    {
        public static void Main(string[] args)
        {
            IApple mango = new Mango();                                             //interface
            mango.HelloMsg();                                                           //interface
            Id id = new Id();                                                //Inheritance single level
            Console.WriteLine("inheritance single level :Sum="+(id.salEmp+id.idEmp));   //Inheritance single level
            Name name = new Name();                                               //Inheritance multilevel
            Console.WriteLine("inheritance multi  level :Sum=" +(name.idEmp+name.salEmp+name.noEmp));//Inheritance multilevel
            Calculator calculator = new Calculator();                                //Inheritance multiple
            calculator.Addtion();                                                      //Inheritance multiple
            calculator.Subtraction();                                                   //Inheritance multiple
            Promact profile = new Profile();                                      //Run time Polymorphism
            profile.Employe();                                                     //Run time Polymorphism
            Employee manager = new Manager();                                    //Run time Polymorphism new
            manager.Add();                                                        //Run time Polymorphism new
            Console.Read();
        }
    }
}
