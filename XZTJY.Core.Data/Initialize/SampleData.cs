using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XZTJY.Core.Data.Context;
using XZTJY.Core.Models;

namespace XZTJY.Core.Data.Initialize
{
    /// <summary>
    /// 数据库初始化策略:这里使用CreateDatabaseIfNotExists，即数据库不存在时创建
    /// </summary>
    public class SampleData : CreateDatabaseIfNotExists<XZTDbContext>
    {
        protected override void Seed(XZTDbContext context)
        {
            List<Member> members = new List<Member>
            {
                new Member { UserName = "admin", Password = "123456", Email = "admin@gmfcn.net", NickName = "管理员" },
                new Member { UserName = "gmfcn", Password = "123456", Email = "mf.guo@qq.com", NickName = "郭明锋" }
            };
            DbSet<Member> memberSet = context.Set<Member>();
            members.ForEach(m => memberSet.Add(m));
            context.SaveChanges();
        }
    }
}
