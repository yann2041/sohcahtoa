using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sohcahtoa.Core
{
  public class TriangleRectangle
  {
    private double _oppose;

    private double _hypotenuse;

    private double _adjacent;

    private double _angle;

    public TriangleRectangle(double angle, double adjacent)
    {
      _adjacent = adjacent;
      Angle = angle;
    }

    public double Oppose
    {
      get { return _oppose; }
      set
      {
        _oppose = value;
        _hypotenuse = Math.Sqrt(_oppose * _oppose + _adjacent * _adjacent);
        _angle = Math.Asin(Sinus(_oppose, _hypotenuse));
      }
    }

    public double Hypotenuse
    {
      get { return _hypotenuse; }
      set
      {
        _hypotenuse = value;
        _adjacent = Math.Cos(_angle) * _hypotenuse;
        _oppose = Math.Sqrt(_hypotenuse * _hypotenuse - _adjacent * _adjacent);
      }
    }

    public double Adjacent
    {
      get { return _adjacent; }
      set
      {
        _adjacent = value;
        _hypotenuse = _adjacent / Math.Cos(_angle);
        _oppose = Math.Sqrt(_hypotenuse * _hypotenuse - _adjacent * _adjacent);
      }
    }

    public double Angle
    {
      get { return _angle; }
      set
      {
        _angle = value;
        _hypotenuse = _adjacent / Math.Cos(_angle);
        _oppose = _hypotenuse * Math.Sin(_angle);

      }
    }

    public static double Sinus(double oppose, double hypotenuse)
    {
      return oppose / hypotenuse;
    }

    public static double Cosinus(double adjacent, double hypotenuse)
    {
      return adjacent / hypotenuse;
    }

    public static double Tangente(double oppose, double adjacent)
    {
      return oppose / adjacent;
    }
  }
}
