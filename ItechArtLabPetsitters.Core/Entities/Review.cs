using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItechArtLabPetsitters.Repository.Entities
{
    public class Review
    {
        public Review(long petsitterID, long clientID, byte mark, string comment)
        {
            PetsitterID = petsitterID;
            ClientID = clientID;
            Mark = mark;
            Comment = comment;
        }

        [Key]
        public long ReviewID { set; get; }
        [ForeignKey("ReviewsList")]
        public long PetsitterID { set; get; }
        public User Petsitter { set; get; }
        [ForeignKey("WritenReviews")]
        public long ClientID { set; get; }
        public User Client { set; get; }
        public byte Mark { set; get; }
        public string Comment { set; get; }
    }
}
