using System.Text.Json.Serialization;

namespace auction.API.Entities
{
	public class FinishedLot : EntityBase
	{
		public Guid? LotId { get; set; }
		[JsonIgnore]
		public Lot? Lot { get; set; }
		public Guid WinnerId { get; set; }
		[JsonIgnore]
		public Person? Winner { get; set; }
		public float? WinnersBet { get; set; }
	}
}
