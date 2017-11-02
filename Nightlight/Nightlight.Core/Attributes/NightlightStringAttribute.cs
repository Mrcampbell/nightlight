using System;
using System.Collections.Generic;
using System.Text;
using Nightlight.Core.Attributes;

namespace Nightlight.Core.Attributes
{
    public class NightlightStringAttribute : NightlightBaseAttribute
    {
        private bool _required;
        private int _minLength;
        private int _maxLength;
        //private string _regex_pattern; // to be

        public NightlightStringAttribute(string title) : base(title)
        {
            _title = title;
        }

        public virtual bool Required { get; set; }

        public virtual int MinLength { get; set; }

        public virtual int MaxLength { get; set; }

    }
}
