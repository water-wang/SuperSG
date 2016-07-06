//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sleemon.Data
{
    using System;
    using System.Collections.Generic;
    using System.Data.Linq.Mapping;
    
    public partial class Questionnaire
        : Entity
    {
        public Questionnaire()
        {
        }
    
        [Column(Name = "Id", DbType = "Int32", IsPrimaryKey = true, CanBeNull = false, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column(Name = "Title", DbType = "String", CanBeNull = false)]
        public string Title { get; set; }
        [Column(Name = "Description", DbType = "String")]
        public string Description { get; set; }
        [Column(Name = "LastUpdateUser", DbType = "String", CanBeNull = false)]
        public string LastUpdateUser { get; set; }
        [Column(Name = "LastUpdateTime", DbType = "DateTime", CanBeNull = false)]
    	private System.DateTime _lastUpdateTime;
    	public virtual System.DateTime LastUpdateTime 
    	{
    		get { return _lastUpdateTime; }
    		set 
    		{
    			if (value.Kind == DateTimeKind.Unspecified) {
    				_lastUpdateTime = DateTime.SpecifyKind(value, DateTimeKind.Utc);
    			} else {
    				_lastUpdateTime = value;
    			}
    		}
    	}
        [Column(Name = "IsActive", DbType = "Boolean", CanBeNull = false)]
        public bool IsActive { get; set; }
    
        private ICollection<QuestionnaireItem> _QuestionnaireItem;
        public virtual ICollection<QuestionnaireItem> QuestionnaireItem
        {
            get { return this._QuestionnaireItem ?? (this._QuestionnaireItem = new HashSet<QuestionnaireItem>()); }
            set { this._QuestionnaireItem = value; }
        }
        private ICollection<TaskQuestionnaire> _TaskQuestionnaire;
        public virtual ICollection<TaskQuestionnaire> TaskQuestionnaire
        {
            get { return this._TaskQuestionnaire ?? (this._TaskQuestionnaire = new HashSet<TaskQuestionnaire>()); }
            set { this._TaskQuestionnaire = value; }
        }
    }
}