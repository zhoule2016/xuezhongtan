﻿
using XZTJY.Component.Tools;
using XZTJY.Core.Models.Security;

using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace XZTJY.Core.Models.Account
{
   
    /// <summary>
    ///     实体类——用户信息
    /// </summary>
    [Description("用户信息")]
    public class Member : EntityBase<int>
    {
        public Member()
        {
            Roles = new List<Role>();
            LoginLogs = new List<LoginLog>();
        }

        [Required]
        [StringLength(20)]
        public string UserName { get; set; }

        [Required]
        [StringLength(32)]
        public string Password { get; set; }

        [Required]
        [StringLength(20)]
        public string NickName { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        /// <summary>
        /// 获取或设置 用户扩展信息
        /// </summary>
        public virtual MemberExtend Extend { get; set; }

        /// <summary>
        /// 获取或设置 用户拥有的角色信息集合
        /// </summary>
        public virtual ICollection<Role> Roles { get; set; }

        /// <summary>
        /// 获取或设置 用户登录记录集合
        /// </summary>
        public virtual ICollection<LoginLog> LoginLogs { get; set; }
    }
}
