using System;
using System.Text.Json.Serialization;

namespace ClearmechanicApi.Models
{
	public class Actor
	{
		public int Id { get; set; }

		public string? Name { get; set; }

        [JsonIgnore]
        public List<MovieActor>? MovieActors { get; }
    }
}

