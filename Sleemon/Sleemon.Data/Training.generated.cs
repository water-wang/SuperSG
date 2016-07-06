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
    
    public partial class Training
        : Entity
    {
        public Training()
        {
        }
    
        [Column(Name = "Id", DbType = "Int32", IsPrimaryKey = true, CanBeNull = false, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column(Name = "Subject", DbType = "String", CanBeNull = false)]
        public string Subject { get; set; }
        [Column(Name = "Description", DbType = "String")]
        public string Description { get; set; }
        [Column(Name = "Avatar", DbType = "String")]
        public string Avatar { get; set; }
        [Column(Name = "Location", DbType = "String", CanBeNull = false)]
        public string Location { get; set; }
        [Column(Name = "StartFrom", DbType = "DateTime", CanBeNull = false)]
    	private System.DateTime _startFrom;
    	public virtual System.DateTime StartFrom 
    	{
    		get { return _startFrom; }
    		set 
    		{
    			if (value.Kind == DateTimeKind.Unspecified) {
    				_startFrom = DateTime.SpecifyKind(value, DateTimeKind.Utc);
    			} else {
    				_startFrom = value;
    			}
    		}
    	}
        [Column(Name = "EndTo", DbType = "DateTime", CanBeNull = false)]
    	private System.DateTime _endTo;
    	public virtual System.DateTime EndTo 
    	{
    		get { return _endTo; }
    		set 
    		{
    			if (value.Kind == DateTimeKind.Unspecified) {
    				_endTo = DateTime.SpecifyKind(value, DateTimeKind.Utc);
    			} else {
    				_endTo = value;
    			}
    		}
    	}
        [Column(Name = "MaxParticipant", DbType = "Int16", CanBeNull = false)]
        public short MaxParticipant { get; set; }
        [Column(Name = "JoinDeadline", DbType = "DateTime", CanBeNull = false)]
    	private System.DateTime _joinDeadline;
    	public virtual System.DateTime JoinDeadline 
    	{
    		get { return _joinDeadline; }
    		set 
    		{
    			if (value.Kind == DateTimeKind.Unspecified) {
    				_joinDeadline = DateTime.SpecifyKind(value, DateTimeKind.Utc);
    			} else {
    				_joinDeadline = value;
    			}
    		}
    	}
        [Column(Name = "IsPublic", DbType = "Boolean", CanBeNull = false)]
        public bool IsPublic { get; set; }
        [Column(Name = "IsCheckInNeeded", DbType = "Boolean", CanBeNull = false)]
        public bool IsCheckInNeeded { get; set; }
        [Column(Name = "CheckInQRCode", DbType = "String")]
        public string CheckInQRCode { get; set; }
        [Column(Name = "GroupKey", DbType = "Guid", CanBeNull = false)]
        public System.Guid GroupKey { get; set; }
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
    
        private ICollection<TrainingTask> _TrainingTask;
        public virtual ICollection<TrainingTask> TrainingTask
        {
            get { return this._TrainingTask ?? (this._TrainingTask = new HashSet<TrainingTask>()); }
            set { this._TrainingTask = value; }
        }
        private ICollection<UserTraining> _UserTraining;
        public virtual ICollection<UserTraining> UserTraining
        {
            get { return this._UserTraining ?? (this._UserTraining = new HashSet<UserTraining>()); }
            set { this._UserTraining = value; }
        }
    }
}
