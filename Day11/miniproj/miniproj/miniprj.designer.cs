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

namespace miniproj
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="miniproject")]
	public partial class miniprjDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertmini(mini instance);
    partial void Updatemini(mini instance);
    partial void Deletemini(mini instance);
    #endregion
		
		public miniprjDataContext() : 
				base(global::miniproj.Properties.Settings.Default.miniprojectConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public miniprjDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public miniprjDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public miniprjDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public miniprjDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<mini> minis
		{
			get
			{
				return this.GetTable<mini>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.mini")]
	public partial class mini : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ID;
		
		private string _Ten;
		
		private string _Phong;
		
		private string _Luong;
		
		private string _Tuoi;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(string value);
    partial void OnIDChanged();
    partial void OnTenChanging(string value);
    partial void OnTenChanged();
    partial void OnPhongChanging(string value);
    partial void OnPhongChanged();
    partial void OnLuongChanging(string value);
    partial void OnLuongChanged();
    partial void OnTuoiChanging(string value);
    partial void OnTuoiChanged();
    #endregion
		
		public mini()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ten", DbType="NVarChar(50)")]
		public string Ten
		{
			get
			{
				return this._Ten;
			}
			set
			{
				if ((this._Ten != value))
				{
					this.OnTenChanging(value);
					this.SendPropertyChanging();
					this._Ten = value;
					this.SendPropertyChanged("Ten");
					this.OnTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phong", DbType="NChar(10)")]
		public string Phong
		{
			get
			{
				return this._Phong;
			}
			set
			{
				if ((this._Phong != value))
				{
					this.OnPhongChanging(value);
					this.SendPropertyChanging();
					this._Phong = value;
					this.SendPropertyChanged("Phong");
					this.OnPhongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Luong", DbType="NVarChar(50)")]
		public string Luong
		{
			get
			{
				return this._Luong;
			}
			set
			{
				if ((this._Luong != value))
				{
					this.OnLuongChanging(value);
					this.SendPropertyChanging();
					this._Luong = value;
					this.SendPropertyChanged("Luong");
					this.OnLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tuoi", DbType="NChar(10)")]
		public string Tuoi
		{
			get
			{
				return this._Tuoi;
			}
			set
			{
				if ((this._Tuoi != value))
				{
					this.OnTuoiChanging(value);
					this.SendPropertyChanging();
					this._Tuoi = value;
					this.SendPropertyChanged("Tuoi");
					this.OnTuoiChanged();
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
