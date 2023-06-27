namespace POS.Model
{
    public class MovieDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Mail { get;set; }

        public string MobileNumber { get; set; } = string.Empty;

        public decimal? Amount { get; set; }

        public int NoOfSeats { get; set; }

        public string MovieName { get; set; }

    }
}