using Chen.Tool;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chen.Data
{
    public partial class DataContext_Helper : DbContext
    {

        public static T Using<T>(Func<DataContext, T> getResult, bool readOnly = false)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            using (var context = new DataContext(optionsBuilder.Options))
            {
                var result = getResult(context);
                if (!readOnly && result is ActionResult)
                {
                    //context.ActionByResult(result as ActionResult);
                }
                return result;
            }
        }

    }
}
