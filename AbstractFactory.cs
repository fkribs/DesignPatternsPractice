using System;
					
public class Program
{

	public static void Main()
	{
		AbstractFactory af = new ConcreteFactory1();
		System.Console.WriteLine("Factory1");
		CreateClientWithFactory(af);
		af = new ConcreteFactory2();
		System.Console.WriteLine("Factory2");
		CreateClientWithFactory(af);
	}
  
	private static void CreateClientWithFactory(AbstractFactory af){
		Client client = new Client(af);
		client.GetPackaging();
		client.GetProduct();
		System.Console.WriteLine(client.Packaging.GetType());
		System.Console.WriteLine(client.Product.GetType());
	}
}

public class Client
{
	private AbstractFactory _factory;
	public Product Product {get;set;}
	public Packaging Packaging {get;set;}
	
  public Client(AbstractFactory factory){
		_factory = factory;
	}
  
	public void GetProduct(){
		Product = _factory.CreateProduct();
	}
	public void GetPackaging(){
		Packaging = _factory.CreatePackaging();
	}
}

public abstract class Product {}
public abstract class Packaging {}

public abstract class AbstractFactory
{
	public abstract Product CreateProduct();
	public abstract Packaging CreatePackaging();
}

public class Product1: Product {}
public class Packaging1: Packaging {}

public class ConcreteFactory1: AbstractFactory{
	
  public override Product CreateProduct(){
		return new Product1();
	}
  
	public override Packaging CreatePackaging(){
		return new Packaging1();
	}
}

public class Product2: Product {}
public class Packaging2: Packaging {}

public class ConcreteFactory2: AbstractFactory{
	
  public override Product CreateProduct(){
		return new Product2();
	}
  
	public override Packaging CreatePackaging(){
		return new Packaging2();
	}
}
