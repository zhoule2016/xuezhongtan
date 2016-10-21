
using System;
using System.ComponentModel.Composition;
using System.Linq;

using XZTJY.Component.Data;
using XZTJY.Core.Models.Account;


namespace XZTJY.Core.Data.Repositories.Account.Impl
{
	/// <summary>
    ///   仓储操作层实现——用户信息
    /// </summary>
    [Export(typeof(IMemberRepository))]
    public partial class MemberRepository : EFRepositoryBase<Member, Int32>, IMemberRepository
    { }
}
