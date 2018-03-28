using System;
using System.Collections.Generic;
using System.Drawing;

namespace GameOfLifeLib
{
    /// <summary>
    /// Helps to draw the world and interact with it in a drawing area.
    /// </summary>
    public class WorldRendererUtil
    {
        protected World world;
        protected int cellSize, borderSize;
        protected int canvasWidth, canvasHeight;

        //Offsets to center the world
        protected int xOffset, yOffset;

        /// <summary>
        /// Constructs an object that helps us draw the world and interact with it in a drawing area.
        /// A world should be first initialized, because this will resize it based on the drawing surface.
        /// </summary>
        /// <param name="cellSize">The size of a world's cell which is a rectangle.</param>
        /// <param name="borderSize">The width of the vertical and horizontal lines that make up the cells.</param>
        /// <param name="canvasWidth">The drawing surface's available width.</param>
        /// <param name="canvasHeight">The drawing surface's available height.</param>
        public WorldRendererUtil(int cellSize, int borderSize, int canvasWidth, int canvasHeight)
        {
            this.cellSize = cellSize;
            this.borderSize = borderSize;
            this.canvasWidth = canvasWidth;
            this.canvasHeight = canvasHeight;

            int worldWidth = (canvasWidth - borderSize) / (cellSize + borderSize);
            int worldHeight = (canvasHeight - borderSize) / (cellSize + borderSize);
            xOffset = (int)Math.Round((canvasWidth - worldWidth * cellSize - (worldWidth + 1) * borderSize) / 2.0);
            yOffset = (int)Math.Round((canvasHeight - worldHeight * cellSize - (worldHeight + 1) * borderSize) / 2.0);
            world = World.GetWorld();
            world.Resize(worldWidth, worldHeight);
        }

        /// <summary>
        /// Gives pairs of points that make up the vertical and horizontal lines that constitute the world.
        /// For each tuple of points, the programmer could draw a line from the first to the second point.
        /// </summary>
        /// <returns>An enumerable of tuples of two points.</returns>
        public IEnumerable<(Point, Point)> GetLinePoints()
        {
            for (int i = 0; i <= world.Width; i++)
            {
                int x = i * (cellSize + borderSize) + xOffset;
                yield return (new Point(x, 0), new Point(x, canvasHeight - 1));
            }

            for (int i = 0; i <= world.Height; i++)
            {
                int y = i * (cellSize + borderSize) + yOffset;
                yield return (new Point(0, y), new Point(canvasWidth - 1, y));
            }
        }

        /// <summary>
        /// Gives the upper left point of the given cell. The point doesn't fall on the borders.
        /// </summary>
        /// <param name="horzCell">The cell's horizontal coordinate.</param>
        /// <param name="vertCell">The cell's vertical coordinate.</param>
        /// <returns>The upper left point of the cell.</returns>
        public Point CellToPoint(int horzCell, int vertCell)
        {
            int x = (horzCell + 1) * borderSize + horzCell * cellSize + xOffset;
            int y = (vertCell + 1) * borderSize + vertCell * cellSize + yOffset;
            return new Point(x, y);
        }

        /// <summary>
        /// Returns the world's cell which the given point belongs to.
        /// Note that the right and bottom borders of a cell are considered to belong to the next one.
        /// This happens because we often want a cell to be selected even when one of its borders is clicked.
        /// Note that (-1, -1) is returned if the point is outside the world.
        /// </summary>
        /// <param name="point">The point in the drawing area.</param>
        /// <returns>A tuple of ints. The first one is the horizontal coordinate and the second the vertical one.</returns>
        public (int, int) PointToCell(Point point)
        {
            int horzFrontier = world.Width * cellSize + (world.Width + 1) * borderSize + xOffset - 1;
            int vertFrontier = world.Height * cellSize + (world.Height + 1) * borderSize + yOffset - 1;
            if (point.X >= xOffset && point.Y >= yOffset && point.X < horzFrontier && point.Y < vertFrontier)
            {
                int horzCell = (point.X - xOffset) / (cellSize + borderSize);
                int vertCell = (point.Y - yOffset) / (cellSize + borderSize);
                return (horzCell, vertCell);
            }
            else return (-1, -1);
        }
    }
}
