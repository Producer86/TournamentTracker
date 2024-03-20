namespace TrackerLibrary.Models
{
  public class MatchupEntryModel
  {
    /// <summary>
    /// The unique identifier of a matchup entry.
    /// </summary>    
    public int Id { get; set; }

    /// <summary>
    /// A Team competing in this Matchup.
    /// </summary>
    public TeamModel TeamCompeting { get; set; }

    /// <summary>
    /// The score the Team has in this Matchup.
    /// </summary>
    public double Score { get; set; }

    /// <summary>
    /// The Matchup this entry belongs to.
    /// </summary>
    public MatchupModel ParentMatchup { get; set; }
  }
}
