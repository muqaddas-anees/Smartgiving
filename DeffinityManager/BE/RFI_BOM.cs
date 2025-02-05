using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Deffinity.BE
{
	/// <summary>
	/// Table RFI_BOM
	/// 
	/// Generated by matricrix's C# Layer Builder
	/// 17/07/2009 15:59:27
	/// </summary>
	public class RFI_BOM
	{
		private int _id;
		private string _description;
		private string _unit;
		private int _qty;
		private double _unitprice;
		private int _subsectionid;
		private int _projectreference;
		private int _worksheetid;
		private int _type;
        private int _currency;

		/// <summary>
		/// Column RFI_BOM.ID
		/// </summary>
		public int ID
		{
			get { return this._id; }
			set { this._id = value; }
		}
		
		/// <summary>
		/// Column RFI_BOM.Description
		/// </summary>
		public string DESCRIPTION
		{
			get { return this._description; }
			set { this._description = value; }
		}
		
		/// <summary>
		/// Column RFI_BOM.Unit
		/// </summary>
		public string UNIT
		{
			get { return this._unit; }
			set { this._unit = value; }
		}
		
		/// <summary>
		/// Column RFI_BOM.Qty
		/// </summary>
		public int QTY
		{
			get { return this._qty; }
			set { this._qty = value; }
		}
		
		/// <summary>
		/// Column RFI_BOM.UnitPrice
		/// </summary>
		public double UNITPRICE
		{
			get { return this._unitprice; }
			set { this._unitprice = value; }
		}
		
		/// <summary>
		/// Column RFI_BOM.SubsectionID
		/// </summary>
		public int SUBSECTIONID
		{
			get { return this._subsectionid; }
			set { this._subsectionid = value; }
		}
		
		/// <summary>
		/// Column RFI_BOM.ProjectReference
		/// </summary>
		public int PROJECTREFERENCE
		{
			get { return this._projectreference; }
			set { this._projectreference = value; }
		}
		
		/// <summary>
		/// Column RFI_BOM.WorkSheetID
		/// </summary>
		public int WORKSHEETID
		{
			get { return this._worksheetid; }
			set { this._worksheetid = value; }
		}
		
		/// <summary>
		/// Column RFI_BOM.Type
		/// </summary>
		public int TYPE
		{
			get { return this._type; }
			set { this._type = value; }
		}

        /// <summary>
        /// Column RFI_BOM.Currency
        /// </summary>
        public int CURRENCY
        {
            get { return this._currency; }
            set { this._currency = value; }
        }

		/// <summary>
		/// Entity properties
		/// </summary>
		/// <returns>Collection properties</returns>
		public System.Data.SqlClient.SqlParameter[] ItemParameter()
		{
			List<System.Data.SqlClient.SqlParameter> oParameters = new List<System.Data.SqlClient.SqlParameter>();
			oParameters.Add(new System.Data.SqlClient.SqlParameter("@ID", this._id));
			oParameters.Add(new System.Data.SqlClient.SqlParameter("@DESCRIPTION", this._description));
			oParameters.Add(new System.Data.SqlClient.SqlParameter("@UNIT", (this._unit == null ? string.Empty : this._unit)));
			oParameters.Add(new System.Data.SqlClient.SqlParameter("@QTY", this._qty));
			oParameters.Add(new System.Data.SqlClient.SqlParameter("@UNITPRICE", this._unitprice));
			oParameters.Add(new System.Data.SqlClient.SqlParameter("@SUBSECTIONID", this._subsectionid));
			oParameters.Add(new System.Data.SqlClient.SqlParameter("@PROJECTREFERENCE", this._projectreference));
			oParameters.Add(new System.Data.SqlClient.SqlParameter("@WORKSHEETID", this._worksheetid));
			oParameters.Add(new System.Data.SqlClient.SqlParameter("@TYPE", this._type));
            oParameters.Add(new System.Data.SqlClient.SqlParameter("@CURRENCY", this._currency));
			return oParameters.ToArray();
		}
	}
}
