using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Content
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Director { get; set; }
        public List<string> Category { get; set; }
        public double IMDbRating { get; set; }
        public string Writer { get; set; }
        public string Stars { get; set; }
        public string Poster { get; set; }
        public string Genre { get; set; }
        public string PlaybackURL { get; set; }
    }
}
