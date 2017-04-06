using System;
using System.Text.RegularExpressions;


namespace Arbor.Filter
{
	public class CamelCaseToDash
	{
		public CamelCaseToDash ()
		{
		}

		public string filter (string text)
		{
			string pattern = @"(?<=(?:[A-Z]))([A-Z]+)([A-Z][A-z])";
			string replacement = @"$1-$2";

			Regex rgx = new Regex(pattern);
			text = rgx.Replace(text, replacement);
			pattern = "(?<=(?:[a-z0-9]))([A-Z])";
			replacement = "-$1";
			rgx = new Regex(pattern);
			text = rgx.Replace(text, replacement);

			return text.ToLower();
		}
	}
}

