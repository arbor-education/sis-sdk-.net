using System;
using System.Collections;

namespace Arbor.Model
{
	public class ModelCollection<T> : CollectionBase
	{
		public ModelCollection ()
		{
		}

		public void add (T model)
		{
			this.List.Add(model);
		}
	}
}

