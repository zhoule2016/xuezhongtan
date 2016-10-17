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
    ///     仓储操作实现——用户扩展信息
    /// </summary>
    [Export(typeof(IMemberExtendRepository))]
    public class MemberExtendRepository : EFRepositoryBase<MemberExtend>, IMemberExtendRepository { }
}
