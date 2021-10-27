using System.Drawing;

namespace Abobului_Ioan_3131_B_Lab_2
{
    internal class Punct
    {
        private int X;
        private int Y;
        private int Z;
        private Color pointColor = Color.OrangeRed;

        public Punct()
        {
        }

        public Punct(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Punct(int x, int y, int z, Color color)
        {
            X = x;
            Y = y;
            Z = z;
            pointColor = color;
        }

        public void setColor(Color color)
        {
            pointColor = color;
        }

        public void setX(int x)
        {
            X = x;
        }

        public void setY(int y)
        {
            Y = y;
        }

        public void setZ(int z)
        {
            Z = z;
        }

        public Color getColor()
        {
            return pointColor;
        }

        public int getX()
        {
            return X;
        }

        public int getY()
        {
            return Y;
        }

        public int getZ()
        {
            return Z;
        }
    }
}