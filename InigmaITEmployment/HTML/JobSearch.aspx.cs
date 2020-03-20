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
           //classLibrary.clsJobCollection Jobs = new classLibrary.clsJobCollection();
           //lstJob.DataSource = Jobs.mJobs;
           //lstJob.DataValueField = "PK_JobNo";
           //lstJob.DataTextField = "JobName";
           //lstJob.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("Add Job.aspx");
        }

       

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Job.aspx");
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Update Job.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Response.Redirect("Delete Job.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.html");
        }
    }
}