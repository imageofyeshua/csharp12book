using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class DeviceManager
{
    public void TurnOff(Computer device)
    {
        device.Shutdown();
    }
}