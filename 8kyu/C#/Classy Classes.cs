public class Person
{  
  public Person(string name, int age)
  {
   _name = name;
   _age = age;
    
   }

        private string _name;
        private int _age;

        public object Info => $"{_name}s age is {_age}";
}