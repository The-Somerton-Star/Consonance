using Heartart.Interactivity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heartart.Interfaces
{
    interface IReception
    {
        // Takes peas and returns pods
        Coincidence Oracle(char pea);
        Coincidence Yonder(char pea);
        Coincidence Star(char pea);
        Coincidence ECOcloud(char pea);
        Coincidence Community(char pea);
    }
}
