using System;
using System.Collections;
using Arbor.Model;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Resource;


namespace Arbor.Tools.Services
{
	public class StudentService
	{
		protected static IGateway defaultApiGateway = null;
		
		public StudentService ()
		{
		}
		
		/// <summary>
		/// Gets the current students.
		/// </summary>
		/// <returns>
		/// ModelCollection<Student> The current students.
		/// </returns>
		public static ModelCollection<Student> getCurrentStudents()
		{
			RestGateway gateway = (RestGateway) StudentService.getGateway();
			ModelCollection<Student> studentCollection = new ModelCollection<Student> ();
						
			SimpleQuery query = new SimpleQuery(ResourceType.SCHOOL_ENROLMENT);
			string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			query.addPropertyFilter("startDate", SimpleQuery.OPERATOR_BEFORE, date);
			query.addPropertyFilter("endDate", SimpleQuery.OPERATOR_AFTER, date);
			
			ModelCollection<ModelBase> collection =  gateway.query(query); // School enrolments
			
			// Get students from school enrolment and add to the collection
			foreach (ModelBase model in collection) {
				SchoolEnrolment schoolEnrolment = (SchoolEnrolment) model;
				Student student = schoolEnrolment.getStudent();
				
        	    studentCollection.add(student);
        	}
			
			return studentCollection;
		}
		
		/// <summary>
		/// Gets the students in registration form.
		/// </summary>
		/// <returns>
		/// The students in registration form.
		/// </returns>
		public static ModelCollection<Student> getStudentsInRegistrationForm()
		{
			RestGateway gateway = (RestGateway) StudentService.getGateway();
			ModelCollection<Student> studentCollection = new ModelCollection<Student> ();

			// TODO: implement querying
			
			return studentCollection;
		}
		
		/// <summary>
		/// Gets the students in year group.
		/// </summary>
		/// <returns>
		/// The students in year group.
		/// </returns>
		public static ModelCollection<Student> getStudentsInYearGroup()
		{
			RestGateway gateway = (RestGateway) StudentService.getGateway();
			ModelCollection<Student> studentCollection = new ModelCollection<Student> ();

			// TODO: implement querying
			
			return studentCollection;
		}
		
		public static IGateway getGateway()
		{
			if (StudentService.defaultApiGateway == null)
			{
				throw new Exception("You must call StudentService.setDefaultGateway() prior to calling 'get' methods");
			}
			
			return StudentService.defaultApiGateway;
		}
		
		public static void setDefaultGateway(IGateway gateway)
		{
			StudentService.defaultApiGateway = gateway;
		}
	}
}

