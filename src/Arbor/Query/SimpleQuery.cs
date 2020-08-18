using System;
using System.Collections;
using System.Collections.Generic;
using Arbor.Model;
using System.Net;
using System.Collections.Specialized;


namespace Arbor.Query
{
	public class SimpleQuery
	{
		protected string resourceType = null;
	    protected List<IDictionary<string, object>> propertyFilters;
	    protected List<IDictionary<string, object>> userTagFilters;
		protected List<object> taggingsFilter;
	    protected int pageNumber = 0;
	    protected int pageSize = 0;
	    protected string orderProperty = null;
	    protected string orderDirection = null;

	    public const string OPERATOR_EQUALS = "equals";
	    public const string OPERATOR_FROM = "from";
	    public const string OPERATOR_TO = "to";
	    public const string OPERATOR_AFTER = "after";
	    public const string OPERATOR_BEFORE = "before";
	    public const string OPERATOR_SEARCH = "search";
	    public const string OPERATOR_IN = "in";

		public SimpleQuery (string resourceType=null, 
		                    List<IDictionary<string, object>> propertyFilters = null, 
		                    List<IDictionary<string, object>> userTagFilters = null, 
		                    int pageNumber = 0,
                            string pageSize=null,
		                    List<object> taggingsFilter = null)
		{
			this.setResourceType (resourceType);

			if (propertyFilters == null) {
				this.setPropertyFilters (new List<IDictionary<string, object>> ());
			} else {
				this.setPropertyFilters (propertyFilters);
			}

			if (userTagFilters == null) {
				this.setUserTagFilters(new List<IDictionary<string, object>>());
			} else {
				this.setUserTagFilters (userTagFilters);
			}

	        this.setPageNumber(pageNumber);

			if (taggingsFilter == null) {
				this.setTaggings(new List<object>());
			} else {
				this.setTaggings (taggingsFilter);
			}
		}

		public void setOrderDirection(string orderDirection)
	    {
	        this.orderDirection = orderDirection;
	    }

		public string getOrderDirection()
	    {
	        return this.orderDirection;
	    }

		public void setOrderProperty(string orderProperty)
	    {
	        this.orderProperty = orderProperty;
	    }

		public string getOrderProperty()
	    {
	        return this.orderProperty;
	    }

		public string getResourceType ()
		{
			return this.resourceType;
		}

		public void setResourceType (string resourceType)
		{
			this.resourceType = resourceType;;
		}

		public void setPropertyFilters (List<IDictionary<string, object>> propertyFilters)
		{
			this.propertyFilters = propertyFilters;
		}

		public List<IDictionary<string, object>> getPropertyFilters()
	    {
	        return this.propertyFilters;
	    }

		public void setUserTagFilters (List<IDictionary<string, object>> userTagFilters)
		{
			this.userTagFilters = userTagFilters;
		}

		public List<IDictionary<string, object>> getUserTagFilters()
	    {
	        return this.userTagFilters;
	    }

		public void setTaggings (List<object> userTagFilters)
		{
			this.taggingsFilter = userTagFilters;
		}
		
		public List<object> getTaggings()
		{
			return this.taggingsFilter;
		}

		public void setPageNumber (int pageNumber)
		{
			this.pageNumber = pageNumber;
		}

		public int getPageNumber()
	    {
	        return this.pageNumber;
	    }

		public void setPageSize(int pageSize)
	    {
	        this.pageSize = pageSize;
	    }

		public int getPageSize()
	    {
	        return this.pageSize;
	    }

		public void addPropertyFilter(string propertyName, string sOperator, object propValue)
	    {
			IDictionary<string, object> dict = new Dictionary<string, object>();
			dict.Add (new KeyValuePair<string, object> ("propertyName", propertyName));
			dict.Add (new KeyValuePair<string, object> ("operator", sOperator));
			dict.Add (new KeyValuePair<string, object> ("value", propValue));

//			dict["propertyName"] = propertyName;
//			dict["operator"] = sOperator;
//			dict["value"] = propValue;

			this.propertyFilters.Add(dict);
		}

		public void addUserTagFilter(string tagName, object propValue)
	    {
	        if(propValue is DateTime)
	        {
	            propValue = ((DateTime) propValue).ToString("yyyy-MM-dd HH:mm:ss");
	        }

			IDictionary<string, object> dict = new Dictionary<string, object>();
			dict["tagName"] = tagName;
			dict["value"] = propValue;

			this.userTagFilters.Add(dict);
	    }

		public string getQueryString ()
		{
			WebClient client = new WebClient();

			(this.getPropertyFilters()).ForEach(delegate (IDictionary<string, object> propertyFilter)
			{
				if (propertyFilter["value"] is ModelBase)
				{
					Uri resourceUrl = ((ModelBase) propertyFilter["value"]).getResourceUrl();

					if(resourceUrl == null)
	                {
	                    throw new QueryException("Model user in filters must be connected and have a resource URL set");
	                }

	                propertyFilter["value"] = resourceUrl;
				}
				else if(propertyFilter["value"] is DateTime)
	            {
	                propertyFilter["value"] = ((DateTime) propertyFilter["value"]).ToString("yyyy-MM-dd HH:mm:ss");
	            }

				string key = "filters." + propertyFilter["propertyName"].ToString() + "." + propertyFilter["operator"].ToString();
				string queryValue = "";
				
				if (propertyFilter["value"] is Uri)
				{
					Uri uri = (Uri) propertyFilter["value"];
					queryValue = uri.OriginalString;
				}
				else {
					queryValue = propertyFilter["value"].ToString();
				}

				client.QueryString.Add(key, queryValue);
			});

			foreach(IDictionary userTagFilter in this.getUserTagFilters())
	        {
				client.QueryString.Add("filters.tags." + userTagFilter["tagName"].ToString(), userTagFilter["value"].ToString());
	        }

	        if(this.getPageNumber() != 0)
			{
				client.QueryString.Add("page", this.getPageNumber().ToString());
			}

	        if(this.getPageSize() != 0) 
			{
				client.QueryString.Add("page-size", this.getPageSize().ToString());
			}

			foreach(object tagg in this.getTaggings())
			{
				client.QueryString.Add("filters.self.tagged", tagg.ToString());
			}

			
			return this.formFilterQuery(client.QueryString);
		}
		
		private string formFilterQuery(NameValueCollection queryString)
		{
			string filter = string.Empty;
			
			foreach (string key in queryString.AllKeys) // <-- No duplicate keys returned
			{
				if (queryString[key].IndexOf(",") > -1) // Same key with multiple values
				{
					string[] separator = new string[] {","};
					string[] filterValues = queryString[key].Split(separator, StringSplitOptions.None);
					int index = 0;
					foreach (string filterValue in filterValues)
					{
						filter += key + "[" + index.ToString() + "]=" + filterValue + "&";
						index++;
					}
				}
				else
				{
					filter += key + "=" + queryString[key] + "&";
				}
			}
			
			filter = filter.TrimEnd('&');
			
			return filter;
		}
	}
}

