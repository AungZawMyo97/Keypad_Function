using KeyPadConsole_CodeTest;
using NUnit.Framework;

[TestFixture]
public class OldPhonePadTests
{
	private ConvertKeyFunction _keyFunction;

	[SetUp]
	public void Setup()
	{
		_keyFunction = new ConvertKeyFunction();
	}

	[Test]
	public void Test1()
	{
		string input = "222 2 22#";
		string expectedOutput = "CAB";
		string actualOutput = _keyFunction.ConvertKeyInputToLetters(input);
		Assert.AreEqual(expectedOutput, actualOutput);
	}

	[Test]
	public void Test2()
	{
		string input = "33#";
		string expectedOutput = "E";
		string actualOutput = _keyFunction.ConvertKeyInputToLetters(input);
		Assert.AreEqual(expectedOutput, actualOutput);
	}

	[Test]
	public void Test3()
	{
		string input = "227*#";
		string expectedOutput = "B";
		string actualOutput = _keyFunction.ConvertKeyInputToLetters(input);
		Assert.AreEqual(expectedOutput, actualOutput);
	}

	[Test]
	public void Test4()
	{
		string input = "4433555 555666#";
		string expectedOutput = "HELLO";
		string actualOutput = _keyFunction.ConvertKeyInputToLetters(input);
		Assert.AreEqual(expectedOutput, actualOutput);
	}

	[Test]
	public void Test5()
	{
		string input = "8 88777444666*664#";
		string expectedOutput = "TURING";
		string actualOutput = _keyFunction.ConvertKeyInputToLetters(input);
		Assert.AreEqual(expectedOutput, actualOutput);
	}

	[Test]
	public void Test6_SpaceTest()
	{
		string input = "288664099992906999666#";
		string expectedOutput = "AUNG ZAW MYO";
		string actualOutput = _keyFunction.ConvertKeyInputToLetters(input);
		Assert.AreEqual(expectedOutput, actualOutput);
	}

}
