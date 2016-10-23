﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XZTJY.Component.Tools;
using XZTJY.Core.Models.Account;
namespace XZTJY.Core.Models.Security
{
    /// <summary>
    ///     实体类——角色信息
    /// </summary>
    [Description("角色信息")]
    public class Role : EntityBase<Guid>
    {
        public Role()
        {
            Id = CombHelper.NewComb();
        }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        /// <summary>
        /// 获取或设置 角色类型
        /// </summary>
        public RoleType RoleType
        {
            get { return (RoleType)RoleTypeNum; }
            set { RoleTypeNum = (int)value; }
        }

        /// <summary>
        /// 获取或设置 角色类型的数值表示，用于数据库存储
        /// </summary>
        public int RoleTypeNum { get; set; }

        /// <summary>
        ///     获取或设置 拥有此角色的用户信息集合
        /// </summary>
        public virtual ICollection<Member> Members { get; set; }
    }

}
