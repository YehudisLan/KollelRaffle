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

namespace KollelRaffleWeb.Data
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="KLS")]
	public partial class EntryDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEntry(Entry instance);
    partial void UpdateEntry(Entry instance);
    partial void DeleteEntry(Entry instance);
    #endregion
		
		public EntryDataContext() : 
				base(global::KollelRaffleWeb.Data.Properties.Settings.Default.KLSConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public EntryDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EntryDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EntryDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EntryDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Entry> Entries
		{
			get
			{
				return this.GetTable<Entry>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Entries")]
	public partial class Entry : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.DateTime _Date;
		
		private string _name;
		
		private string _Number;
		
		private string _StreetAddress;
		
		private string _CityState;
		
		private int _Total;
		
		private int _Sheitel;
		
		private int _Cash;
		
		private int _Payment;
		
		private int _SheitelBulk;
		
		private int _CashBulk;
		
		private string _InHonorOf;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnDateChanging(System.DateTime value);
    partial void OnDateChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnNumberChanging(string value);
    partial void OnNumberChanged();
    partial void OnStreetAddressChanging(string value);
    partial void OnStreetAddressChanged();
    partial void OnCityStateChanging(string value);
    partial void OnCityStateChanged();
    partial void OnTotalChanging(int value);
    partial void OnTotalChanged();
    partial void OnSheitelChanging(int value);
    partial void OnSheitelChanged();
    partial void OnCashChanging(int value);
    partial void OnCashChanged();
    partial void OnPaymentChanging(int value);
    partial void OnPaymentChanged();
    partial void OnSheitelBulkChanging(int value);
    partial void OnSheitelBulkChanged();
    partial void OnCashBulkChanging(int value);
    partial void OnCashBulkChanged();
    partial void OnInHonorOfChanging(string value);
    partial void OnInHonorOfChanged();
    #endregion
		
		public Entry()
		{
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="DateTime NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Number", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Number
		{
			get
			{
				return this._Number;
			}
			set
			{
				if ((this._Number != value))
				{
					this.OnNumberChanging(value);
					this.SendPropertyChanging();
					this._Number = value;
					this.SendPropertyChanged("Number");
					this.OnNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StreetAddress", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string StreetAddress
		{
			get
			{
				return this._StreetAddress;
			}
			set
			{
				if ((this._StreetAddress != value))
				{
					this.OnStreetAddressChanging(value);
					this.SendPropertyChanging();
					this._StreetAddress = value;
					this.SendPropertyChanged("StreetAddress");
					this.OnStreetAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CityState", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string CityState
		{
			get
			{
				return this._CityState;
			}
			set
			{
				if ((this._CityState != value))
				{
					this.OnCityStateChanging(value);
					this.SendPropertyChanging();
					this._CityState = value;
					this.SendPropertyChanged("CityState");
					this.OnCityStateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Total", DbType="Int NOT NULL")]
		public int Total
		{
			get
			{
				return this._Total;
			}
			set
			{
				if ((this._Total != value))
				{
					this.OnTotalChanging(value);
					this.SendPropertyChanging();
					this._Total = value;
					this.SendPropertyChanged("Total");
					this.OnTotalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sheitel", DbType="Int NOT NULL")]
		public int Sheitel
		{
			get
			{
				return this._Sheitel;
			}
			set
			{
				if ((this._Sheitel != value))
				{
					this.OnSheitelChanging(value);
					this.SendPropertyChanging();
					this._Sheitel = value;
					this.SendPropertyChanged("Sheitel");
					this.OnSheitelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cash", DbType="Int NOT NULL")]
		public int Cash
		{
			get
			{
				return this._Cash;
			}
			set
			{
				if ((this._Cash != value))
				{
					this.OnCashChanging(value);
					this.SendPropertyChanging();
					this._Cash = value;
					this.SendPropertyChanged("Cash");
					this.OnCashChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Payment", DbType="Int NOT NULL")]
		public int Payment
		{
			get
			{
				return this._Payment;
			}
			set
			{
				if ((this._Payment != value))
				{
					this.OnPaymentChanging(value);
					this.SendPropertyChanging();
					this._Payment = value;
					this.SendPropertyChanged("Payment");
					this.OnPaymentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SheitelBulk", DbType="Int NOT NULL")]
		public int SheitelBulk
		{
			get
			{
				return this._SheitelBulk;
			}
			set
			{
				if ((this._SheitelBulk != value))
				{
					this.OnSheitelBulkChanging(value);
					this.SendPropertyChanging();
					this._SheitelBulk = value;
					this.SendPropertyChanged("SheitelBulk");
					this.OnSheitelBulkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CashBulk", DbType="Int NOT NULL")]
		public int CashBulk
		{
			get
			{
				return this._CashBulk;
			}
			set
			{
				if ((this._CashBulk != value))
				{
					this.OnCashBulkChanging(value);
					this.SendPropertyChanging();
					this._CashBulk = value;
					this.SendPropertyChanged("CashBulk");
					this.OnCashBulkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InHonorOf", DbType="VarChar(150)")]
		public string InHonorOf
		{
			get
			{
				return this._InHonorOf;
			}
			set
			{
				if ((this._InHonorOf != value))
				{
					this.OnInHonorOfChanging(value);
					this.SendPropertyChanging();
					this._InHonorOf = value;
					this.SendPropertyChanged("InHonorOf");
					this.OnInHonorOfChanged();
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
