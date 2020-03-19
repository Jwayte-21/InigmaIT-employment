using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestInigmaEmployment
{
    [TestClass]
    public class tstJob
    {
        public object AllJobs { get; private set; }

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
            string SomeJob = "Technical work";
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
        [TestMethod]
        public void DateJobPostedPropertyOk()
        {
            clsJob ajob = new clsJob();
            DateTime dt = new DateTime();
            ajob.DateJobPosted = dt;
            Assert.AreEqual(ajob.DateJobPosted, dt);
        }
        [TestMethod]
        public void JobDataValidationOk()
        {
            clsJob ajob = new clsJob();
            string Error = "";
            string SomeJob = "Mechanic";
            Error = ajob.Valid(SomeJob);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FindJobOk()
        {
            clsJob ajob = new clsJob();
            //boolean variable to store the result of validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 PK_JobNo = 1;
            //invoke the method
            Found = ajob.Find(PK_JobNo);
            //test
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void InstanceOfclsJobCollection()
        {
            clsJobCollection allJobs = new clsJobCollection();
            Assert.IsNotNull(allJobs);
        }
        
        
        [TestMethod]
        public void ListOk()
        {
            clsJobCollection allJobs = new clsJobCollection();
            List<clsJob> TestList = new List<clsJob>();
            clsJob TestItem = new clsJob();
            TestItem.PK_JobNo = 1;
            TestItem.JobName = "Mechanic";
            TestItem.JobDescription = "Fix Cars";
            TestItem.DateJobPosted = DateTime.Now.Date;
            TestItem.FK_EmployerNo = 1;
            TestItem.FK_StaffNo = 1;
            TestList.Add(TestItem);
            allJobs.MJobs = TestList;
            Assert.AreEqual(allJobs.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsJobCollection AllJobs = new clsJobCollection();
            clsJob TestItem = new clsJob();
            Int32 PrimaryKey = 0;
            TestItem.PK_JobNo = 1;
            TestItem.JobName = "Chef";
            TestItem.JobDescription = "pub cook";
            TestItem.DateJobPosted = DateTime.Now.Date;
            TestItem.FK_EmployerNo = 1;
            TestItem.FK_StaffNo = 1;
            AllJobs.ThisJob = TestItem;
            PrimaryKey = AllJobs.Add();
            AllJobs.ThisJob = PrimaryKey;
            AllJobs.ThisJob.Find(PrimaryKey);
            Assert.AreEqual(AllJobs.ThisJob, TestItem);
        }
       
      

    }

    
}
