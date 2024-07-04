﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DC.Entity;
using DC.BLL;
namespace DeffinityAppDev.WF.DC.controls
{
    public partial class TicketManagerCtrl : System.Web.UI.UserControl
    {
        
        IDCRespository<TicketManager> aRepository = null;
        IUserRepository<UserMgt.Entity.Contractor> uRepository = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    
                    BindUsers();
                    BindGrid();
                }
            }
            catch (Exception ex)
            {
                LogExceptions.WriteExceptionLog(ex);
            }
        }
        private void BindUsers()
        {
            try
            {
                ddlUsers.DataSource = SecurityAccessMail.BindContractor().Where(p => p.SID == 1 || p.SID == 2 || p.SID == 3).ToList();
                ddlUsers.DataValueField = "ID";
                ddlUsers.DataTextField = "ContractorName";
                ddlUsers.DataBind();
                ddlUsers.Items.Insert(0, new ListItem("Please select...", "0"));
            }
            catch (Exception ex)
            {
                LogExceptions.WriteExceptionLog(ex);
            }
        }
        private void BindGrid()
        {
            try
            {
                aRepository = new DCRepository<TicketManager>();
                uRepository = new UserRepository<UserMgt.Entity.Contractor>();
                var rlist = aRepository.GetAll().ToList();
                var ulist = uRepository.GetAll().ToList();
                var dlist = (from p in rlist
                             join u in ulist on p.UserID equals u.ID
                             select new
                             {
                                 ID = p.TMID,
                                 p.UserID,
                                 u.ContractorName
                             }).ToList();
                GvMailManager.DataSource = dlist;
                GvMailManager.DataBind();
            }
            catch (Exception ex)
            {
                LogExceptions.WriteExceptionLog(ex);
            }

        }
        protected void btnaddUser_Click(object sender, EventArgs e)
        {
            try
            {
                int customerID = sessionKeys.PortfolioID;
                aRepository = new DCRepository<TicketManager>();
                var uentity = aRepository.GetAll().Where(o => o.UserID == Convert.ToInt32(ddlUsers.SelectedValue)).FirstOrDefault();
                if (uentity == null)
                {
                    var manager = new TicketManager();
                    manager.UserID = int.Parse(ddlUsers.SelectedValue);
                    aRepository.Add(manager);
                    lblMsg.Text = "User added successfully";
                    //lblMsg.ForeColor = System.Drawing.Color.Green;
                    BindGrid();
                }
                else
                {
                    lblErrorMsg.Text = "User already exists";
                    //lblMsg.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                LogExceptions.WriteExceptionLog(ex);
            }

        }
        protected void btndeleteUser_Click(object sender, EventArgs e)
        {

        }
        protected void GvMailManager_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "Delete1")
                {
                    if (Convert.ToInt32(e.CommandArgument) > 0)
                    {
                        aRepository = new DCRepository<TicketManager>();
                        var uentity = aRepository.GetAll().Where(o => o.TMID == Convert.ToInt32(e.CommandArgument)).FirstOrDefault();
                        aRepository.Delete(uentity);
                        BindGrid();
                        lblMsg.Text = "Deleted successfully";
                    }
                }

            }
            catch (Exception ex)
            {
                LogExceptions.WriteExceptionLog(ex);
            }



        }
    }
}