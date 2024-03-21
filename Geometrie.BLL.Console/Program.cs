using Geometrie.BLL;
using Geometrie.BLL.Exceptions;

try
{
	var p = new Point(3, 4);
	Console.WriteLine(p);
	//En écriture , on ne peut pas modifier les coordonnées d'un point
	//p.X = 5; //erreur de compilation
	var c = new Cercle(3, p);
	Console.WriteLine(c + " : " + Math.Round(c.CalculerAire()));

	//test du polygone
	var p1 = new Point(0, 0);
	var p2 = new Point(0, 1);
	var p3 = new Point(1, 1);
	var p4 = new Point(1, 0);

	var poly = new Triangle(p1, p2, p3);
	var poly2 = new Quadrilatere(p1, p2, p3, p4);

	foreach (var point in poly)
	{
		Console.WriteLine(point);
	}

	for (var i = 0; i < poly.Count; i++)
	{
		Console.WriteLine(poly[i]);
	}

	Console.WriteLine(poly.CalculerPerimetre());

	var listeDeFormes = new List<IForme>();
	listeDeFormes.Add(c);
	listeDeFormes.Add(poly);
	listeDeFormes.Add(poly2);

	foreach (var forme in listeDeFormes)
	{
		Console.WriteLine($"{forme} #### Périmètre : {forme.CalculerPerimetre()} #### Aire : {forme.CalculerAire()}");
	}
}
catch (ArgumentNullException ex)
{
    Console.WriteLine("Un point est null");
    Console.WriteLine(ex.Message);
}
catch (PolygoneException ex)
{
    Console.WriteLine("Un polygone est invalide");
    Console.WriteLine(ex.Message);
    foreach (var point in ex.Points)
	{
        Console.WriteLine(point);
    }
}
catch (Exception ex)
{
	Console.WriteLine("Une erreur est survenue");
	Console.WriteLine(ex.Message);
}