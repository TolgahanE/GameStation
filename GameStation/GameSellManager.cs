using System;


namespace GameStation
{
    class GameSellManager
    {
        public void Sell(CustormerEntitys custormerEntitys,GamesEntity gamesEntity)
        {
            Console.WriteLine(custormerEntitys.Name +" İsimli Üye "+ gamesEntity.Name + " Oyununu Satın Aldı.");
        }

    }
}
