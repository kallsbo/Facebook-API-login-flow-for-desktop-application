using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBDialogDemo
{
    public partial class FBDialog : Form
    {
        #region Private Vars
        private string p_appID;
        private string p_scopes;
        private string p_access_token;
        private DateTime p_token_expires;
        private string p_granted_scopes;
        private string p_denied_scopes;
        private string p_error;
        private string p_error_reason;
        private string p_error_description;
        private DialogResult result = DialogResult.Cancel;
        #endregion

        #region Public properties
        public string access_token { get { return p_access_token; } }
        public DateTime token_expires { get { return p_token_expires; } }
        public string granted_scopes { get { return p_granted_scopes; } }
        public string denied_scopes { get { return p_denied_scopes; } }
        public string error { get { return p_error; } }
        public string error_reason { get { return p_error_reason; } }
        public string error_description { get { return p_error_description; } }
        #endregion

        /// <summary>
        /// Creates a new login dialog for Facebook
        /// </summary>
        /// <param name="inpAppID">ID of the app authenticating against Facebook</param>
        /// <param name="inpScopes">A comma seperated list of scoopes that the app will ask permission for</param>
        public FBDialog(string inpAppID, string inpScopes)
        {
            p_appID = inpAppID;
            p_scopes = inpScopes;
            InitializeComponent();
        }

        private void FBDialog_Load(object sender, EventArgs e)
        {
            string returnURL = WebUtility.UrlEncode("https://www.facebook.com/connect/login_success.html");
            string scopes = WebUtility.UrlEncode(p_scopes);
            FBwebBrowser.Url = new Uri(string.Format("https://www.facebook.com/dialog/oauth?client_id={0}&redirect_uri={1}&response_type=token%2Cgranted_scopes&scope={2}&display=popup", new object[] { p_appID, returnURL, scopes }));
            FBwebBrowser.Navigated += FBwebBrowser_Navigated;
        }

        void FBwebBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            // Set title
            this.Text = FBwebBrowser.DocumentTitle;

            // Check to see if we hit return url
            if (FBwebBrowser.Url.AbsolutePath == "/connect/login_success.html")
            {
                // Check for error
                if (FBwebBrowser.Url.Query.Contains("error"))
                {
                    // Error detected
                    this.result = System.Windows.Forms.DialogResult.Abort;
                    ExtractURLInfo("?", FBwebBrowser.Url.Query);
                }
                else
                {
                    this.result = System.Windows.Forms.DialogResult.OK;
                    ExtractURLInfo("#", FBwebBrowser.Url.Fragment);
                }
                // Close the dialog
                this.Close();
            }

        }

        private void FBDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Return the dialog result
            this.DialogResult = result;
        }

        private void ExtractURLInfo(string inpTrimChar, string urlInfo)
        {
            string fragments = urlInfo.Trim(char.Parse(inpTrimChar)); // Trim the hash or the ? mark
            string[] parameters = fragments.Split(char.Parse("&")); // Split the url fragments / query string 

            // Extract info from url
            foreach (string parameter in parameters)
            {
                string[] name_value = parameter.Split(char.Parse("=")); // Split the input

                switch (name_value[0])
                {
                    case "access_token":
                        this.p_access_token = name_value[1];
                        break;
                    case "expires_in":
                        double expires = 0;
                        if (double.TryParse(name_value[1], out expires))
                        {
                            this.p_token_expires = DateTime.Now.AddSeconds(expires);
                        }
                        else
                        {
                            this.p_token_expires = DateTime.Now;
                        }
                        break;
                    case "granted_scopes":
                        this.p_granted_scopes = WebUtility.UrlDecode(name_value[1]);
                        break;
                    case "denied_scopes":
                        this.p_denied_scopes = WebUtility.UrlDecode(name_value[1]);
                        break;
                    case "error":
                        this.p_error = WebUtility.UrlDecode(name_value[1]);
                        break;
                    case "error_reason":
                        this.p_error_reason = WebUtility.UrlDecode(name_value[1]);
                        break;
                    case "error_description":
                        this.p_error_description = WebUtility.UrlDecode(name_value[1]);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
