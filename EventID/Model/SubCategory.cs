
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace EventID.Model
{

using System;
    using System.Collections.Generic;
    
public partial class SubCategory
{

    public int SubCategoryID { get; set; }

    public int ProductCategoryID { get; set; }

    public string SubCategoryName { get; set; }



    public virtual ProductCategory ProductCategory { get; set; }

}

}
