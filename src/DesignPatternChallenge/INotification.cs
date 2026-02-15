using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternChallenge
{
    public interface INotification
    {
        void Send(string recipient, string subject, string body);
    }
}
