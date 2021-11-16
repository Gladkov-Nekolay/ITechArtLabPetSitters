using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItechArtLabPetsitters.Repository.Entities
{
    public class Review
    {
        [Key]
        public long ReviewID { set; get; }
        public long PetsitterID { set; get; }
        public Petsitter Petsitter { set; get; }
        public long ClientID { set; get; }
        public Client Client { set; get; }
        public byte Mark { set; get; }
        public string Comment { set; get; }
        public Review(long petsitterID, long clientID, byte mark, string comment)
        {
            PetsitterID = petsitterID;
            ClientID = clientID;
            Mark = mark;
            Comment = comment;
        }
    }
}
