using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using SqlSrv = Microsoft.ApplicationBlocks.Data;

namespace Deffinity.DAL
{
	/// <summary>
	/// Table RFI_BOMVendor
	/// 
	/// Generated by matricrix's C# Layer Builder
	/// 17/07/2009 16:02:46
	/// 
	/// Remark: Use this class to write custom code.
	/// </summary>
	public class RFI_BOMVendor_DAL : RFI_BOMVendor_Base_DAL
	{
		/// <summary>
		/// Constructor
		/// </summary>
		private RFI_BOMVendor_DAL() { }

        /// <summary>
        /// Insert entity
        /// </summary>
        public static int GetVendorID(int ContractorID)
        {
            return Convert.ToInt32(SqlSrv.SqlHelper.ExecuteScalar(Connection.ConnectionString, CommandType.StoredProcedure, "dbo.DEFFINITY_RFI_GETVENDORID", new System.Data.SqlClient.SqlParameter[] { new System.Data.SqlClient.SqlParameter("@CONTRACTORID", ContractorID)}));
        }
        /// <summary>
        /// Insert entity
        /// </summary>
        public static int InsertAll(int ProjectReference, int VendorID)
        {
            return SqlSrv.SqlHelper.ExecuteNonQuery(Connection.ConnectionString, CommandType.StoredProcedure, "dbo.DEFFINITY_RFI_BOMVENDOR_INSERTALL", new System.Data.SqlClient.SqlParameter[] { new System.Data.SqlClient.SqlParameter("@VendorID", VendorID), new System.Data.SqlClient.SqlParameter("@PROJECTREFERENCE", ProjectReference) });
        }

        /// <summary>
        /// Fill entity records
        /// </summary>
        public static DataTable FillSubSection(int ProjectReference, int VendorID, int WorkSheetID)
        {
            DataSet _rfivendorbom = SqlSrv.SqlHelper.ExecuteDataset(Connection.ConnectionString, CommandType.StoredProcedure, "dbo.DEFFINITY_RFI_SUBSECTION_BYVENDORBOM_FILL", new System.Data.SqlClient.SqlParameter[] { new System.Data.SqlClient.SqlParameter("@VENDORID", VendorID), new System.Data.SqlClient.SqlParameter("@PROJECTREFERENCE", ProjectReference),new System.Data.SqlClient.SqlParameter("@WorkSheetID",WorkSheetID)});
            return _rfivendorbom.Tables[0];
        }
        /// <summary>
        /// Fill Subsection
        /// </summary>
        public static DataTable Fill(int ProjectReference, int ContractorID, int SubsectionID, int WorkSheetID)
        {
            DataSet _rfivendorbom = SqlSrv.SqlHelper.ExecuteDataset(Connection.ConnectionString, CommandType.StoredProcedure, "dbo.DEFFINITY_RFI_BOMVENDOR_FILL", new System.Data.SqlClient.SqlParameter[] { new System.Data.SqlClient.SqlParameter("@CONTRACTORID", ContractorID), new System.Data.SqlClient.SqlParameter("@PROJECTREFERENCE", ProjectReference), new System.Data.SqlClient.SqlParameter("@SUBSECTIONID", SubsectionID), new System.Data.SqlClient.SqlParameter("@WORKSHEETID", WorkSheetID) });
            return _rfivendorbom.Tables[0];
        }

        /// <summary>
        /// Fill Subsection to compare with other vendors
        /// </summary>
        public static DataTable FillCompare(int ProjectReference, int SubsectionID)
        {
            DataSet _rfivendorbom = SqlSrv.SqlHelper.ExecuteDataset(Connection.ConnectionString, CommandType.StoredProcedure, "dbo.DEFFINITY_RFI_VENDORPRICE_COMPARE", new System.Data.SqlClient.SqlParameter[] { new System.Data.SqlClient.SqlParameter("@PROJECTREFERENCE", ProjectReference), new System.Data.SqlClient.SqlParameter("@SUBSECTIONID", SubsectionID) });
            return _rfivendorbom.Tables[0];
        }

        /// <summary>
        /// Update entity records
        /// </summary>
        public static int Update(double Price, int id,int currency)
        {
            return SqlSrv.SqlHelper.ExecuteNonQuery(Connection.ConnectionString, CommandType.StoredProcedure, "dbo.DEFFINITY_RFI_BOMVENDOR_UPDATE", new System.Data.SqlClient.SqlParameter[] { new System.Data.SqlClient.SqlParameter("@PRICE", Price), new System.Data.SqlClient.SqlParameter("@ID", id), new System.Data.SqlClient.SqlParameter("@CURRENCY", currency) });
        }
        
        /// <summary>
        /// Delete entity record
        /// </summary>
        public static int Delete(int av2pID)
        {
            return SqlSrv.SqlHelper.ExecuteNonQuery(Connection.ConnectionString, CommandType.StoredProcedure, "dbo.DEFFINITY_RFI_BOMVENDOR_DELETE_VENDORS", new System.Data.SqlClient.SqlParameter[] { new System.Data.SqlClient.SqlParameter("@AV2PID", av2pID) });
        }
        
	}
}
