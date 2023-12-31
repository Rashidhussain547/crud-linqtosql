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

namespace crudlinqtosql
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LibraryMangSystem")]
	public partial class bookDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBook(Book instance);
    partial void UpdateBook(Book instance);
    partial void DeleteBook(Book instance);
    #endregion
		
		public bookDataContext() : 
				base(global::crudlinqtosql.Properties.Settings.Default.LibraryMangSystemConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public bookDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public bookDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public bookDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public bookDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Book> Books
		{
			get
			{
				return this.GetTable<Book>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Books")]
	public partial class Book : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _BookId;
		
		private string _TITLE;
		
		private string _AUTHOR;
		
		private string _ISBN;
		
		private string _GENRE;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBookIdChanging(int value);
    partial void OnBookIdChanged();
    partial void OnTITLEChanging(string value);
    partial void OnTITLEChanged();
    partial void OnAUTHORChanging(string value);
    partial void OnAUTHORChanged();
    partial void OnISBNChanging(string value);
    partial void OnISBNChanged();
    partial void OnGENREChanging(string value);
    partial void OnGENREChanged();
    #endregion
		
		public Book()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int BookId
		{
			get
			{
				return this._BookId;
			}
			set
			{
				if ((this._BookId != value))
				{
					this.OnBookIdChanging(value);
					this.SendPropertyChanging();
					this._BookId = value;
					this.SendPropertyChanged("BookId");
					this.OnBookIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TITLE", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string TITLE
		{
			get
			{
				return this._TITLE;
			}
			set
			{
				if ((this._TITLE != value))
				{
					this.OnTITLEChanging(value);
					this.SendPropertyChanging();
					this._TITLE = value;
					this.SendPropertyChanged("TITLE");
					this.OnTITLEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AUTHOR", DbType="VarChar(50)")]
		public string AUTHOR
		{
			get
			{
				return this._AUTHOR;
			}
			set
			{
				if ((this._AUTHOR != value))
				{
					this.OnAUTHORChanging(value);
					this.SendPropertyChanging();
					this._AUTHOR = value;
					this.SendPropertyChanged("AUTHOR");
					this.OnAUTHORChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ISBN", DbType="VarChar(40)")]
		public string ISBN
		{
			get
			{
				return this._ISBN;
			}
			set
			{
				if ((this._ISBN != value))
				{
					this.OnISBNChanging(value);
					this.SendPropertyChanging();
					this._ISBN = value;
					this.SendPropertyChanged("ISBN");
					this.OnISBNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GENRE", DbType="VarChar(20)")]
		public string GENRE
		{
			get
			{
				return this._GENRE;
			}
			set
			{
				if ((this._GENRE != value))
				{
					this.OnGENREChanging(value);
					this.SendPropertyChanging();
					this._GENRE = value;
					this.SendPropertyChanged("GENRE");
					this.OnGENREChanged();
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
