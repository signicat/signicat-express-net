using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Signicat.Express.Admin
{
    public interface IAdminService
    {
        /// <summary>
        /// Retrieves the details of your Signicat account.
        /// </summary>
        /// <returns></returns>
        Account GetAccount();

        /// <summary>
        /// Retrieves the details of your Signicat account.
        /// </summary>
        /// <returns></returns>
        Task<Account> GetAccountAsync();

        /// <summary>
        /// Updates your Signicat account.
        /// </summary>
        /// <param name="accountUpdateOptions"></param>
        /// <returns></returns>
        Account UpdateAccount(AccountUpdateOptions accountUpdateOptions);

        /// <summary>
        /// Updates your Signicat account.
        /// </summary>
        /// <param name="accountUpdateOptions"></param>
        /// <returns></returns>
        Task<Account> UpdateAccountAsync(AccountUpdateOptions accountUpdateOptions);

        /// <summary>
        /// Creates a new Signicat account.
        /// </summary>
        /// <param name="accountCreateOptions"></param>
        /// <returns></returns>
        Account CreateAccount(AccountCreateOptions accountCreateOptions);

        /// <summary>
        /// Creates a new Signicat account.
        /// </summary>
        /// <param name="accountCreateOptions"></param>
        /// <returns></returns>
        Task<Account> CreateAccountAsync(AccountCreateOptions accountCreateOptions);

        /// <summary>
        /// Sets your Signicat account to inactive/disabled.
        /// </summary>
        void DisableAccount();

        /// <summary>
        /// Sets your Signicat account to inactive/disabled.
        /// </summary>
        /// <returns></returns>
        Task DisableAccountAsync();

        /// <summary>
        /// Returns a list of accounts you have access to.
        /// </summary>
        /// <returns></returns>
        IList<AccountListItem> ListAccounts(
            string name = null,
            string orgNo = null,
            string uniCustomerNo = null,
            DateTime? createdBefore = null,
            DateTime? createdAfter = null,
            DateTime? lastModifiedBefore = null,
            DateTime? lastModifiedAfter = null,
            string dealerName = null,
            string dealerReference = null,
            List<string> tags = null,
            bool? enabled = null);

        /// <summary>
        /// Returns a list of accounts you have access to.
        /// </summary>
        /// <returns></returns>
        Task<IList<AccountListItem>> ListAccountsAsync(
            string name = null,
            string orgNo = null,
            string uniCustomerNo = null,
            DateTime? createdBefore = null,
            DateTime? createdAfter = null,
            DateTime? lastModifiedBefore = null,
            DateTime? lastModifiedAfter = null,
            string dealerName = null,
            string dealerReference = null,
            List<string> tags = null,
            bool? enabled = null);

        /// <summary>
        /// Returns a list of names of accounts you have access to.
        /// </summary>
        /// <returns></returns>
        IList<AccountNameItem> ListAccountNames();

        /// <summary>
        /// Returns a list of names of accounts you have access to.
        /// </summary>
        /// <returns></returns>
        Task<IList<AccountNameItem>> ListAccountNamesAsync();

        /// <summary>
        /// Retrieves the details of a single dealer.
        /// </summary>
        /// <param name="dealerId"></param>
        /// <returns></returns>
        Dealer GetDealer(Guid dealerId);

        /// <summary>
        /// Retrieves the details of a single dealer.
        /// </summary>
        /// <param name="dealerId"></param>
        /// <returns></returns>
        Task<Dealer> GetDealerAsync(Guid dealerId);

        /// <summary>
        /// Updates a dealer.
        /// </summary>
        /// <param name="dealerId"></param>
        /// <param name="dealer"></param>
        /// <returns></returns>
        Dealer UpdateDealer(Guid dealerId, Dealer dealer);

        /// <summary>
        /// Updates a dealer.
        /// </summary>
        /// <param name="dealerId"></param>
        /// <param name="dealer"></param>
        /// <returns></returns>
        Task<Dealer> UpdateDealerAsync(Guid dealerId, Dealer dealer);

        /// <summary>
        /// Returns a list of accounts for a dealer.
        /// </summary>
        /// <param name="dealerId"></param>
        /// <returns></returns>
        IList<AccountListItem> ListAccountsForDealer(Guid dealerId);

        /// <summary>
        /// Returns a list of accounts for a dealer.
        /// </summary>
        /// <param name="dealerId"></param>
        /// <returns></returns>
        Task<IList<AccountListItem>> ListAccountsForDealerAsync(Guid dealerId);

        /// <summary>
        /// Returns a list of transactions for the requested account.
        /// </summary>
        /// <returns></returns>
        IList<Transaction> ListTransactions(
            int year,
            int? month = null,
            bool? getAsCsv = null);

        /// <summary>
        /// Returns a list of transactions for the requested account.
        /// </summary>
        /// <returns></returns>
        Task<IList<Transaction>> ListTransactionsAsync(
            int year,
            int? month = null,
            bool? getAsCsv = null);

        /// <summary>
        /// Returns a list of PDF templates for your Signicat account.
        /// </summary>
        /// <returns></returns>
        IList<PdfTemplateListItem> ListTemplates();

        /// <summary>
        /// Returns a list of PDF templates for your Signicat account.
        /// </summary>
        /// <returns></returns>
        Task<IList<PdfTemplateListItem>> ListTemplatesAsync();

        /// <summary>
        /// Creates a new PDF template.
        /// </summary>
        /// <returns></returns>
        PdfTemplate CreateTemplate(PdfTemplateOptions pdfTemplateOptions);

        /// <summary>
        /// Creates a new PDF template.
        /// </summary>
        /// <returns></returns>
        Task<PdfTemplate> CreateTemplateAsync(PdfTemplateOptions pdfTemplateOptions);

        /// <summary>
        /// Retrieves the details of a single PDF template.
        /// </summary>
        /// <returns></returns>
        PdfTemplate GetTemplate(Guid id);

        /// <summary>
        /// Retrieves the details of a single PDF template.
        /// </summary>
        /// <returns></returns>
        Task<PdfTemplate> GetTemplateAsync(Guid id);

        /// <summary>
        /// Updates the specified PDF template.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pdfTemplateOptions"></param>
        /// <returns></returns>
        PdfTemplate UpdateTemplate(Guid id, PdfTemplateOptions pdfTemplateOptions);

        /// <summary>
        /// Updates the specified PDF template.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pdfTemplateOptions"></param>
        /// <returns></returns>
        Task<PdfTemplate> UpdateTemplateAsync(Guid id, PdfTemplateOptions pdfTemplateOptions);

        /// <summary>
        /// Deletes a PDF template.
        /// </summary>
        /// <param name="id"></param>
        void DeleteTemplate(Guid id);

        /// <summary>
        /// Deletes a PDF template.
        /// </summary>
        /// <param name="id"></param>
        Task DeleteTemplateAsync(Guid id);
    }
}