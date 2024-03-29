﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SeaLevelBroadcast.Models {
  class Observer : IObserver {
    event UpdateObserver IObserver.ObserverEvent {
      add {
        _database.AllObserversEvent += value;
      }
      remove {
        _database.AllObserversEvent -= value;
      }
    }
    private ObserversDatabase _database;
    private int _id;
    private string _username;
    private string _function;
    private SeaLevel _seaLevelData;

    void IObserver.UpdateData(SeaLevel newSeaLevel) {
      _seaLevelData = newSeaLevel;
    }

    internal int ID { get { return _id; } }
    internal string Function { get { return _function; } }
    string IObserver.Username { get { return _username; } }
    SeaLevel IObserver.SeaLevelData { get { return _seaLevelData; } }

    void IObserver.InputObserverData(int id, string username, string function) {
      _id = id;
      _username = username;
      _function = function;
    }

    internal Observer(ObserversDatabase all) {
      _database = all;
    }
  }
}
