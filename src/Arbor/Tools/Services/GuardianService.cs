using System;
using Arbor.Model;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Resource;


namespace Arbor.Tools.Services
{
    public class GuardianService
    {
        protected static IGateway defaultApiGateway = null;

        public GuardianService()
        {
        }

        /// <summary>
        /// Gets the current guardians.
        /// </summary>
        /// <returns>
        /// ModelCollection<Guardian> The current guardians.
        /// </returns>
        public static ModelCollection<Guardian> getCurrentGuardians()
        {
            RestGateway gateway = (RestGateway)GuardianService.getGateway();
            ModelCollection<Guardian> guardianCollection = new ModelCollection<Guardian>();

            // Get current students
            StudentService.setDefaultGateway(gateway);
            ModelCollection<Student> studentCollection = StudentService.getCurrentStudents();

            foreach (Student student in studentCollection)
            {
                // Get guardian relationship for each student
                SimpleQuery relationQuery = new SimpleQuery(ResourceType.STUDENT_GUARDIAN_RELATIONSHIP);
                string studentResourceUrl = student.getResourceUrl().OriginalString;
                relationQuery.addPropertyFilter("student", SimpleQuery.OPERATOR_EQUALS, studentResourceUrl);
                ModelCollection<ModelBase> relationCollection = gateway.query(relationQuery);

                // Get each guardian from student guardian relationship collection
                foreach (ModelBase model in relationCollection)
                {
                    StudentGuardianRelationship relation = (StudentGuardianRelationship)model;
                    guardianCollection.add(relation.getGuardian());
                }

            }

            return guardianCollection;
        }

        public static IGateway getGateway()
        {
            if (GuardianService.defaultApiGateway == null)
            {
                throw new Exception("You must call GuardianService.setDefaultGateway() prior to calling 'get' methods");
            }

            return GuardianService.defaultApiGateway;
        }

        public static void setDefaultGateway(IGateway gateway)
        {
            GuardianService.defaultApiGateway = gateway;
        }
    }
}

