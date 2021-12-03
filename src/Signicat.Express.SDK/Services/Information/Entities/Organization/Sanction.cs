using System;
using System.Collections.Generic;

namespace Signicat.Express.Information.Organization
{
    public class Sanction
    {
        /// <summary>
        /// Status description of the result
        /// </summary>
        public SanctionStatus Status { get; set; }
        
        /// <summary>
        /// Optional message describing the status
        /// </summary>
        public string Message { get;set; }
        
        /// <summary>
        /// A list of sanction hits if any
        /// </summary>
        public IList<SanctionOrg> Hits { get; set; }
        
        public Metadata Metadata { get; set; }
    }
    
    /// <summary>
    /// Sanction info for an organization
    /// </summary>
    public class SanctionOrg {
        /// <summary>
        /// Name of the organization
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Aliases for the company
        /// </summary>
        public IList<string> Aliases { get; set; }
        
        /// <summary>
        /// Country code (ISO 3166-1 alpha-2)
        /// </summary>
        public Iso3166 Nationality { get; set; }
        
        /// <summary>
        /// Title
        /// </summary>
        public string Title { get; set; }
        
        /// <summary>
        /// Details about what the organization does
        /// </summary>
        public string Function { get; set; }
        
        /// <summary>
        /// Comment
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// List of addresses found
        /// </summary>
        public IList<Address> Addresses { get; set; }
        
        /// <summary>
        /// External id
        /// </summary>
        public string ExternalId { get; set; }
        
        /// <summary>
        /// Date of last update
        /// </summary>
        public DateTimeOffset? LastUpdate { get; set; }
        
        /// <summary>
        /// Date of first update
        /// </summary>
        public DateTimeOffset? FirstUpdate { get; set; }
        
        public OrganizationMetadata Metdata { get; set; }
    }
}