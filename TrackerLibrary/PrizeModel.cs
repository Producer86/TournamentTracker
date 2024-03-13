namespace TrackerLibrary
{
  public class PrizeModel
  {
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
  }
}
