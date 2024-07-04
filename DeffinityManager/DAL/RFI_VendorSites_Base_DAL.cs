using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using SqlSrv = Microsoft.ApplicationBlocks.Data;

namespace Deffinity.DAL
{
	/// <summary>
	/// Table RFI_VendorSites
	/// 
	/// Generated by matricrix's C# Layer Builder
	/// 23/06/2009 17:12:46
	/// </summary>
	public class RFI_VendorSites_Base_DAL
	{

		/// <summary>
		/// Load entity
		/// </summary>
		private static BE.RFI_VendorSites Load(DataRow oRow)
		{
			BE.RFI_VendorSites oReturn = new BE.RFI_VendorSites();
			oReturn.VENDORSITEID = (int)oRow["VENDORSITEID"];
			oReturn.VENDORID = (int)oRow["VENDORID"];
			oReturn.SITEID = (int)oRow["SITEID"];
            oReturn.SWITCHBOARDNUMBER =oRow["SWITCHBOARDNUMBER"].ToString();// (oRow["SWITCHBOARDNUMBER"] == DBNull.Value ? (null) : ((int?)oRow["SWITCHBOARDNUMBER"]));
			return oReturn;
		}

		/// <summary>
		/// Insert entity
		/// </summary>
		public static int Insert(BE.RFI_VendorSites oRFI_VendorSites)
		{
            return Convert.ToInt32(SqlSrv.SqlHelper.ExecuteScalar(Connection.ConnectionString, CommandType.StoredProcedure, "dbo.DEFFINITY_RFI_VENDORSITES_INSERT", oRFI_VendorSites.ItemParameter()));
		}

		/// <summary>
		/// Search entity
		/// </summary>
		public static BE.RFI_VendorSites Select(int vendorsiteid)
		{
			DataSet dsRFI_VendorSites = SqlSrv.SqlHelper.ExecuteDataset(Connection.ConnectionString, CommandType.StoredProcedure, "dbo.DEFFINITY_RFI_VENDORSITES_SELECT", new System.Data.SqlClient.SqlParameter[]{ new System.Data.SqlClient.SqlParameter("@VENDORSITEID", vendorsiteid) });
			BE.RFI_VendorSites oRFI_VendorSites = null;
			if (dsRFI_VendorSites.Tables[0].Rows.Count > 0)
				oRFI_VendorSites = RFI_VendorSites_Base_DAL.Load(dsRFI_VendorSites.Tables[0].Rows[0]);
			return oRFI_VendorSites;
		}

		/// <summary>
		/// Check if entity exists
		/// </summary>
        public static bool Exists(string sitename, int vendorid)
		{
            return Convert.ToInt32(SqlSrv.SqlHelper.ExecuteScalar(Connection.ConnectionString, CommandType.StoredProcedure, "dbo.DEFFINITY_RFI_VENDORSITES_EXISTS", new System.Data.SqlClient.SqlParameter[] { new System.Data.SqlClient.SqlParameter("@SITENAME", sitename), new System.Data.SqlClient.SqlParameter("@VENDORID", vendorid) })) > 0;
		}

		/// <summary>
		/// Fill entity list
		/// </summary>
        public static DataTable Fill(int vendorid)
		{
			DataSet dsRFI_VendorSites = SqlSrv.SqlHelper.ExecuteDataset(Connection.ConnectionString, CommandType.StoredProcedure, "dbo.DEFFINITY_RFI_VENDORSITES_FILL",new System.Data.SqlClient.SqlParameter[]{new System.Data.SqlClient.SqlParameter("@VENDORID",vendorid)});
			return dsRFI_VendorSites.Tables[0];
		}

		/// <summary>
		/// Update entity
		/// </summary>
		public static int Update(BE.RFI_VendorSites oRFI_VendorSites)
		{
			return SqlSrv.SqlHelper.ExecuteNonQuery(Connection.ConnectionString, CommandType.StoredProcedure, "dbo.DEFFINITY_RFI_VENDORSITES_UPDATE", oRFI_VendorSites.ItemParameter());
		}

		/// <summary>
		/// Delete entity record
		/// </summary>
		public static int Delete(int vendorsiteid)
		{
			return SqlSrv.SqlHelper.ExecuteNonQuery(Connection.ConnectionString, CommandType.StoredProcedure, "dbo.DEFFINITY_RFI_VENDORSITES_DELETE", new System.Data.SqlClient.SqlParameter[] { new System.Data.SqlClient.SqlParameter("@VENDORSITEID", vendorsiteid) });
		}
		/// <summary>
		/// Delete entity ALL records
		/// </summary>
		public static int DeleteAll()
		{
			return SqlSrv.SqlHelper.ExecuteNonQuery(Connection.ConnectionString, CommandType.StoredProcedure, "dbo.DEFFINITY_RFI_VENDORSITES_DELETEALL");
		}
	}
}
