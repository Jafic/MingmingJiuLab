using System;

namespace Chen.Model
{
    /// <summary>
    /// 时间戳模型
    /// </summary>
    public class ModelWithTime
    {
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime Create_Time { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        public DateTime Update_Time { get; set; }
    }
}
