using System;


namespace GameStation
{
    class NewAccountSale : ISaleManager
    {
        public void Sale(GamesEntity gamesEntity)
        {
            double NewPrice = gamesEntity.Price * 0.75;

            Console.WriteLine(gamesEntity.Name + " Yeni Hesap İndirimi Uygulandı.\n" + "Oyun Fiyatı : " + gamesEntity.Price + "TL" + "\nYeni Oyun Fiyatı : " + NewPrice + "TL");
        }
    }
}
