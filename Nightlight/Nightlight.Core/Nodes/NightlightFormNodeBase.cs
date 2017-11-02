using System;
using System.Collections.Generic;
using System.Text;

namespace Nightlight.Core.Nodes
{
    public abstract class NightlightFormNodeBase
    {
        public string Title { get; set; }

        public override string ToString()
        {
            return string.Format("[NightlightFormNode: Title={0}]", Title);
        }

        public abstract bool IsValid();
        public abstract string GetErrorMessage();
    }
}
