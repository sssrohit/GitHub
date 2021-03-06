﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sqlCandidate
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="F:\\Rohit\\c#learning\\Databases\\CandidateDbase.sdf")]
	public partial class CandidateDbaseContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCandidateTable(CandidateTable instance);
    partial void UpdateCandidateTable(CandidateTable instance);
    partial void DeleteCandidateTable(CandidateTable instance);
    #endregion
		
		public CandidateDbaseContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CandidateDbaseContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CandidateDbaseContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CandidateDbaseContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CandidateTable> CandidateTable
		{
			get
			{
				return this.GetTable<CandidateTable>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute()]
	public partial class CandidateTable : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Sr_No;
		
		private string _Date_Candidate;
		
		private string _Name_Candidate;
		
		private string _Position_Candidate;
		
		private string _WorkLocation_Candidate;
		
		private string _CurrentLocation_Candidate;
		
		private string _ContactNo_Candidate;
		
		private string _EmailId_Candidate;
		
		private string _Qualification_Candidate;
		
		private string _TopExp_Candidate;
		
		private string _RelevantExp_Candidate;
		
		private string _CurrentCompany_Candidate;
		
		private string _CurrentCTC_Candidate;
		
		private string _ExpectedCTC_Candidate;
		
		private string _NoticePeriod_Candidate;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSr_NoChanging(int value);
    partial void OnSr_NoChanged();
    partial void OnDate_CandidateChanging(string value);
    partial void OnDate_CandidateChanged();
    partial void OnName_CandidateChanging(string value);
    partial void OnName_CandidateChanged();
    partial void OnPosition_CandidateChanging(string value);
    partial void OnPosition_CandidateChanged();
    partial void OnWorkLocation_CandidateChanging(string value);
    partial void OnWorkLocation_CandidateChanged();
    partial void OnCurrentLocation_CandidateChanging(string value);
    partial void OnCurrentLocation_CandidateChanged();
    partial void OnContactNo_CandidateChanging(string value);
    partial void OnContactNo_CandidateChanged();
    partial void OnEmailId_CandidateChanging(string value);
    partial void OnEmailId_CandidateChanged();
    partial void OnQualification_CandidateChanging(string value);
    partial void OnQualification_CandidateChanged();
    partial void OnTopExp_CandidateChanging(string value);
    partial void OnTopExp_CandidateChanged();
    partial void OnRelevantExp_CandidateChanging(string value);
    partial void OnRelevantExp_CandidateChanged();
    partial void OnCurrentCompany_CandidateChanging(string value);
    partial void OnCurrentCompany_CandidateChanged();
    partial void OnCurrentCTC_CandidateChanging(string value);
    partial void OnCurrentCTC_CandidateChanged();
    partial void OnExpectedCTC_CandidateChanging(string value);
    partial void OnExpectedCTC_CandidateChanged();
    partial void OnNoticePeriod_CandidateChanging(string value);
    partial void OnNoticePeriod_CandidateChanged();
    #endregion
		
		public CandidateTable()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sr_No", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Sr_No
		{
			get
			{
				return this._Sr_No;
			}
			set
			{
				if ((this._Sr_No != value))
				{
					this.OnSr_NoChanging(value);
					this.SendPropertyChanging();
					this._Sr_No = value;
					this.SendPropertyChanged("Sr_No");
					this.OnSr_NoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date_Candidate", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Date_Candidate
		{
			get
			{
				return this._Date_Candidate;
			}
			set
			{
				if ((this._Date_Candidate != value))
				{
					this.OnDate_CandidateChanging(value);
					this.SendPropertyChanging();
					this._Date_Candidate = value;
					this.SendPropertyChanged("Date_Candidate");
					this.OnDate_CandidateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name_Candidate", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Name_Candidate
		{
			get
			{
				return this._Name_Candidate;
			}
			set
			{
				if ((this._Name_Candidate != value))
				{
					this.OnName_CandidateChanging(value);
					this.SendPropertyChanging();
					this._Name_Candidate = value;
					this.SendPropertyChanged("Name_Candidate");
					this.OnName_CandidateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Position_Candidate", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Position_Candidate
		{
			get
			{
				return this._Position_Candidate;
			}
			set
			{
				if ((this._Position_Candidate != value))
				{
					this.OnPosition_CandidateChanging(value);
					this.SendPropertyChanging();
					this._Position_Candidate = value;
					this.SendPropertyChanged("Position_Candidate");
					this.OnPosition_CandidateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WorkLocation_Candidate", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string WorkLocation_Candidate
		{
			get
			{
				return this._WorkLocation_Candidate;
			}
			set
			{
				if ((this._WorkLocation_Candidate != value))
				{
					this.OnWorkLocation_CandidateChanging(value);
					this.SendPropertyChanging();
					this._WorkLocation_Candidate = value;
					this.SendPropertyChanged("WorkLocation_Candidate");
					this.OnWorkLocation_CandidateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CurrentLocation_Candidate", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string CurrentLocation_Candidate
		{
			get
			{
				return this._CurrentLocation_Candidate;
			}
			set
			{
				if ((this._CurrentLocation_Candidate != value))
				{
					this.OnCurrentLocation_CandidateChanging(value);
					this.SendPropertyChanging();
					this._CurrentLocation_Candidate = value;
					this.SendPropertyChanged("CurrentLocation_Candidate");
					this.OnCurrentLocation_CandidateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactNo_Candidate", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string ContactNo_Candidate
		{
			get
			{
				return this._ContactNo_Candidate;
			}
			set
			{
				if ((this._ContactNo_Candidate != value))
				{
					this.OnContactNo_CandidateChanging(value);
					this.SendPropertyChanging();
					this._ContactNo_Candidate = value;
					this.SendPropertyChanged("ContactNo_Candidate");
					this.OnContactNo_CandidateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmailId_Candidate", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string EmailId_Candidate
		{
			get
			{
				return this._EmailId_Candidate;
			}
			set
			{
				if ((this._EmailId_Candidate != value))
				{
					this.OnEmailId_CandidateChanging(value);
					this.SendPropertyChanging();
					this._EmailId_Candidate = value;
					this.SendPropertyChanged("EmailId_Candidate");
					this.OnEmailId_CandidateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Qualification_Candidate", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Qualification_Candidate
		{
			get
			{
				return this._Qualification_Candidate;
			}
			set
			{
				if ((this._Qualification_Candidate != value))
				{
					this.OnQualification_CandidateChanging(value);
					this.SendPropertyChanging();
					this._Qualification_Candidate = value;
					this.SendPropertyChanged("Qualification_Candidate");
					this.OnQualification_CandidateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TopExp_Candidate", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string TopExp_Candidate
		{
			get
			{
				return this._TopExp_Candidate;
			}
			set
			{
				if ((this._TopExp_Candidate != value))
				{
					this.OnTopExp_CandidateChanging(value);
					this.SendPropertyChanging();
					this._TopExp_Candidate = value;
					this.SendPropertyChanged("TopExp_Candidate");
					this.OnTopExp_CandidateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RelevantExp_Candidate", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string RelevantExp_Candidate
		{
			get
			{
				return this._RelevantExp_Candidate;
			}
			set
			{
				if ((this._RelevantExp_Candidate != value))
				{
					this.OnRelevantExp_CandidateChanging(value);
					this.SendPropertyChanging();
					this._RelevantExp_Candidate = value;
					this.SendPropertyChanged("RelevantExp_Candidate");
					this.OnRelevantExp_CandidateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CurrentCompany_Candidate", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string CurrentCompany_Candidate
		{
			get
			{
				return this._CurrentCompany_Candidate;
			}
			set
			{
				if ((this._CurrentCompany_Candidate != value))
				{
					this.OnCurrentCompany_CandidateChanging(value);
					this.SendPropertyChanging();
					this._CurrentCompany_Candidate = value;
					this.SendPropertyChanged("CurrentCompany_Candidate");
					this.OnCurrentCompany_CandidateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CurrentCTC_Candidate", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string CurrentCTC_Candidate
		{
			get
			{
				return this._CurrentCTC_Candidate;
			}
			set
			{
				if ((this._CurrentCTC_Candidate != value))
				{
					this.OnCurrentCTC_CandidateChanging(value);
					this.SendPropertyChanging();
					this._CurrentCTC_Candidate = value;
					this.SendPropertyChanged("CurrentCTC_Candidate");
					this.OnCurrentCTC_CandidateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExpectedCTC_Candidate", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string ExpectedCTC_Candidate
		{
			get
			{
				return this._ExpectedCTC_Candidate;
			}
			set
			{
				if ((this._ExpectedCTC_Candidate != value))
				{
					this.OnExpectedCTC_CandidateChanging(value);
					this.SendPropertyChanging();
					this._ExpectedCTC_Candidate = value;
					this.SendPropertyChanged("ExpectedCTC_Candidate");
					this.OnExpectedCTC_CandidateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NoticePeriod_Candidate", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string NoticePeriod_Candidate
		{
			get
			{
				return this._NoticePeriod_Candidate;
			}
			set
			{
				if ((this._NoticePeriod_Candidate != value))
				{
					this.OnNoticePeriod_CandidateChanging(value);
					this.SendPropertyChanging();
					this._NoticePeriod_Candidate = value;
					this.SendPropertyChanged("NoticePeriod_Candidate");
					this.OnNoticePeriod_CandidateChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
