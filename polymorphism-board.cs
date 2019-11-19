 /*
雇佣兵生命值、主角生命值、经验值、耐力值、主角精力值
封装主角生命值和雇佣兵生命值
*/
using System;
using System.Collections.Generic;
namespace Board
{	
	abstract class DashBoard
	{
		public abstract void Render();
	}
	class MercenaryHp:DashBoard //雇佣兵HP,is-a
	{
		public int Hp=200;
		public override void Render()   //渲染
		{
			Console.WriteLine("雇佣兵的HP为{0}",this.Hp);
		}
	}
	class ProtagonistHp:DashBoard //雇佣兵HP is-a
	{
		public int Hp=100;
		public override void Render()   //渲染
		{
			Console.WriteLine("主角的HP为{0}",this.Hp);
		}
	}
	class Protagonist    //主角
	{
		public ProtagonistHp HP = new ProtagonistHp();  //has-a
		public Mercenary Helper = new Mercenary();		//has-a
	}
	class Mercenary		//雇佣兵
	{
		public MercenaryHp HP = new MercenaryHp();
	}
	class Program
	{
		static void Redraw(List<DashBoard> dashboards)   //多肽链表
		{
			foreach(var dashboard in dashboards)
				dashboard.Render();
		}
		static void Main()
		{
			Protagonist me = new Protagonist();
			List<DashBoard> dbs = new List<DashBoard>();
			dbs.Add(me.HP);
			dbs.Add(me.Helper.HP);
			Redraw(dbs);     //不管多少人的血条，只用这么一个方法就够了
			me.HP.Hp -= 20;
			me.Helper.HP.Hp -= 50;
			Redraw(dbs);

			
		}
	}
}
