using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;
using DevExpress.Web.ASPxHtmlEditor;
using DevExpress.Internal;

namespace Placeholder {
    public partial class Placeholder : System.Web.UI.Page {
        private string htmlPage = @"<p>Text mail</p><p>Date: { DateNow } { TimeNow }</p><p>Signature: { FirstName } { LastName }</p>";
        
        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack)
                HtmlEditor.Html = htmlPage;
        }

        #region #ReplacePlaceholdersFromObject
        private class PlaceholdersForDate {
            private DateTime date = DateTime.Now;
            private string formatDate = "d MMM yyyy";
            private string formatTime = "HH:mm";
            public string DateNow {
                get {
                    return date.ToString(formatDate);
                }
            }
            public string TimeNow {
                get {
                    return date.ToString(formatTime);
                }
            }
        }
        // Replaces placeholders specified as an object
        protected void Insert_Date(object sender, EventArgs e) {
            PlaceholdersForDate placeholdersForDate = new PlaceholdersForDate();
            string html = HtmlEditor.Html;
            string newHtml = ASPxHtmlEditor.ReplacePlaceholders(html, placeholdersForDate);
            HtmlEditor.Html = newHtml;
        }
        #endregion #ReplacePlaceholdersFromObject

        #region #ReplacePlaceholdersFromDictionary
        private Dictionary<string, string> PlaceholdersForSignature = new Dictionary<string, string>() {
	        {"FirstName", "Mary"},
            {"LastName", "Bonn"}
	    };

        // Replaces placeholders specified as a dictionary
        protected void Insert_Signature(object sender, EventArgs e) {
            string html = HtmlEditor.Html;
            string newHtml = ASPxHtmlEditor.ReplacePlaceholders(html, PlaceholdersForSignature);
            HtmlEditor.Html = newHtml;
        }
        #endregion #ReplacePlaceholdersFromDictionary

    }
}
