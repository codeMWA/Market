﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MarketForm.AccesLinq
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Market")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Définitions de méthodes d'extensibilité
    partial void OnCreated();
    partial void Insertaccounts_products(accounts_products instance);
    partial void Updateaccounts_products(accounts_products instance);
    partial void Deleteaccounts_products(accounts_products instance);
    partial void Insertcustomer(customer instance);
    partial void Updatecustomer(customer instance);
    partial void Deletecustomer(customer instance);
    partial void Insertorders(orders instance);
    partial void Updateorders(orders instance);
    partial void Deleteorders(orders instance);
    partial void Insertseller(seller instance);
    partial void Updateseller(seller instance);
    partial void Deleteseller(seller instance);
    partial void Insertproducts(products instance);
    partial void Updateproducts(products instance);
    partial void Deleteproducts(products instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::MarketForm.Properties.Settings.Default.MarketConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<accounts_products> accounts_products
		{
			get
			{
				return this.GetTable<accounts_products>();
			}
		}
		
		public System.Data.Linq.Table<customer> customer
		{
			get
			{
				return this.GetTable<customer>();
			}
		}
		
		public System.Data.Linq.Table<orders> orders
		{
			get
			{
				return this.GetTable<orders>();
			}
		}
		
		public System.Data.Linq.Table<seller> seller
		{
			get
			{
				return this.GetTable<seller>();
			}
		}
		
		public System.Data.Linq.Table<products> products
		{
			get
			{
				return this.GetTable<products>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.accounts_products")]
	public partial class accounts_products : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_account;
		
		private string _account_type;
		
		private System.Nullable<decimal> _price;
		
		private string _email;
		
		private string _passwordA;
		
		private System.Nullable<int> _account_duration;
		
		private string _userS;
		
		private EntitySet<orders> _orders;
		
		private EntityRef<seller> _seller;
		
		private EntityRef<products> _products;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_accountChanging(int value);
    partial void Onid_accountChanged();
    partial void Onaccount_typeChanging(string value);
    partial void Onaccount_typeChanged();
    partial void OnpriceChanging(System.Nullable<decimal> value);
    partial void OnpriceChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnpasswordAChanging(string value);
    partial void OnpasswordAChanged();
    partial void Onaccount_durationChanging(System.Nullable<int> value);
    partial void Onaccount_durationChanged();
    partial void OnuserSChanging(string value);
    partial void OnuserSChanged();
    #endregion
		
		public accounts_products()
		{
			this._orders = new EntitySet<orders>(new Action<orders>(this.attach_orders), new Action<orders>(this.detach_orders));
			this._seller = default(EntityRef<seller>);
			this._products = default(EntityRef<products>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_account", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_account
		{
			get
			{
				return this._id_account;
			}
			set
			{
				if ((this._id_account != value))
				{
					this.Onid_accountChanging(value);
					this.SendPropertyChanging();
					this._id_account = value;
					this.SendPropertyChanged("id_account");
					this.Onid_accountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_account_type", DbType="VarChar(40)")]
		public string account_type
		{
			get
			{
				return this._account_type;
			}
			set
			{
				if ((this._account_type != value))
				{
					if (this._products.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onaccount_typeChanging(value);
					this.SendPropertyChanging();
					this._account_type = value;
					this.SendPropertyChanged("account_type");
					this.Onaccount_typeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Money")]
		public System.Nullable<decimal> price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(60)")]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_passwordA", DbType="VarChar(40)")]
		public string passwordA
		{
			get
			{
				return this._passwordA;
			}
			set
			{
				if ((this._passwordA != value))
				{
					this.OnpasswordAChanging(value);
					this.SendPropertyChanging();
					this._passwordA = value;
					this.SendPropertyChanged("passwordA");
					this.OnpasswordAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_account_duration", DbType="Int")]
		public System.Nullable<int> account_duration
		{
			get
			{
				return this._account_duration;
			}
			set
			{
				if ((this._account_duration != value))
				{
					this.Onaccount_durationChanging(value);
					this.SendPropertyChanging();
					this._account_duration = value;
					this.SendPropertyChanged("account_duration");
					this.Onaccount_durationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userS", DbType="VarChar(30)")]
		public string userS
		{
			get
			{
				return this._userS;
			}
			set
			{
				if ((this._userS != value))
				{
					if (this._seller.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnuserSChanging(value);
					this.SendPropertyChanging();
					this._userS = value;
					this.SendPropertyChanged("userS");
					this.OnuserSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="accounts_products_orders", Storage="_orders", ThisKey="id_account", OtherKey="id_account")]
		public EntitySet<orders> orders
		{
			get
			{
				return this._orders;
			}
			set
			{
				this._orders.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="seller_accounts_products", Storage="_seller", ThisKey="userS", OtherKey="userS", IsForeignKey=true)]
		public seller seller
		{
			get
			{
				return this._seller.Entity;
			}
			set
			{
				seller previousValue = this._seller.Entity;
				if (((previousValue != value) 
							|| (this._seller.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._seller.Entity = null;
						previousValue.accounts_products.Remove(this);
					}
					this._seller.Entity = value;
					if ((value != null))
					{
						value.accounts_products.Add(this);
						this._userS = value.userS;
					}
					else
					{
						this._userS = default(string);
					}
					this.SendPropertyChanged("seller");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="products_accounts_products", Storage="_products", ThisKey="account_type", OtherKey="account_type", IsForeignKey=true)]
		public products products
		{
			get
			{
				return this._products.Entity;
			}
			set
			{
				products previousValue = this._products.Entity;
				if (((previousValue != value) 
							|| (this._products.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._products.Entity = null;
						previousValue.accounts_products.Remove(this);
					}
					this._products.Entity = value;
					if ((value != null))
					{
						value.accounts_products.Add(this);
						this._account_type = value.account_type;
					}
					else
					{
						this._account_type = default(string);
					}
					this.SendPropertyChanged("products");
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
		
		private void attach_orders(orders entity)
		{
			this.SendPropertyChanging();
			entity.accounts_products = this;
		}
		
		private void detach_orders(orders entity)
		{
			this.SendPropertyChanging();
			entity.accounts_products = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.customer")]
	public partial class customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _userC;
		
		private string _nameC;
		
		private string _passwordC;
		
		private string _CityC;
		
		private string _phoneC;
		
		private EntitySet<orders> _orders;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnuserCChanging(string value);
    partial void OnuserCChanged();
    partial void OnnameCChanging(string value);
    partial void OnnameCChanged();
    partial void OnpasswordCChanging(string value);
    partial void OnpasswordCChanged();
    partial void OnCityCChanging(string value);
    partial void OnCityCChanged();
    partial void OnphoneCChanging(string value);
    partial void OnphoneCChanged();
    #endregion
		
		public customer()
		{
			this._orders = new EntitySet<orders>(new Action<orders>(this.attach_orders), new Action<orders>(this.detach_orders));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userC", DbType="VarChar(30) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string userC
		{
			get
			{
				return this._userC;
			}
			set
			{
				if ((this._userC != value))
				{
					this.OnuserCChanging(value);
					this.SendPropertyChanging();
					this._userC = value;
					this.SendPropertyChanged("userC");
					this.OnuserCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nameC", DbType="VarChar(30)")]
		public string nameC
		{
			get
			{
				return this._nameC;
			}
			set
			{
				if ((this._nameC != value))
				{
					this.OnnameCChanging(value);
					this.SendPropertyChanging();
					this._nameC = value;
					this.SendPropertyChanged("nameC");
					this.OnnameCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_passwordC", DbType="VarChar(40)")]
		public string passwordC
		{
			get
			{
				return this._passwordC;
			}
			set
			{
				if ((this._passwordC != value))
				{
					this.OnpasswordCChanging(value);
					this.SendPropertyChanging();
					this._passwordC = value;
					this.SendPropertyChanged("passwordC");
					this.OnpasswordCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CityC", DbType="VarChar(30)")]
		public string CityC
		{
			get
			{
				return this._CityC;
			}
			set
			{
				if ((this._CityC != value))
				{
					this.OnCityCChanging(value);
					this.SendPropertyChanging();
					this._CityC = value;
					this.SendPropertyChanged("CityC");
					this.OnCityCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phoneC", DbType="VarChar(10)")]
		public string phoneC
		{
			get
			{
				return this._phoneC;
			}
			set
			{
				if ((this._phoneC != value))
				{
					this.OnphoneCChanging(value);
					this.SendPropertyChanging();
					this._phoneC = value;
					this.SendPropertyChanged("phoneC");
					this.OnphoneCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="customer_orders", Storage="_orders", ThisKey="userC", OtherKey="userC")]
		public EntitySet<orders> orders
		{
			get
			{
				return this._orders;
			}
			set
			{
				this._orders.Assign(value);
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
		
		private void attach_orders(orders entity)
		{
			this.SendPropertyChanging();
			entity.customer = this;
		}
		
		private void detach_orders(orders entity)
		{
			this.SendPropertyChanging();
			entity.customer = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.orders")]
	public partial class orders : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _n_order;
		
		private string _userC;
		
		private string _userS;
		
		private System.Nullable<int> _id_account;
		
		private System.Nullable<System.DateTime> _order_date;
		
		private EntityRef<accounts_products> _accounts_products;
		
		private EntityRef<customer> _customer;
		
		private EntityRef<seller> _seller;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onn_orderChanging(int value);
    partial void Onn_orderChanged();
    partial void OnuserCChanging(string value);
    partial void OnuserCChanged();
    partial void OnuserSChanging(string value);
    partial void OnuserSChanged();
    partial void Onid_accountChanging(System.Nullable<int> value);
    partial void Onid_accountChanged();
    partial void Onorder_dateChanging(System.Nullable<System.DateTime> value);
    partial void Onorder_dateChanged();
    #endregion
		
		public orders()
		{
			this._accounts_products = default(EntityRef<accounts_products>);
			this._customer = default(EntityRef<customer>);
			this._seller = default(EntityRef<seller>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_n_order", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int n_order
		{
			get
			{
				return this._n_order;
			}
			set
			{
				if ((this._n_order != value))
				{
					this.Onn_orderChanging(value);
					this.SendPropertyChanging();
					this._n_order = value;
					this.SendPropertyChanged("n_order");
					this.Onn_orderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userC", DbType="VarChar(30)")]
		public string userC
		{
			get
			{
				return this._userC;
			}
			set
			{
				if ((this._userC != value))
				{
					if (this._customer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnuserCChanging(value);
					this.SendPropertyChanging();
					this._userC = value;
					this.SendPropertyChanged("userC");
					this.OnuserCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userS", DbType="VarChar(30)")]
		public string userS
		{
			get
			{
				return this._userS;
			}
			set
			{
				if ((this._userS != value))
				{
					if (this._seller.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnuserSChanging(value);
					this.SendPropertyChanging();
					this._userS = value;
					this.SendPropertyChanged("userS");
					this.OnuserSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_account", DbType="Int")]
		public System.Nullable<int> id_account
		{
			get
			{
				return this._id_account;
			}
			set
			{
				if ((this._id_account != value))
				{
					if (this._accounts_products.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_accountChanging(value);
					this.SendPropertyChanging();
					this._id_account = value;
					this.SendPropertyChanged("id_account");
					this.Onid_accountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_order_date", DbType="DateTime")]
		public System.Nullable<System.DateTime> order_date
		{
			get
			{
				return this._order_date;
			}
			set
			{
				if ((this._order_date != value))
				{
					this.Onorder_dateChanging(value);
					this.SendPropertyChanging();
					this._order_date = value;
					this.SendPropertyChanged("order_date");
					this.Onorder_dateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="accounts_products_orders", Storage="_accounts_products", ThisKey="id_account", OtherKey="id_account", IsForeignKey=true)]
		public accounts_products accounts_products
		{
			get
			{
				return this._accounts_products.Entity;
			}
			set
			{
				accounts_products previousValue = this._accounts_products.Entity;
				if (((previousValue != value) 
							|| (this._accounts_products.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._accounts_products.Entity = null;
						previousValue.orders.Remove(this);
					}
					this._accounts_products.Entity = value;
					if ((value != null))
					{
						value.orders.Add(this);
						this._id_account = value.id_account;
					}
					else
					{
						this._id_account = default(Nullable<int>);
					}
					this.SendPropertyChanged("accounts_products");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="customer_orders", Storage="_customer", ThisKey="userC", OtherKey="userC", IsForeignKey=true)]
		public customer customer
		{
			get
			{
				return this._customer.Entity;
			}
			set
			{
				customer previousValue = this._customer.Entity;
				if (((previousValue != value) 
							|| (this._customer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._customer.Entity = null;
						previousValue.orders.Remove(this);
					}
					this._customer.Entity = value;
					if ((value != null))
					{
						value.orders.Add(this);
						this._userC = value.userC;
					}
					else
					{
						this._userC = default(string);
					}
					this.SendPropertyChanged("customer");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="seller_orders", Storage="_seller", ThisKey="userS", OtherKey="userS", IsForeignKey=true)]
		public seller seller
		{
			get
			{
				return this._seller.Entity;
			}
			set
			{
				seller previousValue = this._seller.Entity;
				if (((previousValue != value) 
							|| (this._seller.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._seller.Entity = null;
						previousValue.orders.Remove(this);
					}
					this._seller.Entity = value;
					if ((value != null))
					{
						value.orders.Add(this);
						this._userS = value.userS;
					}
					else
					{
						this._userS = default(string);
					}
					this.SendPropertyChanged("seller");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.seller")]
	public partial class seller : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _userS;
		
		private string _nameS;
		
		private string _passwordS;
		
		private string _CityS;
		
		private string _phoneS;
		
		private EntitySet<accounts_products> _accounts_products;
		
		private EntitySet<orders> _orders;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnuserSChanging(string value);
    partial void OnuserSChanged();
    partial void OnnameSChanging(string value);
    partial void OnnameSChanged();
    partial void OnpasswordSChanging(string value);
    partial void OnpasswordSChanged();
    partial void OnCitySChanging(string value);
    partial void OnCitySChanged();
    partial void OnphoneSChanging(string value);
    partial void OnphoneSChanged();
    #endregion
		
		public seller()
		{
			this._accounts_products = new EntitySet<accounts_products>(new Action<accounts_products>(this.attach_accounts_products), new Action<accounts_products>(this.detach_accounts_products));
			this._orders = new EntitySet<orders>(new Action<orders>(this.attach_orders), new Action<orders>(this.detach_orders));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userS", DbType="VarChar(30) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string userS
		{
			get
			{
				return this._userS;
			}
			set
			{
				if ((this._userS != value))
				{
					this.OnuserSChanging(value);
					this.SendPropertyChanging();
					this._userS = value;
					this.SendPropertyChanged("userS");
					this.OnuserSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nameS", DbType="VarChar(30)")]
		public string nameS
		{
			get
			{
				return this._nameS;
			}
			set
			{
				if ((this._nameS != value))
				{
					this.OnnameSChanging(value);
					this.SendPropertyChanging();
					this._nameS = value;
					this.SendPropertyChanged("nameS");
					this.OnnameSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_passwordS", DbType="VarChar(40)")]
		public string passwordS
		{
			get
			{
				return this._passwordS;
			}
			set
			{
				if ((this._passwordS != value))
				{
					this.OnpasswordSChanging(value);
					this.SendPropertyChanging();
					this._passwordS = value;
					this.SendPropertyChanged("passwordS");
					this.OnpasswordSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CityS", DbType="VarChar(30)")]
		public string CityS
		{
			get
			{
				return this._CityS;
			}
			set
			{
				if ((this._CityS != value))
				{
					this.OnCitySChanging(value);
					this.SendPropertyChanging();
					this._CityS = value;
					this.SendPropertyChanged("CityS");
					this.OnCitySChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phoneS", DbType="VarChar(30)")]
		public string phoneS
		{
			get
			{
				return this._phoneS;
			}
			set
			{
				if ((this._phoneS != value))
				{
					this.OnphoneSChanging(value);
					this.SendPropertyChanging();
					this._phoneS = value;
					this.SendPropertyChanged("phoneS");
					this.OnphoneSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="seller_accounts_products", Storage="_accounts_products", ThisKey="userS", OtherKey="userS")]
		public EntitySet<accounts_products> accounts_products
		{
			get
			{
				return this._accounts_products;
			}
			set
			{
				this._accounts_products.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="seller_orders", Storage="_orders", ThisKey="userS", OtherKey="userS")]
		public EntitySet<orders> orders
		{
			get
			{
				return this._orders;
			}
			set
			{
				this._orders.Assign(value);
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
		
		private void attach_accounts_products(accounts_products entity)
		{
			this.SendPropertyChanging();
			entity.seller = this;
		}
		
		private void detach_accounts_products(accounts_products entity)
		{
			this.SendPropertyChanging();
			entity.seller = null;
		}
		
		private void attach_orders(orders entity)
		{
			this.SendPropertyChanging();
			entity.seller = this;
		}
		
		private void detach_orders(orders entity)
		{
			this.SendPropertyChanging();
			entity.seller = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.products")]
	public partial class products : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _account_type;
		
		private System.Nullable<int> _quantity;
		
		private EntitySet<accounts_products> _accounts_products;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onaccount_typeChanging(string value);
    partial void Onaccount_typeChanged();
    partial void OnquantityChanging(System.Nullable<int> value);
    partial void OnquantityChanged();
    #endregion
		
		public products()
		{
			this._accounts_products = new EntitySet<accounts_products>(new Action<accounts_products>(this.attach_accounts_products), new Action<accounts_products>(this.detach_accounts_products));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_account_type", DbType="VarChar(40) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string account_type
		{
			get
			{
				return this._account_type;
			}
			set
			{
				if ((this._account_type != value))
				{
					this.Onaccount_typeChanging(value);
					this.SendPropertyChanging();
					this._account_type = value;
					this.SendPropertyChanged("account_type");
					this.Onaccount_typeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_quantity", DbType="Int")]
		public System.Nullable<int> quantity
		{
			get
			{
				return this._quantity;
			}
			set
			{
				if ((this._quantity != value))
				{
					this.OnquantityChanging(value);
					this.SendPropertyChanging();
					this._quantity = value;
					this.SendPropertyChanged("quantity");
					this.OnquantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="products_accounts_products", Storage="_accounts_products", ThisKey="account_type", OtherKey="account_type")]
		public EntitySet<accounts_products> accounts_products
		{
			get
			{
				return this._accounts_products;
			}
			set
			{
				this._accounts_products.Assign(value);
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
		
		private void attach_accounts_products(accounts_products entity)
		{
			this.SendPropertyChanging();
			entity.products = this;
		}
		
		private void detach_accounts_products(accounts_products entity)
		{
			this.SendPropertyChanging();
			entity.products = null;
		}
	}
}
#pragma warning restore 1591
