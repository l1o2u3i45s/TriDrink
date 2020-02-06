using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DrinkAndDrink.ValidationRule
{
    public class EmptyStringRule : System.Windows.Controls.ValidationRule
    {
        public EmptyStringRule()
        {
        }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            var account = value as string;
            return string.IsNullOrEmpty(account) ? new ValidationResult(false,"此欄位不可空白") : ValidationResult.ValidResult;
        }
    }
}
