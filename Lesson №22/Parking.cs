using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lesson__22
{
    class Parking : IEnumerable //IEnumerable<Car>
    {
        private List<Car> _cars = new List<Car>();
        private const int MAX_CARS = 100;

        public Car this[string number]
        {
            get
            {
                var car = _cars.FirstOrDefault(s => s.Number == number);
                return car;
            }
        }

        public Car this[int position]
        {
            get
            {
                if (position < _cars.Count)
                {
                    return _cars[position];
                }
                return null;
            }
            set
            {
                if (position < _cars.Count)
                {
                    _cars[position] = value;
                }
            }
        }

        public string Name { get; set; }
        public int Count => _cars.Count;

        public int Add(Car car)
        {
            if (car == null)
            {
                throw new ArgumentNullException(nameof(car), "Car is null");
            }

            if (_cars.Count < MAX_CARS)
            {
                _cars.Add(car);

                return _cars.Count - 1;
            }
            return -1;
        }

        public void GoOut(string number)
        {
            if (string.IsNullOrWhiteSpace(number))
            {
                throw new ArgumentNullException(nameof(number), "Number is null or empty.");
            }

            var car = _cars.FirstOrDefault(s => s.Number == number);

            if (car != null)
            {
                _cars.Remove(car);
            }
        }

        //public IEnumerator<Car> GetEnumerator()
        //{
        //    return _cars.GetEnumerator();
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return _cars.GetEnumerator();
        //}

        //public IEnumerator GetEnumerator()
        //{
        //    var current = 0;
        //    for (int i = 0; i < 10; i++)
        //    {
        //        current += i;
        //        yield return current;
        //    }
        //}

        public IEnumerator GetEnumerator()
        {
            foreach (var car in _cars)
            {
                // yield возвращает перечислитель
                yield return car;
            }
        }

        public IEnumerable GetNames()
        {
            foreach (var car in _cars)
            {
                yield return car.Name;
            }
        }

        public class ParkingEnumerator : IEnumerator
        {
            public object Current => throw new NotImplementedException();

            public bool MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }
    }
}
