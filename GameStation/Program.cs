namespace GameStation
{
    class Program
    {
        static void Main(string[] args)
        {
            CustormerEntitys custormerEntitys = new CustormerEntitys()
            {
                Nidentity = "1",
                Name = "Tolgahan",
                Surname = "Erbabi",
                BirthYear = 1996
            };

            GameSellManager gameSellManager = new GameSellManager();

            UserValiditionService userValiditionService = new UserValiditionService();
            GamesEntity fifa21 = new GamesEntity();
            fifa21.Name = "Fifa 21";
            fifa21.Price = 350;

            GamesEntity pes21 = new GamesEntity();
            pes21.Name = "Pes 21";
            pes21.Price = 100;

            GamesEntity nba2k21 = new GamesEntity();
            nba2k21.Name = "Nba 2k 21";
            nba2k21.Price = 250;

            CustomerManager customerManager = new CustomerManager(userValiditionService);
            customerManager.Register(custormerEntitys);

            ISaleManager newAccountSale = new NewAccountSale();
            ISaleManager newYearSale = new NewYearSale();

            newAccountSale.Sale(nba2k21);
            gameSellManager.Sell(custormerEntitys,nba2k21);
        }
    }
}
