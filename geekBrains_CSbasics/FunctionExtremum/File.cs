namespace FunctionExtremum
{
    internal class File
    {
        public static void Create(string fileName, double start, double end, double step, Functions.Function function)
        {
            using FileStream fs = new(fileName, FileMode.Create, FileAccess.Write);
            using BinaryWriter writer = new(fs);

            while (start <= end)
            {
                writer.Write(function(start));
                start += step;
            }
        }

        public static double Load(string fileName)
        {
            using FileStream fs = new (fileName, FileMode.Open, FileAccess.Read);
            using BinaryReader reader = new (fs);
            double min = double.MaxValue;
            for(int i = 0; i < fs.Length / sizeof(double); i++)
            {
                double d = reader.ReadDouble();
                if (d < min)
                    min = d;
            }
            return min;
        }

        public static double[] LoadValues(string fileName, out double min)
        {
            using FileStream fs = new(fileName, FileMode.Open, FileAccess.Read);
            using BinaryReader reader = new(fs);
           
            double[] values = new double[fs.Length/ sizeof(double)];
            min = double.MaxValue;
            for( int i = 0; i < fs.Length / sizeof(double); i++)
            {
                double d = reader.ReadDouble();
                values[i] = d;
                if (d < min)
                    min = d;
            }
            return values;
        }
    }
}
