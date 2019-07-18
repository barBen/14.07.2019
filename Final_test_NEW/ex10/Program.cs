using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            IWindow basic = new BaseWindow();
            Console.WriteLine(basic.GetDetails());

            IWindow basicReflection = new SemiReflectionDecoration(basic);
            Console.WriteLine(basicReflection.GetDetails());

            IWindow basicReflection3D = new ThreeDimensionLightDecoration(basicReflection);
            Console.WriteLine(basicReflection3D.GetDetails());

            IWindow basicReflection3DShadowing = new ShadowingDecoration(basicReflection3D);
            Console.WriteLine(basicReflection3DShadowing.GetDetails());

            IWindow basicReflection3DShadowingFlicker = new FlickeringBackgroundDecoration(basicReflection3DShadowing);
            Console.WriteLine(basicReflection3DShadowingFlicker.GetDetails());

            IWindow basicReflection3DShadowingFlickerColorful = new ColorfulFrameDecoration(basicReflection3DShadowingFlicker);
            Console.WriteLine(basicReflection3DShadowingFlickerColorful.GetDetails());

            Console.WriteLine("");
            IWindow basicReflectionColorful = new ColorfulFrameDecoration(basicReflection);
            Console.WriteLine(basicReflectionColorful.GetDetails());
        }
    }
}
