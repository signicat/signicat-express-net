﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using IdentiSign.Addonservices.Models.Infrastructure;
using Newtonsoft.Json;
using Signicat.Aml.Vipps.Client.Models.API;

namespace Idfy.Addons
{
    public class OrganizationResponseModel
    {
        /// <summary>
        /// Organization key information like name organization number and registeredDate
        /// </summary>
        public OrganizationInformationModel KeyInformation { get; set; }

        /// <summary>
        /// Address information for the organization
        /// </summary>
        public OrganizationAddress Address { get; set; }

        /// <summary>
        /// AML sanction result for the organization
        /// </summary>
        public OrganizationSanctionsResults Sanction { get; set; }

        /// <summary>
        /// Official roles for the organization, ceo, chair and board-members
        /// </summary>
        public OfficialRoles OfficialRoles { get; set; }

        /// <summary>
        /// Ownership for the organization, beneficial owners, shareholders and subsidiaries.
        /// </summary>
        public OrganizationOwnersModel Ownership { get; set; }

        /// <summary>
        /// List of persons that have authorization to sign for the organization
        /// </summary>
        public OrganizationAuthorizationModel Authorities { get; set; }
        
        /// <summary>
        /// List of persons that have authorization to sign for the organization
        /// </summary>
        public OrganizationAuthorizationModelLegacy Authorizations { get; set; }

        /// <summary>
        /// Financial information for the organizations including credit and accounting information
        /// </summary>
        public OrganizationFinancialsModel Financials { get; set; }

        /// <summary>
        /// List of links to external resources or to reports.
        /// </summary>
        public LinksModel Links { get; set; }
    }

    public class LinksModel
    {
        /// <summary>
        /// List of reports that is created. Use the same token and poll until you get status code 200.
        /// </summary>
        public List<LinkItemModel> Reports { get; set; }

        /// <summary>
        /// List of urls to external resources
        /// </summary>
        public List<LinkItemModel> External { get; set; }
    }

    public class OrganizationFinancialsModel
    {
        public OrganizationFinanicialBasicModel KeyFigures { get; set; }

        /// <summary>
        /// The name and organization number for the organizations auditor
        /// </summary>
        public CompanyWithMetaDataModel Auditor { get; set; }

        /// <summary>
        /// The name and organization number for the organizations accountant
        /// </summary>
        public CompanyWithMetaDataModel Accountant { get; set; }

        /// <summary>
        /// Credit information including rating and historic data for the organization
        /// </summary>
        public OrganizationFinanicialCreditModel Credit { get; set; }

        /// <summary>
        /// Accounting information for the organization going back maximum 3 years
        /// </summary>
        public AccountingModel Accounting { get; set; }
    }

    public class AccountingModel
    {
        /// <summary>
        /// List of accounting years
        /// </summary>
        public List<AccountingYearModel> Years { get; set; }

        /// <summary>
        /// Meta data for the content, contains source information, url and other metadata.
        /// </summary>
        public OrganizationMetaData Metadata { get; set; }
    }

    public class BalanceSheetModel
    {
        public double? CurrentAssets { get; set; }
        public double? FixedAssets { get; set; }
        public double? SumAssets { get; set; }
        public double? Equity { get; set; }
        public double? Debt { get; set; }
        public double? SumEquityAndDebt { get; set; }
    }

    public class IncomeStatementModel
    {
        public double? SalesRevenues { get; set; }
        public double? OtherRevenues { get; set; }
        public double? TotalRevenues { get; set; }
        public double? CostOfGoodsSold { get; set; }
        public double? InventoryChanges { get; set; }
        public double? SalaryCosts { get; set; }
        public double? FinancialCosts { get; set; }
        public double? Depreciations { get; set; }
        public double? Amortizations { get; set; }
        public double? OtherOperatingCosts { get; set; }
        public double? OperatingProfits { get; set; }
        public double? OrdinaryProfits { get; set; }
        public double? Taxes { get; set; }
        public double? ExtraordinaryRevenues { get; set; }
        public double? ExtraordinaryCosts { get; set; }
        public double? MinorityInterests { get; set; }
        public double? ResultBeforeTax { get; set; }
        public double? NetProfits { get; set; }
    }

    public class AccountingYearModel
    {
        public int Year { get; set; }

        public IncomeStatementModel IncomeStatement { get; set; }
        public BalanceSheetModel BalanceSheet { get; set; }
    }

    public class OrganizationFinanicialCreditModel
    {
        /// <summary>
        /// Current credit information
        /// </summary>
        public OrganizationFinanicialCreditItemModel Current { get; set; }

        /// <summary>
        /// Historic credit information
        /// </summary>
        public List<OrganizationFinanicialCreditHistoricItemModel> Historical { get; set; }

        /// <summary>
        /// The organization payment defaults
        /// </summary>
        public PaymentDefaultModel PaymentDefaults { get; set; }

        /// <summary>
        /// Meta data for the content, contains source information, url and other metadata.
        /// </summary>
        public OrganizationMetaData Metadata { get; set; }
    }


    public class OrganizationFinanicialCreditItemModel
    {
        public string Rating { get; set; }

        public string RatingDescription { get; set; }

        
    }

    public class OrganizationFinanicialCreditHistoricItemModel
    {
        public string Rating { get; set; }        

        public int Year { get; set; }

        public CreditHistoryItemChangeModel Change { get; set; }
    }

    public class CreditHistoryItemChangeModel
    {
        public int? Year { get; set; }

        public int? Month { get; set; }
    }

    public class PaymentDefaultModel
    {
        public string Description { get; set; }

        public int Count { get; set; }
    }


    public class OrganizationFinanicialBasicModel
    {
        public double ShareCapital { get; set; }

        public double? TurnOver { get; set; }

        public double? OperatingProfit { get; set; }

        public double? Equity { get; set; }

        public double? Earnings { get; set; }

        public OrganizationMetaData Metadata { get; set; }
    }


    public class OrganizationAuthorizationModel
    {
        /// <summary>
        /// Information about the organization's signature rights.
        /// </summary>
        public SignatureModel SignatureRights { get; set; }

        /// <summary>
        /// Information about the organization's power of procuration rules.
        /// </summary>
        public SignatureModel PowerOfProcuration { get; set; }

        /// <summary>
        /// Meta data for the content, contains source information, url and other metadata.
        /// </summary>
        public OrganizationMetaData Metadata { get; set; }
    }
    public class OrganizationAuthorizationModelLegacy
    {
        /// <summary>
        /// Information about the organization's signature rights.
        /// </summary>
        public SignatureModelLegacy SignatureRights { get; set; }

        /// <summary>
        /// Information about the organization's power of procuration rules.
        /// </summary>
        public SignatureModelLegacy PowerOfProcuration { get; set; }

        /// <summary>
        /// Meta data for the content, contains source information, url and other metadata.
        /// </summary>
        public OrganizationMetaData Metadata { get; set; }
    }

    public class SignatureModelLegacy
    {
        public string RequirementsDecription { get; set; }
    }

    public class SignatureModel
    {
        /// <summary>
        /// Status of signing rights 
        /// </summary>
        public AuthorizationStatus Status { get; set; }
        /// <summary>
        /// Description 
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// A list of different options for valid signatures 
        /// </summary>
        public List<SigningOptionModel> Options { get; set; }
        /// <summary>
        /// List of remarks for the signature model. 
        /// </summary>
        public List<Remark> Remarks { get; set; }
    }

    /// <summary>
    /// Remarks to the signing result
    /// </summary>
    public class Remark
    {
        /// <summary>
        /// Different categories of remark
        /// </summary>
        public RemarkCategory Category { get; set; }
        /// <summary>
        /// Human readable comment to the remark
        /// </summary>
        public string Comment { get; set; }
        
    }

    /// <summary>
    /// Category of remark
    /// </summary>
    public enum RemarkCategory
    {
        /// <summary>
        /// If the conclusive result might have exceptions, like for example deptuy boardmembers
        /// </summary>
        EXCEPTIONS_POSSIBLE,
        /// <summary>
        /// Category for when we adds info to the signing description
        /// </summary>
        SUPPLEMENTED,
        /// <summary>
        /// Missing role members, to fulfill an otherwise Conclusive description
        /// </summary>
        INCOMPLETE_DATA
    }
    
    public class SigningOptionModel
    {
        /// <summary>
        /// List of required signers
        /// </summary>
        public List<Signature> Required { get; set; }
        /// <summary>
        /// List of other signers than can be mixed
        /// </summary>
        [JsonIgnore]
        public SignSelectionModel Selection { get; set; }
        
    }
    /// <summary>
    /// Selection
    /// </summary>
    public class SignSelectionModel 
    {
        /// <summary>
        /// Number of signers from this bulk
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// List of persons that are available for signing 
        /// </summary>
        public List<Signature> Persons { get; set; }
    }
    

    /// <summary>
    /// If the signing rights can be interpreted programatically 
    /// </summary>
    public enum AuthorizationStatus
    {
        /// <summary>
        /// The signing rights can be determined programatically
        /// </summary>
        CONCLUSIVE,
        /// <summary>
        /// The signing rights can not be determined programatically
        /// </summary>
        IN_CONCLUSIVE,
        /// <summary>
        /// No status is set
        /// </summary>
        NOT_SET
    }

//    public class SignatureModel
//    {
//        /// <summary>
//        /// A textual description of the signature requirements
//        /// </summary>
//        public string RequirementsDescription { get; set; }
//
//        /// <summary>
//        /// List of signers that have to sign to create a valid signature
//        /// </summary>
//        public List<Signature> Required { get; set; }
//
//        /// <summary>
//        /// List of optional signers, where a given number of them have to sign in order to create a valid signature
//        /// </summary>
//        public OtherSignatures Others { get; set; }
//    }

//    public class OtherSignatures
//    {
//        /// <summary>
//        /// How many others do have to sign to make the signature valid
//        /// </summary>
//        public int RequiredNumberOfOthers { get; set; }
//
//        /// <summary>
//        /// Optional signers, the number of other signers to signed is given in requiredNumberOfOthers.
//        /// </summary>
//        public List<Signature> Signatures { get; set; }
//    }

    public class Signature
    {
        /// <summary>
        /// The name of the person
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The date of birth for the person
        /// </summary>
        [JsonConverter(typeof(DateWithOutTimeFormatter))]
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// The persons role in the organization
        /// </summary>
        public Roles? Role { get; set; }
    }

    public class OrganizationOwnersModel
    {
        /// <summary>
        /// List beneficial owners of the organization. When the ownership structure of an entity indicates that there are no beneficial owners, this list will be empty.
        /// </summary>
        public List<BeneficialOwner> Beneficial { get; set; }
        /// <summary>
        /// The list of the organization share holders
        /// </summary>
        public List<ShareholderModel> Shareholders { get; set; }

        /// <summary>
        /// The organizations subsidiaries, this list is empty the organization does not have any subsidiaries.
        /// </summary>
        public List<CompanyOwnerShipModel> Subsidiaries { get; set; }


        /// <summary>
        /// Meta data for the content, contains source information, url and other metadata.
        /// </summary>
        public OrganizationMetaData Metadata { get; set; }
    }

    public class SectorModel
    {
        /// <summary>
        /// Sector code 
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Description of sector 
        /// </summary>
        public string Description { get; set; }
    }

    public class ShareholderModel
    {
        /// <summary>
        /// The name of the share holder.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Organization number if the share holder is an organization, if a the shareholder is a person this is empty.
        /// </summary>
        public string OrganizationNumber { get; set; }

        /// <summary>
        /// The percentage the share holder owns.
        /// </summary>
        public double? Percentage { get; set; }

        /// <summary>
        /// Date of birth  if the share holder is an person, if a the shareholder is a organization this is empty.
        /// </summary>
        [JsonConverter(typeof(DateWithOutTimeFormatter))]
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// The type of owner, person or organization.
        /// </summary>
        public OwnerType Type { get; set; }
    }

    public enum OwnerType
    {
        PERSON,
        ORGANIZATION,
    }

    public class OrganizationInformationModel
    {
        /// <summary>
        /// The name of the organization
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The organization registration number
        /// </summary>
        public string OrganizationNumber { get; set; }

        /// <summary>
        /// The organization DUNS number, read more about that here: https://en.wikipedia.org/wiki/Data_Universal_Numbering_System
        /// </summary>
        public string DunsNumber { get; set; }

        /// <summary>
        /// The organizations LEI number, include keyInformation.lei in the expand paramter to get this. Read more about lei here: https://en.wikipedia.org/wiki/Legal_Entity_Identifier
        /// </summary>
        public string LeiNumber { get; set; }

        /// <summary>
        /// The organization type
        /// </summary>
        public Organizationtypes? OrganizationType { get; set; }

        /// <summary>
        /// The organization phone number if found
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The resident country for the organization
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// The registration date for the organization
        /// </summary>
        [JsonConverter(typeof(DateWithOutTimeFormatter))]
        public DateTime? RegisteredDate { get; set; }
        
        ///<summary>
        /// The established date for the organization
        /// </summary>
        [JsonConverter(typeof(DateWithOutTimeFormatter))]
        public DateTime? EstablishedDate { get; set; }

        /// <summary>
        /// The url for the organization if available
        /// </summary>
        public string Webpage { get; set; }

        /// <summary>
        /// The purpose for the organization if available
        /// </summary>
        public string Purpose { get; set; }

        /// <summary>
        /// Information about how many employees the organization have.
        /// </summary>
        public EmployeesModel Employees { get; set; }

        /// <summary>
        /// List of registries the organization is a member of
        /// </summary>
        public List<string> MemberOfRegistries { get; set; }

        /// <summary>
        /// Institutional Sector 
        /// </summary>
        public SectorModel InstitutionalSector { get; set; }
        /// <summary>
        /// Institutional Sector 
        /// </summary>
        public SectorModel IndustrySector { get; set; }
        /// <summary>
        /// List of current status codes for the organization
        /// </summary> 
        public List<string> StatusCodes { get; set; }
        /// <summary>
        /// Meta data for the content, contains source information, url and other metadata.
        /// </summary>
        public OrganizationMetaData Metadata { get; set; }
    }

    /// <summary>
    /// Information about how many employees the organization have.
    /// </summary>
    public class EmployeesModel
    {
        /// <summary>
        /// Employees from 
        /// </summary>
        public int From { get; set; }

        /// <summary>
        /// Employees to 
        /// </summary>
        public int To { get; set; }
    }


    public class CompanyModel
    {
        /// <summary>
        /// The name of the organization
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The organization number
        /// </summary>
        public string OrganizationNumber { get; set; }
    }

    public class CompanyWithMetaDataModel : CompanyModel
    {
        /// <summary>
        /// Meta data for the content, contains source information, url and other metadata.
        /// </summary>
        public OrganizationMetaData Metadata { get; set; }
    }

    public class CompanyOwnerShipModel : CompanyModel
    {
        /// <summary>
        /// The percentage of share the organization owns.
        /// </summary>
        public double? Percentage { get; set; }
    }

    /// <summary>
    /// Meta data for the content, contains source information, url and other metadata.
    /// </summary>
    public class OrganizationMetaData
    {
        /// <summary>
        /// List of sources for the data
        /// </summary>
        public List<Sources> Sources { get; set; }

        /// <summary>
        /// Public urls to the sources if available
        /// </summary>
        public List<string> Urls { get; set; }

        /// <summary>
        /// The accounting year the data originates from
        /// </summary>
        public int? AccountingYear { get; set; }

        /// <summary>
        /// The date the data was last changed if available
        /// </summary>
        public DateTime? LastChanged { get; set; }
    }

    /// <summary>
    /// Meta data for the content, contains source information, url and other metadata.
    /// </summary>
    public class PersonMetaData
    {
        /// <summary>
        /// List of sources for the data
        /// </summary>
        public List<Sources> Sources { get; set; }

        /// <summary>
        /// Public urls to the sources if available
        /// </summary>
        public List<string> Urls { get; set; }
        

        /// <summary>
        /// The date the data was last changed if available
        /// </summary>
        public DateTime? LastChanged { get; set; }
    }

    public enum Sources
    {
        [Description("Bisnode")] BISNODE,

        [Description("Norwegian Brønnøysund Register Centre")]
        BRREG,

        [Description("Consolidated list of UN sanctions")]
        UN_CONSOLIDATED,

        [Description("Consolidated list of persons, groups and entities subject to EU financial sanctions")]
        EU_GLOBAL,

        [Description("A list of all those subject to financial sanctions imposed by the UK")]
        HMTREASURY,

        [Description(
            "List of individuals and companies owned or controlled by, or acting for or on behalf of, targeted countries. It also lists individuals, groups, and entities, such as terrorists and narcotics traffickers designated under programs that are not country-specific.")]
        OFAC,

        [Description("An automatically collected PEP list with world coverage")]
        PEP_AC,

        [Description("A manually collected list of PEPs with Nordic focus")]
        PEP_EDGE,

        [Description("GLEIF makes available the Global LEI Index: https://www.gleif.org/")]
        GLEIF,

        [Description("Norwegian National Registry")]
        NO_NATIONAL_REGISTRY,
        [Description("Norwegian Id Provider")]
        NO_BANK_ID
    }
}
