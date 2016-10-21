﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XZTJY.Core.Models.Account
{
    /// <summary>
    /// 用户地址信息
    /// </summary>
    public class MemberAddress
    {
        [StringLength(10)]
        public string Province { get; set; }

        [StringLength(20)]
        public string City { get; set; }

        [StringLength(20)]
        public string County { get; set; }

        [StringLength(60, MinimumLength = 5)]
        public string Street { get; set; }
    }
}
