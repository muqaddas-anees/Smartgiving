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
	/// </summary>
	public class RFI_AssignVendortoProject_Base_DAL
	{

		/// <summary>
		/// Load entity
		/// </summary>
		private static BE.RFI_AssignVendortoProject Load(DataRow oRow)
		{
			BE.RFI_AssignVendortoProject oReturn = new BE.RFI_AssignVendortoProject();
			oReturn.ID = (int)oRow["ID"];
			oReturn.VENDORID = (int)oRow["VENDORID"];
			oReturn.STATUS = (int)oRow["STATUS"];
			oReturn.PROJECTREFERENCE = (int)oRow["PROJECTREFERENCE"];
			oReturn.FEEDBACK = (oRow["FEEDBACK"] == DBNull.Value ? (null) : ((string)oRow["FEEDBACK"]));
			return oReturn;
		}

		/// <summary>
		/// Insert entity
		/// </summary>
		public static int Insert(BE.RFI_AssignVendortoProject oRFI_AssignVendortoProject)
		{
            return SqlSrv.SqlHelper.ExecuteNonQuery(Connection.ConnectionString, CommandType.StoredProcedure, "dbo.DEFFINITY_RFI_ASSIGNVENDORTOPROJECT_INSERT", oRFI_AssignVendortoProject.ItemParameter());
		}

		/// <summary>
		/// Search entity
		/// </summary>
		public static BE.RFI_AssignVendortoProject Select(int id)
		{
			DataSet dsRFI_AssignVendortoProject = SqlSrv.SqlHelper.ExecuteDataset(Connection.ConnectionString, CommandType.StoredProcedure, "dbo.DEFFINITY_RFI_ASSIGNVENDORTOPROJECT_SELECT", new System.Data.SqlClient.SqlParameter[]{ new System.Data.SqlClient.SqlParameter("@ID", id) });
			BE.RFI_AssignVendortoProject oRFI_AssignVendortoProject = null;
			if (dsRFI_AssignVendortoProject.Tables[0].Rows.Count > 0)
				oRFI_AssignVendortoProject = RFI_AssignVendortoProject_Base_DAL.Load(dsRFI_AssignVendortoProject.Tables[0].Rows[0]);
			return oRFI_AssignVendortoProject;
		}

		/// <summary>
		/// Fill entity list
		/// </summary>
		public static DataTable Fill()
		{
			DataSet dsRFI_AssignVendortoProject = SqlSrv.SqlHelper.ExecuteDataset(Connection.ConnectionString, CommandType.StoredProcedure, "dbo.DEFFINITY_RFI_ASSIGNVENDORTOPROJECT_FILL");
			return dsRFI_AssignVendortoProject.Tables[0];
		}

		/// <summary>
		/// Update entity
		/// </summary>
		public static int Update(BE.RFI_AssignVendortoProject oRFI_AssignVendortoProject)
		{
			return SqlSrv.SqlHelper.ExecuteNonQuery(Connection.ConnectionString, CommandType.StoredProcedure, "dbo.DEFFINITY_RFI_ASSIGNVENDORTOPROJECT_UPDATE", oRFI_AssignVendortoProject.ItemParameter());
		}

		/// <summary>
		/// Delete entity record
		/// </summary>
		public static int Delete(int id)
		{
			return SqlSrv.SqlHelper.ExecuteNonQuery(Connection.ConnectionString, CommandType.StoredProcedure, "dbo.DEFFINITY_RFI_ASSIGNVENDORTOPROJECT_DELETE", new System.Data.SqlClient.SqlParameter[] { new System.Data.SqlClient.SqlParameter("@ID", id) });
		}
		/// <summary>
		/// Delete entity ALL records
		/// </summary>
		public static int DeleteAll()
		{
			return SqlSrv.SqlHelper.ExecuteNonQuery(Connection.ConnectionString, CommandType.StoredProcedure, "dbo.DEFFINITY_RFI_ASSIGNVENDORTOPROJECT_DELETEALL");
		}
	}
}
