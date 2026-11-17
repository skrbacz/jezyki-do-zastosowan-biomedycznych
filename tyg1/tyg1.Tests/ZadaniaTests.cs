using BasicExercises;
using BasicAlgorithm;
using DataTypes;
using ConditionalStatement;
using ExceptionHandlingEx;
using ForLoop; 
using ArrayExercises;
using System.Reflection;


namespace tyg1.Tests;

[TestClass]
public class ZadaniaTests
{
    // Task1 - napisane za pomocą claude trochę zmodyfikowane przeze mnie
    [TestMethod]
    [DataRow(0, 32)]
    [DataRow(100, 212)]
    [DataRow(-40, -40)]
    public void CalculateFarenheit_ReturnsExpected(double c, double expected)
    {
        Assert.AreEqual(expected, Task1.CalculateFarenheit(c), 0.01);
    }

    [TestMethod]
    public void CalculateKelvin_ZeroCelsius_Returns273_15()
    {
        Assert.AreEqual(273.15, Task1.CalculateKelvin(0), 0.01);
    }

    // Task 2 
    [TestMethod]
    [DataRow(16, false)]
    [DataRow(21, true)]
    [DataRow(3,true)]
    public void IsItMultiplyOf3Or7_ReturnsExpected(int i, Boolean expected)
   {
       Assert.AreEqual(expected, Task2.IsItMultiplyOf3Or7(i));
   }

   // Task 3 
  [TestMethod]
  [DataRow(-1)]
  [DataRow(1001)]
  public void IsItLessThan0OrGreater1000_ThrowsAnException(int value)
  {
    // https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-mstest-writing-tests-assertions
    Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => 
    Task3.IsItLessThan0OrGreater1000(value));
  }
   
  [TestMethod]
  [DataRow(0,0)]
  [DataRow(1000,1000)]
  [DataRow(32,32)]
   public void IsItLessThan0OrGreater1000_ReturnsExepcted(int value, int expected)
  {
    Assert.AreEqual(expected, Task3.IsItLessThan0OrGreater1000(value));
  } 

  // Task 4 
  [TestMethod]
  [DataRow(6,new double [] {37.7, 113.1})]
  public void CalculatePremiterAndArea_ReturnsExpected (double r, double[] expected)
  {
    // https://learn.microsoft.com/en-us/dotnet/api/microsoft.visualstudio.testtools.unittesting.collectionassert?view=mstest-net-4.1
    CollectionAssert.AreEqual(Task4.CalculatePremiterAndArea(r), expected);
  }

  // Task 5
  [TestMethod]
  [DataRow(4, "Czwartek")]
  public void NameOfDay_ReturnsExpected (int number, string expected)
  {
    // https://learn.microsoft.com/en-us/dotnet/api/microsoft.visualstudio.testtools.unittesting.collectionassert?view=mstest-net-4.1
    Assert.AreEqual(Task5.NameOfDay(number), expected);
  }

  [TestMethod]
  [DataRow(8)]
  public void NameOfDay_ReturnsExpected (int value)
  {
    // https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-mstest-writing-tests-assertions
    Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => 
    Task5.NameOfDay(value));
  }

  // Task 7
  [TestMethod]
  [DataRow(new int [] {3})]
  public void NameOfDay_ThrowsException (int [] values)
  {
    // https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-mstest-writing-tests-assertions
    Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => 
    Task7.SecondHighestNumber(values));
  }

}