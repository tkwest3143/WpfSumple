using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Common
{
    
    [AttributeUsage(AttributeTargets.Field,Inherited =false,AllowMultiple =false)]
    public sealed class UriAttribute : Attribute
    {
        public string Value { get; private set; }
        public UriAttribute(string value)
        {
            Value = value;
        }
    }
    
}
