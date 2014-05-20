using System;
using NUnit.Framework;

namespace $rootnamespace$
{
	[TestFixture]
	public class $safeitemname$ : TestBaseClass
	{

		#region Test Setups and Teardown Methods

		/// <summary>
		/// Runs Before the 1st test.
		/// </summary>
		[TestFixtureSetUp]
		public void TestFixtureSetup()
		{
			TestBaseFixtureSetup();
		}

		/// <summary>
		/// Runs after all of the test for this class.
		/// </summary>
		[TestFixtureTearDown]
		public void TestFixtureTearDown()
		{
			TestBaseFixtureTearDown();
		}

		/// <summary>
		/// Runs before each test.
		/// </summary>
		[SetUp]
		public void TestSetup()
		{
			TestBaseSetup();
		}

		/// <summary>
		/// Runs after each test.
		/// </summary>
		[TearDown]
		public void TestTearDown()
		{
			TestBaseTearDown();
		}

		#endregion

		[Test]
		public void Test()
		{
			throw new NotImplementedException();
		}
	}
}
