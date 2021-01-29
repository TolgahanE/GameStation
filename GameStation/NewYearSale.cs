using System;


namespace GameStation
{
    class NewYearSale : ISaleManager
    {
        public void Sale(GamesEntity gamesEntity)
        {
            double NewPrice = gamesEntity.Price * 0.5;

            Console.WriteLine(gamesEntity.Name + " Yeni Yıl İndirimi Uygulandı.\n" + "Oyun Fiyatı : " + gamesEntity.Price + "TL" + "\nYeni Oyun Fiyatı : " + NewPrice + "TL");
        }
    }
}
