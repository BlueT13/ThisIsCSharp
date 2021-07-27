using System;

class Global
{
	public static int Count = 0;
}

class ClassA
{
	public ClassA()
	{
		Global.Count++;
	}
}

class ClassB
{
	public ClassB()
	{
		Global.Count++;
	}
}
