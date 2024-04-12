using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.Desktop.Validation.ValidationRules
{
    public class NameValidationRules
    {
        private readonly string _nameToValidate;
        public NameValidationRules(string name)
        {
            _nameToValidate = name;
        }

        public bool IsNameShort => _nameToValidate.Length < 2;
        public bool IsOnlyLetterOrSpaceOrDash => false;
        public bool IsOnlyLetter => !string.IsNullOrEmpty(_nameToValidate) ? _nameToValidate.All(char.IsLetter) : false;

        public bool IsThereSpaceInTheName => 
            string.IsNullOrEmpty(_nameToValidate) ? false :
                _nameToValidate.First() == ' ' || _nameToValidate.EndsWith(" ") ? false :
                    _nameToValidate.Any(char.IsWhiteSpace);
        public bool IsThereDashInTheName => false;

    }
}
