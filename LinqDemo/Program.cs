using System;
using System.Linq;
using System.Collections;
using System.Security.Cryptography;
using System.Collections.Generic;



#region Dummmy Types 
class Employee 
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return $"id = {Id} , Name= {Name} , Age = {Age}";
    }
}

class Child 
{ 
    public string Name { get; set; }
    public string Address { get; set; }
    public string bestFriend { get; set; }

    public override string ToString()
    {
        return $"Child Data: Name = {Name}, Address = {Address} , bestFriend = {bestFriend}";
    }
}

class Father 
{
    public string Name { get; set; }
    public List<Child> kids { get;set; }
}
#endregion
class Program
{
    public static void Main(string[] args) 
    {
        Console.WriteLine("LINQ Demo");
    #region Anonymous Types
    int id = 100;
        string fname = "Abdullah", lname = "Hegab";
        var myObj = new { id,name="Abdullah" , fullName = fname + " " + lname}; // anonymous type from anonymous type 
        Console.WriteLine(myObj.id);
        Console.WriteLine(myObj.fullName);
        #endregion

        #region Linq
        #region Linq Expression and LINQ Methods
        /*
        List<int> numbers = new List<int>() {1,2,3,4,-20,100,90,200};
        // get all even numbers from numbers list
        #region linq expression 
        // using linq expression 
        // linq statements by default => defer execution
        var resultExpression = from number in numbers
                     where number % 2 == 0
                     select number;
        //numbers.Add(1000);
        foreach (var item in resultExpression) 
        {
            Console.WriteLine(item);
        }
        */
        #endregion
        #region Linq methods 
        /*
        // defer execution 
        var result = numbers.Where(n => n % 2 == 0);
        // eager execution 
        var resultEager = numbers.Where(n => n % 2 == 0).ToList();
        numbers.Add(1000);
        foreach (var item in resultEager)
        {
            Console.WriteLine(item);
        }
        */
        #endregion
        #region select (projection) , where (fetch)
        /*
        List<int> numbers = new List<int>() { 1, 2, 3, 4, -20, 100, 90, 200 };
       
        var result = numbers
                            .Where( n => n % 2 == 0 )
                            .Select(xn => new { EvenNumber = xn });

        foreach (var num in result) {
            Console.WriteLine(num);
        }
        */
        /*
        List<Employee> emps = new List<Employee>() {
            new Employee(){ Id=10 , Age=25 , Name="Abdullah"},
            new Employee(){ Id=20 , Age=30 , Name="Ahmed"},
            new Employee(){ Id=30 , Age=40 , Name="Mahmoud"},
            new Employee(){ Id=40 , Age=50 , Name="Hegab"},
            new Employee(){ Id=50 , Age=60 , Name="Hegabovic"},
        };
        // retrive all IDs From EMPS => in new formate => EMPID = projection (select)
        var result = emps.Select(e => new { EMPID = e.Id });
        foreach (var item in result) { Console.WriteLine(item); }
        */
        #endregion
        #region Distinct , First , FirstOrDefault , Last , LastOrDefault , Single , SingleOrDefault , skip ,SkipWhile
             #region Distinct
                /*
                List<string> Names = new List<string>() {"ABDULLAH","abdullah","hegab","hegabovic","Ahmed","Mahmoud","hegab"};
                var result = Names.Where(n => n.Length > 4).Select( n => new { EMPName = n.ToUpper() , EMPLength = n.Length}).Distinct();
                foreach (var item in result) { Console.WriteLine(item); }
                */
                #endregion
             #region First and FirstOrDefault    AND    Last and LastOrDefault
                /*
                List<Employee> emps = new List<Employee>() {
                    new Employee(){ Id=10 , Age=25 , Name="Abdullah"},
                    new Employee(){ Id=20 , Age=30 , Name="Ahmed"},
                    new Employee(){ Id=30 , Age=40 , Name="Mahmoud"},
                    new Employee(){ Id=40 , Age=50 , Name="Hegab"},
                    new Employee(){ Id=50 , Age=60 , Name="Hegabovic"},
                };

                var firstResult = emps.Select(e => new { EMPAge = e.Age }).First(e => e.EMPAge > 70);
                var firstOrDefaultResult = emps.Select(e => new { EMPAge = e.Age }).FirstOrDefault(e => e.EMPAge > 70);
                // foreach ( var item in result) { Console.WriteLine(item); }
                Console.WriteLine(firstResult);
                Console.WriteLine(firstOrDefaultResult);
                */
                #endregion
             #region Single and SingleOrDefault
                // single => get data from table using primary key (PK) "UNIQUE"
                // retrive Name for employee => ID(PK) = 10
                /*
               List<Employee> emps = new List<Employee>() {
                   new Employee(){ Id=10 , Age=25 , Name="Abdullah"},
                   new Employee(){ Id=20 , Age=30 , Name="Ahmed"},
                   new Employee(){ Id=30 , Age=40 , Name="Mahmoud"},
                   new Employee(){ Id=40 , Age=50 , Name="Hegab"},
                   new Employee(){ Id=50 , Age=60 , Name="Hegabovic"},
               };

               var result = emps.SingleOrDefault(e => e.Id == 10);
                */
                #endregion
             #region Skip , SkipWhile   AND    Take and TakeWhile
                //var result = numbers.Skip(3); 
                /*
                 * List<int> numbers = new List<int>() { 1 , 2 , 3 , 4 , 5 , 6 , -10,  7, 8 };
                var result = numbers.SkipWhile(e => e < 4);
                foreach (var item in result) { Console.WriteLine(item); }
                var result2 = numbers.Where(e => e < 4);
                foreach (var item in result2) {Console.WriteLine(item);}
                */
                #endregion
             #region OrderBy  ThenBy , OrderByDescending , ThenByDescending
                /*
                List<Employee> emps = new List<Employee>() {
                    new Employee(){ Id=10 , Age=25 , Name="Abdullah"},
                    new Employee(){ Id=99 , Age=30 , Name="Ahmed"},
                    new Employee(){ Id=44 , Age=40 , Name="Mahmoud"},
                    new Employee(){ Id=40 , Age=40 , Name="Hegab"},
                    new Employee(){ Id=50 , Age=60 , Name="Hegabovic"},
                };
                var sortedemps = emps.OrderBy(e => e.Age).ThenBy(e=> e.Id);
                foreach (var item in sortedemps) { Console.WriteLine(item); }  // assending by defualt 
                */
                #endregion
             #region GroupBy 
        
                List<Child> kids = new List<Child>()
                    {
                        new Child(){ Name="child one", Address="Alexandria",bestFriend="one"},
                        new Child(){ Name="child two", Address="cairo",bestFriend="two"},
                        new Child(){ Name="child three", Address="el mansora",bestFriend="three"},
                    };

                var result = kids.GroupBy(c => c.Name);

                foreach (var item in result) { 
                    Console.WriteLine(item.Key + " : " + item.Count());
                    foreach (var item2 in item) { Console.WriteLine(item2); }
                }

                #endregion
        #endregion
        #endregion



    }

}
