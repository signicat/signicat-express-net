using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Idfy.Infrastructure;

namespace Idfy.Signature
{
    /// <summary>
    /// Sign contracts, declarations, forms and other documents using digital signatures.
    /// </summary>
    public class SignatureService : IdfyBaseService
    {
        public SignatureService()
        {
        }

        public SignatureService(string clientId, string clientSecret, IEnumerable<OAuthScope> scopes) :
            base(clientId, clientSecret, scopes)
        {
        }

        /// <summary>
        /// Retrieves details of a single document.
        /// </summary>
        /// <param name="documentId"></param>
        /// <returns></returns>
        public Document GetDocument(Guid documentId)
        {
            return Get<Document>($"{Urls.SignatureDocuments}/{documentId}");
        }

        /// <summary>
        /// Retrieves  details of a single document.
        /// </summary>
        /// <param name="documentId"></param>
        /// <returns></returns>
        public async Task<Document> GetDocumentAsync(Guid documentId)
        {
            return await GetAsync<Document>($"{Urls.SignatureDocuments}/{documentId}");
        }

        /// <summary>
        /// Creates a new document.
        /// </summary>
        /// <param name="documentCreateOptions"></param>
        /// <returns></returns>
        public Document CreateDocument(DocumentCreateOptions documentCreateOptions)
        {
            return Post<Document>($"{Urls.SignatureDocuments}", documentCreateOptions);
        }
        
        /// <summary>
        /// Creates a new document.
        /// </summary>
        /// <param name="documentCreateOptions"></param>
        /// <returns></returns>
        public async Task<Document> CreateDocumentAsync(DocumentCreateOptions documentCreateOptions)
        {
            return await PostAsync<Document>($"{Urls.SignatureDocuments}", documentCreateOptions);
        }
        
        /// <summary>
        /// Updates a document.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="documentUpdateOptions"></param>
        /// <returns></returns>
        public Document UpdateDocument(Guid documentId, DocumentUpdateOptions documentUpdateOptions)
        {
            return Patch<Document>($"{Urls.SignatureDocuments}/{documentId}", documentUpdateOptions);
        }
        
        /// <summary>
        /// Updates a document.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="documentUpdateOptions"></param>
        /// <returns></returns>
        public async Task<Document> UpdateDocumentAsync(Guid documentId, DocumentUpdateOptions documentUpdateOptions)
        {
            return await PatchAsync<Document>($"{Urls.SignatureDocuments}/{documentId}", documentUpdateOptions);
        }

        /// <summary>
        /// Cancels a document.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="reason"></param>
        /// <returns></returns>
        public void CancelDocument(Guid documentId, string reason = null)
        {
            var url = APIHelper.AppendQueryParams($"{Urls.SignatureDocuments}/{documentId}/cancel",
                new Dictionary<string, object>()
                {
                    {"reason", reason}
                });
            
            Post(url);
        }

        /// <summary>
        /// Cancels a document.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="reason"></param>
        /// <returns></returns>
        public async Task CancelDocumentAsync(Guid documentId, string reason = null)
        {
            var url = APIHelper.AppendQueryParams($"{Urls.SignatureDocuments}/{documentId}/cancel",
                new Dictionary<string, object>()
                {
                    {"reason", reason}
                });
            
            await PostAsync(url);
        }
        
        /// <summary>
        /// Retrieves the status of a document.
        /// </summary>
        /// <param name="documentId"></param>
        /// <returns></returns>
        public DocumentStatusSummary GetDocumentStatus(Guid documentId)
        {
            return Get<DocumentStatusSummary>($"{Urls.SignatureDocuments}/{documentId}/status");
        }

        /// <summary>
        /// Retrieves the status of a document.
        /// </summary>
        /// <param name="documentId"></param>
        /// <returns></returns>
        public async Task<DocumentStatusSummary> GetDocumentStatusAsync(Guid documentId)
        {
            return await GetAsync<DocumentStatusSummary>($"{Urls.SignatureDocuments}/{documentId}/status");
        }

        /// <summary>
        /// Retrieves information about a document.
        /// </summary>
        /// <param name="documentId"></param>
        public DocumentSummary GetDocumentSummary(Guid documentId)
        {
            return Get<DocumentSummary>($"{Urls.SignatureDocuments}/{documentId}/summary");
        }
        
        /// <summary>
        /// Retrieves information about a document.
        /// </summary>
        /// <param name="documentId"></param>
        public async Task<DocumentSummary> GetDocumentSummaryAsync(Guid documentId)
        {
            return await GetAsync<DocumentSummary>($"{Urls.SignatureDocuments}/{documentId}/summary");
        }

        /// <summary>
        /// Queries your documents using the provided parameters.
        /// </summary>
        /// <param name="externalId"></param>
        /// <param name="signerId"></param>
        /// <param name="externalSignerId"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="lastUpdated"></param>
        /// <param name="signedDate"></param>
        /// <param name="nameOfSigner"></param>
        /// <param name="title"></param>
        /// <param name="status"></param>
        /// <param name="tags"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public CollectionWithPaging<DocumentSummary> ListDocumentSummaries(
            string externalId = null,
            Guid? signerId = null,
            string externalSignerId = null,
            DateTime? fromDate = null,
            DateTime? toDate = null,
            DateTime? lastUpdated = null,
            DateTime? signedDate = null,
            string nameOfSigner = null,
            string title = null,
            DocumentStatus? status = null,
            string tags = null,
            int? offset = null,
            int? limit = null)
        {
            var url = APIHelper.AppendQueryParams($"{Urls.SignatureDocuments}/summary",
                new Dictionary<string, object>()
                {
                    {"externalId", externalId},
                    {"signerId", signerId},
                    {"externalSignerId", externalSignerId},
                    {"fromDate", fromDate},
                    {"toDate", toDate},
                    {"lastUpdated", lastUpdated},
                    {"signedDate", signedDate},
                    {"nameOfSigner", nameOfSigner},
                    {"title", title},
                    {"status", status},
                    {"tags", tags},
                    {"offset", offset},
                    {"limit", limit}
                });
            
            return Get<CollectionWithPaging<DocumentSummary>>(url);
        }
        
        /// <summary>
        /// Queries your documents using the provided parameters.
        /// </summary>
        /// <param name="externalId"></param>
        /// <param name="signerId"></param>
        /// <param name="externalSignerId"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="lastUpdated"></param>
        /// <param name="signedDate"></param>
        /// <param name="nameOfSigner"></param>
        /// <param name="title"></param>
        /// <param name="status"></param>
        /// <param name="tags"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public async Task<CollectionWithPaging<DocumentSummary>> ListDocumentSummariesAsync(
            string externalId = null,
            Guid? signerId = null,
            string externalSignerId = null,
            DateTime? fromDate = null,
            DateTime? toDate = null,
            DateTime? lastUpdated = null,
            DateTime? signedDate = null,
            string nameOfSigner = null,
            string title = null,
            DocumentStatus? status = null,
            string tags = null,
            int? offset = null,
            int? limit = null)
        {
            var url = APIHelper.AppendQueryParams($"{Urls.SignatureDocuments}/summary",
                new Dictionary<string, object>()
                {
                    {"externalId", externalId},
                    {"signerId", signerId},
                    {"externalSignerId", externalSignerId},
                    {"fromDate", fromDate},
                    {"toDate", toDate},
                    {"lastUpdated", lastUpdated},
                    {"signedDate", signedDate},
                    {"nameOfSigner", nameOfSigner},
                    {"title", title},
                    {"status", status},
                    {"tags", tags},
                    {"offset", offset},
                    {"limit", limit}
                });
            
            return await GetAsync<CollectionWithPaging<DocumentSummary>>(url);
        }

        /// <summary>
        /// Retrieves the details of a single signer.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="signerId"></param>
        /// <returns></returns>
        public Signer GetSigner(Guid documentId, Guid signerId)
        {
            return Get<Signer>($"{Urls.SignatureDocuments}/{documentId}/signers/{signerId}");
        }
        
        /// <summary>
        /// Retrieves the details of a single signer.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="signerId"></param>
        /// <returns></returns>
        public async Task<Signer> GetSignerAsync(Guid documentId, Guid signerId)
        {
            return await GetAsync<Signer>($"{Urls.SignatureDocuments}/{documentId}/signers/{signerId}");
        }

        /// <summary>
        /// Creates a new signer.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="signerOptions"></param>
        /// <returns></returns>
        public Signer CreateSigner(Guid documentId, SignerOptions signerOptions)
        {
            return Post<Signer>($"{Urls.SignatureDocuments}/{documentId}/signers", signerOptions);
        }
        
        /// <summary>
        /// Creates a new signer.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="signerOptions"></param>
        /// <returns></returns>
        public async Task<Signer> CreateSignerAsync(Guid documentId, SignerOptions signerOptions)
        {
            return await PostAsync<Signer>($"{Urls.SignatureDocuments}/{documentId}/signers", signerOptions);
        }

        /// <summary>
        /// Updates a signer.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="signerId"></param>
        /// <param name="signerOptions"></param>
        /// <returns></returns>
        public Signer UpdateSigner(Guid documentId, Guid signerId, SignerOptions signerOptions)
        {
            return Patch<Signer>($"{Urls.SignatureDocuments}/{documentId}/signers/{signerId}", signerOptions);
        }
        
        /// <summary>
        /// Updates a signer.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="signerId"></param>
        /// <param name="signerOptions"></param>
        /// <returns></returns>
        public Signer UpdateSignerAsync(Guid documentId, Guid signerId, SignerOptions signerOptions)
        {
            return Patch<Signer>($"{Urls.SignatureDocuments}/{documentId}/signers/{signerId}", signerOptions);
        }

        /// <summary>
        /// Deletes a signer.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="signerId"></param>
        public void DeleteSigner(Guid documentId, Guid signerId)
        {
            Delete($"{Urls.SignatureDocuments}/{documentId}/signers/{signerId}");
        }
        
        /// <summary>
        /// Deletes a signer.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="signerId"></param>
        public async Task DeleteSignerAsync(Guid documentId, Guid signerId)
        {
            await DeleteAsync($"{Urls.SignatureDocuments}/{documentId}/signers/{signerId}");
        }

        /// <summary>
        /// Lists all signers of a document.
        /// </summary>
        /// <param name="documentId"></param>
        /// <returns></returns>
        public List<Signer> ListSigners(Guid documentId)
        {
            return Get<List<Signer>>($"{Urls.SignatureDocuments}/{documentId}/signers");
        }
        
        /// <summary>
        /// Lists all signers of a document.
        /// </summary>
        /// <param name="documentId"></param>
        /// <returns></returns>
        public async Task<List<Signer>> ListSignersAsync(Guid documentId)
        {
            return await GetAsync<List<Signer>>($"{Urls.SignatureDocuments}/{documentId}/signers");
        }

        /// <summary>
        /// Retrieves the details of a single attachment.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="attachmentId"></param>
        /// <returns></returns>
        public Attachment GetAttachment(Guid documentId, Guid attachmentId)
        {
            return Get<Attachment>($"{Urls.SignatureDocuments}/{documentId}/attachments/{attachmentId}");
        }
        
        /// <summary>
        /// Retrieves the details of a single attachment.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="attachmentId"></param>
        /// <returns></returns>
        public async Task<Attachment> GetAttachmentAsync(Guid documentId, Guid attachmentId)
        {
            return await GetAsync<Attachment>($"{Urls.SignatureDocuments}/{documentId}/attachments/{attachmentId}");
        }

        /// <summary>
        /// Adds an attachments to the specified document.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="attachmentOptions"></param>
        /// <returns></returns>
        public Attachment CreateAttachment(Guid documentId, AttachmentOptions attachmentOptions)
        {
            return Post<Attachment>($"{Urls.SignatureDocuments}/{documentId}/attachments", attachmentOptions);
        }
        
        /// <summary>
        /// Adds an attachments to the specified document.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="attachmentOptions"></param>
        /// <returns></returns>
        public async Task<Attachment> CreateAttachmentAsync(Guid documentId, AttachmentOptions attachmentOptions)
        {
            return await PostAsync<Attachment>($"{Urls.SignatureDocuments}/{documentId}/attachments",
                attachmentOptions);
        }

        /// <summary>
        /// Updates the specified attachment (Will only take affect if no one has signed the document yet).
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="attachmentId"></param>
        /// <param name="attachmentOptions"></param>
        /// <returns></returns>
        public Attachment UpdateAttachment(Guid documentId, Guid attachmentId, AttachmentOptions attachmentOptions)
        {
            return Patch<Attachment>($"{Urls.SignatureDocuments}/{documentId}/attachments/{attachmentId}",
                attachmentOptions);
        }
        
        /// <summary>
        /// Updates the specified attachment (Will only take affect if no one has signed the document yet).
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="attachmentId"></param>
        /// <param name="attachmentOptions"></param>
        /// <returns></returns>
        public async Task<Attachment> UpdateAttachmentAsync(Guid documentId, Guid attachmentId, AttachmentOptions attachmentOptions)
        {
            return await PatchAsync<Attachment>($"{Urls.SignatureDocuments}/{documentId}/attachments/{attachmentId}",
                attachmentOptions);
        }

        /// <summary>
        /// Deletes the specified attachment (Will only take affect if no one has signed the document yet).
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="attachmentId"></param>
        public void DeleteAttachment(Guid documentId, Guid attachmentId)
        {
            Delete($"{Urls.SignatureDocuments}/{documentId}/attachments/{attachmentId}");
        }
        
        /// <summary>
        /// Deletes the specified attachment (Will only take affect if no one has signed the document yet).
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="attachmentId"></param>
        public async Task DeleteAttachmentAsync(Guid documentId, Guid attachmentId)
        {
            await DeleteAsync($"{Urls.SignatureDocuments}/{documentId}/attachments/{attachmentId}");
        }

        /// <summary>
        /// Returns a list of all attachments for the specified document.
        /// </summary>
        /// <param name="documentId"></param>
        /// <returns></returns>
        public List<Attachment> ListAttachments(Guid documentId)
        {
            return Get<List<Attachment>>($"{Urls.SignatureDocuments}/{documentId}/attachments");
        }
        
        /// <summary>
        /// Returns a list of all attachments for the specified document.
        /// </summary>
        /// <param name="documentId"></param>
        /// <returns></returns>
        public async Task<List<Attachment>> ListAttachmentsAsync(Guid documentId)
        {
            return await GetAsync<List<Attachment>>($"{Urls.SignatureDocuments}/{documentId}/attachments");
        }

        /// <summary>
        /// Retrieves the signed document file.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="fileFormat"></param>
        /// <returns></returns>
        public Stream GetFile(Guid documentId, FileFormat fileFormat)
        {
            var url = APIHelper.AppendQueryParams($"{Urls.SignatureDocuments}/{documentId}/files",
                new Dictionary<string, object>()
                {
                    {"fileFormat", fileFormat}
                });
            
            return GetFile(url);
        }
        
        /// <summary>
        /// Retrieves the signed document file.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="fileFormat"></param>
        /// <returns></returns>
        public async Task<Stream> GetFileAsync(Guid documentId, FileFormat fileFormat)
        {
            var url = APIHelper.AppendQueryParams($"{Urls.SignatureDocuments}/{documentId}/files",
                new Dictionary<string, object>()
                {
                    {"fileFormat", fileFormat}
                });
            
            return await GetFileAsync(url);
        }

        /// <summary>
        /// Retrieves the signed document file for the specified signer.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="signerId"></param>
        /// <param name="fileFormat"></param>
        /// <returns></returns>
        public Stream GetFileForSigner(Guid documentId, Guid signerId, FileFormat fileFormat)
        {
            var url = APIHelper.AppendQueryParams($"{Urls.SignatureDocuments}/{documentId}/files/signers/{signerId}",
                new Dictionary<string, object>()
                {
                    {"fileFormat", fileFormat}
                });
            
            return GetFile(url);
        }
        
        /// <summary>
        /// Retrieves the signed document file for the specified signer.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="signerId"></param>
        /// <param name="fileFormat"></param>
        /// <returns></returns>
        public async Task<Stream> GetFileForSignerAsync(Guid documentId, Guid signerId, FileFormat fileFormat)
        {
            var url = APIHelper.AppendQueryParams($"{Urls.SignatureDocuments}/{documentId}/files/signers/{signerId}",
                new Dictionary<string, object>()
                {
                    {"fileFormat", fileFormat}
                });
            
            return await GetFileAsync(url);
        }

        /// <summary>
        /// Retrieves the attachment file.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="attachmentId"></param>
        /// <param name="fileFormat"></param>
        /// <returns></returns>
        public Stream GetAttachmentFile(Guid documentId, Guid attachmentId, FileFormat fileFormat)
        {
            var url = APIHelper.AppendQueryParams($"{Urls.SignatureDocuments}/{documentId}/files/attachments/{attachmentId}",
                new Dictionary<string, object>()
                {
                    {"fileFormat", fileFormat}
                });
            
            return GetFile(url);
        }
        
        /// <summary>
        /// Retrieves the attachment file.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="attachmentId"></param>
        /// <param name="fileFormat"></param>
        /// <returns></returns>
        public async Task<Stream> GetAttachmentFileAsync(Guid documentId, Guid attachmentId, FileFormat fileFormat)
        {
            var url = APIHelper.AppendQueryParams($"{Urls.SignatureDocuments}/{documentId}/files/attachments/{attachmentId}",
                new Dictionary<string, object>()
                {
                    {"fileFormat", fileFormat}
                });
            
            return await GetFileAsync(url);
        }

        /// <summary>
        /// Retrieves the attachment file for the specified signer.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="attachmentId"></param>
        /// <param name="signerId"></param>
        /// <param name="fileFormat"></param>
        /// <returns></returns>
        public Stream GetAttachmentFileForSigner(Guid documentId, Guid attachmentId, Guid signerId, FileFormat fileFormat)
        {
            var url = APIHelper.AppendQueryParams(
                $"{Urls.SignatureDocuments}/{documentId}/files/attachments/{attachmentId}/signers/{signerId}",
                new Dictionary<string, object>()
                {
                    {"fileFormat", fileFormat}
                });
            
            return GetFile(url);
        }

        /// <summary>
        /// Retrieves the attachment file for the specified signer.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="attachmentId"></param>
        /// <param name="signerId"></param>
        /// <param name="fileFormat"></param>
        /// <returns></returns>
        public async Task<Stream> GetAttachmentFileForSignerAsync(Guid documentId, Guid attachmentId, Guid signerId, FileFormat fileFormat)
        {
            var url = APIHelper.AppendQueryParams(
                $"{Urls.SignatureDocuments}/{documentId}/files/attachments/{attachmentId}/signers/{signerId}",
                new Dictionary<string, object>()
                {
                    {"fileFormat", fileFormat}
                });
            
            return await GetFileAsync(url);
        }

        /// <summary>
        /// Returns a list of all notifications that has been sent / attempted sent for a document.
        /// </summary>
        /// <param name="documentId"></param>
        /// <returns></returns>
        public List<NotificationLogItem> ListNotifications(Guid documentId)
        {
            return Get<List<NotificationLogItem>>($"{Urls.SignatureDocuments}/{documentId}/notifications");
        }
        
        /// <summary>
        /// Returns a list of all notifications that has been sent / attempted sent for a document.
        /// </summary>
        /// <param name="documentId"></param>
        /// <returns></returns>
        public async Task<List<NotificationLogItem>> ListNotificationsAsync(Guid documentId)
        {
            return await GetAsync<List<NotificationLogItem>>($"{Urls.SignatureDocuments}/{documentId}/notifications");
        }

        /// <summary>
        /// Sends a reminder to the specified signers.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="manualReminder"></param>
        /// <returns></returns>
        public ManualReminder SendReminders(Guid documentId, ManualReminder manualReminder)
        {
            return Post<ManualReminder>($"{Urls.SignatureDocuments}/{documentId}/notifications/reminder");
        }
        
        /// <summary>
        /// Sends a reminder to the specified signers.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="manualReminder"></param>
        /// <returns></returns>
        public async Task<ManualReminder> SendRemindersAsync(Guid documentId, ManualReminder manualReminder)
        {
            return await PostAsync<ManualReminder>($"{Urls.SignatureDocuments}/{documentId}/notifications/reminder");
        }

        /// <summary>
        /// Returns a list of all color themes that can be used in the signature application.
        /// </summary>
        /// <returns></returns>
        public List<ColorTheme> ListThemes()
        {
            return Get<List<ColorTheme>>($"{Urls.Signature}/themes/list/themes");
        }
        
        /// <summary>
        /// Returns a list of all color themes that can be used in the signature application.
        /// </summary>
        /// <returns></returns>
        public async Task<List<ColorTheme>> ListThemesAsync()
        {
            return await GetAsync<List<ColorTheme>>($"{Urls.Signature}/themes/list/themes");
        }

        /// <summary>
        /// Returns a list of all spinners that can be used in the signature application.
        /// </summary>
        /// <returns></returns>
        public List<Spinner> ListSpinners()
        {
            return Get<List<Spinner>>($"{Urls.Signature}/themes/list/spinners");
        }
        
        /// <summary>
        /// Returns a list of all spinners that can be used in the signature application.
        /// </summary>
        /// <returns></returns>
        public async Task<List<Spinner>> ListSpinnersAsync()
        {
            return await GetAsync<List<Spinner>>($"{Urls.Signature}/themes/list/spinners");
        }
    }
}