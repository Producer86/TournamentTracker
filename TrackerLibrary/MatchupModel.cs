namespace TrackerLibrary
{
  public class MatchupModel
  {
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