using System;
using Arbor.Model;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Resource;


namespace Arbor.Tools.Services
{
	public class StudentGroupService
	{
		protected static IGateway defaultApiGateway = null;
		
		public StudentGroupService ()
		{
		}
		
		/// <summary>
		/// Gets the current registration forms.
		/// </summary>
		/// <returns>
		/// The current registration forms.
		/// </returns>
		public static ModelCollection<Student> getCurrentRegistrationForms()
		{
			RestGateway gateway = (RestGateway) StudentGroupService.getGateway();
			ModelCollection<Student> studentCollection = new ModelCollection<Student> ();

			// TODO: implement querying
			
			return studentCollection;
		}
		
		/// <summary>
		/// Gets the current year groups.
		/// </summary>
		/// <returns>
		/// The current year groups.
		/// </returns>
		public static ModelCollection<Student> getCurrentYearGroups()
		{
			RestGateway gateway = (RestGateway) StudentGroupService.getGateway();
			ModelCollection<Student> studentCollection = new ModelCollection<Student> ();

			// TODO: implement querying
			
			return studentCollection;
		}
		
		public static IGateway getGateway()
		{
			if (StudentGroupService.defaultApiGateway == null)
			{
				throw new Exception("You must call StudentGroupService.setDefaultGateway() prior to calling 'get' methods");
			}
			
			return StudentGroupService.defaultApiGateway;
		}
		
		public static void setDefaultGateway(IGateway gateway)
		{
			StudentGroupService.defaultApiGateway = gateway;
		}
	}
}

