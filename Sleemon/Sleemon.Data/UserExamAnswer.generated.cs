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
    
    public partial class UserExamAnswer
        : Entity
    {
        [Column(Name = "Id", DbType = "Int32", IsPrimaryKey = true, CanBeNull = false, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column(Name = "TaskId", DbType = "Int32", CanBeNull = false)]
        public int TaskId { get; set; }
        [Column(Name = "UserUniqueId", DbType = "String", CanBeNull = false)]
        public string UserUniqueId { get; set; }
        [Column(Name = "ExamQuestionId", DbType = "Int32", CanBeNull = false)]
        public int ExamQuestionId { get; set; }
        [Column(Name = "MyAnswer", DbType = "String", CanBeNull = false)]
        public string MyAnswer { get; set; }
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
    
        public virtual ExamQuestion ExamQuestion { get; set; }
        public virtual Task Task { get; set; }
    }
}
