using NUnit.Framework;

namespace NUnitProjectTemplate
{
	public abstract class TestBaseClass
	{
		/// <summary>
		/// Runs Before the 1st test.
		/// </summary>
		[TestFixtureSetUp]
		public void TestBaseFixtureSetup()
		{

		}

		/// <summary>
		/// Runs after all of the test for this class.
		/// </summary>
		[TestFixtureTearDown]
		public void TestBaseFixtureTearDown()
		{

		}

		/// <summary>
		/// Runs before each test.
		/// </summary>
		[SetUp]
		public void TestBaseSetup()
		{

		}

		/// <summary>
		/// Runs after each test.
		/// </summary>
		[TearDown]
		public void TestBaseTearDown()
		{

		}
	}
}