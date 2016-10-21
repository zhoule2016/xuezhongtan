
using System;

using XZTJY.Component.Data;
using XZTJY.Core.Models.Security;


namespace XZTJY.Core.Data.Repositories.Security
{
	/// <summary>
    ///   仓储操作层接口——角色信息
    /// </summary>
    public partial interface IRoleRepository : IRepository<Role, Guid>
    { }
}
