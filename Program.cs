//Oggi esercitazione veloce, ossia vi chiedo di prendere dimestichezza con quanto appena visto sui file in classe, in particolare nel live-coding di oggi.
//In questo esercizio dovrete leggere un file CSV, che cambia poco da quanto appena visto nel live-coding in classe, e salvare tutti gli indirizzi contenuti al sul interno all’interno di una lista di oggetti istanziati a partire dalla classe Indirizzo.
//Attenzione: gli ultimi 3 indirizzi presentano dei possibili “casi particolari” che possono accadere a questo genere di file: vi chiedo di pensarci e di gestire come meglio crediate queste casistiche.

StreamReader fileAddress = File.OpenText(@"../../../addresses.csv");
List<Address> listAddress = new List<Address>();
fileAddress.ReadLine();

while (!fileAddress.EndOfStream)
{
    string riga = fileAddress.ReadLine();

    string[] split = riga.Split(',');

    try
    {
        string name = split[0];
        string surname = split[1];
        string street = split[2];
        string city = split[3];
        string province = split[4];
        int zip = int.Parse(split[5]);

        Address address = new Address(name, surname, street, city, province, zip);
        listAddress.Add(address);
        Console.WriteLine(address);
    }
    catch (Exception e)
    {
        if(split.Length < 6)
        {
            Console.WriteLine($"\nIndirizzo non valido (informazioni mancanti)-->{riga}\n");
        } else if(split.Length > 6)
        {
            Console.WriteLine($"\nIndirizzo non valido (informazioni in eccesso)-->{riga}\n");
        } else
        {
            Console.WriteLine(e);
        }
    }
}

fileAddress.Close();
