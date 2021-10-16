using System;

namespace ConsoleApplication1
{
    public class Second
    {
        public class User
        {
            private string _name;
            private int _age;

            public User(string name, int age)
            {
                this._age = age;
                this._name = name;
            }

            public void Methode()
            {
                Console.WriteLine($"Nom: {this._name}");
                Console.WriteLine($"Age: {this._age}");
            }
            
        }
    }
}