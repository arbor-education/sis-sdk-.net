using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StudentInterventionGoal : ModelBase
    {
        protected string resourceType = ResourceType.STUDENT_INTERVENTION_GOAL;
        public const string STUDENT_INTERVENTION = "studentIntervention";
        public const string TARGET_DATE = "targetDate";
        public const string OBJECTIVES = "objectives";

        public StudentInterventionGoal()
        {
            base.resourceType = this.resourceType;
        }

        public StudentInterventionGoal(string resourceType = "StudentInterventionGoal", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<StudentInterventionGoal> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("StudentInterventionGoal");
            RestGateway gateway = (RestGateway)StudentInterventionGoal.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<StudentInterventionGoal> studentinterventiongoalCollection = new ModelCollection<StudentInterventionGoal>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                studentinterventiongoalCollection.add((StudentInterventionGoal)model);
            }

            return studentinterventiongoalCollection;
        }

        public static StudentInterventionGoal retrieve(string id)
        {
            RestGateway gateway = (RestGateway)StudentInterventionGoal.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (StudentInterventionGoal)gateway.retrieve(ResourceType.STUDENT_INTERVENTION_GOAL, id);
        }

        public StudentIntervention getStudentIntervention()
        {
            return (StudentIntervention)this.getProperty("studentIntervention");
        }

        public void setStudentIntervention(StudentIntervention studentIntervention)
        {
            this.setProperty("studentIntervention", studentIntervention);
        }

        public DateTime getTargetDate()
        {
            return Convert.ToDateTime(this.getProperty("targetDate"));
        }

        public void setTargetDate(DateTime targetDate)
        {
            this.setProperty("targetDate", targetDate);
        }

        public string getObjectives()
        {
            return this.getProperty("objectives").ToString();
        }

        public void setObjectives(string objectives)
        {
            this.setProperty("objectives", objectives);
        }


    }
}

