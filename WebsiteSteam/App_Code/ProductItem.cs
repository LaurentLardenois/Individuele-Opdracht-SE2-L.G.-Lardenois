using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Alle producten die worden opgehaald zijn een instantie van dit object.
/// </summary>
public class ProductItem
{
    #region Properties
    public int ID
    {
        get;
        private set;
    }
    public string Name
    {
        get;
        private set;
    }
    public string Description 
    { 
        get; 
        private set;
    }
    public string About
    {
        get;
        private set;
    }
    public decimal Price
    {
        get;
        private set;
    }
    public DateTime ReleaseDate
    {
        get;
        private set;
    }
    #endregion

    #region Constructor
    public ProductItem(int id, string name, string description, string about, decimal price, DateTime releaseDate)
	{
        this.ID = id;
        this.Name = name;
        this.Description = description;
        this.About = about;
        this.Price = price;
        this.ReleaseDate = releaseDate;
    }
    #endregion
}