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
    
    public partial class UserQuestion
        : Entity
    {
        public UserQuestion()
        {
        }
    
        [Column(Name = "Id", DbType = "Int32", IsPrimaryKey = true, CanBeNull = false, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column(Name = "UserUniqueId", DbType = "String", CanBeNull = false)]
        public string UserUniqueId { get; set; }
        [Column(Name = "Question", DbType = "String", CanBeNull = false)]
        public string Question { get; set; }
        [Column(Name = "Description", DbType = "String")]
        public string Description { get; set; }
        [Column(Name = "Status", DbType = "Byte", CanBeNull = false)]
        public byte Status { get; set; }
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
    
        private ICollection<UserQuestionReply> _UserQuestionReply;
        public virtual ICollection<UserQuestionReply> UserQuestionReply
        {
            get { return this._UserQuestionReply ?? (this._UserQuestionReply = new HashSet<UserQuestionReply>()); }
            set { this._UserQuestionReply = value; }
        }
    }
}
