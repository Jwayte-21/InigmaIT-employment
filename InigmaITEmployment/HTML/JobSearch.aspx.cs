using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InigmaITEmployment.HTML
{
    public partial class JobSearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        void DisplayJobs()
        {
            classLibrary.clsJobCollection Jobs = new classLibrary.clsJobCollection();
            lstJob.DataSource = Jobs.mJobs;
            lstJob.DataValueField = "PK_JobNo";
            lstJob.DataTextField = "JobName";
            lstJob.DataBind();
        }

        protected void btnViewJob_Click(object sender, EventArgs e)
        {
            Response.Redirect("Job.aspx");

        }

        protected void btnUpdateJob_Click(object sender, EventArgs e)
        {
            Response.Redirect("Update job.aspx");
        }

        protected void btnAddJob_Click(object sender, EventArgs e)
        {
            //store -1 to the session object to show this is a new record
            Session["PK_JobNo"] = -1;
            Response.Redirect("Add Job.aspx");
        }

        protected void btnDeleteJob_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("Delete Job.aspx");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}