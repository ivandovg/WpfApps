using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfAppBinding2
{
    public class YearOfIssueRule : ValidationRule
    {
        public short CurrentYear { get; set; }

        public YearOfIssueRule()
        {
            CurrentYear = (short)DateTime.Now.Year;
        }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            short year;
            if(!short.TryParse(value.ToString(), out year))
            {
                return new ValidationResult(false, "Cannot parse value!");
            }

            if(year > CurrentYear)
            {
                return new ValidationResult(false, "Cannot set year, is incorrect!");
            }

            return new ValidationResult(true, null);
        }
    }
}
