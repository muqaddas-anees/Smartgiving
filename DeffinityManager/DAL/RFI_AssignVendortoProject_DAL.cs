using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using SqlSrv = Microsoft.ApplicationBlocks.Data;

namespace Deffinity.DAL
{
	/// <summary>
	/// Table RFI_AssignVendortoProject
	/// 
	/// Generated by matricrix's C# Layer Builder
	/// 23/06/2009 17:11:42
	/// 
	/// Remark: Use this class to write custom code.
	/// </summary>
	public class RFI_AssignVendortoProject_DAL : RFI_AssignVendortoProject_Base_DAL
	{
		/// <summary>
		/// Constructor
		/// </summary>
		private RFI_AssignVendortoProject_DAL() { }
        /// <summary>
        /// Fill entity list wrt ProjectReference
        /// </summary>
        public static DataTable Fill(int ProjectReference)
        {
            DataSet dsRFI_AssignVendortoProject = SqlSrv.SqlHelper.ExecuteDataset(Connection.ConnectionString, CommandType.StoredProcedure, "dbo.DEFFINITY_RFI_ASSIGNVENDORTOPROJECT_FILLBYPROJECT", new System.Data.SqlClient.SqlParameter[] { new System.Data.SqlClient.SqlParameter("@ProjectReference", ProjectReference) });
            return dsRFI_AssignVendortoProject.Tables[0];
        }

        /// <summary>
        /// Check if entity exists already
        /// </summary>
        public static bool Exists(int vendorID,int Projectreference)
        {
            return Convert.ToInt32(SqlSrv.SqlHelper.ExecuteScalar(Connection.ConnectionString, CommandType.StoredProcedure, "dbo.DEFFINITY_RFI_ASSIGNVENDORTOPROJECT_EXISTS", new System.Data.SqlClient.SqlParameter[] { new System.Data.SqlClient.SqlParameter("@VendorID", vendorID), new System.Data.SqlClient.SqlParameter("@Projectreference", Projectreference) })) > 0;
        }
        public static int SubmitResponse(bool IsSubmitted,int Projectreference,int vendorID)
        {
            return Convert.ToInt32(SqlSrv.SqlHelper.ExecuteScalar(Connection.ConnectionString, CommandType.StoredProcedure, "dbo.DEFFINITY_RFI_VENDORSUBMIT", new System.Data.SqlClient.SqlParameter[] { new System.Data.SqlClient.SqlParameter("@VendorID", vendorID), new System.Data.SqlClient.SqlParameter("@Projectreference", Projectreference) }));

        }

	}
}
