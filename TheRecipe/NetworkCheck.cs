using System;
using Plugin.Connectivity;

namespace TheRecipe
{
    public class NetworkCheck
    {
        public static bool IsInternet()
        {
            if(CrossConnectivity.Current.IsConnected)
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
