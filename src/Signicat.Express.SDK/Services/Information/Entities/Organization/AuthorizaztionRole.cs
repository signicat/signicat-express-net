namespace Signicat.Express.Information.Organization
{
    /// <summary>
    /// Role of the entity
    /// </summary>
    public enum AuthorizationRole {
    
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,
    
        /// <summary>
        /// CEO
        /// </summary>
        Ceo = 1,

        /// <summary>
        /// Chair of the board
        /// </summary>
        BoardLeader = 2,
    
        /// <summary>
        /// A member of the board
        /// </summary>
        BoardMember = 3,

        /// <summary>
        /// Right to represent and sign on behalf of the company.
        /// </summary>
        Signature = 5,
    
        /// <summary>
        /// Right to represent and sign on behalf of the company on day-to-day activity.
        /// </summary>
        Procuration = 4,

        /// <summary>
        /// Bookkeeper for a company. NO: Regnskapfører
        /// </summary>
        Bookkeeper = 6,
    
        /// <summary>
        /// Accountant for a company. NO: Revisor
        /// </summary>
        Accountant = 7,
    }
}