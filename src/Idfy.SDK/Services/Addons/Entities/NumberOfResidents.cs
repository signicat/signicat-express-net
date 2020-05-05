namespace Idfy.Addons.Entities
{
    public class NumberOfResidents
    { 
        /// <summary>
        /// Gets or Sets Residents
        /// </summary>
        public int? Residents { get; set; }

        /// <summary>
        /// Gets or Sets HouseType
        /// </summary>
        public NumberOfResidentsHouseType? HouseType { get; set; }

        /// <summary>
        /// Gets or Sets MetaData
        /// </summary>
        public PersonMetaData MetaData { get; set; }
    }
}
