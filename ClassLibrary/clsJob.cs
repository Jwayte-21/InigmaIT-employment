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
    }
}