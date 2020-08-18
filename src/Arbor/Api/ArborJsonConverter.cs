using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.Text;


namespace Arbor.Model.Api
{
	/// <summary>
	/// Arbor custom json converter. Use this class in order to override
	/// default character escaping in json response.
	/// </summary>
	/// <exception cref='NotImplementedException'>
	/// Is thrown when a requested operation is not implemented for a given type.
	/// </exception>
	public class ArborJsonConverter : JsonConverter
	{
		public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(String);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

		/// <summary>
		/// Customize jston write. In case of date we will remove escape characters
		/// from json response.
		/// </summary>
		/// <param name='writer'>
		/// Writer.
		/// </param>
		/// <param name='value'>
		/// Value.
		/// </param>
		/// <param name='serializer'>
		/// Serializer.
		/// </param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {			
			JToken token = JToken.FromObject(value);
			string sTokenVal = (string) token.Value<string>();
			
			// Handle specific types that are escaped by default
			if (sTokenVal.IndexOf('\\') > -1 
			    || sTokenVal.Contains("\"entityType\":\"date\"") 
			    || sTokenVal.Contains("tagName") 
			    || sTokenVal.Contains("{}") 
			    || sTokenVal.Contains("\"") 
			    || sTokenVal == "\"\"")
			{
                writer.WriteRawValue(value.ToString());
			}
			else
			{
				writer.WriteValue(value.ToString()); // Write value without escaping characters
			}
            writer.Flush();
        }
		
		public override bool CanWrite
	    {
	        get
	        {
	            return true;
	        }
	    }
	    public override bool CanRead
	    {
	        get
	        {
	            return false;
	        }
	    }
	}
}

