using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Form_PasswordGeneratorProject {

    public class PasswordGenerator {
        const string symbols = "!@#$%^&*()_+{}:?|[];',./`~" + @"\";
        const string numbers = "0123456789";
        const string lowercase = "abcdefghijklmnopqrstuvwxyz";
        const string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string similar = "iIl10oO";
        private const string ambiguous = @"{}[]()'""~`,:_<>" + @"\";
        
        public string GeneratePassword(PasswordContext passwordContext) {
            string valid = GetValidCharacterTable(passwordContext);
            StringBuilder stringBuilder = new StringBuilder();
            Random random = new Random();
            var length = passwordContext.passwordLength;
            while (0 < length--)
            {
                stringBuilder.Append(valid[random.Next(valid.Length)]);
            }
            return stringBuilder.ToString();

        }

        private string GetValidCharacterTable(PasswordContext passwordContext) {
            StringBuilder validStringBuilder = new StringBuilder();
            
            if (passwordContext.includeSymbols) {
                validStringBuilder.Append(symbols);
            }
            if (passwordContext.includeNumbers) {
                validStringBuilder.Append(numbers);
            }
            if (passwordContext.includeLowercase) {
                validStringBuilder.Append(lowercase);
            }
            if (passwordContext.includeUppercase) {
                validStringBuilder.Append(uppercase);
            }

            string valid = validStringBuilder.ToString();

            if (passwordContext.excludeSimilar) {
                List<char> excludeSimilarCharList = similar.ToList();
                valid = Filter(valid, excludeSimilarCharList);
            }

            if (passwordContext.excludeAmbiguous) {
                List<char> excludeAmbiguousCharList = ambiguous.ToList();
                valid = Filter(valid, excludeAmbiguousCharList);
            }

            return valid;
        }
        private string Filter(string buffer, List<char> charsToRemove)
        {
            foreach (char c in charsToRemove) {
                buffer = buffer.Replace(c.ToString(), String.Empty);
            }
 
            return buffer;
        }
        
    }
    
}