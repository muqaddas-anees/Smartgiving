using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Deffinity.BE
{
	/// <summary>
	/// Table RFI_Panelists
	/// 
	/// Generated by matricrix's C# Layer Builder
	/// 23/06/2009 17:12:05
	/// </summary>
	public class RFI_Panelists
	{
		private int _panellistid;
		private int _contractorid;
		private int _projectreference;

		/// <summary>
		/// Column RFI_Panelists.PanelistID
		/// </summary>
		public int PANELLISTID
		{
			get { return this._panellistid; }
			set { this._panellistid = value; }
		}
		
		/// <summary>
		/// Column RFI_Panelists.Name
		/// </summary>
		public int CONTRACTORID
		{
            get { return this._contractorid; }
            set { this._contractorid = value; }
		}
		
		/// <summary>
		/// Column RFI_Panelists.ProjectReference
		/// </summary>
		public int PROJECTREFERENCE
		{
			get { return this._projectreference; }
			set { this._projectreference = value; }
		}
		

		/// <summary>
		/// Entity properties
		/// </summary>
		/// <returns>Collection properties</returns>
		public System.Data.SqlClient.SqlParameter[] ItemParameter()
		{
			List<System.Data.SqlClient.SqlParameter> oParameters = new List<System.Data.SqlClient.SqlParameter>();
			oParameters.Add(new System.Data.SqlClient.SqlParameter("@PANELLISTID", this._panellistid));
            oParameters.Add(new System.Data.SqlClient.SqlParameter("@CONTRACTORID", this._contractorid));
			oParameters.Add(new System.Data.SqlClient.SqlParameter("@PROJECTREFERENCE", this._projectreference));
			return oParameters.ToArray();
		}
	}
}
