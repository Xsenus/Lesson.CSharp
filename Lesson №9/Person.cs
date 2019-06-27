using System;

namespace Lesson__9
{
    public class Person
    {
        public string SecondName { get; private set; }

        public string Name { get; private set; }

        // Конструктор класса
        public Person(string secodName, string name)
        {
            SecondName = secodName;
            Name = name;
        }

        //public string FullName
        //{
        //    get
        //    {
        //        return SecondName + " " + Name;
        //    }
        //}

        //public string ShortName
        //{
        //    get
        //    {
        //        //return String.Format("{0} {1}.", SecondName, Name.Substring(0,1));
        //        return $"{SecondName} {Name.Substring(0,1)}.";
        //    }
        //}

        //private string _name;

        //public string Name
        //{
        //    get
        //    {
        //        return _name;
        //    }
        //    set
        //    {
        //        if (String.IsNullOrWhiteSpace(value))
        //        {
        //            throw new ArgumentNullException("Имя не может быть пустым");
        //        }

        //        _name = value;

        //        //_name = value + " Пупкин";
        //    }
        //}

        //public string GetName()
        //{
        //    return _name;
        //}

        //public void SetName(string name)
        //{
        //    if (String.IsNullOrWhiteSpace(name))
        //    {
        //        throw new ArgumentNullException("Имя не может быть пустым");
        //    }

        //    _name = name;
        //}
    }
}
