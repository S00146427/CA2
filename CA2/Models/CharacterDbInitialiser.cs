using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Migrations;
using CA2.Models;
using System.Data.Entity;


namespace CA2.Models
{
    class CharacterDbInitialiser : DropCreateDatabaseAlways<CharactersDBContext>
    {
        protected override void Seed(CharactersDBContext context)
        {
            #region Seed Characters
            var characters = new List<Character>()
            {
                new Character()
                {
                    ID=1,
                    CharacterName="Daenerys Targaryen",
                    House = Houses.Targaryen,
                    Allegiance=Allegiances.The_Unsullied,
                    Status = Status.Alive,
                    ActorName = "Emilia Clarke"
                },
                new Character()
                {
                    ID=2,
                    CharacterName="John Snow",
                    House = Houses.Stark,
                    Allegiance=Allegiances.The_Nights_Watch,
                    Status = Status.Alive,
                    ActorName = "Kit Harington"
                },
                new Character()
                {
                    ID=3,
                    CharacterName="Tyrion Lannister",
                    House = Houses.Lannister,
                    Allegiance=Allegiances.Targaryen,
                    Status = Status.Alive,
                    ActorName = "Peter Dinklage"
                },
                new Character()
                {
                    ID=4,
                    CharacterName="Joffrey Baratheon",
                    House = Houses.Baratheon,
                    Allegiance=Allegiances.Lannister,
                    Status = Status.Dead,
                    ActorName = "Jack Gleeson"
                },
                new Character()
                {
                    ID=5,
                    CharacterName="Khal Drogo",
                    House = Houses.Rogue,
                    Allegiance=Allegiances.No_Allegiances,
                    Status = Status.Dead,
                    ActorName = "Jason Momoa"
                }
            };
            #endregion
            characters.ForEach(character => context.Characters.Add(character));
            context.SaveChanges();

            base.Seed(context);

        }
    }
}