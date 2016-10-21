
using System;
using System.ComponentModel.Composition;
using System.Linq;

using XZTJY.Component.Data;
using XZTJY.Core.Models.Security;


namespace XZTJY.Core.Data.Repositories.Security.Impl
{
	/// <summary>
    ///   仓储操作层实现——角色信息
    /// </summary>
    [Export(typeof(IRoleRepository))]
    public partial class RoleRepository : EFRepositoryBase<Role, Guid>, IRoleRepository
    { }
}
