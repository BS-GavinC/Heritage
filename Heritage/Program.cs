using Heritage;

Chien chien = new Chien();

chien.Pedigree = "Yorkshirishesauce";

Chat chat = new Chat();

List<Animal> Animals = new List<Animal>();

Animals.Add(chien);
Animals.Add(chat);

foreach (Animal ani in Animals)
{
	if (ani.GetType() == typeof(Chien))
	{
		

		Chien chienCast = (Chien)ani;

		Console.WriteLine(chienCast.Pedigree);
	}
}
