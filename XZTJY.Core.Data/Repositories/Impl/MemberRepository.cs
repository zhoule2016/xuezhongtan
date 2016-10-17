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
    ///     仓储操作实现——用户信息
    /// </summary>
    [Export(typeof(IMemberRepository))]
    public class MemberRepository : EFRepositoryBase<Member>, IMemberRepository { }
}
