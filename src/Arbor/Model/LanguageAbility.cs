using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class LanguageAbility : ModelBase
    {
        protected new string resourceType = ResourceType.LANGUAGE_ABILITY;
        public const string PERSON = "person";
        public const string LANGUAGE = "language";
        public const string IS_NATIVE_LANGUAGE = "isNativeLanguage";
        public const string SPEAKS_LANGUAGE = "speaksLanguage";
        public const string UNDERSTANDS_LANGUAGE = "understandsLanguage";
        public const string IS_SPOKEN_AT_HOME = "isSpokenAtHome";
        public const string LANGUAGE_PROFICIENCY = "languageProficiency";
        public const string NOTES = "notes";

        public LanguageAbility()
        {
            base.resourceType = this.resourceType;
        }

        public LanguageAbility(string resourceType = "LanguageAbility", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<LanguageAbility> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("LanguageAbility");
            RestGateway gateway = (RestGateway)LanguageAbility.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<LanguageAbility> languageabilityCollection = new ModelCollection<LanguageAbility>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                languageabilityCollection.add((LanguageAbility)model);
            }

            return languageabilityCollection;
        }

        public static LanguageAbility retrieve(string id)
        {
            RestGateway gateway = (RestGateway)LanguageAbility.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (LanguageAbility)gateway.retrieve(ResourceType.LANGUAGE_ABILITY, id);
        }

        public ModelBase getPerson()
        {
            return (ModelBase)this.getProperty("person");
        }

        public void setPerson(ModelBase person)
        {
            this.setProperty("person", person);
        }

        public Language getLanguage()
        {
            return (Language)this.getProperty("language");
        }

        public void setLanguage(Language language)
        {
            this.setProperty("language", language);
        }

        public bool getIsNativeLanguage()
        {
            return Convert.ToBoolean(this.getProperty("isNativeLanguage"));
        }

        public void setIsNativeLanguage(bool isNativeLanguage)
        {
            this.setProperty("isNativeLanguage", isNativeLanguage);
        }

        public bool getSpeaksLanguage()
        {
            return Convert.ToBoolean(this.getProperty("speaksLanguage"));
        }

        public void setSpeaksLanguage(bool speaksLanguage)
        {
            this.setProperty("speaksLanguage", speaksLanguage);
        }

        public bool getUnderstandsLanguage()
        {
            return Convert.ToBoolean(this.getProperty("understandsLanguage"));
        }

        public void setUnderstandsLanguage(bool understandsLanguage)
        {
            this.setProperty("understandsLanguage", understandsLanguage);
        }

        public bool getIsSpokenAtHome()
        {
            return Convert.ToBoolean(this.getProperty("isSpokenAtHome"));
        }

        public void setIsSpokenAtHome(bool isSpokenAtHome)
        {
            this.setProperty("isSpokenAtHome", isSpokenAtHome);
        }

        public string getLanguageProficiency()
        {
            return this.getProperty("languageProficiency").ToString();
        }

        public void setLanguageProficiency(string languageProficiency)
        {
            this.setProperty("languageProficiency", languageProficiency);
        }

        public string getNotes()
        {
            return this.getProperty("notes").ToString();
        }

        public void setNotes(string notes)
        {
            this.setProperty("notes", notes);
        }


    }
}

