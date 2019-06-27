﻿using System;

namespace Lesson__11
{
    public abstract class Product
    {
        public string Name { get; private set; }

        /// <summary>
        /// Калорийность на 100г продукта
        /// </summary>
        public int Calorie { get; private set; }

        /// <summary>
        /// Объем в граммах
        /// </summary>
        public int Volume { get; set; }

        public double Energy
        {
            get
            {
                return Volume * Calorie / 100.0;
            }
        }

        public Product(string name, int calorie, int volume)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (calorie < 0)
            {
                throw new ArgumentException(nameof(calorie));
            }

            if (volume <= 0)
            {
                throw new ArgumentException(nameof(volume));
            }

            Name = name;
            Calorie = calorie;
            Volume = volume;

        }

        public override string ToString()
        {
            return $"{Name}. Калорийность: {Calorie}. Объем: {Volume}";
        }
    }
}
