
using System;
using System.ComponentModel.Composition;
using System.Linq;

using XZTJY.Component.Data;
using XZTJY.Core.Models.Account;


namespace XZTJY.Core.Data.Repositories.Account.Impl
{
	/// <summary>
    ///   仓储操作层实现——用户扩展信息
    /// </summary>
    [Export(typeof(IMemberExtendRepository))]
    public partial class MemberExtendRepository : EFRepositoryBase<MemberExtend, Guid>, IMemberExtendRepository
    { }
}
