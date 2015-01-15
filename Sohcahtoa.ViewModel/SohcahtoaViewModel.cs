using GalaSoft.MvvmLight;
using Sohcahtoa.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sohcahtoa.ViewModel
{
    public class SohcahtoaViewModel : ViewModelBase
    {
      private TriangleRectangle _triangle = new TriangleRectangle(SocatoahToolbox.DegreesToRadians(30.0), 10.0);

      public double Angle
      {
        get
        {
          return SocatoahToolbox.RadiansToDegrees(_triangle.Angle);
        }
        set
        {
          _triangle.Angle = SocatoahToolbox.DegreesToRadians(value);
          RaisePropertyChanged("Angle");
          RaisePropertyChanged("Hypotenuse");
          RaisePropertyChanged("Oppose");
        }
      }
       
      public double Hypotenuse
        {
          get
          {
            return _triangle.Hypotenuse;
          }
          set
          {
            _triangle.Hypotenuse = value;
            RaisePropertyChanged("Hypotenuse");
            RaisePropertyChanged("Adjacent");
            RaisePropertyChanged("Oppose");
          }
        }
      public double Oppose
      {
        get
        {
          return _triangle.Oppose;
        }
        set
        {
          _triangle.Oppose = value;
          RaisePropertyChanged("Oppose");
          RaisePropertyChanged("Hypotenuse");
          RaisePropertyChanged("Angle");
        }
      }
      public double Adjacent
      {
        get
        {
          return _triangle.Adjacent;
        }
        set
        {
          _triangle.Adjacent = value;
          RaisePropertyChanged("Adjacent");
          RaisePropertyChanged("Oppose");
          RaisePropertyChanged("Hypotenuse");
        }
      }
    }
}
