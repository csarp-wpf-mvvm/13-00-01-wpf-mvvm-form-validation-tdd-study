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
        //Acs-Sánt*
        //Farkasné Sz8bó
        public bool IsOnlyLetterOrSpaceOrDash => IsOnlyLetter || IsThereDashInTheName || IsThereSpaceInTheName;
        public bool IsOnlyLetter => !string.IsNullOrEmpty(_nameToValidate) ? _nameToValidate.All(char.IsLetter) : false;

        public bool IsThereSpaceInTheName => 
            string.IsNullOrEmpty(_nameToValidate) ? false :
                _nameToValidate.First() == ' ' || _nameToValidate.EndsWith(" ") ? false :
                    _nameToValidate.Contains(" ") ? true : false;
        public bool IsThereDashInTheName =>
            string.IsNullOrEmpty(_nameToValidate) ? false : 
                _nameToValidate.First() == '-' || _nameToValidate.EndsWith("-") ? false : 
                    _nameToValidate.Contains("-") ? true : false;

    }
}
