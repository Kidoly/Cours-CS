using DelegateEtGeneric;

var liste = new Liste<int>();
liste.Ajouter(1);
liste.Ajouter(2);
liste.Ajouter(3);

var liste2 = new Liste<string>();
liste2.Ajouter("un");
liste2.Ajouter("deux");
liste2.Ajouter("trois");

foreach (var item in liste)
{
    Console.WriteLine(item);
}

//délégation de la méthode anonyme
//liste.Trier(delegate(int a, int b) {return a> b; });
liste.Trier((a, b) => a > b);

for (var i = 0; i < liste.Count; i++)
{
    Console.WriteLine(liste[i]);
}