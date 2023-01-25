using System;

 namespace MyApp
 {
    class Program
    {
        static void Main(string[] args)
        {
            var id = Guid.NewGuid();
            id.ToString();

            id = new Guid("829629ff-5fce-44e7-8719-0586420f3a37");
            Console.WriteLine(id);
        } //Guids
    }
 }