namespace GameStation
{
    class UserValiditionService : IUserValiditionService
    {
        
        public bool Valitade(CustormerEntitys custormerEntitys)
        {
            if(custormerEntitys.Name == "Tolgahan")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
