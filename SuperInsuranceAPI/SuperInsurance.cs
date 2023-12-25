namespace SuperInsuranceAPI
{
	public class SuperInsurance
	{
		public int Id { get; set; }
		public string PolicyNo { get; set; } = string.Empty;
		public string FirstName { get; set; } = string.Empty;
		public string LastName { get; set; } = string.Empty;
		public string Place { get; set; } = string.Empty;
		public string Policy { get; set; } = string.Empty;
		public string Premium { get; set; } = string.Empty;
		public string VehicleType { get; set; } = string.Empty;
		public int? Contact { get; set; }

	}
}
