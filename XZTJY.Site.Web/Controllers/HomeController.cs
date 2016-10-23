using System;
using System.Collections;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using XZTJY.Component.Tools;
using XZTJY.Component.Tools.Extensions;
using XZTJY.Site.Apply;
using XZTJY.Site.Models;
using XZTJY.Core.Models.Account;

using Webdiyer.WebControls.Mvc;
namespace XZTJY.Site.Web.Controllers
{
    [Export]
    public class HomeController : Controller
    {
        [Import]
        public IAccountSiteContract AccountContract { get; set; }

        public ActionResult Index(int? id)
        {
            int pageIndex = id ?? 1;
            const int pageSize = 20;
            SortCondition[] sortConditions = new[] { new SortCondition("Id") };
            int total;
            //Where<Member, int>(m => true, pageIndex, pageSize, out total, sortConditions).Select(m => new MemberView
            var memberViews = AccountContract.Members.Where<Member, int>(m => true, pageIndex, pageSize, out total, sortConditions).Select(m => new MemberView
            {
                UserName = m.UserName,
                NickName = m.NickName,
                Email = m.Email,
                IsDeleted = m.IsDeleted,
                AddDate = m.AddDate,
                LoginLogCount = m.LoginLogs.Count,
                RoleNames = m.Roles.Select(n => n.Name)
            });
            PagedList<MemberView> model = new PagedList<MemberView>(memberViews, pageIndex, pageSize, total);
            return View(model);
        }
    }
}