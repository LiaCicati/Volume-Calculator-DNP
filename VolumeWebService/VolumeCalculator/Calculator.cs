using System;

namespace VolumeWebService.VolumeCalculator
{
    public class Calculator
    {
        public VolumeResult CalculateVolumeCylinder(double height, double radius)
        {
            return new VolumeResult()
            {
                Type = "cylinder",
                Height = height,
                Radius = radius,
                Volume = Math.PI * (radius * radius) * height
            };
        }

        public VolumeResult CalculateVolumeCone(double radius, double height)
        {
            return new VolumeResult()
            {
                Type = "cone",
                Height = height,
                Radius = radius,
                Volume = (1.0 / 3) * Math.PI * height * radius * radius
            };
        }
    }
}