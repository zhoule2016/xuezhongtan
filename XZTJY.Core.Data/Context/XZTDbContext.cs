using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XZTJY.Core.Models;

namespace XZTJY.Core.Data.Context
{
    /// <summary>
    ///     Demo项目数据访问上下文
    /// </summary>
    [Export(typeof (DbContext))]
    public class XZTDbContext:DbContext
    {
         
        #region 构造函数

        /// <summary>
        ///     初始化一个 使用连接名称为“default”的数据访问上下文类 的新实例
        /// </summary>
        public XZTDbContext(): base("default") { }

        /// <summary>
        /// 初始化一个 使用指定数据连接名称或连接串 的数据访问上下文类 的新实例
        /// </summary>
        public XZTDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString) {  }

        #endregion

        #region 属性

        public DbSet<Role> Roles { get; set; }

        public DbSet<Member> Members { get; set; }

        public DbSet<MemberExtend> MemberExtends { get; set; }

        public DbSet<LoginLog> LoginLogs { get; set; }

        #endregion
        /// <summary>
        /// 可以在 DbContext 的派生类中重写 OnModelCreating 方法来移除一些规则来达到某些需求，
        /// 比如在此，我们移除 OneToManyCascadeDeleteConvention 来达到禁用数据库的 一对多的级联删除 ，
        /// 需要时再在做实体映射时启用，就能防止由于误操作而导致实体相关的数据都被删除的情况
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //移除一对多的级联删除约定，想要级联删除可以在 EntityTypeConfiguration<TEntity>的实现类中进行控制
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            //多对多启用级联删除约定，不想级联删除可以在删除前判断关联的数据进行拦截
            //modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
    }
}
