using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ItechArtLabPetsitters.Repository.Entities
{
    public class Pet
    {
        [Key]
        public long ID { set; get; }
        public string PetName { set; get; }
        public string PetType { set; get; }
        public byte Age { set; get; }
        public string Description { set; get; }
        public List<Order> Orders { set; get; }
        public Pet(string petName, string petType, byte age, string description)
        {
            PetName = petName;
            PetType = petType;
            Age = age;
            Description = description;
        }
    }
}
