namespace Signicat.Express.Information
{
    public enum EntityType
    {
        Unknown = 0,
        
        Organization = 1,
        
        Person = 2
    }
    
    public class EntityQuery : QueryParams
    {
        /// <summary>
        /// Id of the entity to search for
        /// </summary>
        public string Id { get; set; }
        
        /// <summary>
        /// Name of the entity to search for
        /// </summary>
        public string Name { get; set; }
    }

    public class GlobalEntityQuery : EntityQuery
    {
        /// <summary>
        /// Comma-separated list of countries to include in the search - ISO 3166-1 format
        /// </summary>
        public string Countries { get; set; }
    }

    public class GlobalOrganizationEntityQuery : GlobalEntityQuery
    {
        /// <summary>
        /// Optional hint to what kind of id being used.
        /// Allowed values are `organization`, `tax` and `external`, defaults to `organization` and is only used by a limited number of sources.
        /// </summary>
        public string IdType { get; set; }
    }
}