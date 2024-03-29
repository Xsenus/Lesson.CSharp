﻿using System;

namespace Lesson__24
{
    class Lesson
    {
        public string Name { get; }
        public DateTime Begin { get; private set; }

        public event EventHandler<DateTime> Started;
        public Lesson(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                 throw new ArgumentNullException(nameof(name), "Name is null or Empty.");
            }

            Name = name;            
        }

        public void Start()
        {
            Begin = DateTime.Now;
            Started?.Invoke(this, Begin);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
