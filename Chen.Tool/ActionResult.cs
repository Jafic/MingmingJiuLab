using System;

namespace Chen.Tool
{
    public class ActionResult
    {
        /// <summary>
        /// 操作成功
        /// </summary>
        public static ActionResult Success
        {
            get
            {
                return new ActionResult { IsSuccess = true, Message = string.Empty };
            }
        }

        /// <summary>
        /// 是否成功
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 操作消息
        /// </summary>
        public string Message { get; set; }
    }

    /// <summary>
    /// 含数据的操作结果
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ActionResult<T> : ActionResult
    {
        /// <summary>
        /// 数据
        /// </summary>
        public T Data { get; set; }
    }
}
