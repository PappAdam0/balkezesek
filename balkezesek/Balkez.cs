namespace balkezesek
{
    internal class Balkez
    {

        public string Nev { get; private set; }
        public string Elso { get; private set; }
        public string Utolso { get; private set; }
        public int Suly { get; private set; }
        public int Magassag { get; private set; }
        public Balkez(string sor)
        {
            string[] adat = sor.Split(';');
            Nev = adat[0];
            Elso = adat[1];
            Utolso = adat[2];
            Suly = int.Parse(adat[3]);
            Magassag = int.Parse(adat[4]);
        }
    }
}