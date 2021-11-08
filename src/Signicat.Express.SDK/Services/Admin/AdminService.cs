using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Signicat.Express.Infrastructure;

namespace Signicat.Express.Admin
{
    /// <summary>
    /// Manage your Signicat account.
    /// </summary>
    public class AdminService : SignicatBaseService, IAdminService
    {
        public AdminService()
        {
        }

        public AdminService(string clientId, string clientSecret, IEnumerable<string> scopes)
            : base(clientId, clientSecret, scopes)
        {
        }
        
        public AdminService(string clientId, string clientSecret, IEnumerable<OAuthScope> scopes)
            : base(clientId, clientSecret, scopes)
        {
        }

        /// <summary>
        /// Retrieves the details of your Signicat account.
        /// </summary>
        /// <returns></returns>
        public Account GetAccount()
        {
            return Get<Account>($"{Urls.Admin}/account");
        }

        /// <summary>
        /// Retrieves the details of your Signicat account.
        /// </summary>
        /// <returns></returns>
        public async Task<Account> GetAccountAsync()
        {
            return await GetAsync<Account>($"{Urls.Admin}/account");
        }

        /// <summary>
        /// Updates your Signicat account.
        /// </summary>
        /// <param name="accountUpdateOptions"></param>
        /// <returns></returns>
        public Account UpdateAccount(AccountUpdateOptions accountUpdateOptions)
        {
            return Put<Account>($"{Urls.Admin}/account", accountUpdateOptions);
        }

        /// <summary>
        /// Updates your Signicat account.
        /// </summary>
        /// <param name="accountUpdateOptions"></param>
        /// <returns></returns>
        public async Task<Account> UpdateAccountAsync(AccountUpdateOptions accountUpdateOptions)
        {
            return await PutAsync<Account>($"{Urls.Admin}/account", accountUpdateOptions);
        }

        /// <summary>
        /// Creates a new Signicat account.
        /// </summary>
        /// <param name="accountCreateOptions"></param>
        /// <returns></returns>
        public Account CreateAccount(AccountCreateOptions accountCreateOptions)
        {
            return Post<Account>($"{Urls.Admin}/account", accountCreateOptions);
        }

        /// <summary>
        /// Creates a new Signicat account.
        /// </summary>
        /// <param name="accountCreateOptions"></param>
        /// <returns></returns>
        public async Task<Account> CreateAccountAsync(AccountCreateOptions accountCreateOptions)
        {
            return await PostAsync<Account>($"{Urls.Admin}/account", accountCreateOptions);
        }

        /// <summary>
        /// Sets your Signicat account to inactive/disabled.
        /// </summary>
        public void DisableAccount()
        {
            Post($"{Urls.Admin}/account/disable");
        }

        /// <summary>
        /// Sets your Signicat account to inactive/disabled.
        /// </summary>
        /// <returns></returns>
        public async Task DisableAccountAsync()
        {
            await PostAsync($"{Urls.Admin}/account/disable");
        }

        /// <summary>
        /// Returns a list of accounts you have access to.
        /// </summary>
        /// <returns></returns>
        public IList<AccountListItem> ListAccounts(
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
            bool? enabled = null)
        {
            var url = APIHelper.AppendQueryParams($"{Urls.Admin}/account/list", new Dictionary<string, object>()
            {
                {"name", name},
                {"orgNo", orgNo},
                {"uniCustomerNo", uniCustomerNo},
                {"createdBefore", createdBefore},
                {"createdAfter", createdAfter},
                {"lastModifiedBefore", lastModifiedBefore},
                {"lastModifiedAfter", lastModifiedAfter},
                {"dealerName", dealerName},
                {"dealerReference", dealerReference},
                {"tags", tags},
                {"enabled", enabled}
            });

            return Get<IList<AccountListItem>>(url);
        }

        /// <summary>
        /// Returns a list of accounts you have access to.
        /// </summary>
        /// <returns></returns>
        public async Task<IList<AccountListItem>> ListAccountsAsync(
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
            bool? enabled = null)
        {
            var url = APIHelper.AppendQueryParams($"{Urls.Admin}/account/list", new Dictionary<string, object>()
            {
                {"name", name},
                {"orgNo", orgNo},
                {"uniCustomerNo", uniCustomerNo},
                {"createdBefore", createdBefore},
                {"createdAfter", createdAfter},
                {"lastModifiedBefore", lastModifiedBefore},
                {"lastModifiedAfter", lastModifiedAfter},
                {"dealerName", dealerName},
                {"dealerReference", dealerReference},
                {"tags", tags},
                {"enabled", enabled}
            });

            return await GetAsync<IList<AccountListItem>>(url);
        }

        /// <summary>
        /// Returns a list of names of accounts you have access to.
        /// </summary>
        /// <returns></returns>
        public IList<AccountNameItem> ListAccountNames()
        {
            return Get<IList<AccountNameItem>>($"{Urls.Admin}/account/list/names");
        }
        
        /// <summary>
        /// Returns a list of names of accounts you have access to.
        /// </summary>
        /// <returns></returns>
        public async Task<IList<AccountNameItem>> ListAccountNamesAsync()
        {
            return await GetAsync<IList<AccountNameItem>>($"{Urls.Admin}/account/list/names");
        }

        /// <summary>
        /// Retrieves the details of a single dealer.
        /// </summary>
        /// <param name="dealerId"></param>
        /// <returns></returns>
        public Dealer GetDealer(Guid dealerId)
        {
            return Get<Dealer>($"{Urls.Admin}/dealer/{dealerId}");
        }
        
        /// <summary>
        /// Retrieves the details of a single dealer.
        /// </summary>
        /// <param name="dealerId"></param>
        /// <returns></returns>
        public async Task<Dealer> GetDealerAsync(Guid dealerId)
        {
            return await GetAsync<Dealer>($"{Urls.Admin}/dealer/{dealerId}");
        }

        /// <summary>
        /// Updates a dealer.
        /// </summary>
        /// <param name="dealerId"></param>
        /// <param name="dealer"></param>
        /// <returns></returns>
        public Dealer UpdateDealer(Guid dealerId, Dealer dealer)
        {
            return Post<Dealer>($"{Urls.Admin}/dealer/{dealerId}", dealer);
        }
        
        /// <summary>
        /// Updates a dealer.
        /// </summary>
        /// <param name="dealerId"></param>
        /// <param name="dealer"></param>
        /// <returns></returns>
        public async Task<Dealer> UpdateDealerAsync(Guid dealerId, Dealer dealer)
        {
            return await PostAsync<Dealer>($"{Urls.Admin}/dealer/{dealerId}", dealer);
        }

        /// <summary>
        /// Returns a list of accounts for a dealer.
        /// </summary>
        /// <param name="dealerId"></param>
        /// <returns></returns>
        public IList<AccountListItem> ListAccountsForDealer(Guid dealerId)
        {
            return Get<IList<AccountListItem>>($"{Urls.Admin}/dealer/{dealerId}/accounts");
        }
        
        /// <summary>
        /// Returns a list of accounts for a dealer.
        /// </summary>
        /// <param name="dealerId"></param>
        /// <returns></returns>
        public async Task<IList<AccountListItem>> ListAccountsForDealerAsync(Guid dealerId)
        {
            return await GetAsync<IList<AccountListItem>>($"{Urls.Admin}/dealer/{dealerId}/accounts");
        }

        /// <summary>
        /// Returns a list of transactions for the requested account.
        /// </summary>
        /// <returns></returns>
        public IList<Transaction> ListTransactions(
            int year,
            int? month = null,
            bool? getAsCsv = null)
        {
            var url = APIHelper.AppendQueryParams($"{Urls.Admin}/invoice", new Dictionary<string, object>()
            {
                {"year", year},
                {"month", month},
                {"getAsCsv", getAsCsv}
            });
            
            return Get<IList<Transaction>>(url);
        }
        
        /// <summary>
        /// Returns a list of transactions for the requested account.
        /// </summary>
        /// <returns></returns>
        public async Task<IList<Transaction>> ListTransactionsAsync(
            int year,
            int? month = null,
            bool? getAsCsv = null)
        {
            var url = APIHelper.AppendQueryParams($"{Urls.Admin}/invoice", new Dictionary<string, object>()
            {
                {"year", year},
                {"month", month},
                {"getAsCsv", getAsCsv}
            });
            
            return await GetAsync<IList<Transaction>>(url);
        }

        /// <summary>
        /// Returns a list of PDF templates for your Signicat account.
        /// </summary>
        /// <returns></returns>
        public IList<PdfTemplateListItem> ListTemplates()
        {
            return Get<IList<PdfTemplateListItem>>($"{Urls.Admin}/template");
        }
        
        /// <summary>
        /// Returns a list of PDF templates for your Signicat account.
        /// </summary>
        /// <returns></returns>
        public async Task<IList<PdfTemplateListItem>> ListTemplatesAsync()
        {
            return await GetAsync<IList<PdfTemplateListItem>>($"{Urls.Admin}/template");
        }

        /// <summary>
        /// Creates a new PDF template.
        /// </summary>
        /// <returns></returns>
        public PdfTemplate CreateTemplate(PdfTemplateOptions pdfTemplateOptions)
        {
            return Post<PdfTemplate>($"{Urls.Admin}/template", pdfTemplateOptions);
        }
        
        /// <summary>
        /// Creates a new PDF template.
        /// </summary>
        /// <returns></returns>
        public async Task<PdfTemplate> CreateTemplateAsync(PdfTemplateOptions pdfTemplateOptions)
        {
            return await PostAsync<PdfTemplate>($"{Urls.Admin}/template", pdfTemplateOptions);
        }

        /// <summary>
        /// Retrieves the details of a single PDF template.
        /// </summary>
        /// <returns></returns>
        public PdfTemplate GetTemplate(Guid id)
        {
            return Get<PdfTemplate>($"{Urls.Admin}/template/{id}");
        }
        
        /// <summary>
        /// Retrieves the details of a single PDF template.
        /// </summary>
        /// <returns></returns>
        public async Task<PdfTemplate> GetTemplateAsync(Guid id)
        {
            return await GetAsync<PdfTemplate>($"{Urls.Admin}/template/{id}");
        }

        /// <summary>
        /// Updates the specified PDF template.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pdfTemplateOptions"></param>
        /// <returns></returns>
        public PdfTemplate UpdateTemplate(Guid id, PdfTemplateOptions pdfTemplateOptions)
        {
            return Put<PdfTemplate>($"{Urls.Admin}/template/{id}", pdfTemplateOptions);
        }
        
        /// <summary>
        /// Updates the specified PDF template.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pdfTemplateOptions"></param>
        /// <returns></returns>
        public async Task<PdfTemplate> UpdateTemplateAsync(Guid id, PdfTemplateOptions pdfTemplateOptions)
        {
            return await PutAsync<PdfTemplate>($"{Urls.Admin}/template/{id}", pdfTemplateOptions);
        }

        /// <summary>
        /// Deletes a PDF template.
        /// </summary>
        /// <param name="id"></param>
        public void DeleteTemplate(Guid id)
        {
            Delete($"{Urls.Admin}/template/{id}");
        }
        
        /// <summary>
        /// Deletes a PDF template.
        /// </summary>
        /// <param name="id"></param>
        public async Task DeleteTemplateAsync(Guid id)
        {
            await DeleteAsync($"{Urls.Admin}/template/{id}");
        }
    }
}