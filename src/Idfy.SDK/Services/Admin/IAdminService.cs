using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Idfy.Admin
{
    public interface IAdminService
    {
        Account GetAccount();
        
        Task<Account> GetAccountAsync();
        
        Account UpdateAccount(AccountUpdateOptions accountUpdateOptions);
        
        Task<Account> UpdateAccountAsync(AccountUpdateOptions accountUpdateOptions);
        
        Account CreateAccount(AccountCreateOptions accountCreateOptions);
        
        Task<Account> CreateAccountAsync(AccountCreateOptions accountCreateOptions);
        
        void DisableAccount();
        
        Task DisableAccountAsync();

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

        IList<AccountNameItem> ListAccountNames();
        
        Task<IList<AccountNameItem>> ListAccountNamesAsync();
        
        Dealer GetDealer(Guid dealerId);
        
        Task<Dealer> GetDealerAsync(Guid dealerId);

        Dealer UpdateDealer(Guid dealerId, Dealer dealer);

        Task<Dealer> UpdateDealerAsync(Guid dealerId, Dealer dealer);

        IList<PdfTemplateListItem> ListTemplates();

        Task<IList<PdfTemplateListItem>> ListTemplatesAsync();

        PdfTemplate CreateTemplate(PdfTemplateOptions pdfTemplateOptions);

        Task<PdfTemplate> CreateTemplateAsync(PdfTemplateOptions pdfTemplateOptions);

        PdfTemplate GetTemplate(Guid id);

        Task<PdfTemplate> GetTemplateAsync(Guid id);

        PdfTemplate UpdateTemplate(Guid id, PdfTemplateOptions pdfTemplateOptions);
        
        Task<PdfTemplate> UpdateTemplateAsync(Guid id, PdfTemplateOptions pdfTemplateOptions);

        void DeleteTemplate(Guid id);

        Task DeleteTemplateAsync(Guid id);
    }
}
