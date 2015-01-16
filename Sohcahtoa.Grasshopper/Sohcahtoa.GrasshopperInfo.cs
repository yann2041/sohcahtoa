using System;
using System.Drawing;
using Grasshopper.Kernel;

namespace Sohcahtoa.Grasshopper
{
  public class SohcahtoaGrasshopperInfo : GH_AssemblyInfo
  {
    public override string Name
    {
      get
      {
        return "Sohcahtoa";
      }
    }
    public override Bitmap Icon
    {
      get
      {
        //Return a 24x24 pixel bitmap to represent this GHA library.
        return null;
      }
    }
    public override string Description
    {
      get
      {
        //Return a short string describing the purpose of this GHA library.
        return "";
      }
    }
    public override Guid Id
    {
      get
      {
        return new Guid("3677bc4d-2e45-4d2f-b2ba-5e16c90daa8e");
      }
    }

    public override string AuthorName
    {
      get
      {
        //Return a string identifying you or your company.
        return "";
      }
    }
    public override string AuthorContact
    {
      get
      {
        //Return a string representing your preferred contact details.
        return "";
      }
    }
  }
}
