using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Chen.Data.Entity
{
    public class Entity
    {
        public Entity()
        {
            Id = Guid.NewGuid().ToString();
            CreateTime = DateTime.Now;
            UpdateTime = DateTime.Now;
        }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 主键编号
        /// </summary>
        [Key]
        public string Id { get; set; }
        /// <summary>
        /// 创建者
        /// </summary>
        [MaxLength(50)]
        public string CreateOperator { get; set; }

        /// <summary>
        /// 最后更新时间
        /// </summary>
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// 最后更新者
        /// </summary>
        [MaxLength(50)]
        public string UpdateOperator { get; set; }
    }

    /// <summary>
    /// 用户
    /// </summary>
    public class User : Entity
    {
        /// <summary>
        /// 登录名
        /// </summary>
        public string LoginName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string Telephone { get; set; }
    }
}
