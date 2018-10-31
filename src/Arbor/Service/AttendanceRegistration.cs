using System;
using System.Collections;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Arbor.Api.Gateway;
using Arbor.Model.Api;
using Arbor.Model;
using System.Collections.Generic;
using Newtonsoft.Json;


namespace Arbor.Service
{
	public class AttendanceRegistration
	{
		const string MARK_STUDENT = "student";
		const string MARK_MARK = "attendanceMark";
		const string MARK_NOTE = "note";
		const string MARK_MINUTES_LATE = "minutesLate";
		const string MARK_SESSION_START_TIME = "sessionStartTime";
		
		protected RestGateway gateway;
		protected Hydrator hydrator;
		protected List<Hashtable> marks = new List<Hashtable>();

		public AttendanceRegistration (RestGateway gateway)
		{
			this.setGateway(gateway);
			this.hydrator = new Hydrator();
			this.marks = new List<Hashtable>();
		}

		public void awardAttendanceMark(Student student, DateTime sessionStartTime, AttendanceMark attendanceMark, int minutesLate = 0, string note = null)
		{
			Hashtable marks = new Hashtable();

			marks[MARK_STUDENT] = student;
			marks[MARK_SESSION_START_TIME] = sessionStartTime.ToString("yyyy-MM-dd HH:mm:ss");
			marks[MARK_MARK] = attendanceMark;
			marks[MARK_MINUTES_LATE] = minutesLate;
			marks[MARK_NOTE] = note;

			this.marks.Add(marks);
		}


		public JObject saveMarks()
		{
			List<Hashtable> payload = new List<Hashtable>();
			Hashtable htRequest = new Hashtable();
			Hashtable htMarks = new Hashtable();

			foreach(Hashtable mark in this.marks)
			{
				Hashtable markPayload = mark;
				markPayload[MARK_STUDENT] = this.getHydrator().extractArray( (ModelBase) markPayload[MARK_STUDENT], true);
				markPayload[MARK_MARK] = this.getHydrator().extractArray( (ModelBase) markPayload[MARK_MARK], true);

				payload.Add(markPayload);
			}

			htMarks["marks"] = payload;
			htRequest["request"] = htMarks;

			string jsonPayload = JsonConvert.SerializeObject(htRequest, Formatting.None).ToString();
			string url = this.getGateway().getBaseUrl() + "/rest-v2/attendance-registration";
			
			JObject response = this.getGateway().sendRequest(RestGateway.HTTP_METHOD_POST.ToString(), url, jsonPayload);

			if(Convert.ToInt32(response["response"]["code"]) == 200)
			{
				this.marks = new List<Hashtable>();
			}
			return response;
		}

		public void setGateway(RestGateway gateway)
		{
			this.gateway = gateway;
		}

		public RestGateway getGateway()
		{
			return this.gateway;
		}
		

		public Hydrator getHydrator()
		{
			return this.hydrator;
		}
	}

//	struct Key
//	{
//		public readonly string request;
//		public readonly string marks;
//
//		public Key(string request, string marks)
//		{
//			this.request = request;
//			this.marks = marks;
//		}
//	}
}

