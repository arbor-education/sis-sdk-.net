using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CandidateProposalComment : ModelBase
    {
        protected new string resourceType = ResourceType.CANDIDATE_PROPOSAL_COMMENT;
        public const string CANDIDATE_PROPOSAL = "candidateProposal";
        public const string AUTHOR_STAFF = "authorStaff";
        public const string COMMENT_DATETIME = "commentDatetime";
        public const string COMMENT = "comment";

        public CandidateProposalComment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CandidateProposalComment (string resourceType = "CandidateProposalComment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CandidateProposalComment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CandidateProposalComment");
        	RestGateway gateway = (RestGateway) CandidateProposalComment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CandidateProposalComment> candidateproposalcommentCollection = new ModelCollection<CandidateProposalComment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    candidateproposalcommentCollection.add((CandidateProposalComment) model);
        	}
        
        	return candidateproposalcommentCollection;
        }

        public static CandidateProposalComment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CandidateProposalComment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CandidateProposalComment) gateway.retrieve(ResourceType.CANDIDATE_PROPOSAL_COMMENT, id);
        }

        public CandidateProposal getCandidateProposal ()
        {
            return (CandidateProposal) this.getProperty("candidateProposal");
        }

        public void setCandidateProposal (CandidateProposal candidateProposal)
        {
            this.setProperty("candidateProposal", candidateProposal);
        }

        public Staff getAuthorStaff ()
        {
            return (Staff) this.getProperty("authorStaff");
        }

        public void setAuthorStaff (Staff authorStaff)
        {
            this.setProperty("authorStaff", authorStaff);
        }

        public DateTime getCommentDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("commentDatetime"));
        }

        public void setCommentDatetime (DateTime commentDatetime)
        {
            this.setProperty("commentDatetime", commentDatetime);
        }

        public string getComment ()
        {
            return this.getProperty("comment").ToString();
        }

        public void setComment (string comment)
        {
            this.setProperty("comment", comment);
        }


    }
}

