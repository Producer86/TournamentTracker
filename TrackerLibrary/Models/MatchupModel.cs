namespace TrackerLibrary.Models
{
  public class MatchupModel
  {
    /// <summary>
    /// Unique identifier for a Matchup.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Entries for each Team competing in this Matchup.
    /// </summary>
    public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

    /// <summary>
    /// The winner Team of this Matchup.
    /// </summary>
    public TeamModel Winner { get; set; }

    /// <summary>
    /// The Rounds this Matchup takes place in.
    /// </summary>
    public int MatchupRound { get; set; }
  }
}