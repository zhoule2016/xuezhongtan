﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XZTJY.Component.Data
{
    /// <summary>
    ///     EF数据访问上下文
    /// </summary>
    [Export(typeof(DbContext))]
    public class EFDbContext : DbContext
    {
        public EFDbContext()
            : base("default") { }

        public EFDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString) { }

        [ImportMany(typeof(IEntityMapper))]
        public IEnumerable<IEntityMapper> EntityMappers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            if (EntityMappers == null)
            {
                return;
                //throw PublicHelper.ThrowDataAccessException("实体映射对象个数为0，创建DbContext上下文对象失败。");
            }

            foreach (var mapper in EntityMappers)
            {
                mapper.RegistTo(modelBuilder.Configurations);
            }
        }
    }
}
