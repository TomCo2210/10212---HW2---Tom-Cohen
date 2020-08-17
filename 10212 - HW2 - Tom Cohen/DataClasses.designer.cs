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

namespace _10212___HW2___Tom_Cohen
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Data")]
	public partial class DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTblStudent(TblStudent instance);
    partial void UpdateTblStudent(TblStudent instance);
    partial void DeleteTblStudent(TblStudent instance);
    partial void InsertTblCourse(TblCourse instance);
    partial void UpdateTblCourse(TblCourse instance);
    partial void DeleteTblCourse(TblCourse instance);
    partial void InsertTblLecturer(TblLecturer instance);
    partial void UpdateTblLecturer(TblLecturer instance);
    partial void DeleteTblLecturer(TblLecturer instance);
    partial void InsertTblLecturesInCourse(TblLecturesInCourse instance);
    partial void UpdateTblLecturesInCourse(TblLecturesInCourse instance);
    partial void DeleteTblLecturesInCourse(TblLecturesInCourse instance);
    partial void InsertTblStudentsInCourse(TblStudentsInCourse instance);
    partial void UpdateTblStudentsInCourse(TblStudentsInCourse instance);
    partial void DeleteTblStudentsInCourse(TblStudentsInCourse instance);
    partial void InsertTblLecturesStudent(TblLecturesStudent instance);
    partial void UpdateTblLecturesStudent(TblLecturesStudent instance);
    partial void DeleteTblLecturesStudent(TblLecturesStudent instance);
    #endregion
		
		public DataClassesDataContext() : 
				base(global::_10212___HW2___Tom_Cohen.Properties.Settings.Default.DataConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TblStudent> TblStudents
		{
			get
			{
				return this.GetTable<TblStudent>();
			}
		}
		
		public System.Data.Linq.Table<TblCourse> TblCourses
		{
			get
			{
				return this.GetTable<TblCourse>();
			}
		}
		
		public System.Data.Linq.Table<TblLecturer> TblLecturers
		{
			get
			{
				return this.GetTable<TblLecturer>();
			}
		}
		
		public System.Data.Linq.Table<TblLecturesInCourse> TblLecturesInCourses
		{
			get
			{
				return this.GetTable<TblLecturesInCourse>();
			}
		}
		
		public System.Data.Linq.Table<TblStudentsInCourse> TblStudentsInCourses
		{
			get
			{
				return this.GetTable<TblStudentsInCourse>();
			}
		}
		
		public System.Data.Linq.Table<TblLecturesStudent> TblLecturesStudents
		{
			get
			{
				return this.GetTable<TblLecturesStudent>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TblStudents")]
	public partial class TblStudent : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _City;
		
		private System.DateTime _Birthday;
		
		private EntitySet<TblStudentsInCourse> _TblStudentsInCourses;
		
		private EntitySet<TblLecturesStudent> _TblLecturesStudents;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnBirthdayChanging(System.DateTime value);
    partial void OnBirthdayChanged();
    #endregion
		
		public TblStudent()
		{
			this._TblStudentsInCourses = new EntitySet<TblStudentsInCourse>(new Action<TblStudentsInCourse>(this.attach_TblStudentsInCourses), new Action<TblStudentsInCourse>(this.detach_TblStudentsInCourses));
			this._TblLecturesStudents = new EntitySet<TblLecturesStudent>(new Action<TblLecturesStudent>(this.attach_TblLecturesStudents), new Action<TblLecturesStudent>(this.detach_TblLecturesStudents));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="Char(40) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="Char(40) NOT NULL", CanBeNull=false)]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Birthday", DbType="Date NOT NULL")]
		public System.DateTime Birthday
		{
			get
			{
				return this._Birthday;
			}
			set
			{
				if ((this._Birthday != value))
				{
					this.OnBirthdayChanging(value);
					this.SendPropertyChanging();
					this._Birthday = value;
					this.SendPropertyChanged("Birthday");
					this.OnBirthdayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TblStudent_TblStudentsInCourse", Storage="_TblStudentsInCourses", ThisKey="Id", OtherKey="StudentId")]
		public EntitySet<TblStudentsInCourse> TblStudentsInCourses
		{
			get
			{
				return this._TblStudentsInCourses;
			}
			set
			{
				this._TblStudentsInCourses.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TblStudent_TblLecturesStudent", Storage="_TblLecturesStudents", ThisKey="Id", OtherKey="StudentId")]
		public EntitySet<TblLecturesStudent> TblLecturesStudents
		{
			get
			{
				return this._TblLecturesStudents;
			}
			set
			{
				this._TblLecturesStudents.Assign(value);
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
		
		private void attach_TblStudentsInCourses(TblStudentsInCourse entity)
		{
			this.SendPropertyChanging();
			entity.TblStudent = this;
		}
		
		private void detach_TblStudentsInCourses(TblStudentsInCourse entity)
		{
			this.SendPropertyChanging();
			entity.TblStudent = null;
		}
		
		private void attach_TblLecturesStudents(TblLecturesStudent entity)
		{
			this.SendPropertyChanging();
			entity.TblStudent = this;
		}
		
		private void detach_TblLecturesStudents(TblLecturesStudent entity)
		{
			this.SendPropertyChanging();
			entity.TblStudent = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TblCourses")]
	public partial class TblCourse : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _CourseName;
		
		private double _Credits;
		
		private EntitySet<TblLecturesInCourse> _TblLecturesInCourses;
		
		private EntitySet<TblStudentsInCourse> _TblStudentsInCourses;
		
		private EntitySet<TblLecturesStudent> _TblLecturesStudents;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnCourseNameChanging(string value);
    partial void OnCourseNameChanged();
    partial void OnCreditsChanging(double value);
    partial void OnCreditsChanged();
    #endregion
		
		public TblCourse()
		{
			this._TblLecturesInCourses = new EntitySet<TblLecturesInCourse>(new Action<TblLecturesInCourse>(this.attach_TblLecturesInCourses), new Action<TblLecturesInCourse>(this.detach_TblLecturesInCourses));
			this._TblStudentsInCourses = new EntitySet<TblStudentsInCourse>(new Action<TblStudentsInCourse>(this.attach_TblStudentsInCourses), new Action<TblStudentsInCourse>(this.detach_TblStudentsInCourses));
			this._TblLecturesStudents = new EntitySet<TblLecturesStudent>(new Action<TblLecturesStudent>(this.attach_TblLecturesStudents), new Action<TblLecturesStudent>(this.detach_TblLecturesStudents));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CourseName", DbType="Char(40) NOT NULL", CanBeNull=false)]
		public string CourseName
		{
			get
			{
				return this._CourseName;
			}
			set
			{
				if ((this._CourseName != value))
				{
					this.OnCourseNameChanging(value);
					this.SendPropertyChanging();
					this._CourseName = value;
					this.SendPropertyChanged("CourseName");
					this.OnCourseNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Credits", DbType="Float NOT NULL")]
		public double Credits
		{
			get
			{
				return this._Credits;
			}
			set
			{
				if ((this._Credits != value))
				{
					this.OnCreditsChanging(value);
					this.SendPropertyChanging();
					this._Credits = value;
					this.SendPropertyChanged("Credits");
					this.OnCreditsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TblCourse_TblLecturesInCourse", Storage="_TblLecturesInCourses", ThisKey="Id", OtherKey="CourseId")]
		public EntitySet<TblLecturesInCourse> TblLecturesInCourses
		{
			get
			{
				return this._TblLecturesInCourses;
			}
			set
			{
				this._TblLecturesInCourses.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TblCourse_TblStudentsInCourse", Storage="_TblStudentsInCourses", ThisKey="Id", OtherKey="CourseId")]
		public EntitySet<TblStudentsInCourse> TblStudentsInCourses
		{
			get
			{
				return this._TblStudentsInCourses;
			}
			set
			{
				this._TblStudentsInCourses.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TblCourse_TblLecturesStudent", Storage="_TblLecturesStudents", ThisKey="Id", OtherKey="CourseId")]
		public EntitySet<TblLecturesStudent> TblLecturesStudents
		{
			get
			{
				return this._TblLecturesStudents;
			}
			set
			{
				this._TblLecturesStudents.Assign(value);
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
		
		private void attach_TblLecturesInCourses(TblLecturesInCourse entity)
		{
			this.SendPropertyChanging();
			entity.TblCourse = this;
		}
		
		private void detach_TblLecturesInCourses(TblLecturesInCourse entity)
		{
			this.SendPropertyChanging();
			entity.TblCourse = null;
		}
		
		private void attach_TblStudentsInCourses(TblStudentsInCourse entity)
		{
			this.SendPropertyChanging();
			entity.TblCourse = this;
		}
		
		private void detach_TblStudentsInCourses(TblStudentsInCourse entity)
		{
			this.SendPropertyChanging();
			entity.TblCourse = null;
		}
		
		private void attach_TblLecturesStudents(TblLecturesStudent entity)
		{
			this.SendPropertyChanging();
			entity.TblCourse = this;
		}
		
		private void detach_TblLecturesStudents(TblLecturesStudent entity)
		{
			this.SendPropertyChanging();
			entity.TblCourse = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TblLecturers")]
	public partial class TblLecturer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private EntitySet<TblLecturesInCourse> _TblLecturesInCourses;
		
		private EntitySet<TblLecturesStudent> _TblLecturesStudents;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public TblLecturer()
		{
			this._TblLecturesInCourses = new EntitySet<TblLecturesInCourse>(new Action<TblLecturesInCourse>(this.attach_TblLecturesInCourses), new Action<TblLecturesInCourse>(this.detach_TblLecturesInCourses));
			this._TblLecturesStudents = new EntitySet<TblLecturesStudent>(new Action<TblLecturesStudent>(this.attach_TblLecturesStudents), new Action<TblLecturesStudent>(this.detach_TblLecturesStudents));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="Char(40) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TblLecturer_TblLecturesInCourse", Storage="_TblLecturesInCourses", ThisKey="Id", OtherKey="LectureId")]
		public EntitySet<TblLecturesInCourse> TblLecturesInCourses
		{
			get
			{
				return this._TblLecturesInCourses;
			}
			set
			{
				this._TblLecturesInCourses.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TblLecturer_TblLecturesStudent", Storage="_TblLecturesStudents", ThisKey="Id", OtherKey="LectureId")]
		public EntitySet<TblLecturesStudent> TblLecturesStudents
		{
			get
			{
				return this._TblLecturesStudents;
			}
			set
			{
				this._TblLecturesStudents.Assign(value);
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
		
		private void attach_TblLecturesInCourses(TblLecturesInCourse entity)
		{
			this.SendPropertyChanging();
			entity.TblLecturer = this;
		}
		
		private void detach_TblLecturesInCourses(TblLecturesInCourse entity)
		{
			this.SendPropertyChanging();
			entity.TblLecturer = null;
		}
		
		private void attach_TblLecturesStudents(TblLecturesStudent entity)
		{
			this.SendPropertyChanging();
			entity.TblLecturer = this;
		}
		
		private void detach_TblLecturesStudents(TblLecturesStudent entity)
		{
			this.SendPropertyChanging();
			entity.TblLecturer = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TblLecturesInCourses")]
	public partial class TblLecturesInCourse : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _LectureId;
		
		private int _CourseId;
		
		private EntityRef<TblCourse> _TblCourse;
		
		private EntityRef<TblLecturer> _TblLecturer;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnLectureIdChanging(int value);
    partial void OnLectureIdChanged();
    partial void OnCourseIdChanging(int value);
    partial void OnCourseIdChanged();
    #endregion
		
		public TblLecturesInCourse()
		{
			this._TblCourse = default(EntityRef<TblCourse>);
			this._TblLecturer = default(EntityRef<TblLecturer>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LectureId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int LectureId
		{
			get
			{
				return this._LectureId;
			}
			set
			{
				if ((this._LectureId != value))
				{
					if (this._TblLecturer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnLectureIdChanging(value);
					this.SendPropertyChanging();
					this._LectureId = value;
					this.SendPropertyChanged("LectureId");
					this.OnLectureIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CourseId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int CourseId
		{
			get
			{
				return this._CourseId;
			}
			set
			{
				if ((this._CourseId != value))
				{
					if (this._TblCourse.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCourseIdChanging(value);
					this.SendPropertyChanging();
					this._CourseId = value;
					this.SendPropertyChanged("CourseId");
					this.OnCourseIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TblCourse_TblLecturesInCourse", Storage="_TblCourse", ThisKey="CourseId", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public TblCourse TblCourse
		{
			get
			{
				return this._TblCourse.Entity;
			}
			set
			{
				TblCourse previousValue = this._TblCourse.Entity;
				if (((previousValue != value) 
							|| (this._TblCourse.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TblCourse.Entity = null;
						previousValue.TblLecturesInCourses.Remove(this);
					}
					this._TblCourse.Entity = value;
					if ((value != null))
					{
						value.TblLecturesInCourses.Add(this);
						this._CourseId = value.Id;
					}
					else
					{
						this._CourseId = default(int);
					}
					this.SendPropertyChanged("TblCourse");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TblLecturer_TblLecturesInCourse", Storage="_TblLecturer", ThisKey="LectureId", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public TblLecturer TblLecturer
		{
			get
			{
				return this._TblLecturer.Entity;
			}
			set
			{
				TblLecturer previousValue = this._TblLecturer.Entity;
				if (((previousValue != value) 
							|| (this._TblLecturer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TblLecturer.Entity = null;
						previousValue.TblLecturesInCourses.Remove(this);
					}
					this._TblLecturer.Entity = value;
					if ((value != null))
					{
						value.TblLecturesInCourses.Add(this);
						this._LectureId = value.Id;
					}
					else
					{
						this._LectureId = default(int);
					}
					this.SendPropertyChanged("TblLecturer");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TblStudentsInCourses")]
	public partial class TblStudentsInCourse : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _StudentId;
		
		private int _CourseId;
		
		private EntityRef<TblCourse> _TblCourse;
		
		private EntityRef<TblStudent> _TblStudent;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnStudentIdChanging(int value);
    partial void OnStudentIdChanged();
    partial void OnCourseIdChanging(int value);
    partial void OnCourseIdChanged();
    #endregion
		
		public TblStudentsInCourse()
		{
			this._TblCourse = default(EntityRef<TblCourse>);
			this._TblStudent = default(EntityRef<TblStudent>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StudentId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int StudentId
		{
			get
			{
				return this._StudentId;
			}
			set
			{
				if ((this._StudentId != value))
				{
					if (this._TblStudent.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnStudentIdChanging(value);
					this.SendPropertyChanging();
					this._StudentId = value;
					this.SendPropertyChanged("StudentId");
					this.OnStudentIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CourseId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int CourseId
		{
			get
			{
				return this._CourseId;
			}
			set
			{
				if ((this._CourseId != value))
				{
					if (this._TblCourse.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCourseIdChanging(value);
					this.SendPropertyChanging();
					this._CourseId = value;
					this.SendPropertyChanged("CourseId");
					this.OnCourseIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TblCourse_TblStudentsInCourse", Storage="_TblCourse", ThisKey="CourseId", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public TblCourse TblCourse
		{
			get
			{
				return this._TblCourse.Entity;
			}
			set
			{
				TblCourse previousValue = this._TblCourse.Entity;
				if (((previousValue != value) 
							|| (this._TblCourse.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TblCourse.Entity = null;
						previousValue.TblStudentsInCourses.Remove(this);
					}
					this._TblCourse.Entity = value;
					if ((value != null))
					{
						value.TblStudentsInCourses.Add(this);
						this._CourseId = value.Id;
					}
					else
					{
						this._CourseId = default(int);
					}
					this.SendPropertyChanged("TblCourse");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TblStudent_TblStudentsInCourse", Storage="_TblStudent", ThisKey="StudentId", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public TblStudent TblStudent
		{
			get
			{
				return this._TblStudent.Entity;
			}
			set
			{
				TblStudent previousValue = this._TblStudent.Entity;
				if (((previousValue != value) 
							|| (this._TblStudent.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TblStudent.Entity = null;
						previousValue.TblStudentsInCourses.Remove(this);
					}
					this._TblStudent.Entity = value;
					if ((value != null))
					{
						value.TblStudentsInCourses.Add(this);
						this._StudentId = value.Id;
					}
					else
					{
						this._StudentId = default(int);
					}
					this.SendPropertyChanged("TblStudent");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TblLecturesStudents")]
	public partial class TblLecturesStudent : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _LectureId;
		
		private int _StudentId;
		
		private int _CourseId;
		
		private EntityRef<TblCourse> _TblCourse;
		
		private EntityRef<TblLecturer> _TblLecturer;
		
		private EntityRef<TblStudent> _TblStudent;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnLectureIdChanging(int value);
    partial void OnLectureIdChanged();
    partial void OnStudentIdChanging(int value);
    partial void OnStudentIdChanged();
    partial void OnCourseIdChanging(int value);
    partial void OnCourseIdChanged();
    #endregion
		
		public TblLecturesStudent()
		{
			this._TblCourse = default(EntityRef<TblCourse>);
			this._TblLecturer = default(EntityRef<TblLecturer>);
			this._TblStudent = default(EntityRef<TblStudent>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LectureId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int LectureId
		{
			get
			{
				return this._LectureId;
			}
			set
			{
				if ((this._LectureId != value))
				{
					if (this._TblLecturer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnLectureIdChanging(value);
					this.SendPropertyChanging();
					this._LectureId = value;
					this.SendPropertyChanged("LectureId");
					this.OnLectureIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StudentId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int StudentId
		{
			get
			{
				return this._StudentId;
			}
			set
			{
				if ((this._StudentId != value))
				{
					if (this._TblStudent.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnStudentIdChanging(value);
					this.SendPropertyChanging();
					this._StudentId = value;
					this.SendPropertyChanged("StudentId");
					this.OnStudentIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CourseId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int CourseId
		{
			get
			{
				return this._CourseId;
			}
			set
			{
				if ((this._CourseId != value))
				{
					if (this._TblCourse.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCourseIdChanging(value);
					this.SendPropertyChanging();
					this._CourseId = value;
					this.SendPropertyChanged("CourseId");
					this.OnCourseIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TblCourse_TblLecturesStudent", Storage="_TblCourse", ThisKey="CourseId", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public TblCourse TblCourse
		{
			get
			{
				return this._TblCourse.Entity;
			}
			set
			{
				TblCourse previousValue = this._TblCourse.Entity;
				if (((previousValue != value) 
							|| (this._TblCourse.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TblCourse.Entity = null;
						previousValue.TblLecturesStudents.Remove(this);
					}
					this._TblCourse.Entity = value;
					if ((value != null))
					{
						value.TblLecturesStudents.Add(this);
						this._CourseId = value.Id;
					}
					else
					{
						this._CourseId = default(int);
					}
					this.SendPropertyChanged("TblCourse");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TblLecturer_TblLecturesStudent", Storage="_TblLecturer", ThisKey="LectureId", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public TblLecturer TblLecturer
		{
			get
			{
				return this._TblLecturer.Entity;
			}
			set
			{
				TblLecturer previousValue = this._TblLecturer.Entity;
				if (((previousValue != value) 
							|| (this._TblLecturer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TblLecturer.Entity = null;
						previousValue.TblLecturesStudents.Remove(this);
					}
					this._TblLecturer.Entity = value;
					if ((value != null))
					{
						value.TblLecturesStudents.Add(this);
						this._LectureId = value.Id;
					}
					else
					{
						this._LectureId = default(int);
					}
					this.SendPropertyChanged("TblLecturer");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TblStudent_TblLecturesStudent", Storage="_TblStudent", ThisKey="StudentId", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public TblStudent TblStudent
		{
			get
			{
				return this._TblStudent.Entity;
			}
			set
			{
				TblStudent previousValue = this._TblStudent.Entity;
				if (((previousValue != value) 
							|| (this._TblStudent.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TblStudent.Entity = null;
						previousValue.TblLecturesStudents.Remove(this);
					}
					this._TblStudent.Entity = value;
					if ((value != null))
					{
						value.TblLecturesStudents.Add(this);
						this._StudentId = value.Id;
					}
					else
					{
						this._StudentId = default(int);
					}
					this.SendPropertyChanged("TblStudent");
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
