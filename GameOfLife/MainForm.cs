using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameOfLifeLib;

namespace GameOfLife
{
    public partial class MainForm : Form
    {
        const int CELL_SIZE = 15;
        const int BORDER_SIZE = 1;
        const string FILE_EXT = "Game of Life (*.gol)|*.gol";
        const string SMALL_WORLD_MSG = "You need a larger world. Please resize the window.";

        World world;
        Game game;
        WorldRendererUtil worldRend;
        Color color;
        Timer timer;

        public MainForm()
        {
            InitializeComponent();
            FormClosing += MainForm_FormClosing;
            panel.Resize += (sender, e) => panel.Refresh();
            panel.Paint += (sender, e) => ResizeWorld(e.Graphics);
            panel.MouseClick += Panel_MouseClick;

            world = World.GetWorld(0, 0);
            world.OnLifeChange += (x, y, alive) => DrawCell(x, y, alive);
            game = new Game();

            timer = new Timer();
            timer.Tick += (sender, e) => game.Tick();
            speedNumericUpDown.ValueChanged += (sender, e) => timer.Interval = 1000 * 1 / (int)speedNumericUpDown.Value;

            color = Properties.Settings.Default.Color;
            Width = Properties.Settings.Default.Width;
            Height = Properties.Settings.Default.Height;
            speedNumericUpDown.Value = Properties.Settings.Default.Speed;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Color = color;
            Properties.Settings.Default.Width = Width;
            Properties.Settings.Default.Height = Height;
            Properties.Settings.Default.Speed = speedNumericUpDown.Value;
            Properties.Settings.Default.Save();
        }

        void ResizeWorld(Graphics g)
        {
            worldRend = new WorldRendererUtil(CELL_SIZE, BORDER_SIZE, panel.ClientRectangle.Width, panel.ClientRectangle.Height);
            DrawWorldBorders(g);
            FillWorld();
        }

        void DrawWorldBorders(Graphics g)
        {
            g.Clear(Color.Black);
            Pen pen = new Pen(color);
            foreach (var line in worldRend.GetLinePoints())
                g.DrawLine(pen, line.Item1.X, line.Item1.Y, line.Item2.X, line.Item2.Y);
        }

        void FillWorld()
        {
            for (int x = 0; x < world.Width; x++)
                for (int y = 0; y < world.Height; y++)
                    if (world[x, y] == true)
                        DrawCell(x, y, true);
        }

        void DrawCell(int horzCell, int vertCell, bool alive)
        {
            Point p = worldRend.CellToPoint(horzCell, vertCell);
            panel.CreateGraphics().FillRectangle(new SolidBrush(alive ? color : Color.Black), p.X, p.Y, CELL_SIZE, CELL_SIZE);
        }

        private void Panel_MouseClick(object sender, MouseEventArgs e)
        {
            var cell = worldRend.PointToCell(new Point(e.X, e.Y));
            int horzCell = cell.Item1;
            int vertCell = cell.Item2;
            if (horzCell != -1 && vertCell != -1)
                world[horzCell, vertCell] = !world[horzCell, vertCell];
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            world.Clear();
        }

        private void TemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            world.Clear();
            Action action = null;
            if (sender == blocksLoafsBeehivesBoatsToolStripMenuItem)
                action = WorldSamples.StillLife;
            else if (sender == blinkerToolStripMenuItem)
                action = WorldSamples.Blinker;
            else if (sender == koksGalaxyToolStripMenuItem)
                action = WorldSamples.KoksGalaxy;
            else if (sender == gliderToolStripMenuItem)
                action = WorldSamples.Glider;
            else if (sender == lightweightSpaceshipToolStripMenuItem)
                action = WorldSamples.LightweightSpaceship;
            else if (sender == smallExploderToolStripMenuItem)
                action = WorldSamples.SmallExploder;
            else if (sender == exploderToolStripMenuItem)
                action = WorldSamples.Exploder;
            else if (sender == tenCellRowToolStripMenuItem)
                action = WorldSamples.TenCellRow;
            else if (sender == gosperGliderGunToolStripMenuItem)
                action = WorldSamples.GosperGliderGun;

            try { action?.Invoke(); }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show(SMALL_WORLD_MSG, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    color = dlg.Color;
                    panel.Refresh();
                }
            }
        }

        void SafeCall(Action DoAction)
        {
            try { DoAction?.Invoke(); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SafeCall(() =>
            {
                using (SaveFileDialog dlg = new SaveFileDialog())
                {
                    dlg.Filter = FILE_EXT;
                    if (dlg.ShowDialog() == DialogResult.OK)
                        world.Save(dlg.FileName);
                }
            });
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SafeCall(() =>
            {
                using (OpenFileDialog dlg = new OpenFileDialog())
                {
                    dlg.Filter = FILE_EXT;
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        try { world.Load(dlg.FileName); }
                        catch (IndexOutOfRangeException)
                        {
                            throw new Exception(SMALL_WORLD_MSG);
                        }
                    }
                }
            });
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (!timer.Enabled)
            {
                timer.Start();
                playButton.Text = "Stop";
            }
            else
            {
                timer.Stop();
                playButton.Text = "Start";
            }
        }
    }
}
