using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Khanhlyluyentap1.Models
{
    public class StringProcessLyMSV
    {
        public static String LowerToUpper(string input)
        {
            return input.ToUpper();
        }
    }
}