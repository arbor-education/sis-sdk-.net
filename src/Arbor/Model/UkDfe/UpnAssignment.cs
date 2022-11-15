using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class UpnAssignment : ModelBase
    {
        protected new string resourceType = ResourceType.UK_DFE_UPN_ASSIGNMENT;
        public const string STUDENT = "student";
        public const string ISSUED_YEAR = "issuedYear";
        public const string ISSUED_LOCAL_AUTHORITY = "issuedLocalAuthority";
        public const string ISSUED_ESTABLISHMENT_NUMBER = "issuedEstablishmentNumber";
        public const string ISSUED_SERIAL_NUMBER = "issuedSerialNumber";
        public const string UPN = "upn";
        public const string START_DATETIME = "startDatetime";
        public const string END_DATETIME = "endDatetime";
        public const string IS_TEMPORARY = "isTemporary";

        public UpnAssignment()
        {
            base.resourceType = this.resourceType;
        }

        public UpnAssignment(string resourceType = "UpnAssignment", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<UpnAssignment> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("UkDfe_UpnAssignment");
            RestGateway gateway = (RestGateway)UpnAssignment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<UpnAssignment> upnassignmentCollection = new ModelCollection<UpnAssignment>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                upnassignmentCollection.add((UpnAssignment)model);
            }

            return upnassignmentCollection;
        }

        public static UpnAssignment retrieve(string id)
        {
            RestGateway gateway = (RestGateway)UpnAssignment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (UpnAssignment)gateway.retrieve(ResourceType.UK_DFE_UPN_ASSIGNMENT, id);
        }

        public Student getStudent()
        {
            return (Student)this.getProperty("student");
        }

        public void setStudent(Student student)
        {
            this.setProperty("student", student);
        }

        public int getIssuedYear()
        {
            return Convert.ToInt32(this.getProperty("issuedYear"));
        }

        public void setIssuedYear(int issuedYear)
        {
            this.setProperty("issuedYear", issuedYear);
        }

        public string getIssuedLocalAuthority()
        {
            return this.getProperty("issuedLocalAuthority").ToString();
        }

        public void setIssuedLocalAuthority(string issuedLocalAuthority)
        {
            this.setProperty("issuedLocalAuthority", issuedLocalAuthority);
        }

        public string getIssuedEstablishmentNumber()
        {
            return this.getProperty("issuedEstablishmentNumber").ToString();
        }

        public void setIssuedEstablishmentNumber(string issuedEstablishmentNumber)
        {
            this.setProperty("issuedEstablishmentNumber", issuedEstablishmentNumber);
        }

        public int getIssuedSerialNumber()
        {
            return Convert.ToInt32(this.getProperty("issuedSerialNumber"));
        }

        public void setIssuedSerialNumber(int issuedSerialNumber)
        {
            this.setProperty("issuedSerialNumber", issuedSerialNumber);
        }

        public string getUpn()
        {
            return this.getProperty("upn").ToString();
        }

        public void setUpn(string upn)
        {
            this.setProperty("upn", upn);
        }

        public DateTime getStartDatetime()
        {
            return Convert.ToDateTime(this.getProperty("startDatetime"));
        }

        public void setStartDatetime(DateTime startDatetime)
        {
            this.setProperty("startDatetime", startDatetime);
        }

        public DateTime getEndDatetime()
        {
            return Convert.ToDateTime(this.getProperty("endDatetime"));
        }

        public void setEndDatetime(DateTime endDatetime)
        {
            this.setProperty("endDatetime", endDatetime);
        }

        public bool getIsTemporary()
        {
            return Convert.ToBoolean(this.getProperty("isTemporary"));
        }

        public void setIsTemporary(bool isTemporary)
        {
            this.setProperty("isTemporary", isTemporary);
        }


    }
}

