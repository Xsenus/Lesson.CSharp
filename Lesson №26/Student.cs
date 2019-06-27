using System;
using System.Runtime.Serialization;

namespace Lesson__26
{
    [DataContract]
    public class Student
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int Age { get; set; }

        public Group Group { get; set; }

        public Student(string name, int age)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Age = age;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
