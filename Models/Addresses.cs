using System.Collections.Generic;
using System;


namespace Addresses.Models
{
    public class Address
    {
      private string _name;
      private string _address;
      private long _number;
      private static List<Address> _book = new List<Address>{};
      private int _id;


      public Address(string name, string address, long number)
      {
        _name = name;
        _address = address;
        _number = number;
        _id = _book.Count;
      }

      public void SetName(string newName)
      {
        _name = newName;
      }

      public string GetName()
      {
        return _name;
      }

      public void SetAddress(string newAddress)
      {
        _address = newAddress;
      }

      public string GetAddress()
      {
        return _address;
      }

      public void SetNumber(long newNumber)
      {
        _number = newNumber;
      }

      public long GetNumber()
      {
        return _number;
      }

      public int GetId()
      {
        return _id;
      }

      public static List<Address> GetAll()
      {
        return _book;
      }

      public static void ClearAll()
      {
        _book.Clear();

      }

      public void AddressSave()
      {
        _book.Add(this);
      }

      public static Address Find(int id)
      {
        return _book[id];
      }

      public void RemoveOne()
      {
        _book.Remove(this);
      }

    }


}
