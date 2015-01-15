using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sohcahtoa.Core;
using System.Diagnostics;

namespace Sohcahtoa.Testing
{
  [TestClass]
  public class TriangleRectangleUnitTest
  {
    [TestMethod]
    public void TestMethod()
    {
      TriangleRectangle triangle = new TriangleRectangle(SocatoahToolbox.DegreesToRadians(10.0), 15.0);
      Debug.Assert(triangle.Hypotenuse < 2.6450 && triangle.Hypotenuse > 2.6448);
      Debug.Assert(triangle.Oppose < 0.4595 && triangle.Oppose > 0.4590);
    }
  }
}
