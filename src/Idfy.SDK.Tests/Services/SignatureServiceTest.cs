using System;
using System.Net.Http;
using System.Threading.Tasks;
using AutoFixture;
using Idfy.Signature;
using NUnit.Framework;

namespace Idfy.SDK.Tests
{

    [TestFixture]
    public class SignatureServiceTest : BaseTest
    {
        private SignatureService _signatureService;
        private Guid _documentId;

        public SignatureServiceTest()
        {
            _signatureService = new SignatureService();
        }

        [SetUp]
        public void Setup()
        {
            _documentId = Guid.NewGuid();
        }

        [Test]
        public void GetDocument()
        {
            var document = _signatureService.GetDocument(_documentId);

            Assert.IsNotNull(document);
            AssertRequest(HttpMethod.Get, $"/signature/documents/{_documentId}");
        }

        [Test]
        public async Task GetDocumentAsync()
        {
            var document = await _signatureService.GetDocumentAsync(_documentId);

            Assert.IsNotNull(document);
            AssertRequest(HttpMethod.Get, $"/signature/documents/{_documentId}");
        }

        [Test]
        public void CreateDocument()
        {
            var options = Fixture.Create<DocumentCreateOptions>();
            var document = _signatureService.CreateDocument(options);

            Assert.IsNotNull(document);
            AssertRequest(HttpMethod.Post, "/signature/documents");
        }

        [Test]
        public async Task CreateDocumentAsync()
        {
            var options = Fixture.Create<DocumentCreateOptions>();
            var document = await _signatureService.CreateDocumentAsync(options);

            Assert.IsNotNull(document);
            AssertRequest(HttpMethod.Post, "/signature/documents");
        }

        [Test]
        public void UpdateDocument()
        {
            var options = Fixture.Create<DocumentUpdateOptions>();
            var document = _signatureService.UpdateDocument(_documentId, options);

            Assert.IsNotNull(document);
            AssertRequest(new HttpMethod("PATCH"), $"/signature/documents/{_documentId}");
        }

        [Test]
        public async Task UpdateDocumentAsync()
        {
            var options = Fixture.Create<DocumentUpdateOptions>();
            var document = await _signatureService.UpdateDocumentAsync(_documentId, options);

            Assert.IsNotNull(document);
            AssertRequest(new HttpMethod("PATCH"), $"/signature/documents/{_documentId}");
        }
    }
}