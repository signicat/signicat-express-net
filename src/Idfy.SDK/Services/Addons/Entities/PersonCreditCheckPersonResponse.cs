using System.Collections.Generic;

namespace Idfy.Addons.Entities
{
    public class PersonCreditCheckPersonResponse
    { 
        /// <summary>
        /// Gets or Sets RequestId
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Gets or Sets Report
        /// </summary>
        public string Report { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets PostalCode
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or Sets Score
        /// </summary>
        public int? Score { get; set; }

        /// <summary>
        /// Gets or Sets ScoreDecision
        /// </summary>
        public string ScoreDecision { get; set; }

        /// <summary>
        /// Gets or Sets DateOfBirth
        /// </summary>
        public string DateOfBirth { get; set; }

        /// <summary>
        /// Gets or Sets Age
        /// </summary>
        public int? Age { get; set; }

        /// <summary>
        /// Gets or Sets Gender
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfPaymentDefaults
        /// </summary>
        public int? NumberOfPaymentDefaults { get; set; }

        /// <summary>
        /// Gets or Sets PaymentDefaultsAmount
        /// </summary>
        public double? PaymentDefaultsAmount { get; set; }

        /// <summary>
        /// Gets or Sets IncomeAndFortune
        /// </summary>
        public List<PersonEconomy> IncomeAndFortune { get; set; }

        /// <summary>
        /// Gets or Sets DetailedInformation
        /// </summary>
        public PersonHentPersonResponse DetailedInformation { get; set; }
    }
}
