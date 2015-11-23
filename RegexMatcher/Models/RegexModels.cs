using System.ComponentModel;
using System.Text.RegularExpressions;

namespace RegexMatcher.Models
{
    public class RegexModels
    {
        [DisplayName("String")]
        public string stringToMatch { get; set; }

        public string regex { get; set; }    
        
        public string output { get; set; }    
    }
}