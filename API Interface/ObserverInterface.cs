﻿using System;
using System.Collections.Generic;
using System.Text;
using SeaLevelBroadcast.Models;
using SeaLevelBroadcast.SensorDevice;

namespace SeaLevelBroadcast.BusinessLogic {
  interface IObserver {
  public string GetDataFromObject();
  }
}