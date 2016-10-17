using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XZTJY.Component.Data;
using XZTJY.Core.Models;

namespace XZTJY.Core.Data.Repositories.Impl
{
    /// <summary>
    ///     仓储操作实现——登录记录信息
    /// </summary>
    [Export(typeof(ILoginLogRepository))]
    public class LoginLogRepository : EFRepositoryBase<LoginLog>, ILoginLogRepository { }
}
