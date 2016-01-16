using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Handler
/// </summary>
public class Handler
{
    #region Fields
    private static Handler instance;
    private Database db;
    #endregion

    #region Properties
    public Account User;
    public List<ProductItem> Products;
    public int Type;
    #endregion

    #region Constructor
    public Handler()
	{
        db = new Database();
        Products = new List<ProductItem>();
	}

    public static Handler Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Handler();
            }
            return instance;
        }
    }
    #endregion

    #region Methodes
    public bool LogIn(string username, string password)
    {
        User = db.LogIn(username, password);
        if (User != null)
        {
            return true;
        }
        return false;
    }
    public void GetProducts()
    {
        Products = db.GetProducts(Type);
    }
    #endregion
}