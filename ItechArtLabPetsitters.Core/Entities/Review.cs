using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItechArtLabPetsitters.Core.Entities
{
    public class Review
    {
        [Key]
        public long _ReviewID { set; get; }
        public long _PetsitterID { set; get; }
        public Petsitter _Petsitter { set; get; }
        public long _ClientID { set; get; }
        public Client _Client { set; get; }
        public byte _Mark { set; get; }
        public string _Comment { set; get; }
        public Review(long reviewID, long petsitterID, long clientID, byte mark, string comment)
        {
            _ReviewID = reviewID;
            _PetsitterID = petsitterID;
            _ClientID = clientID;
            _Mark = mark;
            _Comment = comment;
        }
    }
}
