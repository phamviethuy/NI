using System.Collections.Generic;
using System.Windows;
using System.Windows.Media.Media3D;

namespace NationalInstruments.Examples.NonUniformIntensity
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            double[] resolutions = new[] { 2.0, 1.0, 0.5 };
            var data = new List<List<Point3D>>(resolutions.Length);
            const int Radius = 6;
            foreach (double resolution in resolutions)
            {
                var current = new List<Point3D>();
                data.Add(current);

                double offset = (resolution / 2) % 1.0;
                for (int i = -Radius; i <= Radius; ++i)
                {
                    double x = i * resolution;
                    for (int j = -Radius; j <= Radius; ++j)
                    {
                        double y = j * resolution;
                        double z = x * y / 6;
                        current.Add(new Point3D(x + offset, y + offset, z));
                    }
                }
            }

            graph.DataSource = data;
        }
    }
}
