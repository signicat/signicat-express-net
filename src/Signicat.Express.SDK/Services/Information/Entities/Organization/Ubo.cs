using System.Collections.Generic;

namespace Signicat.Express.Information.Organization
{
    public class Ubo
    {
        /// <summary>
        /// Ultimate beneficiary owners
        /// </summary>
        public IList<UltimateBeneficiaryOwner> UltimateBeneficiaryOwners { get; set; }
        
        public Metadata Metadata { get; set; }
    }

    public class UltimateBeneficiaryOwner
    {
        public UboOwnership Ownership { get; set; }
        
        public Name Name { get; set; }
        
        public Address Address { get; set; }
        
        public Birth Birth { get; set; }

        public Gender Gender { get; set; }
        
        public IdNumberDto IdentityNumber { get; set; }
        
        public Iso3166 Nationality { get; set; }
        
        public UboRole Role { get; set; }
    }

    /// <summary>
    /// Ownership information
    /// </summary>
    public class UboOwnership
    {
        /// <summary>
        /// Shareholding percentage
        /// </summary>
        public double? DirectOwnership { get; set; }

        public OwnershipRange DirectOwnershipRange { get; set; }
        
        /// <summary>
        /// Indirect ownership
        /// </summary>
        public double? IndirectOwnership { get; set; }
        
        /// <summary>
        /// Direct and indirect ownership
        /// </summary>
        public double? IntegratedOwnership { get; set; }
        
        /// <summary>
        /// Voting rights of the person in percent
        /// </summary>
        public double? VotingRights { get; set; }

        /// <summary>
        /// Voting power in percent. The voting power may reflect the ability to influence the voting outcome or the extent of control over the company (the exact formula used to calculate this value may be different depending on the source).
        /// </summary>
        public double? VotingPower { get; set; }

        public VotingPowerRange VotingPowerRange { get; set; }
    }

    /// <summary>
    /// Shareholding percentage range
    /// </summary>
    public class OwnershipRange : Range
    {
    }

    /// <summary>
    /// Voting power percentage range
    /// </summary>
    public class VotingPowerRange : Range
    {
        
    }
    
    /// <summary>
    /// Role of the person
    /// </summary>
    public enum UboRole {
        Unknown = 0,
        BoardMember = 1,
        Shareholder = 2,
        Other = 3
    }
}