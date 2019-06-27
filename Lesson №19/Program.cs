using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson__19
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Домашнее задание
             * Создать базу данных на основе своей предметной области с помощью Code First
             * Реализовать запись, чтение, изменение и удаление данных.
             */

            using (var context = new MyDbContext())
            {
                var group1 = new Group()
                {
                    Name = "Ramstain",
                    Year = 1994
                };

                var group2 = new Group()
                {
                    Name = "Linkin Park",
                    Year = 1994
                };

                context.Groups.Add(group1);
                context.Groups.Add(group2);
                context.SaveChanges();

                var songs = new List<Song>()
                {
                    new Song() { Name = "In the end", GroupId = group1.GroupId },
                    new Song() { Name = "Numb", GroupId = group2.GroupId },
                    new Song() { Name = "Mutter", GroupId = group1.GroupId }
                };

                context.Songs.AddRange(songs);
                context.SaveChanges();

                var s = context.Groups.Single(x => x.GroupId == group1.GroupId);
                s.Name = "";
                context.SaveChanges();

                foreach (var song in songs)
                {
                    Console.WriteLine($"Song name: {song.Name}, Group name: {song.Group?.Name}");
                }

                Console.WriteLine($"id: {group1.GroupId}, name: {group1.Name}, year: {group1.Year}");
                Console.ReadLine();
            }
        }
    }
}
