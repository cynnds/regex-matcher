using System.ComponentModel;
using System.Text.RegularExpressions;

namespace RegexMatcher.Models
{
    public class RegexModels
    {
        [DisplayName("String")]
        public string stringToMatch { get; set; }

        public string inputRegex { get; set; }        
    }
}