using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using CA2.Models;

namespace CA2.Controllers
{
    public class CharacterController : ApiController
    {
        private CharactersDBContext db = new CharactersDBContext();

        // GET: api/Character
        public List<Character> GetCharacters()
        {
            List<Character> c = new List<Character>();

            var characters = db.Characters.ToList();

            characters.ForEach(b => c.Add(new Character()
            {
                ID = b.ID,
                CharacterName = b.CharacterName,
                House = b.House,
                Allegiance = b.Allegiance,
                Status = b.Status,
                ActorName = b.ActorName
            }));

            return c;
        }

        // GET: api/Character/5
        [ResponseType(typeof(Character))]
        public IHttpActionResult GetTeam(int id)
        {
            Character c = db.Characters.Find(id);

            if (c == null)
            {
                return NotFound();
            }

            Character characters = new Character()
            {
                ID = c.ID,
                CharacterName = c.CharacterName,
                House = c.House,
                Allegiance = c.Allegiance,
                Status = c.Status,
                ActorName = c.ActorName
            };

            return Ok(c);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CharacterExists(int id)
        {
            return db.Characters.Count(e => e.ID == id) > 0;
        }
    }
}
