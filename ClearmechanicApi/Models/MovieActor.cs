using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClearmechanicApi.Models
{
	public class MovieActor
	{
		public int Id { get; set; }

	    [ForeignKey("Movie")]
        public int MovieId { get; set; }
        public virtual Movie? Movie { get; set; }

        [ForeignKey("Actor")]
        public int ActorId { get; set; }
        public virtual Actor? Actor { get; set; }

    }
}