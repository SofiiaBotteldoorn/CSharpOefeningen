namespace Linq
{
    public static class BoekService
    {
        public static List<Boek> BoekenLijst()
        {
            return new List<Boek>
            {
                new Boek { BoekId = 1, Titel = "Crime and Punishment", Auteur = "Fyodor Dostoevsky", Genre = "Roman", PaginaAantal = 671, Prijs = 19.99m },
                new Boek { BoekId = 2, Titel = "An American Tragedy", Auteur = "Theodore Dreiser", Genre = "Roman", PaginaAantal = 856, Prijs = 22.50m },
                new Boek { BoekId = 3, Titel = "Stad", Auteur = "Plato", Genre = "Filosofie", PaginaAantal = 300, Prijs = 14.99m },
                new Boek { BoekId = 4, Titel = "The Call of Cthulhu", Auteur = "H.P. Lovecraft", Genre = "Horror", PaginaAantal = 154, Prijs = 11.99m },
                new Boek { BoekId = 5, Titel = "The Shining", Auteur = "Stephen King", Genre = "Horror", PaginaAantal = 447, Prijs = 18.99m },
                new Boek { BoekId = 6, Titel = "De Politiek", Auteur = "Aristoteles", Genre = "Filosofie", PaginaAantal = 330, Prijs = 16.50m },
                new Boek { BoekId = 7, Titel = "Lord of the Flies", Auteur = "William Golding", Genre = "Roman", PaginaAantal = 224, Prijs = 13.99m },
                new Boek { BoekId = 8, Titel = "De Kleine Prins", Auteur = "Antoine de Saint-Exupéry", Genre = "Roman", PaginaAantal = 96, Prijs = 9.99m },
                new Boek { BoekId = 9, Titel = "War and Peace", Auteur = "Leo Tolstoy", Genre = "Roman", PaginaAantal = 1225, Prijs = 29.99m },
                new Boek { BoekId = 10, Titel = "The Brothers Karamazov", Auteur = "Fyodor Dostoevsky", Genre = "Roman", PaginaAantal = 824, Prijs = 24.99m },
                new Boek { BoekId = 11, Titel = "Murder on the Orient Express", Auteur = "Agatha Christie", Genre = "Detective", PaginaAantal = 256, Prijs = 12.99m },
                new Boek { BoekId = 12, Titel = "1984", Auteur = "George Orwell", Genre = "Dystopie", PaginaAantal = 328, Prijs = 15.99m },
                new Boek { BoekId = 13, Titel = "Pride and Prejudice", Auteur = "Jane Austen", Genre = "Roman", PaginaAantal = 432, Prijs = 14.50m },
                new Boek { BoekId = 14, Titel = "Sapiens", Auteur = "Yuval Noah Harari", Genre = "Geschiedenis", PaginaAantal = 443, Prijs = 24.99m },
                new Boek { BoekId = 15, Titel = "Brave New World", Auteur = "Aldous Huxley", Genre = "Dystopie", PaginaAantal = 311, Prijs = 17.50m }
             };

        }
        public static void ToonBoekenOnder15Euro(List<Boek> boeken)
        {
            //De titels, auteurs en prijzen van alle boeken die minder dan 15 euro kosten, gesorteerd op prijs stijgend.
            Console.WriteLine("Boeken die minder dan 15 euro kosten:");
            var boekenOnder15Euro = from boek in boeken
                                    where boek.Prijs < 15m
                                    orderby boek.Prijs ascending
                                    select boek;
            foreach (var boek in boekenOnder15Euro)
            {
                Console.WriteLine($" \"{boek.Titel}\" {boek.Auteur} - {boek.Prijs} euro");
            }


            //---------Met lambda-expresions-------//
            /*var resultaat = boeken.Where(boek => boek.Prijs < 15m).OrderBy(boek => boek.Prijs);
            foreach(var boek in resultaat)
            {
                Console.WriteLine($" \"{boek.Titel}\" {boek.Auteur} - {boek.Prijs} euro");
            }*/
        }

        public static void ToonAantalBoekenPerGenre(List<Boek> boeken)
        {
            //Aantal boeken per genre.
            Console.WriteLine("Aantal boeken per genre:");
            var genresMetBoeken = from boek in boeken
                                  group boek by boek.Genre
                                   into genregroep
                                  orderby genregroep.Key
                                  select new
                                  {
                                      Genre = genregroep.Key,
                                      AantalBoeken = genregroep.Count()
                                  };
            foreach (var groep in genresMetBoeken)
            {
                Console.WriteLine($"{groep.Genre}: {groep.AantalBoeken}");
            }

            //---------Met lambda-expresions-------//

            /*var genres = boeken.GroupBy(boek => boek.Genre)
                                  .OrderBy(groep => groep.Key)
                                  .Select(groep => new { groep.Key, AantalBoeken = groep.Count() });
            foreach (var groep in genres)
            {
                Console.WriteLine($"{groep.Key}: {groep.AantalBoeken}");
            }*/
        }

        public static void ToonGemmideldePrijsVanAlleBoeken(List<Boek> boeken)
        {
            //Gemiddelde prijs van alle boeken
            Console.WriteLine("De gemiddelde prijs van alle boeken:");
            Console.WriteLine(boeken.Average(boek => boek.Prijs).ToString("0.00 euro"));
        }
        public static void ToonGemmideldeEnHoogstePrijsRoman(List<Boek> boeken)
        {
            //Gemiddelde prijs en de hoogste prijs van boeken in het genre "Roman".
            var romanen = from boek in boeken
                          where boek.Genre == "Roman"
                          select boek.Prijs;
            Console.WriteLine($"Roman. Gemmidelde prijs: {romanen.Average():0.00} euro. Hoogste prijs: {romanen.Max()} euro");

            //---------Met lambda-expresions-------//
           /* var romanLijst = boeken.Where(boek => boek.Genre == "Roman").Select(boek => boek.Prijs);
            Console.WriteLine($"Roman - Gemiddeld: {romanLijst.Average():0.00} euro, Max: {romanLijst.Max():0.00} euro");
            */
        }

        public static void ToonBoekenMetMeerDan500Paginas(List<Boek> boeken)
        {
            //Titels van alle boeken die meer dan 500 pagina's hebben
            Console.WriteLine("Die boeken meer dan 500 pagina's hebben:");
            var boekenMetMeerDan500Paginas = from boek in boeken
                                             where boek.PaginaAantal > 500
                                             select boek.Titel;
            foreach (var boek in boekenMetMeerDan500Paginas)
            {
                Console.WriteLine(boek);
            }

            //---------Met lambda-expresions-------//
           /* foreach (var titel in boeken.Where(boek => boek.PaginaAantal > 500).Select(boek => boek.Titel))
                Console.WriteLine(titel);
           */
        }

        public static void ToonBoekenDieBeginMetTStarten(List<Boek> boeken)
        {
            //Alle boeken die beginnen met de letter "T"
            Console.WriteLine("Alle boeken die beginnen met de letter \"T\":");
            var boekenDieMetTStarten = from boek in boeken
                                       where boek.Titel.StartsWith('T')
                                       select boek;
            foreach (var boek in boekenDieMetTStarten)
            {
                Console.WriteLine($"  -  {boek.Titel}");
            }

            //---------Met lambda-expresions-------//
            /*foreach(var boek in boeken.Where(boek => boek.Titel.StartsWith('T')))
                Console.WriteLine($"  -  {boek.Titel}");
            */
        }

        public static void ToonUniekeGenres(List<Boek> boeken)
        {
            //Lijst van unieke genres (alle genres zonder dubbels)
            Console.WriteLine("Unieke genres:");
            var genres = (from boek in boeken
                          select boek.Genre).Distinct();
            foreach (var genre in genres)
            {
                Console.WriteLine(genre);
            }

            //---------Met lambda-expresions-------//
            /*foreach (var genre in boeken.Select(boek => boek.Genre).Distinct())
                Console.WriteLine(genre);
            */
        }

        public static void ToonBoekenPerGenre(List<Boek> boeken)
        {
            //Naam van het genre
            //Aantal boeken in dat genre
            //Gemiddelde prijs van de boeken in dat genre
            //De boeken van dat genre, gesorteerd alfabetisch op titel
            Console.WriteLine("Boeken per genre en gemmidelde prijs:");
            var boekenPerGenre = from boek in boeken
                                 group boek by boek.Genre
                                 into genregroep
                                 orderby genregroep.Key
                                 select new
                                 {
                                     Genre = genregroep.Key,
                                     AantalBoeken = genregroep.Count(),
                                     GemmideldePrijs = genregroep.Average(boek => boek.Prijs),
                                     Naam = genregroep.OrderBy(boek => boek.Titel)
                                 };
            foreach (var groep in boekenPerGenre)
            {
                Console.WriteLine($"Genre: {groep.Genre}");
                Console.WriteLine($"Aantal boeken: {groep.AantalBoeken}");
                Console.WriteLine($"Gemmidelde prijs: {groep.GemmideldePrijs:0.00} euro");
                Console.WriteLine($"Boeken:");
                foreach (var boek in groep.Naam)
                {
                    Console.WriteLine($"  -  \"{boek.Titel}\" {boek.Auteur}");
                }
                Console.WriteLine();
            }

            //---------Met lambda-expresions-------//
            /*var groepen = boeken.GroupBy(boek => boek.Genre)
                                .OrderBy(groep => groep.Key)
                                .Select(groep => new
                                {
                                    groep.Key,
                                    Aantal = groep.Count(),
                                    GemiddeldePrijs = groep.Average(boek => boek.Prijs),
                                    Boeken = groep.OrderBy(boek => boek.Titel)
                                });

            foreach (var groep in groepen)
            {
                Console.WriteLine($"{groep.Key} ({groep.Aantal} boek(en), {groep.GemiddeldePrijs:0.00} euro gemiddeld)");
                foreach (var boek in groep.Boeken)
                    Console.WriteLine($"- \"{boek.Titel}\" van {boek.Auteur}");
            }
            */
        }
        public static void ToonDuursteBoekenPerGenre(List<Boek> boeken)
        {
            //Hoogste prijs binnen elk genre
            Console.WriteLine("De duurste boek per genre:");
            var duursteBoeken = from boek in boeken
                                group boek by boek.Genre
                          into boekgenres
                                select new
                                {
                                    Genre = boekgenres.Key,
                                    maxPrijs = boekgenres.Max(boek => boek.Prijs)
                                };
            foreach (var groep in duursteBoeken)
            {
                Console.WriteLine(groep.Genre);
                Console.WriteLine($"    {groep.maxPrijs} euro");
            }


            //---------Met lambda-expresions-------//
            /*var duurste = boeken.GroupBy(boek => boek.Genre).Select(groep => groep.OrderByDescending(boek => boek.Prijs).First());
            foreach (var boek in duurste)
                Console.WriteLine($"{boek.Genre}: {boek.Titel} ({boek.Prijs:0.00} euro)");
            */
        }
        public static void ToonBoekenOpAuteursNaam(List<Boek> boeken)
        {
            //Alle boeken alfabetisch op auteur
            Console.WriteLine("Alle boeken alfabetisch op auteurs naam: \n");
            var opAuteur = from boek in boeken
                           orderby boek.Auteur
                           select boek;
            foreach (var boek in opAuteur)
            {
                Console.WriteLine($"{boek.Auteur} \"{boek.Titel}\", {boek.Genre}  -  {boek.Prijs} euro");
            }

            //---------Met lambda-expresions-------//
            /*foreach(var boek in boeken.OrderBy(boek => boek.Auteur))
                Console.WriteLine($"{boek.Auteur} \"{boek.Titel}\", {boek.Genre}  -  {boek.Prijs} euro");
            */
        }
        public static void ToonBoekenPerGenreOpPrijs(List<Boek> boeken)
        {
            //Genres, boeken gegroepeerd op genre, de titels gesorteerd op prijs dalend.
            Console.WriteLine("Van het duurste tot het goedkoopste boek per genre: ");
            var perGenre = from boek in boeken
                           group boek by boek.Genre
                           into genregroep
                           orderby genregroep.Key
                           select new
                           {
                               Genre = genregroep.Key,
                               Boeken = genregroep.OrderByDescending(boek => boek.Prijs)
                           };
            foreach (var groep in perGenre)
            {
                Console.WriteLine(groep.Genre.ToUpper());
                foreach (var boek in groep.Boeken)
                {
                    Console.WriteLine($"  -  \"{boek.Titel}\" {boek.Prijs} euro");
                }
            }

            //---------Met lambda-expresions-------//
            /*var groepen = boeken.GroupBy(boek => boek.Genre).OrderBy(groep => groep.Key);
            foreach(var groep in groepen)
            {
                Console.WriteLine($"{groep.Key.ToUpper()}:");
                foreach (var boek in groep.OrderByDescending(b => b.Prijs))
                    Console.WriteLine($"- {boek.Titel} ({boek.Prijs:0.00} euro)");
                Console.WriteLine();
            }
            */
        }
    }
}
