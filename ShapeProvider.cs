using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Abstract
{
  public class ShapeProvider
    {
public Shape GetShape(string shapeType)
        {
            switch (shapeType) {
                case "circle":
                    return new Circle(4);
                case "rectangle":
                    return new Rectangle(3, 4);

                 default:
                    return new Circle(4);
                    break;     
            
            }
           
        }

    }
}
