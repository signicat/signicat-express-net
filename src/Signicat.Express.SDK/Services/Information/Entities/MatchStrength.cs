namespace Signicat.Express.Information
{
    /// <summary>
    /// An indication of how relevant the result is
    /// </summary>
    public class MatchStrength
    {
        /// <summary>
        /// A score from 0 - 100 where higher values are more relevant
        /// </summary>
        public int? Score { get; set; }
        
        /// <summary>
        /// Used if an exact score is unavailable
        /// </summary>
        public MatchCertainty Certainty { get; set; }
    }

    public enum MatchCertainty
    {
        Unknown = 0,
        High = 1,
        Medium = 2,
        Low = 3
    }
}