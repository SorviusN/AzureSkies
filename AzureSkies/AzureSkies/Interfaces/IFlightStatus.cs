﻿using AzureSkies.DTO;
using AzureSkies.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureSkies.Interfaces
{
    public interface IFlightStatus
    {
        // Get Flight data from API
        // public Task<FlightDTO> GetFlight(NewSMSFlightDTO newSMSFlightDTO);

        public Task AddFlight(string message, string phoneNumber);

        public Task GetFlights();

        public Task Delete(int id);
    }
}
