using System;
using Arbor.Model;

namespace Arbor.ChangeLog
{
    public class Change
    {
        protected string changeType;
        protected ModelBase changedResource;
        protected int changedFromRevision;
        protected int changedToRevision;

        /// <summary>
        /// Initializes a new instance of the <see cref="Arbor.ChangeLog.Change"/> class.
        /// </summary>
        /// <param name='changedResource'>
        /// Changed resource.
        /// </param>
        /// <param name='changeType'>
        /// Change type.
        /// </param>
        /// <param name='changedFromRevision'>
        /// Changed from revision.
        /// </param>
        /// <param name='changedToRevision'>
        /// Changed to revision.
        /// </param>
        public Change(ModelBase changedResource, string changeType,
                       int changedFromRevision, int changedToRevision)
        {
            this.setChangeType(changeType);
            this.setChangedResource(changedResource);
            this.setChangedFromRevision(changedFromRevision);
            this.setChangedToRevision(changedToRevision);
        }

        /// <summary>
        /// Sets the type of the change.
        /// </summary>
        /// <param name='changeType'>
        /// Change type.
        /// </param>
        public void setChangeType(string changeType)
        {
            this.changeType = changeType;
        }

        /// <summary>
        /// Gets the type of the change.
        /// </summary>
        /// <returns>
        /// The change type.
        /// </returns>
        public string getChangeType()
        {
            return this.changeType;
        }

        /// <summary>
        /// Sets the changed from revision.
        /// </summary>
        /// <param name='changedFromRevision'>
        /// Changed from revision.
        /// </param>
        public void setChangedFromRevision(int changedFromRevision)
        {
            this.changedFromRevision = changedFromRevision;
        }

        /// <summary>
        /// Gets the changed from revision.
        /// </summary>
        /// <returns>
        /// The changed from revision.
        /// </returns>
        public int getChangedFromRevision()
        {
            return this.changedFromRevision;
        }

        /// <summary>
        /// Sets the changed resource.
        /// </summary>
        /// <param name='changedResource'>
        /// Changed resource.
        /// </param>
        public void setChangedResource(ModelBase changedResource)
        {
            this.changedResource = changedResource;
        }

        /// <summary>
        /// Gets the changed resource.
        /// </summary>
        /// <returns>
        /// The changed resource.
        /// </returns>
        public ModelBase getChangedResource()
        {
            return this.changedResource;
        }

        /// <summary>
        /// Sets the changed to revision.
        /// </summary>
        /// <param name='changedToRevision'>
        /// Changed to revision.
        /// </param>
        public void setChangedToRevision(int changedToRevision)
        {
            this.changedToRevision = changedToRevision;
        }

        /// <summary>
        /// Gets the changed to revision.
        /// </summary>
        /// <returns>
        /// The changed to revision.
        /// </returns>
        public int getChangedToRevision()
        {
            return this.changedToRevision;
        }

    }
}

