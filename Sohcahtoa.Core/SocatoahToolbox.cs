using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sohcahtoa.Core
{
  public class SocatoahToolbox
  {
    public static double DegreesToRadians(double angle)
    {
      return Math.PI * angle / 180.0;
    }

    public static double RadiansToDegrees(double angle)
    {
      return angle * (180.0 / Math.PI);
    }
  }
}
