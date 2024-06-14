using System;
using System.Linq;
using System.Reflection;

namespace Magnus.Core.Infrastructure.Resources.Extentions;

public static class TypeExtentions
{
    public static PropertyInfo[] GetDistinctProperties(this Type source, Type comparison)
    {
        PropertyInfo[] sourceProperties = source.GetProperties();
        string[] comparisonPropertyNames = comparison.GetProperties().Select(p => p.PropertyType.FullName!).ToArray();

        return sourceProperties.Where(p => comparisonPropertyNames.Contains(p.PropertyType.FullName) is false).ToArray();
    }
}
