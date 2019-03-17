using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Models
{
    public interface IClock
    {
        string GetTime();
    }

    public class LocalClock : IClock
    {
        public string GetTime()
        {
            return $"The local time is {DateTime.Now}";
        }
    }
}
