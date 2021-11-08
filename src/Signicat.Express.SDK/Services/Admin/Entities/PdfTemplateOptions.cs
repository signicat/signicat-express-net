using Newtonsoft.Json;

namespace Signicat.Express.Admin
{
    public class PdfTemplateOptions
    {
        /// <summary>
        /// The name of the Pdf template
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Cover page is the page added to the document at the beginning or end that show a list of the signers.
        /// This setting hides that page or put it first or last. Default firstpage.
        /// </summary>
        [JsonProperty(PropertyName = "CoverPageSetting")]
        public CoverPageSetting? CoverPageSetting { get; set; }

        /// <summary>
        /// Adds a list of signer names on the last page of the
        /// PDF, only use this if you are sure that you have room for the
        /// signatures.
        /// </summary>
        [JsonProperty(PropertyName = "AddListOfSignaturesOnLastPageOfExistingPDF")]
        public bool? AddListOfSignaturesOnLastPageOfExistingPdf { get; set; }

        /// <summary>
        /// The html template for the coverpage, if this is set it
        /// will override the default template. See our documentation on more
        /// info on how to make your own custom template.
        /// </summary>
        [JsonProperty(PropertyName = "CoverPageHtml")]
        public string CoverPageHtml { get; set; }

        /// <summary>
        /// List of html templates for the details attatchments.
        /// If this is set for one or more language, it will override the
        /// default template. See our documentation on more info on how to make
        /// your own custom template.
        /// </summary>
        [JsonProperty(PropertyName = "DetailsPageHtml")]
        public PdfTemplateDetailsPageHtml DetailsPageHtml { get; set; }

        /// <summary>
        /// List of labels for the verified label on the footer on
        /// each page. If this is set it will override the default text. See
        /// our documentation on more info on how to customize.
        /// </summary>
        [JsonProperty(PropertyName = "VerifiedTemplate")]
        public PdfTemplateVerifiedTemplate VerifiedTemplate { get; set; }

        /// <summary>
        /// List of labels for the templates, this are used in the
        /// html templates. If this is set it will override the default labels.
        /// See our documentation on more info on how to customize.
        /// </summary>
        [JsonProperty(PropertyName = "Labels")]
        public PdfTemplateLabels Labels { get; set; }

        /// <summary>
        /// Include your logo in the Pdf template
        /// </summary>
        [JsonProperty(PropertyName = "IncludeLogo")]
        public bool? IncludeLogo { get; set; }

        /// <summary>
        /// The time zone that is used for displaying signing time
        /// in the PADES (See:
        /// https://support.microsoft.com/en-us/help/973627/microsoft-time-zone-index-values
        /// for valid values) Defaults to W. Europe Standard Time
        /// </summary>
        [JsonProperty(PropertyName = "TimeZone")]
        public string TimeZone { get; set; }

        /// <summary>
        /// Url to the logo that you want to use in your template
        /// </summary>
        [JsonProperty(PropertyName = "LogoSourceUrl")]
        public string LogoSourceUrl { get; set; }
    }
}
