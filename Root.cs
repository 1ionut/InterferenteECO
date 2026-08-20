using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Inteferente_ECO
{
    public partial class Root : Form
    {
        private readonly Pen _whitePen = new Pen(Color.WhiteSmoke);
        private readonly SolidBrush _pathBrush = new SolidBrush(Color.Orange);
        private readonly OpenFileDialog _ofd = new OpenFileDialog();

        private readonly Dictionary<string, Bitmap> _baseImageCache = new Dictionary<string, Bitmap>();
        private readonly Dictionary<(string Name, int Rotation), Bitmap> _rotatedImageCache = new Dictionary<(string, int), Bitmap>();
        private readonly Dictionary<(string Name, int Rotation), TextureBrush> _brushCache = new Dictionary<(string, int), TextureBrush>();

        private Bitmap _deflectorPanelBaseBitmap;
        private readonly Dictionary<int, TextureBrush> _deflectorPanelBrushCache = new Dictionary<int, TextureBrush>();

        public Root()
        {
            InitializeComponent();
            this.FormClosing += Root_FormClosing;
        }

        private void Root_Load(object sender, EventArgs e)
        {
            Context.CellSizeX = MainPictureBox.Width / 10;
            Context.CellSizeY = MainPictureBox.Height / 20;

            _ofd.Filter = "Game Map|*.txt";
            _ofd.FileName = string.Empty;
            _ofd.InitialDirectory = Path.GetFullPath(Context.ResourcesPath);
        }

        private TextureBrush GetEntityBrush(string name, int rotation)
        {
            var key = (name, rotation);

            if (_brushCache.TryGetValue(key, out TextureBrush cachedBrush))
            {
                return cachedBrush;
            }

            if (!_baseImageCache.TryGetValue(name, out Bitmap baseBitmap))
            {
                baseBitmap = new Bitmap(Image.FromFile(Context.ResourcesPath + name + ".png"), Context.CellSizeX, Context.CellSizeY);
                _baseImageCache[name] = baseBitmap;
            }

            Bitmap rotatedBitmap = (Bitmap)baseBitmap.Clone();
            for (int i = 1; i <= rotation; i++)
            {
                rotatedBitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

            var brush = new TextureBrush(rotatedBitmap);
            _rotatedImageCache[key] = rotatedBitmap;
            _brushCache[key] = brush;

            return brush;
        }

        private TextureBrush GetDeflectorPanelBrush(int rotation)
        {
            if (_deflectorPanelBrushCache.TryGetValue(rotation, out TextureBrush cachedBrush))
            {
                return cachedBrush;
            }

            if (_deflectorPanelBaseBitmap == null)
            {
                _deflectorPanelBaseBitmap = new Bitmap(Image.FromFile(Context.ResourcesPath + "Deflector.png"), DeflectorPanel.Width, DeflectorPanel.Height);
            }

            Bitmap rotated = (Bitmap)_deflectorPanelBaseBitmap.Clone();
            for (int i = 1; i <= rotation; i++)
            {
                rotated.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

            var brush = new TextureBrush(rotated);
            _deflectorPanelBrushCache[rotation] = brush;

            return brush;
        }

        private void LoadMap()
        {
            Console.WriteLine("Registering entities...");

            Context.ColorPath = new Color[20, 10];
            Context.Entities = new Entity[20, 10];
            Context.TotalCollectibleCount = 0;

            foreach (string textLine in File.ReadAllLines(_ofd.FileName))
            {
                string[] lineSplit = textLine.Split(' ');
                int entityRow = Convert.ToInt32(lineSplit[1]) - 1;
                int entityCol = Convert.ToInt32(lineSplit[2]) - 1;

                Context.Entities[entityRow, entityCol] = new Entity
                {
                    Name = lineSplit[0],
                    X = entityCol * Context.CellSizeX,
                    Y = entityRow * Context.CellSizeY,
                };

                if (lineSplit[0] == "Robot")
                {
                    Context.RobotLine = entityRow;
                    Context.RobotColumn = entityCol;
                    Context.ColorPath[entityRow, entityCol] = Color.Orange;
                }
                else if (Context.Collectibles.ContainsKey(lineSplit[0]))
                {
                    Context.TotalCollectibleCount++;
                }
            }

            Updater.Start();
        }

        private void MainPictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (GridCheckbox.Checked)
            {
                DrawGrid(e.Graphics);
            }

            if (string.IsNullOrEmpty(_ofd.FileName)) return;
            if (Context.Entities == null) LoadMap();

            DrawPath(e.Graphics);
            DrawEntities(e.Graphics);
            DrawDeflectorPreview(e.Graphics);
        }

        private void DrawGrid(Graphics g)
        {
            for (int row = 0; row <= 20; row++)
            {
                g.DrawLine(_whitePen, 0, row * Context.CellSizeY, MainPictureBox.Width, row * Context.CellSizeY);
            }
            for (int col = 0; col <= 10; col++)
            {
                g.DrawLine(_whitePen, col * Context.CellSizeX, MainPictureBox.Height, col * Context.CellSizeX, -MainPictureBox.Height);
            }
        }

        private void DrawPath(Graphics g)
        {
            if (string.IsNullOrEmpty(Context.Direction)) return;

            for (int row = 0; row < 20; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    if (Context.ColorPath[row, col] != Color.Empty)
                    {
                        _pathBrush.Color = Context.ColorPath[row, col];
                        g.FillRectangle(_pathBrush, col * Context.CellSizeX, row * Context.CellSizeY, Context.CellSizeX, Context.CellSizeY);
                    }
                }
            }
        }

        private void DrawEntities(Graphics g)
        {
            for (int row = 0; row < 20; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    var entity = Context.Entities[row, col];
                    if (entity != null)
                    {
                        var brush = GetEntityBrush(entity.Name, entity.Action);
                        g.FillRectangle(brush, entity.X, entity.Y, Context.CellSizeX, Context.CellSizeY);
                    }
                }
            }
        }

        private void DrawDeflectorPreview(Graphics g)
        {
            if (!Context.PlacingDeflector) return;

            var brush = GetEntityBrush("Deflector", Context.DeflectorIncrement);
            g.FillRectangle(brush, Context.PlacementColumn * Context.CellSizeX, Context.PlacementLine * Context.CellSizeY, Context.CellSizeX, Context.CellSizeY);
        }


        private void StartButton_Click(object sender, EventArgs e)
        {
            if (Context.Entities != null)
            {
                if (string.IsNullOrEmpty(Context.Direction))
                {
                    new ChooseDirection().Show();
                }
            }
            else
            {
                MessageBox.Show("Please load a map before starting the game");
            }
        }

        private void Update_Tick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Context.Direction))
            {
                Entity robot = Context.Entities[Context.RobotLine, Context.RobotColumn];

                GetNewRobotLocation(robot);
                int collisionResult = CheckRobotCollision();
                Context.Entities[Context.RobotLine, Context.RobotColumn] = robot;

                switch (collisionResult)
                {
                    case 0:
                        MarkPathSegment();
                        break;
                    case 1:
                        EndGame(win: false);
                        return;
                    case 2:
                        EndGame(win: true);
                        return;
                }
            }

            MainPictureBox.Invalidate();
            DeflectorPanel.Invalidate();
        }

        private void GetNewRobotLocation(Entity robot)
        {
            Context.Entities[Context.RobotLine, Context.RobotColumn] = null;

            var (dRow, dCol) = Context.DirectionVectors[Context.Direction];
            Context.RobotLine = WrapIndex(Context.RobotLine + dRow, 20);
            Context.RobotColumn = WrapIndex(Context.RobotColumn + dCol, 10);

            robot.X = Context.RobotColumn * Context.CellSizeX;
            robot.Y = Context.RobotLine * Context.CellSizeY;
        }

        private int CheckRobotCollision()
        {
            Entity destinationEntity = Context.Entities[Context.RobotLine, Context.RobotColumn];

            if (destinationEntity != null)
            {
                Console.WriteLine($"[DEBUG] Robot a ajuns pe entitatea: '{destinationEntity.Name}'");

                if (Context.Collectibles.ContainsKey(destinationEntity.Name))
                {
                    Context.Collectibles[destinationEntity.Name]++;
                    UpdateCollectedLabels();
                    if (CheckWinCondition()) return 2;
                }

                if (Context.MarineLifeNames.Contains(destinationEntity.Name))
                {
                    return 1;
                }

                if (destinationEntity.Name == "Deflector" &&
                    Context.DeflectorRedirects.TryGetValue((Context.Direction, destinationEntity.Action), out string newDirection))
                {
                    Context.Direction = newDirection;
                }
            }

            return 0;
        }

        private static int WrapIndex(int value, int size)
        {
            if (value < 0) return size - 1;
            if (value >= size) return 0;
            return value;
        }

        private void MarkPathSegment()
        {
            if (Context.ColorPath[Context.RobotLine, Context.RobotColumn] == Color.Empty)
            {
                Console.WriteLine(Context.RobotLine + "-" + Context.RobotColumn);
                Context.ColorPath[Context.RobotLine, Context.RobotColumn] = Color.MediumPurple;
            }
        }

        private void UpdateCollectedLabels()
        {
            BottleLabel.Text = "Sticla - " + Context.Collectibles["Sticla"];
            PlasticLabel.Text = "Plastic - " + Context.Collectibles["Plastic"];
            PaperLabel.Text = "Hartie - " + Context.Collectibles["Hartie"];
        }

        private bool CheckWinCondition()
        {
            if (Context.TotalCollectibleCount <= 0) return false;

            int collected = 0;
            foreach (var count in Context.Collectibles.Values)
            {
                collected += count;
            }

            return collected >= Context.TotalCollectibleCount;
        }

        private void EndGame(bool win)
        {
            Updater.Stop();
            Context.Direction = string.Empty;

            MainPictureBox.Invalidate();
            MainPictureBox.Refresh();

            if (win)
            {
                MessageBox.Show("Felicitari! Ai colectat toate deseurile!", "Ai castigat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ai lovit o vietate marina! Jocul s-a incheiat.", "Ai pierdut", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ClearMap();
        }

        private void ClearMap()
        {
            _ofd.FileName = string.Empty;
            Context.ResetState();
            UpdateCollectedLabels();

            Updater.Start();
            MainPictureBox.Invalidate();
            DeflectorPanel.Invalidate();
        }

        private void LoadmapButton_Click(object sender, EventArgs e)
        {
            _ofd.ShowDialog();
        }

        private void DeflectorPanel_Paint(object sender, PaintEventArgs e)
        {
            var brush = GetDeflectorPanelBrush(Context.DeflectorIncrement);
            e.Graphics.FillRectangle(brush, 0, 0, DeflectorPanel.Width, DeflectorPanel.Height);
        }

        private void RotateDeflectorButton_Click(object sender, EventArgs e)
        {
            Context.DeflectorIncrement = (Context.DeflectorIncrement + 1) % 4;
        }

        private void DeflectorPanel_Click(object sender, EventArgs e)
        {
            Context.PlacingDeflector = !Context.PlacingDeflector;
        }

        private void MainPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (Context.PlacingDeflector)
            {
                Context.PlacementColumn = (e.Location.X / Context.CellSizeX);
                Context.PlacementLine = (e.Location.Y / Context.CellSizeY);
            }
        }

        private void MainPictureBox_Click(object sender, EventArgs e)
        {
            if (Context.PlacingDeflector && Context.Entities != null)
            {
                if (Context.Entities[Context.PlacementLine, Context.PlacementColumn] == null)
                {
                    Context.Entities[Context.PlacementLine, Context.PlacementColumn] = new Entity
                    {
                        Name = "Deflector",
                        Action = Context.DeflectorIncrement,
                        X = Context.PlacementColumn * Context.CellSizeX,
                        Y = Context.PlacementLine * Context.CellSizeY
                    };

                    Context.PlacingDeflector = false;
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (Context.Entities != null)
            {
                ClearMap();
            }
        }

        private void Root_FormClosing(object sender, FormClosingEventArgs e)
        {
            _whitePen.Dispose();
            _pathBrush.Dispose();

            foreach (var bmp in _rotatedImageCache.Values) bmp.Dispose();
            foreach (var brush in _brushCache.Values) brush.Dispose();
            foreach (var bmp in _baseImageCache.Values) bmp.Dispose();
            foreach (var brush in _deflectorPanelBrushCache.Values) brush.Dispose();

            _deflectorPanelBaseBitmap?.Dispose();
        }
    }
}