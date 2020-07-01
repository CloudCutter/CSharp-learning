using System;
namespace tong
{
	class Student{
		String name;
	}
	class Secret
	{
		public int Age{get;set;}
		public double weight{get;set;}
	}
	class Animal
	{
		protected Secret SecretData = new Secret(){Age = 1,weight = 20.0};
		public virtual string Name{get;set;}       //字段属性也可以复写
		public virtual void shout()
		{
			Console.WriteLine("未知动物的叫声");
		}
	}
	class Dog:Animal    //继承了Animal的属性和方法
	{
		public override string Name{get;set;}
		public override void shout()
		{
			Console.WriteLine("age={0},"+this.Name+"wangwang"+",wegiht={1}",SecretData.Age,SecretData.weight);
		}
	}
	class Dog1:Dog    //继承Dog
	{
	//	public override string Name{get;set;}
		public override void shout()
		{
			Console.WriteLine("age={0},"+this.Name+"hahaha"+",wegiht={1}",SecretData.Age,SecretData.weight);
		}
	}
	class Cat:Animal
	{
		public override void shout()
		{
			Console.WriteLine(this.Name+"miaomiao");
		}
	}
	class Program
	{
		
		static void Test(Animal animal)    
		{
			Console.WriteLine(animal.Name);
			animal.shout();
		}
		static void Main()
		{
		//	var dog2 = new Dog(){Name = "小白"};
			Animal dog1 = new Dog1(){Name="小黄"};
	//		Console.WriteLine(dog2.Name);
			Test(dog1);
		}
	}
}
