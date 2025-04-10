namespace StadPostcode
{
    public class PostcodesInfo
    {
        public int Postcode(string inputStad)
        {
            string bestand = Path.Combine(AppContext.BaseDirectory, "postcodes.txt");
            using (StreamReader lezer = new StreamReader(bestand))
            {
                string? regel;
                while ((regel = lezer.ReadLine()) != null)
                {
                    int streepje = regel.IndexOf('-');
                    string stad = regel.Substring(0, streepje - 1);
                    if (stad.ToLower() == inputStad.Trim().ToLower())
                        return int.Parse(regel.Substring(streepje + 2));
                }
            }
            throw new Exception($"Stad {inputStad} is niet gevonden.");
        }
    }
}
