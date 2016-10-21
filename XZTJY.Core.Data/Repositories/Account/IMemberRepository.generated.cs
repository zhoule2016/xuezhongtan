
using System;

using XZTJY.Component.Data;
using XZTJY.Core.Models.Account;


namespace XZTJY.Core.Data.Repositories.Account
{
	/// <summary>
    ///   仓储操作层接口——用户信息
    /// </summary>
    public partial interface IMemberRepository : IRepository<Member, Int32>
    { }
}
