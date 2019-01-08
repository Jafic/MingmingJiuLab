namespace Chen.Data
{
    using Chen.Data.Entity;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// 数据访问上下文（表结构定义）
    /// </summary>
    public partial class DataContext : DbContext
    {
        /// <summary>
        /// 用户
        /// </summary>
        public virtual DbSet<User> User { get; set; }
    }
}