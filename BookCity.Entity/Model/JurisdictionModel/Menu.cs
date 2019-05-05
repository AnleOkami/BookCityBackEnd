using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.JurisdictionModel
{
    /// <summary>
    /// 菜单表
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// 自增主键
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// 父ID
        /// </summary>
        [Required]
        public int ParentId { get; set; }
        /// <summary>
        /// 子ID
        /// </summary>
        [Required]
        public int CodeId { get; set; }
        /// <summary>
        /// 菜单名称
        /// </summary>
        [Required]
        [Column(TypeName="varchar(50)")]
        public string MeunName { get; set; }
        /// <summary>
        /// 菜单排序
        /// </summary>
        [Required]
        public int MeunSort { get; set; }
        /// <summary>
        /// 菜单页面URL
        /// </summary>
        public string MeunURL { get; set; }
        /// <summary>
        /// 菜单图标
        /// </summary>
        public long MeunIcon { get; set; }
    }
}
