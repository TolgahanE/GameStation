using System;


namespace GameStation
{
    class CustomerManager
    {
        UserValiditionService userValiditionService;

        public CustomerManager(UserValiditionService userValiditionService)
        {
            this.userValiditionService = userValiditionService;
        }

        public void Register(CustormerEntitys custormerEntitys)
        {
            if(userValiditionService.Valitade(custormerEntitys)==true)
            Console.WriteLine(custormerEntitys.Name + " Listeye Eklendi.");
            else
            Console.WriteLine(custormerEntitys.Name + " Listeye Eklenemedi.");
        }


        public void Del(CustormerEntitys custormerEntitys)
        {
            Console.WriteLine(custormerEntitys.Name + "Listeyi Sildi.");

        }

    }
}
