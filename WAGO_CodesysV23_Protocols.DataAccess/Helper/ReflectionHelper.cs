using System;
using System.Reflection;

namespace WAGO_CodesysV23_Protocols.DataAccess.Helper
{
    internal static class ReflectionHelper
    {
        // Reflection - allows inner classes - supports string and boolean as destination type
        internal static void SetValue(object obj, string property, string value)
        {
            if (obj == null)
            {
                throw new NullReferenceException($"Object is null for property name: {property}");
            }
            
            var properties = property.Split('.');
            if (properties.Length == 1)
            {
                Type type = obj.GetType();
                PropertyInfo rowPI = type.GetProperty(property);
                if (rowPI == null)
                {
                    throw new ArgumentException($"Wrong property name: {property}");
                }
                rowPI.SetValue(obj, value);
            }
            else
            {
                for (int i = 0; i < properties.Length; i++)
                {
                    Type type = obj.GetType();
                    PropertyInfo rowPI = type.GetProperty(properties[i]);
                    if (rowPI == null)
                    {
                        throw new ArgumentException($"Wrong property name: {property}");
                    }
                    if (i < (properties.Length - 1))
                    {
                        obj = rowPI.GetValue(obj);
                    }
                    else
                    {
                        // ToDo add helper class or method for boolean handling
                        if (rowPI.PropertyType.Name == "Boolean")
                        {
                            rowPI.SetValue(obj, Convert.ToBoolean(Convert.ToInt16(value)));
                        }
                        else
                        {
                            rowPI.SetValue(obj, value);
                        }
                    }
                }
            }
        }
    }
}
