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
    public class TRIEmployeeIDRule : System.Windows.Controls.ValidationRule
    {
        public TRIEmployeeIDRule()
        {
        }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            var account = value as string;
            var triEmpID = new Regex("tr[0-9]{4}");
            return !triEmpID.IsMatch(account) ? new ValidationResult(false,"工號格式錯誤") : ValidationResult.ValidResult;
        }
    }
}
