using System;

namespace Arbor.Filter
{
    public class PluralizeFilter : FilterInterface
    {
        public PluralizeFilter()
        {
        }

        public string filter(string text)
        {
            char lastLetter = text[text.Length - 1];
            string pluralizeLetter, returnString = "";

            switch (lastLetter)
            {
                case 's':
                    pluralizeLetter = "ses";
                    break;
                case 'y':
                    if (text.Substring(Math.Max(0, text.Length - 2)) == "ay")
                    {
                        pluralizeLetter = "s";
                    }
                    else
                    {
                        pluralizeLetter = "ies";
                    }
                    break;
                default:
                    pluralizeLetter = "s";
                    break;
            }

            if (pluralizeLetter != "s")
            {
                returnString = text.Substring(0, text.Length - 1) + pluralizeLetter;
            }
            else
            {
                returnString = text + pluralizeLetter;
            }

            return returnString;
        }
    }
}

