using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.ComponentModel;
using System.Data;

namespace Deffinity.BLL
{
	/// <summary>
	/// Table RFI_VendorSites
	/// 
	/// Generated by matricrix's C# Layer Builder
	/// 23/06/2009 17:12:46
	/// </summary>
	public class RFI_VendorSites_Base_SVC
	{

		/// <summary>
		/// Insert entity
		/// </summary>
		[DataObjectMethod(DataObjectMethodType.Insert, true)]
		public static int Insert(BE.RFI_VendorSites oRFI_VendorSites)
		{
			return DAL.RFI_VendorSites_DAL.Insert(oRFI_VendorSites);
		}

		/// <summary>
		/// Search entity
		/// </summary>
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public static BE.RFI_VendorSites Select(int vendorsiteid)
		{
			return DAL.RFI_VendorSites_DAL.Select(vendorsiteid);
		}

		/// <summary>
		/// Check if entity exists
		/// </summary>
		public static bool Exists(string  sitename,int vendorid)
		{
            return DAL.RFI_VendorSites_DAL.Exists(sitename, vendorid);
		}

		/// <summary>
		/// Fill entity list
		/// </summary>
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
        public static DataTable Fill(int vendorid)
		{
            return DAL.RFI_VendorSites_DAL.Fill(vendorid);
		}

		/// <summary>
		/// Update entity
		/// </summary>
		[DataObjectMethod(DataObjectMethodType.Update, true)]
		public static int Update(BE.RFI_VendorSites oRFI_VendorSites)
		{
			return DAL.RFI_VendorSites_DAL.Update(oRFI_VendorSites);
		}

		/// <summary>
		/// Delete entity record
		/// </summary>
		[DataObjectMethod(DataObjectMethodType.Delete, true)]
		public static int Delete(int vendorsiteid)
		{
			return DAL.RFI_VendorSites_DAL.Delete(vendorsiteid);
		}

		/// <summary>
		/// Delete entity ALL records
		/// </summary>
		[DataObjectMethod(DataObjectMethodType.Delete, false)]
		public static int DeleteAll()
		{
			return DAL.RFI_VendorSites_DAL.DeleteAll();
		}

	}
}
