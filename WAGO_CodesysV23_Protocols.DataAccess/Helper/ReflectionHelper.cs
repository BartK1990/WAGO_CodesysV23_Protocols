using System;
using System.Linq;
using System.Reflection;
using WAGO_CodesysV23_Protocols.Model.Type;

namespace WAGO_CodesysV23_Protocols.DataAccess.Helper
{
    internal static class ReflectionHelper
    {
        // Reflection - allows inner classes - supports string and System.Boolean as destination type
        internal static void SetValue(object obj, string property, string value)
        {
            object finalObj;
            PropertyInfo rowPI;
            finalObj = DigObject(obj, property);
            var finalProperty = property.Split('.').Last();

            Type type = finalObj.GetType();
            rowPI = type.GetProperty(finalProperty);
            if (rowPI == null)
            {
                throw new ArgumentException($"Wrong property name: {property}");
            }

            switch (rowPI.PropertyType.Name)
            {
                case "Boolean":
                    if (int.TryParse(value, out int i))
                    {
                        bool b = Convert.ToBoolean(i);
                        rowPI.SetValue(finalObj, b);
                    }
                    break;
                case "WagoTime":
                    InvokeMethod(finalObj, finalProperty, nameof(WagoTime.SetTimeValue), new object[] { value });
                    break;
                default:
                    rowPI.SetValue(finalObj, value);
                    break;
            }
        }

        private static object DigObject(object obj, string property)
        {
            if (obj == null)
            {
                throw new NullReferenceException($"Object is null for property name: {property}");
            }

            var properties = property.Split('.');
            if (properties.Length > 1)
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
                        return obj;
                    }
                }
            }
            return obj;
        }

        private static void InvokeMethod(object obj, string property, string method, object[] parametersArray = null)
        {
            if (obj == null)
            {
                throw new NullReferenceException($"Object is null for property name: {property}");
            }

            // Get property class type
            Type type = obj.GetType();
            PropertyInfo rowPI = type.GetProperty(property);
            obj = rowPI.GetValue(obj);
            type = obj.GetType();

            MethodInfo methodInfo = type.GetMethod(method);
            if (methodInfo == null)
                throw new NullReferenceException($"There is no method: {method} for property: {property}");

            methodInfo.Invoke(obj, parametersArray);
        }

    }
}
