using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace GIG_HUB.ViewModels
{
    public class FutureDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            bool isValid = System.DateTime.TryParseExact(Convert.ToString(value),
                                            "d MMM yyyy",
                                            CultureInfo.CurrentCulture,
                                            DateTimeStyles.None,
                                            out DateTime dateTime
                                         );

            return (isValid && dateTime > DateTime.Now);
        }
    }
}
