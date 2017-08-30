using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace PardotAPI
{ 

    // -------------------------------------------------------------
    // --------- Main class object - handles all calls -------------
    // -------------------------------------------------------------

    public class pardot
    {

        // ----------------------------------
        // --------- properties -------------
        // ----------------------------------

        public PardotAPI.token token;
        public const string exampleUrl = "https://pi.pardot.com/api/<object>/version/3/do/<operator>/<identifier_field>/<identifier>";
        public string method = "xml";
        public string status;
        public string api_ver;


        // ----------------------------------
        // ------- child interfaces ---------
        // ----------------------------------

        public PardotAPI.@interface accounts;
        public PardotAPI.@interface campaigns;
        public PardotAPI.@interface customFields;
        public PardotAPI.@interface customRedirects;
        public PardotAPI.@interface dynamicContents;
        public PardotAPI.@interface emails;
        public PardotAPI.@interface emailClicks;
        public PardotAPI.@interface emailTemplates;
        public PardotAPI.@interface forms;
        public PardotAPI.@interface lifecycleHistories;
        public PardotAPI.@interface lifecycleStages;
        public PardotAPI.@interface lists;
        public PardotAPI.@interface listMemberships;
        public PardotAPI.@interface opportunities;
        public PardotAPI.@interface prospects;
        public PardotAPI.@interface prospectAccounts;
        public PardotAPI.@interface stats;
        public PardotAPI.@interface tags;
        public PardotAPI.@interface tagObjects;
        public PardotAPI.@interface users;
        public PardotAPI.@interface visitors;
        public PardotAPI.@interface visitorActivities;
        public PardotAPI.@interface visits;

        
        // ----------------------------------
        // --------- instantiation ----------
        // ----------------------------------

        public pardot()
        {
            string user = System.Configuration.ConfigurationManager.AppSettings.Get("PardotUser");
            string pass = System.Configuration.ConfigurationManager.AppSettings.Get("PardotPass");
            string ukey = System.Configuration.ConfigurationManager.AppSettings.Get("PardotUkey");

            instantiate(user, pass, ukey);
        }
        public pardot(string email, string password, string user_key)
        {
            instantiate(email, password, user_key);
        }

        public void instantiate(string email, string password, string user_key)
        { 
            // make sure parameters are filld out
            if ( email.notFilled() || password.notFilled() || user_key.notFilled() )
            {
                throw new System.ArgumentException("Email, password, and user key must be provided");
            }
            
            // create token from provided parameters
            token = new PardotAPI.token(email,password,user_key);

            // test token
            if ( !token.is_valid() )
            {
                status = "An error occurred creating the security token. Please double check your credentials.";
                PardotAPI.GlobalMethods.notifyAdmin(status);
            }

            // load child objects
            accounts = new PardotAPI.@interface(ref token, "account");
            campaigns = new PardotAPI.@interface(ref token, "campaign");
            customFields = new PardotAPI.@interface(ref token, "customField");
            customRedirects = new PardotAPI.@interface(ref token, "customRedirect");
            dynamicContents = new PardotAPI.@interface(ref token, "dynamicContent");
            emails = new PardotAPI.@interface(ref token, "email");
            emailClicks = new PardotAPI.@interface(ref token, "emailClick");
            emailTemplates = new PardotAPI.@interface(ref token, "emailTemplate");
            forms = new PardotAPI.@interface(ref token, "form");
            lifecycleHistories = new PardotAPI.@interface(ref token, "lifecycleHistorie");
            lifecycleStages = new PardotAPI.@interface(ref token, "lifecycleStage");
            lists = new PardotAPI.@interface(ref token, "list");
            listMemberships = new PardotAPI.@interface(ref token, "listMembership");
            opportunities = new PardotAPI.@interface(ref token, "opportunity");
            prospects = new PardotAPI.@interface(ref token, "prospect");
            prospectAccounts = new PardotAPI.@interface(ref token, "prospectAccount");
            stats = new PardotAPI.@interface(ref token, "stat");
            tags = new PardotAPI.@interface(ref token, "tag");
            tagObjects = new PardotAPI.@interface(ref token, "tagObject"); ;
            users = new PardotAPI.@interface(ref token, "user");
            visitors = new PardotAPI.@interface(ref token, "visitor");
            visitorActivities = new PardotAPI.@interface(ref token, "visitorActivity");
            visits = new PardotAPI.@interface(ref token, "visit");
        }



        // ----------------------------------
        // ------------ methods -------------
        // ----------------------------------

        // made method private because it's not current supported
        private void changeMethod(string methodName)
        {
            // validate that the provided method name is either json or xml
            switch ( methodName.ToLower() )
            {
                case "json":
                    //method = methodName.ToLower();
                    break;
                case "xml":
                    //method = methodName.ToLower();
                    break;
            }
        }

        private bool notFilled(string str)
        {
            if ( str != null && str.Length > 0 )
            {
                return true;
            }
            return false;
        }

    }
}