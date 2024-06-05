namespace auction.API.Entities
{
	public class Person : EntityBase
	{
		public string? Name { get; set; }
		public string? Lastname { get; set; }
		public string? Middlename { get; set; }
		public string? PhoneNumber { get; set; }
		public string? Email { get; set; }
		public float? Tax { get; set; }
	}
}
