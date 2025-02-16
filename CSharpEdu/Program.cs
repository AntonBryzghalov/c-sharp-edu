// See https://aka.ms/new-console-template for more information
using CSharpEdu.src;

Console.WriteLine("Hello, World!");

var vartypes = new VarTypes();
vartypes.TestIntegers()
	.TestFloats()
	.TestChars();

var structs = new Structs().TestStructs();

var delegates = new Delegates().TestDelegates();

GenericsEqualityTest.TestStringsEquality();

var closuresTests = new ClosuresTests().TestIteratorValueClosure();

var arrays = new Arrays().TestArrays();

PassingByReference.TestPassingByReference();