using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XZTJY.Component.Data;
using XZTJY.Core.Models.Account;

namespace XZTJY.Core.Data.Configurations
{
    public class LoginLogConfiguration : EntityTypeConfiguration<LoginLog>, IEntityMapper
    {
        public LoginLogConfiguration()
        {
            HasRequired(m => m.Member).WithMany(n => n.LoginLogs);
        }

        public void RegistTo(ConfigurationRegistrar configurations)
        {
            configurations.Add(this);
        }
    }
}
