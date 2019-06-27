using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lesson__19
{
    public class Group
    {
        //[Key]
        //public int blabla { get; set; }
        //public int Id { get; set; }
        public int GroupId { get; set; }
        public string Name { get; set; }
        public int? Year { get; set; }
        public string Type { get; set; }
        public virtual ICollection<Song> Songs { get; set; }
    }
}
