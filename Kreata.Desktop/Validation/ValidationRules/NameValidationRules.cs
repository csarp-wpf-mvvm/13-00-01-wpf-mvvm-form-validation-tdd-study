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
        public bool IsOnlyLetter
        {
            get
            {
                if (!_nameToValidate.Any())
                    return false;
                foreach (char c in _nameToValidate)
                    if (!char.IsLetter(c))
                        return false;
                return true;
            }
        }

        public bool IsThereSpaceInTheName => false;
        public bool IsThereDashInTheName => false;

    }
}
