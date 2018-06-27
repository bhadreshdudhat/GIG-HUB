using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace GIG_HUB.ViewModels
{
    public class ValidTime : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            bool isValid = System.DateTime.TryParseExact(Convert.ToString(value),
                                            "HH:mm",
                                            CultureInfo.CurrentCulture,
                                            DateTimeStyles.None,
                                            out DateTime dateTime
                                         );
            
            return (isValid);
        }
    }
}
