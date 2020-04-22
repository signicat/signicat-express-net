﻿﻿using System;
using System.Collections.Generic;
 using IdentiSign.Addonservices.Models.Aml;
 using IdentiSign.Addonservices.Models.Aml.Vipps.Organization;
 using IdentiSign.Addonservices.Models.Infrastructure;
 using Newtonsoft.Json;

namespace Idfy.Addons
{
    /// <summary>
    /// Basic information about a person
    /// </summary>
    public class BasicPersonInformationModel
    {
        /// <summary>
        /// Full name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// First name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Date of birth
        /// </summary>
        [JsonConverter(typeof(DateWithOutTimeFormatter))]
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// National ID number
        /// </summary>
        public string Ssn { get; set; }

        /// <summary>
        /// Gender
        /// </summary>
        public Gender? Gender { get; set; }

        /// <summary>
        /// Sources and other information
        /// </summary>
        public PersonMetaData MetaData { get; set; }
    }
    /// <summary>
    /// Information about screened person
    /// </summary>
    public class PersonInformation : BasicPersonInformationModel
    {
        /// <summary>
        /// List of citizenship, must be asked for with expand 
        /// </summary>
        public IEnumerable<CitizenshipModel> Citizenship { get; set; }

        /// <summary>
        /// Screened persons place of birth
        /// </summary>
        public BirthPlaceModel BirthPlace { get; set; }
        /// <summary>
        /// List of historic names, must be asked for with expand
        /// </summary>
        public IEnumerable<HistoricName> HistoricNames { get; set; }
    }

    /// <summary>
    /// Historic name
    /// </summary>
    public class HistoricName
    {
        /// <summary>
        /// First name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Middle name
        /// </summary>
        public string MiddleName { get; set; }
        /// <summary>
        /// Last name
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Date the change got registered 
        /// </summary>
        public string RegisteredDate { get; set; }
        
    }
    /// <summary>
    /// Information about Citizenship
    /// </summary>
    public class CitizenshipModel
    {
        /// <summary>
        /// Country Code (ISO 3166)
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// Start date of citizenship, if available
        /// </summary>
        [JsonConverter(typeof(DateWithOutTimeFormatter))]
        public DateTime? Start { get; set; }
        
        /// <summary>
        /// End date, if applicable and available
        /// </summary>
        [JsonConverter(typeof(DateWithOutTimeFormatter))]
        public DateTime? End { get; set; }
    }

    /// <summary>
    /// Birth place information
    /// </summary>
    public class BirthPlaceModel
    {
        /// <summary>
        /// Country code (ISO 3166) 
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// Location if known
        /// </summary>
        public string Location { get; set; }

        public PersonMetaData MetaData { get; set; }
    }

    /// <summary>
    /// Family information, not yet implemented
    /// </summary>
    public class PersonFamilyModel
    {
        public IEnumerable<BasicPersonInformationModel> Children { get; set; }

        public RelationshipsStatusTypes MaritalStatus { get; set; }

        public BasicPersonInformationModel Partner { get; set; }

        public string FamilyName { get; set; }

        public PersonMetaData MetaData { get; set; }
    }

    public enum RelationshipsStatusTypes
    {
        UNKOWN,
        SINGEL,
        MARRIED,
    }
}