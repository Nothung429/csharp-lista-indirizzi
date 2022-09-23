public class Address
{
    public string name;
    public string surname;
    public string street;
    public string city;
    public string province;
    public int zip;
    public Address(string name, string surname, string street, string city, string province, int zip)
    {
        this.name = name;
        this.surname = surname;
        this.street = street;
        this.city = city;
        this.province = province;
        this.zip = zip;
    }
    public override string ToString()
    {
        string line = "//-----------------Indirizzo-----------------//\n";
        line += "Nome: " + name + "\n";
        line += "Cognome: " + surname + "\n";
        line += "Indirizzo: " + street + "\n";
        line += "Città: " + city + "\n";
        line += "Provincia: " + province + "\n";
        line += "CAP: " + zip + "\n";
        line += "//-----------------*********-----------------//\n";

        return line;
    }
}