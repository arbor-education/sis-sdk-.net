using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StudentRecordChange : ModelBase
    {
        protected string resourceType = ResourceType.STUDENT_RECORD_CHANGE;
        public const string STUDENT = "student";
        public const string CHANGER_CLASS_NAME = "changerClassName";
        public const string CHANGE_TYPE = "changeType";
        public const string REFERENCE_OBJECT = "referenceObject";
        public const string ACCEPTED_DATETIME = "acceptedDatetime";
        public const string REJECTED_DATETIME = "rejectedDatetime";
        public const string ACTIONED_BY_STAFF = "actionedByStaff";
        public const string OLD_DATA = "oldData";
        public const string NEW_DATA = "newData";

        public StudentRecordChange()
        {
            base.resourceType = this.resourceType;
        }

        public StudentRecordChange(string resourceType = "StudentRecordChange", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<StudentRecordChange> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("StudentRecordChange");
            RestGateway gateway = (RestGateway)StudentRecordChange.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<StudentRecordChange> studentrecordchangeCollection = new ModelCollection<StudentRecordChange>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                studentrecordchangeCollection.add((StudentRecordChange)model);
            }

            return studentrecordchangeCollection;
        }

        public static StudentRecordChange retrieve(string id)
        {
            RestGateway gateway = (RestGateway)StudentRecordChange.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (StudentRecordChange)gateway.retrieve(ResourceType.STUDENT_RECORD_CHANGE, id);
        }

        public Student getStudent()
        {
            return (Student)this.getProperty("student");
        }

        public void setStudent(Student student)
        {
            this.setProperty("student", student);
        }

        public string getChangerClassName()
        {
            return this.getProperty("changerClassName").ToString();
        }

        public void setChangerClassName(string changerClassName)
        {
            this.setProperty("changerClassName", changerClassName);
        }

        public string getChangeType()
        {
            return this.getProperty("changeType").ToString();
        }

        public void setChangeType(string changeType)
        {
            this.setProperty("changeType", changeType);
        }

        public ModelBase getReferenceObject()
        {
            return (ModelBase)this.getProperty("referenceObject");
        }

        public void setReferenceObject(ModelBase referenceObject)
        {
            this.setProperty("referenceObject", referenceObject);
        }

        public DateTime getAcceptedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("acceptedDatetime"));
        }

        public void setAcceptedDatetime(DateTime acceptedDatetime)
        {
            this.setProperty("acceptedDatetime", acceptedDatetime);
        }

        public DateTime getRejectedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("rejectedDatetime"));
        }

        public void setRejectedDatetime(DateTime rejectedDatetime)
        {
            this.setProperty("rejectedDatetime", rejectedDatetime);
        }

        public Staff getActionedByStaff()
        {
            return (Staff)this.getProperty("actionedByStaff");
        }

        public void setActionedByStaff(Staff actionedByStaff)
        {
            this.setProperty("actionedByStaff", actionedByStaff);
        }

        public string getOldData()
        {
            return this.getProperty("oldData").ToString();
        }

        public void setOldData(string oldData)
        {
            this.setProperty("oldData", oldData);
        }

        public string getNewData()
        {
            return this.getProperty("newData").ToString();
        }

        public void setNewData(string newData)
        {
            this.setProperty("newData", newData);
        }


    }
}

