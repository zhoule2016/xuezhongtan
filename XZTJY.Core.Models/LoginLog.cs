﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XZTJY.Component.Tools;
namespace XZTJY.Core.Models
{
    /// <summary>
    /// 实体类——登录记录信息
    /// </summary>
    [Description("登录记录信息")]
    public class LoginLog : Entity
    {
        /// <summary>
        /// 获取或设置 登录记录编号
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// 获取或设置 登录IP地址
        /// </summary>
        [Required]
        [StringLength(15)]
        public string IpAddress { get; set; }

        /// <summary>
        /// 获取或设置 用户信息
        /// </summary>
        public virtual Member Member { get; set; }
    }
}
