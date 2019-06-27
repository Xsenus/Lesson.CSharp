using System;
namespace Lesson__13
{
    interface ICar : IObject
    {
        /// <summary>
        /// Выполнить перемещение.
        /// </summary>
        /// <param name="distance">Расстояние.</param>
        /// <returns>Время движения.</returns>
        int Move(int distance);

        int Speed { get; set; }
    }
}
