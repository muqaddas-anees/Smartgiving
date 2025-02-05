using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.ComponentModel;
using System.Data;

namespace Deffinity.BLL
{
	/// <summary>
	/// Table RFI_VendorCertification
	/// 
	/// Generated by matricrix's C# Layer Builder
	/// 23/06/2009 17:12:40
	/// 
	/// Remark: Use this class to write custom code.
	/// </summary>
	[DataObjectAttribute]
	public class RFI_VendorCertification_SVC : RFI_VendorCertification_Base_SVC
	{
		/// <summary>
		/// Constructor
		/// </summary>
		private RFI_VendorCertification_SVC() { }
        /// <summary>
        /// Fill entity list wrt to vendor
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Fill, true)]
        public static DataTable Fill(int vendorID)
        {
            return DAL.RFI_VendorCertification_DAL.Fill(vendorID);
        }

	}
}
