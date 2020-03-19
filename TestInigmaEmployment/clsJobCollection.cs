using System;
using System.Collections.Generic;
using ClassLibrary;

namespace TestInigmaEmployment
{
    public class clsJobCollection
    {
        List<clsJob> mAllJobs = new List<clsJob>();
        private clsJob mThisJob = new clsJob();

        public int Count
        {
            get
            {
                return MJobs.Count;
            }
            set => Count = value;
        }

        public List<clsJob>MJobs
        {
            get => MJobs;
            set
            {
                MJobs = value;
            }
        }

        public clsJob ThisJob
        {
            get
            {
                return mThisJob;
            }
            set
            {
                mThisJob = value;
            }


        }

        public clsJobCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblJob_selectAll");
            Int32 RecordCount = DB.Count;
            Int32 Index = 0;
            while (Index < RecordCount)
            {
                clsJob ajob = new clsJob();
                ajob.PK_JobNo = Convert.ToInt32(DB.DataTable.Rows[Index]["PK_JobNo"]);
                ajob.JobName = Convert.ToString(DB.DataTable.Rows[Index]["Job Name"]);
                ajob.JobDescription = Convert.ToString(DB.DataTable.Rows[Index]["Job Description"]);
                ajob.DateJobPosted = Convert.ToDateTime(DB.DataTable.Rows[Index]["Date Job Added"]);
                ajob.FK_EmployerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["FK_EmployerNo"]);
                ajob.FK_StaffNo = Convert.ToInt32(DB.DataTable.Rows[Index]["FK_StaffNo"]);
                MJobs.Add(ajob);
                Index++;
            }
            
        }

        public clsJobCollection(clsJob mThisJob)
        {
            this.mThisJob = mThisJob;
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PK_JobNo", mThisJob.PK_JobNo);
            DB.AddParameter("@JobName", mThisJob.JobName);
            DB.AddParameter("@JobDescription", mThisJob.JobDescription);
            DB.AddParameter("@DateJobPosted", mThisJob.DateJobPosted);
            DB.AddParameter("@FK_EmployerNo", mThisJob.FK_EmployerNo);
            DB.AddParameter("@FK_StaffNo", mThisJob.FK_StaffNo);

            return DB.Execute("sproc_tblJob_insert");
          
        }
            

       
    }
}