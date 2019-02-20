using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class BehaviouralIncidentLevelWorkflow : ModelBase
    {
        protected string resourceType = ResourceType.BEHAVIOURAL_INCIDENT_LEVEL_WORKFLOW;
        public const string LEVEL_OF_INCIDENT = "levelOfIncident";
        public const string AUTO_CLOSE = "autoClose";
        public const string ESCALATION_THRESHOLD_COUNT = "escalationThresholdCount";
        public const string ESCALATION_THRESHOLD_TIME_RANGE = "escalationThresholdTimeRange";
        public const string ESCALATE_TO_LEVEL = "escalateToLevel";
        public const string RESET_TO_ZERO = "resetToZero";
        public const string GUARDIAN_EMAIL_TEMPLATE = "guardianEmailTemplate";
        public const string MESSAGE_CHANNEL = "messageChannel";
        public const string DEFAULT_ASSIGNEE = "defaultAssignee";
        public const string SPECIFIC_ASSIGNEE = "specificAssignee";
        public const string DETENTION_TYPE = "detentionType";
        public const string DETENTION_TIME_FRAME = "detentionTimeFrame";
        public const string POINT_AWARD_SCALE = "pointAwardScale";
        public const string ADD_DEDUCT_POINTS = "addDeductPoints";
        public const string EDITABLE_WATCHERS = "editableWatchers";
        public const string ALLOW_ASSIGN_DETENTION = "allowAssignDetention";
        public const string ALLOW_ADD_DEDUCT_POINTS = "allowAddDeductPoints";
        public const string EMAIL_ASSIGNEE = "emailAssignee";
        public const string ALLOW_ASSIGN_INTERNAL_EXCLUSION = "allowAssignInternalExclusion";

        public BehaviouralIncidentLevelWorkflow ()
        {
            base.resourceType = this.resourceType;
        }
        
        public BehaviouralIncidentLevelWorkflow (string resourceType = "BehaviouralIncidentLevelWorkflow", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<BehaviouralIncidentLevelWorkflow> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("BehaviouralIncidentLevelWorkflow");
        	RestGateway gateway = (RestGateway) BehaviouralIncidentLevelWorkflow.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<BehaviouralIncidentLevelWorkflow> behaviouralincidentlevelworkflowCollection = new ModelCollection<BehaviouralIncidentLevelWorkflow> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    behaviouralincidentlevelworkflowCollection.add((BehaviouralIncidentLevelWorkflow) model);
        	}
        
        	return behaviouralincidentlevelworkflowCollection;
        }

        public static BehaviouralIncidentLevelWorkflow retrieve (string id)
        {
            RestGateway gateway = (RestGateway) BehaviouralIncidentLevelWorkflow.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (BehaviouralIncidentLevelWorkflow) gateway.retrieve(ResourceType.BEHAVIOURAL_INCIDENT_LEVEL_WORKFLOW, id);
        }

        public int getLevelOfIncident ()
        {
            return Convert.ToInt32(this.getProperty("levelOfIncident"));
        }

        public void setLevelOfIncident (int levelOfIncident)
        {
            this.setProperty("levelOfIncident", levelOfIncident);
        }

        public bool getAutoClose ()
        {
            return Convert.ToBoolean(this.getProperty("autoClose"));
        }

        public void setAutoClose (bool autoClose)
        {
            this.setProperty("autoClose", autoClose);
        }

        public int getEscalationThresholdCount ()
        {
            return Convert.ToInt32(this.getProperty("escalationThresholdCount"));
        }

        public void setEscalationThresholdCount (int escalationThresholdCount)
        {
            this.setProperty("escalationThresholdCount", escalationThresholdCount);
        }

        public string getEscalationThresholdTimeRange ()
        {
            return this.getProperty("escalationThresholdTimeRange").ToString();
        }

        public void setEscalationThresholdTimeRange (string escalationThresholdTimeRange)
        {
            this.setProperty("escalationThresholdTimeRange", escalationThresholdTimeRange);
        }

        public int getEscalateToLevel ()
        {
            return Convert.ToInt32(this.getProperty("escalateToLevel"));
        }

        public void setEscalateToLevel (int escalateToLevel)
        {
            this.setProperty("escalateToLevel", escalateToLevel);
        }

        public bool getResetToZero ()
        {
            return Convert.ToBoolean(this.getProperty("resetToZero"));
        }

        public void setResetToZero (bool resetToZero)
        {
            this.setProperty("resetToZero", resetToZero);
        }

        public string getGuardianEmailTemplate ()
        {
            return this.getProperty("guardianEmailTemplate").ToString();
        }

        public void setGuardianEmailTemplate (string guardianEmailTemplate)
        {
            this.setProperty("guardianEmailTemplate", guardianEmailTemplate);
        }

        public string getMessageChannel ()
        {
            return this.getProperty("messageChannel").ToString();
        }

        public void setMessageChannel (string messageChannel)
        {
            this.setProperty("messageChannel", messageChannel);
        }

        public string getDefaultAssignee ()
        {
            return this.getProperty("defaultAssignee").ToString();
        }

        public void setDefaultAssignee (string defaultAssignee)
        {
            this.setProperty("defaultAssignee", defaultAssignee);
        }

        public Staff getSpecificAssignee ()
        {
            return (Staff) this.getProperty("specificAssignee");
        }

        public void setSpecificAssignee (Staff specificAssignee)
        {
            this.setProperty("specificAssignee", specificAssignee);
        }

        public DetentionType getDetentionType ()
        {
            return (DetentionType) this.getProperty("detentionType");
        }

        public void setDetentionType (DetentionType detentionType)
        {
            this.setProperty("detentionType", detentionType);
        }

        public string getDetentionTimeFrame ()
        {
            return this.getProperty("detentionTimeFrame").ToString();
        }

        public void setDetentionTimeFrame (string detentionTimeFrame)
        {
            this.setProperty("detentionTimeFrame", detentionTimeFrame);
        }

        public PointAwardScale getPointAwardScale ()
        {
            return (PointAwardScale) this.getProperty("pointAwardScale");
        }

        public void setPointAwardScale (PointAwardScale pointAwardScale)
        {
            this.setProperty("pointAwardScale", pointAwardScale);
        }

        public float getAddDeductPoints ()
        {
            return (float) this.getProperty("addDeductPoints");
        }

        public void setAddDeductPoints (float addDeductPoints)
        {
            this.setProperty("addDeductPoints", addDeductPoints);
        }

        public bool getEditableWatchers ()
        {
            return Convert.ToBoolean(this.getProperty("editableWatchers"));
        }

        public void setEditableWatchers (bool editableWatchers)
        {
            this.setProperty("editableWatchers", editableWatchers);
        }

        public bool getAllowAssignDetention ()
        {
            return Convert.ToBoolean(this.getProperty("allowAssignDetention"));
        }

        public void setAllowAssignDetention (bool allowAssignDetention)
        {
            this.setProperty("allowAssignDetention", allowAssignDetention);
        }

        public bool getAllowAddDeductPoints ()
        {
            return Convert.ToBoolean(this.getProperty("allowAddDeductPoints"));
        }

        public void setAllowAddDeductPoints (bool allowAddDeductPoints)
        {
            this.setProperty("allowAddDeductPoints", allowAddDeductPoints);
        }

        public bool getEmailAssignee ()
        {
            return Convert.ToBoolean(this.getProperty("emailAssignee"));
        }

        public void setEmailAssignee (bool emailAssignee)
        {
            this.setProperty("emailAssignee", emailAssignee);
        }

        public bool getAllowAssignInternalExclusion ()
        {
            return Convert.ToBoolean(this.getProperty("allowAssignInternalExclusion"));
        }

        public void setAllowAssignInternalExclusion (bool allowAssignInternalExclusion)
        {
            this.setProperty("allowAssignInternalExclusion", allowAssignInternalExclusion);
        }


    }
}

