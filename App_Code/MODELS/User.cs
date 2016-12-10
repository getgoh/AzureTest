﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for User
/// </summary>
public class User
{
    public static int Admin = 1;
    public static int Employee = 2;

    public User()
    {

    }

    public int UserId { get; set; }
    public string Username { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public int Type { get; set; }
    public int TotalIncome { get; set; }
    public int TotalTaxesPaid { get; set; }
    public int Contributions { get; set; }

}