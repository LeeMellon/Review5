using System.Collections.Generic;
using System;
using Addresses.Models;

namespace Streets.Models
{
    public class Street
    {
      private string _line1;
      private string _line2;
      private string _city;
      private string _state;
      private int _zipCode;
      private int _streetId;
      private int _addressId;
      private List<Street> _currentAddress = new List<Street>{};

      public Street(string line1, string line2, string city, string state, int zip, int addressId)
      {
        _line1 = line1;
        _line2 = line2;
        _city = city;
        _state = state;
        _zipCode = zip;
        _streetId = _currentAddress.Count;
        _addressId = addressId;
      }
    }
}
