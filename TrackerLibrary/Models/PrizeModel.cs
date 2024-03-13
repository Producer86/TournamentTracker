namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// Unique identifier for the Prize.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Placement number this Prize belongs to.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Placement name this Prize belongs to.
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// The prize amount that comes with this Prize.
        /// Mutually exclusive with PrizePercentage.
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// The prize pool percentage that comes with this Prize.
        /// Mutually exclusive with PrizeAmount.
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        { }

        public PrizeModel(string placeNumber, string placeName, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
