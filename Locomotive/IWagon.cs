﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locomotive
{
    public interface IWagon
    {
        bool ConnectToTrain(Train train);
        bool DisconnectFromTrain(Train train);
        string ToString();
    }
}
