﻿using System.Collections.Generic;
using HotelBeds.Shared.TransferContent.Dto;

namespace HotelBeds.Shared.TransferContent.Response
{
    public class RouteResponse : BaseResponse
    {
        public List<Route> Routes { get; set; }
    }
}