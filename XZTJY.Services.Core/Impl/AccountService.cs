using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using XZTJY.Core.Models;
using XZTJY.Component.Tools;
namespace XZTJY.Services.Core.Impl
{
    /// <summary>
    ///     账户模块核心业务实现
    /// </summary>
    public abstract class AccountService : IAccountContract
    {
        private static readonly Member[] Members = new[]
        {
            new Member { UserName = "admin", Password = "123456", Email = "admin@gmfcn.net", NickName = "管理员" },
            new Member { UserName = "gmfcn", Password = "123456", Email = "mf.guo@qq.com", NickName = "郭明锋" }
        };

        private static readonly List<LoginLog> LoginLogs = new List<LoginLog>();

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="loginInfo">登录信息</param>
        /// <returns>业务操作结果</returns>
        public virtual OperationResult Login(LoginInfo loginInfo)
        {
            PublicHelper.CheckArgument(loginInfo, "loginInfo");
            Member member = Members.SingleOrDefault(m => m.UserName == loginInfo.Access || m.Email == loginInfo.Access);
            if (member == null)
            {
                return new OperationResult(OperationResultType.QueryNull, "指定账号的用户不存在。");
            }
            if (member.Password != loginInfo.Password)
            {
                return new OperationResult(OperationResultType.Warning, "登录密码不正确。");
            }
            LoginLog loginLog = new LoginLog { IpAddress = loginInfo.IpAddress, Member = member };
            LoginLogs.Add(loginLog);
            return new OperationResult(OperationResultType.Success, "登录成功。", member);
        }
    }

}
