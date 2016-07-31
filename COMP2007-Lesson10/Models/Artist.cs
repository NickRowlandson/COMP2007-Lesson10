using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COMP2007_Lesson10.Models
{
    public class Artist
    {
        public virtual int ArtistId { get; set; }
        public virtual string Name { get; set; }
    }
}