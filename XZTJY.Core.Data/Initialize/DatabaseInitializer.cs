﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XZTJY.Core.Data.Context;

namespace XZTJY.Core.Data.Initialize
{
    /// <summary>
    /// 数据库初始化操作类
    /// </summary>
    public static class DatabaseInitializer
    {
        /// <summary>
        /// 数据库初始化
        /// </summary>
        public static void Initialize()
        {
            Database.SetInitializer(new SampleData());
            using (var db = new XZTDbContext())
            {
                db.Database.Initialize(false);
            }
        }
    }
}
