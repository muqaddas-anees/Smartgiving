﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DeffinityAppDev.WF.DC.controls
{
    public partial class PermitCustomerTab : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["callid"] != null)
                {
                    var tid = Convert.ToInt32(Request.QueryString["callid"]);
                    lbtnChecklists.HRef = string.Format("~/WF/DC/ChecklistCustomer.aspx?callid={0}", tid);
                    lbtnPermit.HRef = string.Format("~/WF/DC/PermitToWorkCustomer.aspx?callid={0}", tid);
                }
                else
                {
                    lbtnChecklists.HRef = "#";
                    lbtnPermit.HRef = "#";

                }
            }
        }
    }
}