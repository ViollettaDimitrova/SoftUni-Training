namespace Task1
{
    using System;
   
    public class Box
    {
        private decimal height;
        private decimal width;
        private decimal length;

        public Box(decimal height, decimal width, decimal length)
        {
            this.Height = height;
            this.Width = width;
            this.Length = length;
        }

        public decimal Height
        {
            get
            {
                return height;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new Exception($"{nameof(Height)} cannot be zero or negative.");
                }

                this.height = value;
            }
        }

        public decimal Width
        {
            get
            {
                return width;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new Exception($"{nameof(Width)} cannot be zero or negative.");
                }

                this.width = value;
            }
        }


        public decimal Length
        {
            get
            {
                return length;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new Exception($"{nameof(Length)} cannot be zero or negative.");
                }

                this.length = value;
            }
        }

        public string SurfaceArea()
        {
            decimal surfaceArea = 2 * this.Length * this.Width + 2 * this.Length * this.Height + 2 * this.Width * this.Height;
            return $"Surface Area - {surfaceArea:F2}";
        }

        public string LateralSurfaceArea()
        {
            decimal lateralSurafaceArea = 2 * this.Length * this.Height + 2 * this.Width * this.Height;
            return $"Lateral Surface Area - {lateralSurafaceArea:F2}";
        }

        public string Volume()
        {
            decimal volume = this.Height * this.Width * this.Length;
            return $"Volume - {volume:F2}";
        }
    }
}