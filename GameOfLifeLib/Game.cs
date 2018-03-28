using System;
using System.Collections.Generic;

namespace GameOfLifeLib
{
    public class Game
    {
        protected World world;
        protected bool[,] tmpWorld; //We need a temp to differentiate between snapshots of the world

        public Game()
        {
            world = World.GetWorld();
            world.OnLifeChange += World_OnLifeChange;
            world.OnResize += () => InitTmpWorld();
            InitTmpWorld();
        }

        void InitTmpWorld()
        {
            //Copy world to tmpWorld
            tmpWorld = new bool[world.Width, world.Height];
            for (int x = 0; x < world.Width; x++)
                for (int y = 0; y < world.Height; y++)
                    tmpWorld[x, y] = world[x, y];
        }

        private void World_OnLifeChange(int x, int y, bool alive)
        {
            //Keep tmpWorld in sync with world
            if (tmpWorld[x, y] != alive)
                tmpWorld[x, y] = alive; //change occured from outside of this class
        }

        /// <summary>
        /// Determines if a cell leaves in the next generation. Any cell outside the world's bounds
        /// is considered to be dead. You can override this to implement your own rules.
        /// Conway's rules are:
        /// 1. Any live cell with fewer than two live neighbours dies, as if caused by under-population.
        /// 2. Any live cell with two or three live neighbours lives on to the next generation.
        /// 3. Any live cell with more than three live neighbours dies, as if by overcrowding.
        /// 4. Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.
        /// </summary>
        /// <param name="x">The cell's horizontal coordinate.</param>
        /// <param name="y">The cell's vertical coordinate.</param>
        /// <returns></returns>
        protected virtual bool CellLeavesOn(int x, int y)
        {
            int aliveNeighs = AliveNeighbours(x, y);
            if (world[x, y])
            {
                if (aliveNeighs < 2 || aliveNeighs > 3)
                    return false;
                else if (aliveNeighs == 2 || aliveNeighs == 3)
                    return true;
            }
            else if (aliveNeighs == 3)
                return true;

            return false;
        }

        protected int AliveNeighbours(int x, int y)
        {
            int count = 0;
            foreach (var t in new[] { (x - 1, y - 1), (x, y - 1), (x + 1, y - 1), (x - 1, y), (x + 1, y), (x - 1, y + 1), (x, y + 1), (x + 1, y + 1) })
            {
#if DEBUG
                //In debug mode, exceptions are very costly, so prevent them from being thrown
                if (t.Item1 < 0 || t.Item1 >= world.Width || t.Item2 < 0 || t.Item2 >= world.Height)
                    continue;
#endif
                try { if (world[t.Item1, t.Item2]) count++; } catch { }
            }
            return count;
        }

        /// <summary>
        /// Advances the world to the next generation.
        /// </summary>
        public void Tick()
        {
            //Make a first pass to limit the world's size that needs to be processed.
            int minX = -1, maxX = -1, minY = -1, maxY = -1;
            for (int y = 0; y < world.Height; y++)
                for (int x = 0; x < world.Width; x++)
                {
                    if (world[x, y])
                    {
                        if (minX == -1)
                        {
                            minX = maxX = x;
                            minY = maxY = y;
                        }
                        else
                        {
                            if (x < minX) minX = x;
                            else if (x > maxX) maxX = x;
                            if (y < minY) minY = y;
                            else if (y > maxY) maxY = y;
                        }
                    }
                }
            //We also have to process the closest neighbours of the live cells on the edges, because they might come to life.
            minX = Math.Max(0, minX - 1);
            maxX = Math.Min(world.Width - 1, maxX + 1);
            minY = Math.Max(0, minY - 1);
            maxY = Math.Min(world.Height - 1, maxY + 1);

            //Change tmpWorld and gather the changes. This could run in a parallel for...
            List<(int, int)> changes = new List<(int, int)>();
            for (int y = minY; y <= maxY; y++)
                for (int x = minX; x <= maxX; x++)
                {
                    bool leaves = CellLeavesOn(x, y);
                    if (leaves != tmpWorld[x, y])
                    {
                        tmpWorld[x, y] = leaves;
                        changes.Add((x, y));
                    }
                }

            //Apply all changes to the world.
            foreach (var change in changes)
                world[change.Item1, change.Item2] = tmpWorld[change.Item1, change.Item2];
        }
    }
}
