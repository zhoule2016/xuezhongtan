using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XZTJY.Component.Data;
using XZTJY.Core.Models.Security;

namespace XZTJY.Core.Data.Configurations
{
    public class RoleConfiguration : EntityTypeConfiguration<Role>, IEntityMapper
    {
        public RoleConfiguration()
        {
            HasMany(m => m.Members).WithMany(n => n.Roles);
        }

        public void RegistTo(ConfigurationRegistrar configurations)
        {
            configurations.Add(this);
        }
    }
}
