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

namespace WindowsFormsApplication2
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="opensysdb")]
	public partial class NhanVienDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public NhanVienDataContext() : 
				base(global::WindowsFormsApplication2.Properties.Settings.Default.opensysdbConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public NhanVienDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NhanVienDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NhanVienDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NhanVienDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<QLCA1> QLCA1s
		{
			get
			{
				return this.GetTable<QLCA1>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.QLCA1")]
	public partial class QLCA1
	{
		
		private string _SHIFT;
		
		private string _SHIFTNAME;
		
		private System.Nullable<System.TimeSpan> _START;
		
		private System.Nullable<System.TimeSpan> _ENDTIME;
		
		private System.Nullable<int> _STATUS;
		
		public QLCA1()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SHIFT", DbType="NChar(10)")]
		public string SHIFT
		{
			get
			{
				return this._SHIFT;
			}
			set
			{
				if ((this._SHIFT != value))
				{
					this._SHIFT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SHIFTNAME", DbType="NVarChar(50)")]
		public string SHIFTNAME
		{
			get
			{
				return this._SHIFTNAME;
			}
			set
			{
				if ((this._SHIFTNAME != value))
				{
					this._SHIFTNAME = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_START", DbType="Time")]
		public System.Nullable<System.TimeSpan> START
		{
			get
			{
				return this._START;
			}
			set
			{
				if ((this._START != value))
				{
					this._START = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ENDTIME", DbType="Time")]
		public System.Nullable<System.TimeSpan> ENDTIME
		{
			get
			{
				return this._ENDTIME;
			}
			set
			{
				if ((this._ENDTIME != value))
				{
					this._ENDTIME = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_STATUS", DbType="Int")]
		public System.Nullable<int> STATUS
		{
			get
			{
				return this._STATUS;
			}
			set
			{
				if ((this._STATUS != value))
				{
					this._STATUS = value;
				}
			}
		}
	}
}
#pragma warning restore 1591