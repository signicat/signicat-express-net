namespace Signicat.Express.Information
{
    /// <summary>
    /// Account Type
    /// </summary>
    public class AccountDetails
    {
        /// <summary>
        /// Account types enumeration
        /// </summary>
        public AccountType AccountType { get; set; }
        
        /// <summary>
        /// Account status enumeration
        /// </summary>
        public AccountStatus AccountStatus { get; set; }

        /// <summary>
        /// If the account is shared
        /// </summary>
        public bool? IsJoinedAccount { get; set; }

        /// <summary>
        /// The number of account holders 
        /// </summary>
        public int? NumberOfHolders { get; set; }
        
        /// <summary>
        /// If the account is foreign
        /// </summary>
        public bool? Foreign { get; set; }
        
        /// <summary>
        /// Country code
        /// </summary>
        public Iso3166 CountryOfAccount { get; set; }
    }
    
    
    public enum AccountType {
        Person  = 0,
        Organization = 1,
        Unknown = 2,
    }
    
    public enum AccountStatus {
        Active   = 0,
        Inactive  = 1,
        Unknown = 2,
    }
}