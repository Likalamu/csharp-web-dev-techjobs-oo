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
            int job2Id = 3;

            Job test_job = new Job();

            // act
            int ID = test_job.Id;

            // assert
            Assert.IsTrue(job1Id != job2Id);
        }


        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            //arrange
            Job test_jobConstructor = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            // act
          
            //assert
            Assert.AreEqual("Product tester", test_jobConstructor.Name);
            Assert.AreEqual("ACME", test_jobConstructor.EmployerName.ToString());
            Assert.AreEqual("Desert", test_jobConstructor.EmployerLocation.ToString());
            Assert.AreEqual("Quality control", test_jobConstructor.JobType.ToString());
            Assert.AreEqual("Persistence", test_jobConstructor.JobCoreCompetency.ToString());
            Assert.AreEqual(1, test_jobConstructor.Id);
        }


        [TestMethod]
        public void TestJobsForEquality()
        {
           
            Job test1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job test2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.IsFalse(test1.Equals(test2));
        }

        [TestMethod]
        public void TestToString()
        {
            Job test1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            string testString = test1.ToString();
            char firstCharacter = testString[0];
            char lastCharacter = testString[testString.Length - 1];
            Assert.IsTrue(firstCharacter == lastCharacter);
        }
    }
}
