﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static FlightService.Libs.Models.Flight;

namespace FlightService.Libs.Services
{
    public interface IFlightService
    {
        Task<RootObject> GetFlightFromParameters(string airport, int howMany, string filter, int offset);
    }
}
