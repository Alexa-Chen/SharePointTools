using System.Net;
using System.Security;
using Microsoft.SharePoint.Client;

namespace SharePointTools.Services
{
    public class SharePointInfo
    {
        private static readonly string address1 = "https://cnportal.avepoint.net/sites/ChinaAdministration";
        private static readonly string address2 = "https://portal.avepoint.net/my";
        public ClientContext ChinaAdministrationContext,MyContext;

        public SharePointInfo()
        {
            this.ChinaAdministrationContext = this.GetChinaAdministrationContext();
            //this.MyContext = this.GetMyContext();
        }

        public Web GetWeb1()
        {
            var web = ChinaAdministrationContext.Web;
            this.ChinaAdministrationContext.Load(web);
            this.ChinaAdministrationContext.ExecuteQuery();
            return web;
        }

        public Web GetWeb2()
        {
            var web = this.MyContext.Web;
            this.MyContext.Load(web);
            this.MyContext.ExecuteQuery();
            return web;
        }

        public ClientContext GetChinaAdministrationContext()
        {
            System.Net.ServicePointManager.ServerCertificateValidationCallback = ((sender, certificate, chain, sslPolicyErrors) => true);
            this.ChinaAdministrationContext = new ClientContext(address1);
            var ses = new SecureString();
            const string pswd = "yt@19940124";
            foreach (var c in pswd)
            {
                ses.AppendChar(c);
            }
            ChinaAdministrationContext.Credentials = new NetworkCredential("AvePoint\\tyang", ses);
            return this.ChinaAdministrationContext;
        }

        public ClientContext GetMyContext()
        {
            System.Net.ServicePointManager.ServerCertificateValidationCallback = ((sender, certificate, chain, sslPolicyErrors) => true);
            this.ChinaAdministrationContext = new ClientContext(address2);
            var ses = new SecureString();
            const string pswd = "yt@19940124";
            foreach (var c in pswd)
            {
                ses.AppendChar(c);
            }
            ChinaAdministrationContext.Credentials = new NetworkCredential("AvePoint\\tyang", ses);
            return this.MyContext;
        }
    }
}
