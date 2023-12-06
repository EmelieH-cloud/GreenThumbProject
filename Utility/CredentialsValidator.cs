namespace GreenThumbProject.Utility
{
    // Klass som används i regsiterWindow för att säkerställa att valt username + password är ok.
    public class CredentialsValidator
    {

        public bool LengthRequirementAchieved(string input)
        {
            int length = input.Length;
            if (length >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool ContainsAtLeastOneNumber(string input)
        {
            int counter = 0;
            char[] chars = input.ToCharArray();
            foreach (char c in chars)
            {
                if (char.IsDigit(c))
                    counter++;
            }

            if (counter == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
