using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    /// <summary>
    /// 用户表
    /// </summary>
    public class Personnels
    {
        /// <summary>
        /// 自增主键
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// 账户
        /// </summary>
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string AccountNumber { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string AccountName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Password { get; set; }
        /// <summary>
        /// 性别 0：女；1：男；2：未知
        /// </summary>
        [DefaultValue(1)]
        public int sex { get; set; }
        /// <summary>
        /// 分组
        /// </summary>
        [Column(TypeName = "varchar(50)")]
        public string GroupId { get; set; }
        /// <summary>
        /// 手机号码
        /// </summary>
        [Column(TypeName = "varchar(11)")]
        public string Mobile { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        [Column(TypeName = "varchar(40)")]
        public string Email { get; set; }
        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTime CreatTime { get; set; }
        /// <summary>
        /// 上次登录时间
        /// </summary>
        public DateTime LastLoginTime { get; set; }
        /// <summary>
        /// 上次登录IP
        /// </summary>
        [Column(TypeName = "varchar(30)")]
        public string LastLoginIP { get; set; }
        /// <summary>
        /// 是否启用
        /// </summary>
        [DefaultValue(true)]
        public bool isEnable { get; set; }
    }
}
