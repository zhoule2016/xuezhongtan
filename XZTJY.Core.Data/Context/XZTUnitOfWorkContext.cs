using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XZTJY.Component.Data;

namespace XZTJY.Core.Data.Context
{
    public class XZTUnitOfWorkContext : UnitOfWorkContextBase
    {
        /// <summary>
        ///     获取或设置 当前使用的数据访问上下文对象
        /// </summary>
        protected override DbContext Context
        {
            get { return XZTDbContext; }
        }

        /// <summary>
        ///     获取或设置 默认的Demo项目数据访问上下文对象
        /// </summary>
        [Import(typeof(DbContext))]
        public XZTDbContext XZTDbContext { get; set; }
    }
}
