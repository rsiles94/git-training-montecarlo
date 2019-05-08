/// <summary>
/// The auxiliar MPoint file.
/// </summary>
namespace MontecarloAlgorithms
{
    /// <summary>
    /// A points structure.
    /// </summary>
    public struct MPoint
    {
        /// <summary>
        /// X value
        /// </summary>
        public double X;

        /// <summary>
        /// Y value
        /// </summary>
        public double Y;

        /// <summary>
        /// insideCircle value
        /// </summary>
        public bool insideCircle;

        /// <summary>
        /// MPoint constructor
        /// </summary>
        /// <param name="x">X</param>
        /// <param name="y">Y</param>
        /// <param name="insideCircle">insideCircle</param>
        public MPoint(double x, double y, bool insideCircle)
        {
            this.X = x;
            this.Y = y;
            this.insideCircle = insideCircle;
        }
    }
}
