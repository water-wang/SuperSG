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
    
    public partial class LearningCourse
        : Entity
    {
        public LearningCourse()
        {
        }
    
        [Column(Name = "Id", DbType = "Int32", IsPrimaryKey = true, CanBeNull = false, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column(Name = "Subject", DbType = "String", CanBeNull = false)]
        public string Subject { get; set; }
        [Column(Name = "Description", DbType = "String")]
        public string Description { get; set; }
        [Column(Name = "Star", DbType = "Int32")]
        public Nullable<int> Star { get; set; }
        [Column(Name = "ForLevel", DbType = "Int32")]
        public Nullable<int> ForLevel { get; set; }
        [Column(Name = "GroupKey", DbType = "Guid")]
        public Nullable<System.Guid> GroupKey { get; set; }
        [Column(Name = "Status", DbType = "Int32", CanBeNull = false)]
        public int Status { get; set; }
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
    
        private ICollection<LearningChapter> _LearningChapter;
        public virtual ICollection<LearningChapter> LearningChapter
        {
            get { return this._LearningChapter ?? (this._LearningChapter = new HashSet<LearningChapter>()); }
            set { this._LearningChapter = value; }
        }
    }
}