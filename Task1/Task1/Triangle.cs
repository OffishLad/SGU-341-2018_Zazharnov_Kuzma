using System;

namespace Task1
{
    class Triangle
    {
        #region fields
        private Point a;
        private Point b;
        private Point c;
        #endregion
        public Triangle(Point a, Point b, Point c)
        {
            ChangeVertexes(a, b, c);
        }

        public Triangle(double ax, double ay, double bx, double by, double cx, double cy)
            : this(new Point(ax, ay), new Point(bx, by), new Point(cx, cy))
        { }

        public Point FirstPoint
        {
            get
            {
                return a;
            }
            set
            {
                if (IsCorrect(value, b, c))
                {
                    a = value;
                }
            }
        }
        public Point SecondPoint
        {
            get
            {
                return b;
            }
            set
            {
                if (IsCorrect(a, value, c))
                {
                    b = value;
                }
            }
        }
        public Point ThirdPoint
        {
            get
            {
                return c;
            }
            set
            {
                if (IsCorrect(a, b, value))
                {
                    c = value;
                }
            }
        }

        public double Area()
        {
            double A = GetLenth(a, b);
            double B = GetLenth(b, c);
            double C = GetLenth(a, c);
            double P = (A + B + C)/2;      //Полупериметр 
            return Math.Sqrt(P * (P - A) * (P - B) * (P - C));
        }
        public double Peremeter()
        {
            return GetLenth(a, b) + GetLenth(a, c) + GetLenth(b, c);
        }

        public void ChangeVertexes(Point a, Point b, Point c)
        {
            if (IsCorrect(a, b, c))
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
        }

        private bool IsCorrect(Point a, Point b, Point c)     //Проверяет треугольник на невырожденность
        {
            if (a == null)
            {
                throw new ArgumentNullException(nameof(a));
            }
            if (b == null)
            {
                throw new ArgumentNullException(nameof(b));
            }
            if (c == null)
            {
                throw new ArgumentNullException(nameof(c));
            }
            if (GetLenth(a, b) == 0 || GetLenth(b, c) == 0 || GetLenth(a, c) == 0)
            {
                throw new ArgumentException("Треугольник вырожденный");
            }

            return true;
        }

        public static double GetLenth(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }
    }
}
