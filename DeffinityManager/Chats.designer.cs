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

namespace DeffinityManager
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="PlegitDB")]
	public partial class ChatsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public ChatsDataContext() : 
				base(global::DeffinityManager.Properties.Settings.Default.PlegitDBConnectionString2, mappingSource)
		{
			OnCreated();
		}
		
		public ChatsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ChatsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ChatsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ChatsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Chat> Chats
		{
			get
			{
				return this.GetTable<Chat>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Chat")]
	public partial class Chat
	{
		
		private int _MessageId;
		
		private string _Content;
		
		private System.Nullable<System.DateTime> _Timestamp;
		
		private string _SenderEmail;
		
		private string _ReceiverEmail;
		
		public Chat()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MessageId", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int MessageId
		{
			get
			{
				return this._MessageId;
			}
			set
			{
				if ((this._MessageId != value))
				{
					this._MessageId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Content", DbType="NVarChar(MAX)")]
		public string Content
		{
			get
			{
				return this._Content;
			}
			set
			{
				if ((this._Content != value))
				{
					this._Content = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Timestamp", DbType="DateTime")]
		public System.Nullable<System.DateTime> Timestamp
		{
			get
			{
				return this._Timestamp;
			}
			set
			{
				if ((this._Timestamp != value))
				{
					this._Timestamp = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SenderEmail", DbType="NVarChar(255)")]
		public string SenderEmail
		{
			get
			{
				return this._SenderEmail;
			}
			set
			{
				if ((this._SenderEmail != value))
				{
					this._SenderEmail = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceiverEmail", DbType="NVarChar(255)")]
		public string ReceiverEmail
		{
			get
			{
				return this._ReceiverEmail;
			}
			set
			{
				if ((this._ReceiverEmail != value))
				{
					this._ReceiverEmail = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
