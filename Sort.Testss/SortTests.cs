using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nauka;

namespace Sort.Testss
{
    [TestClass]
    public class SortTests
    {
        private TestContext testContext;
        public TestContext TestContext
        {
            get
            {
                return this.testContext;
            }
            set
            {
                this.testContext = value;
            }
        }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "C:\\Users\\Kopdzio\\source\\repos\\Nauka\\Sort.Testss\\sorttests.csv", "sorttests#csv",
            DataAccessMethod.Sequential), DeploymentItem("sorttests.csv"),
            TestMethod]
        public void SortTableKopdzioSortedTable()
        {
            int size = int.Parse(this.TestContext.DataRow["s"].ToString());

            UnitTest(new LinquSort(size, BuildTestTable(string.Empty)), size);
            UnitTest(new BoubleSort(size, BuildTestTable(string.Empty)), size);
            UnitTest(new KopdzioSort(size, BuildTestTable(string.Empty)), size);
        }
        public void UnitTest(ISorts sort, int size)
        {
            var sortedTab = sort.Sort();
            int[] expected = BuildTestTable("out");

            for (int i = 0; i < size; i++)
            {
                Assert.AreEqual<int>(expected[i], sortedTab[i]);
            }
        }
        private int[] BuildTestTable(string beforeLetter)
        {
            return new int[] 
            {
                int.Parse(this.TestContext.DataRow[$"{beforeLetter}A"].ToString()),
                int.Parse(this.TestContext.DataRow[$"{beforeLetter}B"].ToString()),
                int.Parse(this.TestContext.DataRow[$"{beforeLetter}C"].ToString()),
                int.Parse(this.TestContext.DataRow[$"{beforeLetter}D"].ToString()),
                int.Parse(this.TestContext.DataRow[$"{beforeLetter}E"].ToString())
            };
        }
    }
}
