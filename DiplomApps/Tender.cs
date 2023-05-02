namespace DiplomApps
{
	public class Tender
	{
		public int Id { get; set; }
		public string StartCity { get; set; }
		public string FinishCity { get; set; }
		public string DateStart { get; set; }
		public string DateFinish { get; set; }
		public string Product { get; set; }
		public string Quantity { get; set; }
		public int ParticipantID { get; set; }
		public decimal Price { get; set; }
		public string Status { get; set; }
	}
}
