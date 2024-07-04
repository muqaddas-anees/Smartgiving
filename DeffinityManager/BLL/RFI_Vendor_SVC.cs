using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.ComponentModel;
using System.Data;

namespace Deffinity.BLL
{
	/// <summary>
	/// Table RFI_Vendor
	/// 
	/// Generated by matricrix's C# Layer Builder
	/// 23/06/2009 17:12:35
	/// 
	/// Remark: Use this class to write custom code.
	/// </summary>
	[DataObjectAttribute]
	public class RFI_Vendor_SVC : RFI_Vendor_Base_SVC
	{
		/// <summary>
		/// Constructor
		/// </summary>
		private RFI_Vendor_SVC() { }

        /// <summary>
        /// Check if entity exists
        /// </summary>
        public static bool Exists(string vendorName, string vendorLogin)
        {
            return DAL.RFI_Vendor_DAL.Exists(vendorName, vendorLogin);
        }
        /// <summary>
        /// Fill entity list ACCORDING TO THE VENDOR/CONTRACTOR LOGGED IN
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Fill, true)]
        public static DataTable Fill(int contractorID)
        {
            return DAL.RFI_Vendor_DAL.Fill(contractorID);
        }

        /// <summary>
        /// get Vendors for submission summary
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Fill, true)]
        public static DataTable GetSubmissionVendors(int projectReference)
        {
            return DAL.RFI_Vendor_DAL.GetSubmissionVendors(projectReference);
        }
        
                /// <summary>
        /// get submission summary for a project
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Fill, true)]
        public static DataTable GetSubmissionSummary(int projectReference)
        {
            return DAL.RFI_Vendor_DAL.GetSubmissionSummary(projectReference);
        }
        /// <summary>
        /// get Vendors for submission Docs
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Fill, true)]
        public static DataTable GetSubmissionVendors_Docs(int projectReference,int vendorID)
        {
            return DAL.RFI_Vendor_DAL.GetSubmissionVendors_Docs(projectReference,vendorID);
        }
        /// <summary>
        /// get cONTRACTORID
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Fill, true)]
        public static int GetContractorID(int vendorID)
        {
            return DAL.RFI_Vendor_DAL.GetContractorID(vendorID);
        }

         [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public static int DeleteVendorByvendorID(int vendorID)
        {
            return DAL.RFI_Vendor_DAL.DeleteVendorByvendorID(vendorID);
        }
        

	}
}
