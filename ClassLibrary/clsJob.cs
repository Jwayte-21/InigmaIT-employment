using System;

namespace ClassLibrary
{
    public class clsJob
    {
        public clsJob()
        {
        }

        public string JobName { get; set; }
        public string JobDescription { get; set; }
        public int PK_JobNo { get; set; }
        public int FK_EmployerNo { get; set; }
        public int FK_StaffNo { get; set; }
        public DateTime DateJobPosted { get; set; }

        public string Valid(string someJob)
        {
            if (someJob !="")
            {
                return "";
            }
            else
            {
                return "the Job name may not be blank!";
            }
        }
    }
}