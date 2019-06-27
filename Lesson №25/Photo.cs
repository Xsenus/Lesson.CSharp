using System;

namespace Lesson__25
{    
    public class Photo
    {
        [Geo(10, 20)]
        public string Path { get; set; }
        public string Name { get; set; }

        public Photo(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }
    }
}
