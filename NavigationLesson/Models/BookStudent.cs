using System;
using System.Collections.Generic;
using System.Text;

namespace NavigationLesson.Models
{
    public class BookStudent : Entity
    {
        public Book Book { get; set; }
        public Student Student { get; set; }
    }
}
