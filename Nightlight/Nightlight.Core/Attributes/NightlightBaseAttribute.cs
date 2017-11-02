using System;
using System.Collections.Generic;
using System.Text;

namespace Nightlight.Core.Attributes
{
    [AttributeUsage(AttributeTargets.All)]
    public abstract class NightlightBaseAttribute : Attribute
    {
        protected string _title;

        public NightlightBaseAttribute(string title)
        {
            _title = title;
        }

        public virtual string Title
        {
            get { return _title; }
        }
    }
}
