using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryApp.Models
{
    public enum Productivity : byte
    {
        SUBANSAMBLY = 0,
        FINISHED = 1,
        NONPRODUCTIVE = 2
    }
    public static class ProductivityMethods
    {
        public static string GetString(Productivity productivity)
        {
            switch(productivity)
            {
                case Productivity.SUBANSAMBLY:
                    return "Subansambly";
                case Productivity.FINISHED:
                    return "Finished";
                case Productivity.NONPRODUCTIVE:
                    return "Non-productive";
                default:
                    return "Subansambly";
            }
        }
    }
}
