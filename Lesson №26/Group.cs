using System;

namespace Lesson__26
{
    [Serializable]
    public class Group
    {
        [NonSerialized]
        private static readonly Random rnd = new Random(DateTime.Now.Millisecond);

        // Есть доступ к приватному классу

        // private int privateInti = 12345678;

        private int privateInti;

        public int Number { get; set; }
        public string Name { get; set; }

        public Group()
        {
            Number = rnd.Next(1, 10);
            Name = "Группа " + rnd;

            //privateInti = rnd.Next();
        }

        public Group(int number, string name)
        {
            Number = number;
            Name = name ?? throw new ArgumentNullException(nameof(name));

            //privateInti = rnd.Next();
        }

        public void setPrivate(int i)
        {
            privateInti = i;
        }

        public override string ToString()
        {
            return $"{Name} -> int privateInti {privateInti}";
        }
    }
}
