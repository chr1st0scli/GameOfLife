using System;
using System.Collections.Generic;
using System.IO;

namespace GameOfLifeLib
{
    public sealed class World
    {
        bool[,] world;

        static World w;
        public static World GetWorld(int width, int height)
        {
            if (w == null)
                w = new World(width, height);
            return w;
        }

        public static World GetWorld()
        {
            if (w == null)
                throw new InvalidOperationException();
            return w;
        }

        public static void Reset()
        {
            w = null;
        }

        World(int width, int height) => world = new bool[width, height];

        public void Resize(int width, int height)
        {
            int minW = Math.Min(width, world.GetLength(0));
            int minH = Math.Min(height, world.GetLength(1));

            bool[,] tmp = new bool[width, height];
            for (int x = 0; x < minW; x++)
                for (int y = 0; y < minH; y++)
                    tmp[x, y] = world[x, y];
            world = tmp;
            OnResize?.Invoke();
        }

        public int Width { get { return world.GetLength(0); } }

        public int Height { get { return world.GetLength(1); } }

        public bool this[int x, int y]
        {
            get { return world[x, y]; }
            set
            {
                if (world[x, y] != value)
                {
                    world[x, y] = value;
                    OnLifeChange?.Invoke(x, y, value);
                }
            }
        }

        public delegate void LifeChange(int x, int y, bool alive);

        public event LifeChange OnLifeChange;

        public event Action OnResize;

        void WorldOper(Action<int, int> DoAction)
        {
            if (DoAction != null)
            {
                for (int x = 0; x < Width; x++)
                    for (int y = 0; y < Height; y++)
                        DoAction(x, y);
            }
        }

        public void Clear()
        {
            WorldOper((x, y) =>
            {
                if (this[x, y])
                    this[x, y] = false;
            });
        }

        public List<(int,int)> GetAliveCells()
        {
            var l = new List<(int, int)>();
            WorldOper((x, y) =>
            {
                if (world[x, y])
                    l.Add((x, y));
            });
            return l;
        }

        public void Save(string fileName)
        {
            using (BinaryWriter bw = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                var cells = GetAliveCells();
                bw.Write(cells.Count);
                foreach (var cell in cells)
                {
                    bw.Write(cell.Item1);
                    bw.Write(cell.Item2);
                }
            }
        }

        public void Load(string fileName)
        {
            using (BinaryReader br = new BinaryReader(File.Open(fileName, FileMode.Open)))
            {
                Clear();
                int size = br.ReadInt32();
                for (int i = 0; i < size; i++)
                    this[br.ReadInt32(), br.ReadInt32()] = true;
            }
        }
    }
}
