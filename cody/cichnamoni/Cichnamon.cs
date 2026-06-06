using System;

public class Cichnamon
{
	public string Jmeno { get; set; }
	public int MaxHP { get; set; }
	public int HP;
	public int Bonus { get; set; }
	public Utok UtokZakl { get; set; }
	public Utok UtokSpec { get; set; }

	public Cichnamon(string jmeno, int maxHP, int bonus, string nazevUtokuZakl, int poskozeniZakl, string popisZakl, string nazevUtokuSpec, int poskozeniSpec, string popisSpec)
	{
		Jmeno = jmeno;
		MaxHP = maxHP;
		HP = maxHP;
		Bonus = bonus;
		UtokZakl = new Utok(nazevUtokuZakl, poskozeniZakl, popisZakl);
		UtokSpec = new Utok(nazevUtokuSpec, poskozeniSpec, popisSpec);
	}

	public void VypisInfo()
	{
		Console.WriteLine($"  Cichnamon \"{Jmeno}\"");
		Console.WriteLine($"  Maximalni zdravi: {MaxHP} HP");
		Console.WriteLine($"  Aktualni zdravi: {HP} HP");
		Console.WriteLine($"  Ma utoky: \"{UtokZakl.Nazev}\" a \"{UtokSpec.Nazev}\"");
		Console.WriteLine($"  Bonus k utoku: +{Bonus}");
	}

	public void ProvestUtokZakl(Cichnamon hrac, Cichnamon protihrac)
	{
		protihrac.HP -= hrac.UtokZakl.Poskozeni;
	}

	public void ProvestUtokSpec(Cichnamon hrac, Cichnamon protihrac)
	{
		protihrac.HP -= hrac.UtokSpec.Poskozeni;
	}

	public void Uzdraveni(int hp)
	{
		HP += hp;
	}

	public bool JeNazivu()
	{
		return HP >= 0;
	}
}
