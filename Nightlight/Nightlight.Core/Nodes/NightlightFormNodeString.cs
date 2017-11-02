using System;
using System.Collections.Generic;
using System.Text;

namespace Nightlight.Core.Nodes
{
    public class NightlightFormNodeString : NightlightFormNodeBase
    {
        public string Value {
            get { return _value; }
            set { _value = value; }
        }

        public bool Required
        {
            get { return _required; }
            set { _required = value; }
        }

        public int MinLength {

            get { return _minLength; }

            set
            {
                // TODO: validate input value
                _minLength = value;

                // only set after validated
                _minLengthSet = true;

            }
        }

        public int MaxLength
        {
            get
            {
                return _maxLength;
            }
            set
            {
                // TODO: validate input value
                _minLength = value;

                // only set after validated
                _minLengthSet = true;
            }
        }

        // implement the gettter/setters
        private string _value;
        private string _title;
        private bool _required;
        private int _minLength;
        private int _maxLength;

        // these exist so we can know whether we need
        // to validate length in the IsValid function
        // if not, we can ignore them.
        private bool _minLengthSet { get; set; }
        private bool _maxLengthSet { get; set; }

        public override bool IsValid()
        {
            return GetErrorMessage().Equals(String.Empty);
        }

        public override string GetErrorMessage()
        {
            if (_required && String.IsNullOrWhiteSpace(_value))
                return "Field Cannot Be Empty";
            if (_minLengthSet && _value.Length < _minLength)
                return $"Too Short. Minimum Length: {_minLength}";
            if (_maxLengthSet && _value.Length > _maxLength)
                return $"Too Long. Maximum Length: {_maxLength}";

            return String.Empty;

        }

        public NightlightFormNodeString(string title)
        {
            _title = title;
            _required = false;
            _minLength = 0;
            _maxLength = 0;
            _minLengthSet = false;
            _maxLengthSet = false;
        }
    }
}
