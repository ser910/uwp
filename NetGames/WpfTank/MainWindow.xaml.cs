using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TankGame;
using TankGame.GameObject;
using TankGame.Map;

namespace WpfTank
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Windows.Threading.DispatcherTimer DispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        private long TimerTicks = 250;

        private Game Game = new Game();

        private float Multiplier = 30;

        private Direction Direction = Direction.Non;
        private TankGame.GameObject.Action Action = TankGame.GameObject.Action.Non;

        public MainWindow()
        {
            InitializeComponent();

            TempInit();

            DispatcherTimer.Tick += new EventHandler(Timer);
            DispatcherTimer.Interval = new TimeSpan(TimerTicks);
            DispatcherTimer.Start();

        }

        private void TempInit()
        {
            Map Map = new Map(13, 13);
            
            Map.AddObject(new Tank(1, 1, 1, 1, Direction.Bottom, true, false, 1, 1, true, true, false, true)); // AI
            Map.AddObject(new Tank(7, 1, 2, 1, Direction.Bottom, true, false, 1, 1, true, true, false, true)); // AI
            Map.AddObject(new Tank(13, 1, 1, 2, Direction.Bottom, true, false, 1, 1, true, true, false, true)); // AI
            
            Map.AddObject(new Tank(7, 13, 1, 1, Direction.Top, false, true, 1, 1, true, true, false, true)); // player
            
            Map.AddObject(new Wall(2, 2, true, 1, 1, 1, true, false, false, 0, false, false, Direction.Non)); // wall
            Map.AddObject(new Wall(2, 3, true, 1, 1, 1, true, false, false, 0, false, false, Direction.Non)); // wall
            Map.AddObject(new Wall(2, 4, true, 1, 1, 1, true, false, false, 0, false, false, Direction.Non)); // wall
            Map.AddObject(new Wall(2, 5, true, 1, 1, 1, true, false, false, 0, false, false, Direction.Non)); // wall
            
            Map.AddObject(new Wall(12, 2, true, 1, 1, 1, true, false, false, 0, false, false, Direction.Non)); // wall
            Map.AddObject(new Wall(12, 3, true, 1, 1, 1, true, false, false, 0, false, false, Direction.Non)); // wall
            Map.AddObject(new Wall(12, 4, true, 1, 1, 1, true, false, false, 0, false, false, Direction.Non)); // wall
            Map.AddObject(new Wall(12, 5, true, 1, 1, 1, true, false, false, 0, false, false, Direction.Non)); // wall
            
            Map.AddObject(new Wall(4, 7, false, 1, 1, 1, true, false, false, 0, false, false, Direction.Non)); // wall
            Map.AddObject(new Wall(5, 7, false, 1, 1, 1, true, false, false, 0, false, false, Direction.Non)); // wall
            Map.AddObject(new Wall(6, 7, false, 1, 1, 1, true, false, false, 0, false, false, Direction.Non)); // wall
            
            Map.AddObject(new Wall(8, 7, false, 1, 1, 1, true, false, false, 0, false, false, Direction.Non)); // wall
            Map.AddObject(new Wall(9, 7, false, 1, 1, 1, true, false, false, 0, false, false, Direction.Non)); // wall
            Map.AddObject(new Wall(10, 7, false, 1, 1, 1, true, false, false, 0, false, false, Direction.Non)); // wall
            
            Game.AddMap(Map);
        }

        private void Draw(Map Map)
        {
            MainCanvas.Children.Clear();

            foreach (GameObject GameObject in Map.GameObjects)
            {

                Label obj = new Label();

                obj.Width = Convert.ToInt32(GameObject.Width * Multiplier);
                obj.Height = Convert.ToInt32(GameObject.Height * Multiplier);
                obj.Margin = new Thickness(Convert.ToInt32(GameObject.Left * Multiplier), Convert.ToInt32(GameObject.Top * Multiplier),0,0);

                switch (GameObject.Name)
                {
                    case "Tank":
                        obj.Content = "T";
                        break;
                    case "Wall":
                        obj.Content = "W";
                        break;
                    case "Bullet":
                        obj.Content = "B";
                        break;
                    default:
                        break;
                }

                MainCanvas.Children.Add(obj);
            }

        }

        private void Timer(Object Object, EventArgs EventArgs)
        {
            if (Keyboard.IsKeyDown(Key.W))
            {
                Draw(Game.Play(Direction.Top, TankGame.GameObject.Action.Move));
            }
            else
            {
                Draw(Game.Play(Direction, Action));
            }

        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Up:
                case Key.W:
                    Direction = Direction.Top;
                    Action = TankGame.GameObject.Action.Move;
                    break;
                case Key.Left:
                case Key.A:
                    Direction = Direction.Left;
                    Action = TankGame.GameObject.Action.Move;
                    break;
                case Key.Down:
                case Key.S:
                    Direction = Direction.Bottom;
                    Action = TankGame.GameObject.Action.Move;
                    break;
                case Key.Right:
                case Key.D:
                    Direction = Direction.Right;
                    Action = TankGame.GameObject.Action.Move;
                    break;
                case Key.Space:
                    Action = TankGame.GameObject.Action.Shot;
                    break;
                default:
                    break;
            }
        }
    }
}
