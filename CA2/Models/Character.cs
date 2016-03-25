using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CA2.Models
{
    public class Character
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Character")]
        public string CharacterName { get; set; }

        [Display(Name = "House of")]
        public Houses House { get; set; }

        [Display(Name = "In Allegiance with")]
        public Allegiances Allegiance { get; set; }

        [Display(Name = "Status")]
        public Status Status { get; set; }

        [Display(Name = "Actor Name")]
        public string ActorName { get; set; }
    }

    public enum Houses
    {
        Stark,
        Lannister,
        Baratheon,
        Targaryen,
        Greyjoy,
        Arryn,
        Martell,
        Tully,
        Tyrell,
        FreeFolk,
        Rogue,
        Other
    }

    public enum Status
    {
        Dead,
        Alive,
        Unknown,
    }

    public enum Allegiances
    {
        Stark,
        Lannister,
        Baratheon,
        Targaryen,
        Greyjoy,
        Arryn,
        Martell,
        Tully,
        Tyrell,
        The_Nights_Watch,
        The_Khal,
        The_Unsullied,
        No_Allegiances
    }

    class CharactersDBContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }

        public CharactersDBContext()
            : base("S00146427")
        {

        }
    }
}