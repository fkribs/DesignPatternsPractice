using System;
					
public class Program
{
	public static void Main()
	{
		Director.Direct(new FooBuilder());
		Director.Direct(new BarBuilder());
	}
}

public static class Director{
	public static void Direct(Builder builder){
		builder.StepOne();
		builder.StepTwo();
		builder.StepThree();
	}
}

public abstract class Builder
{
	public abstract void StepOne();
	public abstract void StepTwo();
	public abstract void StepThree();
}

public class FooBuilder: Builder{
	private string _name = "foo";
	public override void StepOne(){Console.WriteLine("{0} one", _name);}
	public override void StepTwo(){Console.WriteLine("{0} two", _name);}
	public override void StepThree(){Console.WriteLine("{0} three", _name);}
}
public class BarBuilder: Builder{
	private string _name = "bar";
	public override void StepOne(){Console.WriteLine("{0} one", _name);}
	public override void StepTwo(){Console.WriteLine("{0} two", _name);}
	public override void StepThree(){Console.WriteLine("{0} three", _name);}
}
