using System;
using System.Collections.Generic;

using Grasshopper.Kernel;
using Rhino.Geometry;
using Sohcahtoa.Core;

namespace Sohcahtoa.Grasshopper
{
  public class SohcahtoaGrasshopperComponent : GH_Component
  {
    /// <summary>
    /// Each implementation of GH_Component must provide a public 
    /// constructor without any arguments.
    /// Category represents the Tab in which the component will appear, 
    /// Subcategory the panel. If you use non-existing tab or panel names, 
    /// new tabs/panels will automatically be created.
    /// </summary>
    public SohcahtoaGrasshopperComponent()
      : base("ConstructTriangle", "CTri",
          "Description",
          "Sohcahtoa", "General")
    {
    }

    /// <summary>
    /// Registers all the input parameters for this component.
    /// </summary>
    protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
    {
      pManager.AddNumberParameter("Adjacent", "Adj.", "The length of the adjacent side.", GH_ParamAccess.item);
      pManager.AddAngleParameter("Angle", "Ang.", "The angle of the triangle.", GH_ParamAccess.item);
    }

    /// <summary>
    /// Registers all the output parameters for this component.
    /// </summary>
    protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
    {
      pManager.AddNumberParameter("Opposite", "O", "The length of the opposite side.", GH_ParamAccess.item);
      pManager.AddBrepParameter("Triangle", "T", "The resulting triangle.", GH_ParamAccess.item);
    }

    /// <summary>
    /// This is the method that actually does the work.
    /// </summary>
    /// <param name="DA">The DA object can be used to retrieve data from input parameters and 
    /// to store data in output parameters.</param>
    protected override void SolveInstance(IGH_DataAccess DA)
    {
      double adjacent = 0;
      DA.GetData<double>("Adjacent", ref adjacent);
      double angle = 0;
      DA.GetData<double>("Angle", ref angle);
      TriangleRectangle triangle = new TriangleRectangle(angle, adjacent);
      DA.SetData(0, triangle.Oppose);
      Point3d a = new Point3d(0, 0, 0);
      Point3d b = new Point3d(adjacent, 0, 0);
      Point3d c = new Point3d(adjacent, triangle.Oppose, 0);
      Surface triangleSurface = Brep.CreateFromCornerPoints(a, b, c, a, double.Epsilon).Surfaces[0];
      DA.SetData(1, triangleSurface);
    }

    /// <summary>
    /// Provides an Icon for every component that will be visible in the User Interface.
    /// Icons need to be 24x24 pixels.
    /// </summary>
    protected override System.Drawing.Bitmap Icon
    {
      get
      {
        // You can add image files to your project resources and access them like this:
        //return Resources.IconForThisComponent;
        return null;
      }
    }

    /// <summary>
    /// Each component must have a unique Guid to identify it. 
    /// It is vital this Guid doesn't change otherwise old ghx files 
    /// that use the old ID will partially fail during loading.
    /// </summary>
    public override Guid ComponentGuid
    {
      get { return new Guid("{e73ce59a-d642-4be4-b8bf-62a43de6f3d9}"); }
    }
  }
}
