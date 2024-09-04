using System.ComponentModel.DataAnnotations.Schema;

namespace ClearmechanicApi.Models
{
	public class Movie
	{
		public int Id { get; set; }

		public string? Title { get; set; }

        [ForeignKey("Gender")]
        public int GenderId { get; set; }

        public virtual Gender? Gender { get; set; }

        public int Year { get; set; }

        public List<MovieActor>? MovieActors { get; }

        public List<Actor>? Actors { get; }
    }
}