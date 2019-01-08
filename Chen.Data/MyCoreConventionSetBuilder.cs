using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chen.Data
{

    public class MyCoreConventionSetBuilder : CoreConventionSetBuilder
    {
        public MyCoreConventionSetBuilder(CoreConventionSetBuilderDependencies dependencies) : base(dependencies) { }
        public override ConventionSet CreateConventionSet()
        {
            var conventionSet = base.CreateConventionSet();
            //字符串
            conventionSet.PropertyAddedConventions.Insert(0, new StringDefaultLengthConvention());
            return conventionSet;
        }
    }
    //字符串默认长度
    public class StringDefaultLengthConvention : IPropertyAddedConvention
    {
        public InternalPropertyBuilder Apply(InternalPropertyBuilder propertyBuilder)
        {
            if (propertyBuilder.Metadata.ClrType == typeof(string))
            {
                propertyBuilder.HasMaxLength(32, ConfigurationSource.Convention);
            }
            return propertyBuilder;
        }
    }
}
