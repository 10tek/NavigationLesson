using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NavigationLesson.Models
{
    public class Book : Entity
    {
        public string TitleName { get; set; }
        public ICollection<BookStudent> Students { get; set; }
    }
}
