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

namespace ThietKeNoiThat.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ShopNoiThat")]
	public partial class ThietKeNoiThatDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAdmin(Admin instance);
    partial void UpdateAdmin(Admin instance);
    partial void DeleteAdmin(Admin instance);
    partial void InsertCategory(Category instance);
    partial void UpdateCategory(Category instance);
    partial void DeleteCategory(Category instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertLoaiNT(LoaiNT instance);
    partial void UpdateLoaiNT(LoaiNT instance);
    partial void DeleteLoaiNT(LoaiNT instance);
    partial void InsertTinTuc(TinTuc instance);
    partial void UpdateTinTuc(TinTuc instance);
    partial void DeleteTinTuc(TinTuc instance);
    partial void InsertPRODUCT(PRODUCT instance);
    partial void UpdatePRODUCT(PRODUCT instance);
    partial void DeletePRODUCT(PRODUCT instance);
    partial void InsertDonDatHang(DonDatHang instance);
    partial void UpdateDonDatHang(DonDatHang instance);
    partial void DeleteDonDatHang(DonDatHang instance);
    partial void InsertCTDDH(CTDDH instance);
    partial void UpdateCTDDH(CTDDH instance);
    partial void DeleteCTDDH(CTDDH instance);
    #endregion
		
		public ThietKeNoiThatDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ShopNoiThatConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ThietKeNoiThatDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ThietKeNoiThatDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ThietKeNoiThatDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ThietKeNoiThatDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Admin> Admins
		{
			get
			{
				return this.GetTable<Admin>();
			}
		}
		
		public System.Data.Linq.Table<Category> Categories
		{
			get
			{
				return this.GetTable<Category>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<LoaiNT> LoaiNTs
		{
			get
			{
				return this.GetTable<LoaiNT>();
			}
		}
		
		public System.Data.Linq.Table<TinTuc> TinTucs
		{
			get
			{
				return this.GetTable<TinTuc>();
			}
		}
		
		public System.Data.Linq.Table<PRODUCT> PRODUCTs
		{
			get
			{
				return this.GetTable<PRODUCT>();
			}
		}
		
		public System.Data.Linq.Table<DonDatHang> DonDatHangs
		{
			get
			{
				return this.GetTable<DonDatHang>();
			}
		}
		
		public System.Data.Linq.Table<CTDDH> CTDDHs
		{
			get
			{
				return this.GetTable<CTDDH>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Admin")]
	public partial class Admin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _TaiKhoan;
		
		private string _Password;
		
		private string _TenAdmin;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnTaiKhoanChanging(string value);
    partial void OnTaiKhoanChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnTenAdminChanging(string value);
    partial void OnTenAdminChanged();
    #endregion
		
		public Admin()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaiKhoan", DbType="NChar(10)")]
		public string TaiKhoan
		{
			get
			{
				return this._TaiKhoan;
			}
			set
			{
				if ((this._TaiKhoan != value))
				{
					this.OnTaiKhoanChanging(value);
					this.SendPropertyChanging();
					this._TaiKhoan = value;
					this.SendPropertyChanged("TaiKhoan");
					this.OnTaiKhoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NChar(10)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenAdmin", DbType="NChar(10)")]
		public string TenAdmin
		{
			get
			{
				return this._TenAdmin;
			}
			set
			{
				if ((this._TenAdmin != value))
				{
					this.OnTenAdminChanging(value);
					this.SendPropertyChanging();
					this._TenAdmin = value;
					this.SendPropertyChanged("TenAdmin");
					this.OnTenAdminChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Category")]
	public partial class Category : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ID;
		
		private string _Name;
		
		private string _IMGpath;
		
		private string _Link;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(string value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnIMGpathChanging(string value);
    partial void OnIMGpathChanged();
    partial void OnLinkChanging(string value);
    partial void OnLinkChanged();
    #endregion
		
		public Category()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NChar(10)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IMGpath", DbType="NChar(10)")]
		public string IMGpath
		{
			get
			{
				return this._IMGpath;
			}
			set
			{
				if ((this._IMGpath != value))
				{
					this.OnIMGpathChanging(value);
					this.SendPropertyChanging();
					this._IMGpath = value;
					this.SendPropertyChanged("IMGpath");
					this.OnIMGpathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Link", DbType="NChar(10)")]
		public string Link
		{
			get
			{
				return this._Link;
			}
			set
			{
				if ((this._Link != value))
				{
					this.OnLinkChanging(value);
					this.SendPropertyChanging();
					this._Link = value;
					this.SendPropertyChanged("Link");
					this.OnLinkChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _TaiKhoan;
		
		private string _Password;
		
		private System.Nullable<System.DateTime> _NgaySinh;
		
		private string _SDT;
		
		private string _DiaChi;
		
		private string _Hoten;
		
		private string _email;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnTaiKhoanChanging(string value);
    partial void OnTaiKhoanChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnNgaySinhChanging(System.Nullable<System.DateTime> value);
    partial void OnNgaySinhChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnHotenChanging(string value);
    partial void OnHotenChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    #endregion
		
		public User()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaiKhoan", DbType="VarChar(50)")]
		public string TaiKhoan
		{
			get
			{
				return this._TaiKhoan;
			}
			set
			{
				if ((this._TaiKhoan != value))
				{
					this.OnTaiKhoanChanging(value);
					this.SendPropertyChanging();
					this._TaiKhoan = value;
					this.SendPropertyChanged("TaiKhoan");
					this.OnTaiKhoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySinh", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgaySinh
		{
			get
			{
				return this._NgaySinh;
			}
			set
			{
				if ((this._NgaySinh != value))
				{
					this.OnNgaySinhChanging(value);
					this.SendPropertyChanging();
					this._NgaySinh = value;
					this.SendPropertyChanged("NgaySinh");
					this.OnNgaySinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="VarChar(20)")]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NText", UpdateCheck=UpdateCheck.Never)]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hoten", DbType="NVarChar(50)")]
		public string Hoten
		{
			get
			{
				return this._Hoten;
			}
			set
			{
				if ((this._Hoten != value))
				{
					this.OnHotenChanging(value);
					this.SendPropertyChanging();
					this._Hoten = value;
					this.SendPropertyChanged("Hoten");
					this.OnHotenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(50)")]
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LoaiNT")]
	public partial class LoaiNT : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IDLNT;
		
		private string _Name;
		
		private string _IMGPath;
		
		private string _Link;
		
		private System.Nullable<bool> _HIDE;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDLNTChanging(int value);
    partial void OnIDLNTChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnIMGPathChanging(string value);
    partial void OnIMGPathChanged();
    partial void OnLinkChanging(string value);
    partial void OnLinkChanged();
    partial void OnHIDEChanging(System.Nullable<bool> value);
    partial void OnHIDEChanged();
    #endregion
		
		public LoaiNT()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDLNT", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IDLNT
		{
			get
			{
				return this._IDLNT;
			}
			set
			{
				if ((this._IDLNT != value))
				{
					this.OnIDLNTChanging(value);
					this.SendPropertyChanging();
					this._IDLNT = value;
					this.SendPropertyChanged("IDLNT");
					this.OnIDLNTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IMGPath", DbType="VarChar(50)")]
		public string IMGPath
		{
			get
			{
				return this._IMGPath;
			}
			set
			{
				if ((this._IMGPath != value))
				{
					this.OnIMGPathChanging(value);
					this.SendPropertyChanging();
					this._IMGPath = value;
					this.SendPropertyChanged("IMGPath");
					this.OnIMGPathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Link", DbType="VarChar(50)")]
		public string Link
		{
			get
			{
				return this._Link;
			}
			set
			{
				if ((this._Link != value))
				{
					this.OnLinkChanging(value);
					this.SendPropertyChanging();
					this._Link = value;
					this.SendPropertyChanged("Link");
					this.OnLinkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HIDE", DbType="Bit")]
		public System.Nullable<bool> HIDE
		{
			get
			{
				return this._HIDE;
			}
			set
			{
				if ((this._HIDE != value))
				{
					this.OnHIDEChanging(value);
					this.SendPropertyChanging();
					this._HIDE = value;
					this.SendPropertyChanged("HIDE");
					this.OnHIDEChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TinTuc")]
	public partial class TinTuc : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IDTT;
		
		private string _NoiDung;
		
		private string _img;
		
		private string _tentt;
		
		private string _link;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDTTChanging(int value);
    partial void OnIDTTChanged();
    partial void OnNoiDungChanging(string value);
    partial void OnNoiDungChanged();
    partial void OnimgChanging(string value);
    partial void OnimgChanged();
    partial void OntenttChanging(string value);
    partial void OntenttChanged();
    partial void OnlinkChanging(string value);
    partial void OnlinkChanged();
    #endregion
		
		public TinTuc()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDTT", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IDTT
		{
			get
			{
				return this._IDTT;
			}
			set
			{
				if ((this._IDTT != value))
				{
					this.OnIDTTChanging(value);
					this.SendPropertyChanging();
					this._IDTT = value;
					this.SendPropertyChanged("IDTT");
					this.OnIDTTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NoiDung", DbType="NText", UpdateCheck=UpdateCheck.Never)]
		public string NoiDung
		{
			get
			{
				return this._NoiDung;
			}
			set
			{
				if ((this._NoiDung != value))
				{
					this.OnNoiDungChanging(value);
					this.SendPropertyChanging();
					this._NoiDung = value;
					this.SendPropertyChanged("NoiDung");
					this.OnNoiDungChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_img", DbType="VarChar(50)")]
		public string img
		{
			get
			{
				return this._img;
			}
			set
			{
				if ((this._img != value))
				{
					this.OnimgChanging(value);
					this.SendPropertyChanging();
					this._img = value;
					this.SendPropertyChanged("img");
					this.OnimgChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tentt", DbType="NVarChar(50)")]
		public string tentt
		{
			get
			{
				return this._tentt;
			}
			set
			{
				if ((this._tentt != value))
				{
					this.OntenttChanging(value);
					this.SendPropertyChanging();
					this._tentt = value;
					this.SendPropertyChanged("tentt");
					this.OntenttChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_link", DbType="VarChar(50)")]
		public string link
		{
			get
			{
				return this._link;
			}
			set
			{
				if ((this._link != value))
				{
					this.OnlinkChanging(value);
					this.SendPropertyChanging();
					this._link = value;
					this.SendPropertyChanged("link");
					this.OnlinkChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PRODUCT")]
	public partial class PRODUCT : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private string _IMGPath;
		
		private string _Link;
		
		private System.Nullable<bool> _Hide;
		
		private string _MOTA;
		
		private System.Nullable<double> _PRICE;
		
		private string _LoaiNoiThat;
		
		private EntitySet<CTDDH> _CTDDHs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnIMGPathChanging(string value);
    partial void OnIMGPathChanged();
    partial void OnLinkChanging(string value);
    partial void OnLinkChanged();
    partial void OnHideChanging(System.Nullable<bool> value);
    partial void OnHideChanged();
    partial void OnMOTAChanging(string value);
    partial void OnMOTAChanged();
    partial void OnPRICEChanging(System.Nullable<double> value);
    partial void OnPRICEChanged();
    partial void OnLoaiNoiThatChanging(string value);
    partial void OnLoaiNoiThatChanged();
    #endregion
		
		public PRODUCT()
		{
			this._CTDDHs = new EntitySet<CTDDH>(new Action<CTDDH>(this.attach_CTDDHs), new Action<CTDDH>(this.detach_CTDDHs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IMGPath", DbType="VarChar(50)")]
		public string IMGPath
		{
			get
			{
				return this._IMGPath;
			}
			set
			{
				if ((this._IMGPath != value))
				{
					this.OnIMGPathChanging(value);
					this.SendPropertyChanging();
					this._IMGPath = value;
					this.SendPropertyChanged("IMGPath");
					this.OnIMGPathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Link", DbType="VarChar(50)")]
		public string Link
		{
			get
			{
				return this._Link;
			}
			set
			{
				if ((this._Link != value))
				{
					this.OnLinkChanging(value);
					this.SendPropertyChanging();
					this._Link = value;
					this.SendPropertyChanged("Link");
					this.OnLinkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hide", DbType="Bit")]
		public System.Nullable<bool> Hide
		{
			get
			{
				return this._Hide;
			}
			set
			{
				if ((this._Hide != value))
				{
					this.OnHideChanging(value);
					this.SendPropertyChanging();
					this._Hide = value;
					this.SendPropertyChanged("Hide");
					this.OnHideChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MOTA", DbType="NText", UpdateCheck=UpdateCheck.Never)]
		public string MOTA
		{
			get
			{
				return this._MOTA;
			}
			set
			{
				if ((this._MOTA != value))
				{
					this.OnMOTAChanging(value);
					this.SendPropertyChanging();
					this._MOTA = value;
					this.SendPropertyChanged("MOTA");
					this.OnMOTAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PRICE", DbType="Float")]
		public System.Nullable<double> PRICE
		{
			get
			{
				return this._PRICE;
			}
			set
			{
				if ((this._PRICE != value))
				{
					this.OnPRICEChanging(value);
					this.SendPropertyChanging();
					this._PRICE = value;
					this.SendPropertyChanged("PRICE");
					this.OnPRICEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoaiNoiThat", DbType="NVarChar(50)")]
		public string LoaiNoiThat
		{
			get
			{
				return this._LoaiNoiThat;
			}
			set
			{
				if ((this._LoaiNoiThat != value))
				{
					this.OnLoaiNoiThatChanging(value);
					this.SendPropertyChanging();
					this._LoaiNoiThat = value;
					this.SendPropertyChanged("LoaiNoiThat");
					this.OnLoaiNoiThatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PRODUCT_CTDDH", Storage="_CTDDHs", ThisKey="ID", OtherKey="ID")]
		public EntitySet<CTDDH> CTDDHs
		{
			get
			{
				return this._CTDDHs;
			}
			set
			{
				this._CTDDHs.Assign(value);
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
		
		private void attach_CTDDHs(CTDDH entity)
		{
			this.SendPropertyChanging();
			entity.PRODUCT = this;
		}
		
		private void detach_CTDDHs(CTDDH entity)
		{
			this.SendPropertyChanging();
			entity.PRODUCT = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DonDatHang")]
	public partial class DonDatHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _IDDonHang;
		
		private string _TenDonHang;
		
		private EntitySet<CTDDH> _CTDDHs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDDonHangChanging(string value);
    partial void OnIDDonHangChanged();
    partial void OnTenDonHangChanging(string value);
    partial void OnTenDonHangChanged();
    #endregion
		
		public DonDatHang()
		{
			this._CTDDHs = new EntitySet<CTDDH>(new Action<CTDDH>(this.attach_CTDDHs), new Action<CTDDH>(this.detach_CTDDHs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDDonHang", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string IDDonHang
		{
			get
			{
				return this._IDDonHang;
			}
			set
			{
				if ((this._IDDonHang != value))
				{
					this.OnIDDonHangChanging(value);
					this.SendPropertyChanging();
					this._IDDonHang = value;
					this.SendPropertyChanged("IDDonHang");
					this.OnIDDonHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDonHang", DbType="NChar(10)")]
		public string TenDonHang
		{
			get
			{
				return this._TenDonHang;
			}
			set
			{
				if ((this._TenDonHang != value))
				{
					this.OnTenDonHangChanging(value);
					this.SendPropertyChanging();
					this._TenDonHang = value;
					this.SendPropertyChanged("TenDonHang");
					this.OnTenDonHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DonDatHang_CTDDH", Storage="_CTDDHs", ThisKey="IDDonHang", OtherKey="IDDonHang")]
		public EntitySet<CTDDH> CTDDHs
		{
			get
			{
				return this._CTDDHs;
			}
			set
			{
				this._CTDDHs.Assign(value);
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
		
		private void attach_CTDDHs(CTDDH entity)
		{
			this.SendPropertyChanging();
			entity.DonDatHang = this;
		}
		
		private void detach_CTDDHs(CTDDH entity)
		{
			this.SendPropertyChanging();
			entity.DonDatHang = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CTDDH")]
	public partial class CTDDH : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _IDDonHang;
		
		private string _SolLuong;
		
		private string _DonGia;
		
		private EntityRef<DonDatHang> _DonDatHang;
		
		private EntityRef<PRODUCT> _PRODUCT;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnIDDonHangChanging(string value);
    partial void OnIDDonHangChanged();
    partial void OnSolLuongChanging(string value);
    partial void OnSolLuongChanged();
    partial void OnDonGiaChanging(string value);
    partial void OnDonGiaChanged();
    #endregion
		
		public CTDDH()
		{
			this._DonDatHang = default(EntityRef<DonDatHang>);
			this._PRODUCT = default(EntityRef<PRODUCT>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					if (this._PRODUCT.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDDonHang", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string IDDonHang
		{
			get
			{
				return this._IDDonHang;
			}
			set
			{
				if ((this._IDDonHang != value))
				{
					if (this._DonDatHang.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDDonHangChanging(value);
					this.SendPropertyChanging();
					this._IDDonHang = value;
					this.SendPropertyChanged("IDDonHang");
					this.OnIDDonHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SolLuong", DbType="NChar(10)")]
		public string SolLuong
		{
			get
			{
				return this._SolLuong;
			}
			set
			{
				if ((this._SolLuong != value))
				{
					this.OnSolLuongChanging(value);
					this.SendPropertyChanging();
					this._SolLuong = value;
					this.SendPropertyChanged("SolLuong");
					this.OnSolLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonGia", DbType="NChar(10)")]
		public string DonGia
		{
			get
			{
				return this._DonGia;
			}
			set
			{
				if ((this._DonGia != value))
				{
					this.OnDonGiaChanging(value);
					this.SendPropertyChanging();
					this._DonGia = value;
					this.SendPropertyChanged("DonGia");
					this.OnDonGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DonDatHang_CTDDH", Storage="_DonDatHang", ThisKey="IDDonHang", OtherKey="IDDonHang", IsForeignKey=true)]
		public DonDatHang DonDatHang
		{
			get
			{
				return this._DonDatHang.Entity;
			}
			set
			{
				DonDatHang previousValue = this._DonDatHang.Entity;
				if (((previousValue != value) 
							|| (this._DonDatHang.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DonDatHang.Entity = null;
						previousValue.CTDDHs.Remove(this);
					}
					this._DonDatHang.Entity = value;
					if ((value != null))
					{
						value.CTDDHs.Add(this);
						this._IDDonHang = value.IDDonHang;
					}
					else
					{
						this._IDDonHang = default(string);
					}
					this.SendPropertyChanged("DonDatHang");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PRODUCT_CTDDH", Storage="_PRODUCT", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
		public PRODUCT PRODUCT
		{
			get
			{
				return this._PRODUCT.Entity;
			}
			set
			{
				PRODUCT previousValue = this._PRODUCT.Entity;
				if (((previousValue != value) 
							|| (this._PRODUCT.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._PRODUCT.Entity = null;
						previousValue.CTDDHs.Remove(this);
					}
					this._PRODUCT.Entity = value;
					if ((value != null))
					{
						value.CTDDHs.Add(this);
						this._ID = value.ID;
					}
					else
					{
						this._ID = default(int);
					}
					this.SendPropertyChanged("PRODUCT");
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