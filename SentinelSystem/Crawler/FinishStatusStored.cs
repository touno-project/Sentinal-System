﻿using System;
using System.Data;
using Travox.Sentinel.Engine;
using Travox.Systems;

namespace Travox.Sentinel.Crawler
{
    public class FinishStatusStored : Controller
    {
        public FinishStatusStored()
        {
            base.OnceTime = true;
            base.SetIntervel = new TimeSpan(0, 10, 0);
        }

        public override void Update()
        {   
            new DB("travox_system").StoredProcedure("sentinel.booking_status_finish");
            new DB("travox_system").StoredProcedure("sentinel.booking_status_payment");
            base.Update();
        }
    }
}
