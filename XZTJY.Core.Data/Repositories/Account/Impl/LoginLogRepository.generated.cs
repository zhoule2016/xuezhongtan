
using System;
using System.ComponentModel.Composition;
using System.Linq;

using XZTJY.Component.Data;
using XZTJY.Core.Models.Account;
using XZTJY.Data.Repositories.Account;


namespace XZTJY.Core.Data.Repositories.Account.Impl
{
	/// <summary>
    ///   仓储操作层实现——登录记录信息
    /// </summary>
    [Export(typeof(ILoginLogRepository))]
    public partial class LoginLogRepository : EFRepositoryBase<LoginLog, Guid>, ILoginLogRepository
    { }
}
