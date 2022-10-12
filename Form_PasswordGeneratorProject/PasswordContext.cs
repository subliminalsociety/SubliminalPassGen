namespace Form_PasswordGeneratorProject {
    public class PasswordContext {
        public PasswordContext(int passwordLength, bool includeSymbols, bool includeNumbers, bool includeLowercase, bool includeUppercase, bool excludeSimilar, bool excludeAmbiguous) {
            this.passwordLength = passwordLength;
            this.includeSymbols = includeSymbols;
            this.includeNumbers = includeNumbers;
            this.includeLowercase = includeLowercase;
            this.includeUppercase = includeUppercase;
            this.excludeSimilar = excludeSimilar;
            this.excludeAmbiguous = excludeAmbiguous;
        }

        
        public int passwordLength { get; private set; }
        public bool includeSymbols { get; private set; }
        public bool includeNumbers { get; private set; }
        public bool includeLowercase { get; private set; }
        public bool includeUppercase { get; private set; }
        public bool excludeSimilar { get; private set; }
        public bool excludeAmbiguous { get; private set; }

    }
}