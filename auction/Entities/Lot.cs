using System.Text.Json.Serialization;

namespace auction.API.Entities
{
	public class Lot : EntityBase
	{
		public string? Name { get; set; }
		public string? Description { get; set; }
		public float? StartPrice { get; set; }
		public Guid OwnerId { get; set; }
		public DateTime? StartTime { get; set; }
		public DateTime? EndTime { get; set; }
	}
}
