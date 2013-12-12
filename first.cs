using System;

public class Foo
{
	private int number;
	private string text;
	
	string Number
	{
		get { return this.number; }
		set { this.number = value; }
	}
	
	Foo()
	{
		this.Number = 0;
		this.text = "Hello";
	}
}