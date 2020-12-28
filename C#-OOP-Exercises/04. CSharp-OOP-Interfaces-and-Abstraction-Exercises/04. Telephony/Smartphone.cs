namespace Telephony
{
    public class Smartphone : ICallable, IBrowsabale
    {
        public string Browse(string URL)
        {
            bool isLettersOnly = this.CheckForNumbersInURL(URL);

            if (isLettersOnly)
            {
                return $"Browsing: {URL}!";
            }
            else
            {
                return "Invalid URL!";
            }

        }

        public string Call(string number)
        {
            bool isNumbersOnly = this.CheckForLettersInNumber(number);

            if (isNumbersOnly)
            {
                return $"Calling... {number}";
            }
            else
            {
                return "Invalid number!";
            }
        }

        private bool CheckForLettersInNumber(string number)
        {
            foreach (var symbol in number)
            {
                if (!char.IsDigit(symbol))
                {
                    return false;
                }
            }

            return true;
        }

        private bool CheckForNumbersInURL(string URL)
        {
            foreach (var letter in URL)
            {
                if (char.IsDigit(letter))
                {
                    return false;
                }
            }

            return true;
        }
    }
}