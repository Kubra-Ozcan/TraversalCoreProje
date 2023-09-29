using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommmentID { get; set; }
        public string CommmentUser { get; set; }
        public DateTime CommmentDate { get; set; }
        public string CommmentContent{ get; set; }
        public bool CommentState { get; set; }
        public int DestinationID { get; set; }
        public Destination Destination { get; set; }

    }
}
