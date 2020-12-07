using System;
using UnityEngine;

namespace Ascetic.Unity.Core
{
    [AttributeUsage(AttributeTargets.Field)]
    public class PropertyFieldAttribute : PropertyAttribute
    {
        public string PropertyName { get; private set; }

        public PropertyFieldAttribute(string propertyName)
        {
            PropertyName = propertyName;
        }
    }
}
