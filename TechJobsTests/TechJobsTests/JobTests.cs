using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        //[TestInitialize]
        //public void CreateJobObject()
        //{
        //    Job test_job = new Job();
        //    Job test_job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        //}

        [TestMethod]
        public void TestSettingJobId()
        {
            // arrange
            int job1Id = 1;
            int job2Id = 2;

            Job test_job = new Job();

            // act
            int ID = test_job.Id;

            // assert
            Assert.AreEqual(job1Id, job2Id, 1);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            //arrange
            Job test_jobConstructor = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            //Job test_jobConstructor = new Job("Product tester", new Employer employerName, new Location employerLocation, new PositionType jobType, new CoreCompetency jobCoreCompetency);

            // act
          
            //assert
            Assert.AreEqual("Product tester", test_jobConstructor.Name);
            Assert.AreEqual("ACME", test_jobConstructor.EmployerName.ToString());
            Assert.AreEqual("Desert", test_jobConstructor.EmployerLocation.ToString());
            Assert.AreEqual("Quality control", test_jobConstructor.JobType.ToString());
            Assert.AreEqual("Persistence", test_jobConstructor.JobCoreCompetency.ToString());
            Assert.AreEqual(1, test_jobConstructor.Id);
        }

        //[TestMethod]
        //public void TestJobsForEquality()
        //{
        //   //Assert.AreEqual(test_job, 1);
        //}

        //[TestMethod]
        //public void TestToString()
        //{
        //    //Assert.AreEqual(test_job, 1);
        //}
    }
}
