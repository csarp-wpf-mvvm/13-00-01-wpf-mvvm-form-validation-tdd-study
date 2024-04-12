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
        public bool IsOnlyLetterOrSpaceOrDash
        {
            get
            {
                if (string.IsNullOrEmpty(_nameToValidate))
                    return false;
                for (int i = 0; i < _nameToValidate.Length; i++)
                {
                    if (i == 0 || i == _nameToValidate.Length - 1)
                    {
                        if (!char.IsLetter(_nameToValidate[i]))
                            return false;
                    }
                    else
                    {
                        if (!(char.IsLetter(_nameToValidate[i]) || _nameToValidate[i] == ' ' || _nameToValidate[i] == '-'))
                            return false;
                    }
                }
                return true;
            }
        }
        public bool IsOnlyLetter => !string.IsNullOrEmpty(_nameToValidate) ? _nameToValidate.All(char.IsLetter) : false;

        public bool IsThereSpaceInTheName => 
            string.IsNullOrEmpty(_nameToValidate) ? false :
                _nameToValidate.First() == ' ' || _nameToValidate.EndsWith(" ") ? false :
                    _nameToValidate.Contains(" ") ? true : false;
        public bool IsThereDashInTheName =>
            string.IsNullOrEmpty(_nameToValidate) ? false : 
                _nameToValidate.First() == '-' || _nameToValidate.EndsWith("-") ? false : 
                    _nameToValidate.Contains("-") ? true : false;
        public bool IsTheFirstLetterCapital => false;
        public bool IsOnlyLetterOrSpace => false;
        public bool IsLowerCaseAfterCapitalLetter => false;
        public bool IsAfterDashOneCapitalAndOneLowerCaseLetter => false;
        public bool IsAfterSpcaeOneCapitalAndOneLowerCaseLetter => false;
        public bool IsOnlyOneSpaceInName => false;
        public bool IsOnlyOneSpaceOrDashInName => false;
    }
}
