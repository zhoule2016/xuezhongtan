using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XZTJY.Component.Data;
using XZTJY.Core.Models;

namespace XZTJY.Core.Data.Configurations
{
    public class MemberExtendConfiguration : EntityTypeConfiguration<MemberExtend>, IEntityMapper
    {
        public MemberExtendConfiguration()
        {
            HasRequired(m => m.Member).WithOptional(n => n.Extend);
        }

        public void RegistTo(ConfigurationRegistrar configurations)
        {
            configurations.Add(this);
        }
    }
}
