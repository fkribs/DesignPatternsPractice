using System;
using System.Collections;
using System.Linq;
					
public class Program
{
	public static void Main()
	{
		var rcf = new RedCarFactory();
		var bcf = new BlueCarFactory();
		foreach (var ci in Enum.GetValues(typeof(ColorIntensity)).Cast<ColorIntensity>()){
			Console.WriteLine(rcf.CreateCar(ci));
			Console.WriteLine(bcf.CreateCar(ci));
		}
	}
}

public enum ColorIntensity{
	light,
	medium,
	dark
}

public class Car{
	public ColorIntensity ColorIntensity {get;set;}
	public Car(ColorIntensity ci){
		ColorIntensity = ci;
	}
	public override string ToString(){
		return String.Format("{0} {1}",this.GetType(),ColorIntensity.ToString());
	}
}

public class RedCar: Car{
	public RedCar(ColorIntensity ci): base(ci){}
}
public class BlueCar: Car{
	public BlueCar(ColorIntensity ci): base(ci){}
}


public abstract class CarFactory{
	public abstract Car CreateCar(ColorIntensity ci);
}

public class RedCarFactory: CarFactory{
	public override Car CreateCar(ColorIntensity ci){
		switch(ci){
			case ColorIntensity.light:
				return new RedCar(ColorIntensity.light);
			case ColorIntensity.medium:
				return new RedCar(ColorIntensity.medium);
			case ColorIntensity.dark:
				return new RedCar(ColorIntensity.dark);
			default:
				throw new ArgumentException("ColorIntensity type not implemented.");
		}
	}
}
public class BlueCarFactory: CarFactory{
	public override Car CreateCar(ColorIntensity ci){
		switch(ci){
			case ColorIntensity.light:
				return new BlueCar(ColorIntensity.light);
			case ColorIntensity.medium:
				return new BlueCar(ColorIntensity.medium);
			case ColorIntensity.dark:
				return new BlueCar(ColorIntensity.dark);
			default:
				throw new ArgumentException("ColorIntensity type not implemented.");
		}
	}
}
