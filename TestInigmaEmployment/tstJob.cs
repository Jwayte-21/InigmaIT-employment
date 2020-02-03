using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestInigmaEmployment
{
    [TestClass]
    public class tstJob
    {
        [TestMethod]
        public void InstanceOfclsJob()
        {
            clsJob aJob = new clsJob();
            Assert.IsNotNull(aJob);
        }

        [TestMethod]
        public void JobNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsJob aJob = new clsJob();
            //create test data to assign the property
            String SomeJob = "mechanic";
            //asign the data to a property
            aJob.JobName = SomeJob;
            //test to see that the two values are the same
            Assert.AreEqual(aJob.JobName, SomeJob);

        }
        [TestMethod]
        public void JobDescriptionPropertyOK()
        {
            clsJob aJob = new clsJob();
            string SomeJob = "nice";
            aJob.JobDescription = SomeJob;
            Assert.AreEqual(aJob.JobDescription, SomeJob);
        }
        
        [TestMethod]
        public void PK_JobNoPropertyOK()
        {
            clsJob aJob = new clsJob();
            Int32 PK_JobNo = 1;
            aJob.PK_JobNo = PK_JobNo;
            Assert.AreEqual(aJob.PK_JobNo, PK_JobNo);
        }
        [TestMethod]
        public void FK_EmployerNoPropertyOk()
        {
            clsJob ajob = new clsJob();
            Int32 FK_EmployerNo = 1;
            ajob.FK_EmployerNo = FK_EmployerNo;
            Assert.AreEqual(ajob.FK_EmployerNo, FK_EmployerNo);    

        }
        [TestMethod]
        public void FK_StaffNoPropertyOK()
        {
            clsJob ajob = new clsJob();
            Int32 FK_StaffNo = 1;
            ajob.FK_StaffNo = FK_StaffNo;
            Assert.AreEqual(ajob.FK_StaffNo, FK_StaffNo);
        }
      

    }
}
