using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Het account waarmee de gebruiker is ingelogd.
/// </summary>
public class Account
{
    #region properties
    public int ID
    {
        get;
        private set;
    }
    public string UserName
    {
        get;
        private set;
    }
    public string Email
    {
        get;
        private set;
    }
    #endregion

    #region Constructor
    public Account(int id, string username, string email)
	{
        this.ID = id;
        this.UserName = username;
        this.Email = email;
    }
    #endregion
}