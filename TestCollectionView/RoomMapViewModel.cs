using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace TestCollectionView
{
    public class RoomFloor : List<RoomMapCell>
    {
        internal RoomFloor(BF bf, IEnumerable<RoomMapCell> cs) : base(cs)
        {
            this.Category = bf.ToString();
        }
        public string Category { get; private set; }
        public override string ToString()
        {
            return this.Category;
        }
    }

    public class RoomMapViewModel
    {
        public RoomMapViewModel()
        {
            var cells = new RoomMapCell[]
            {
                new RoomMapCell()
                {
                    Flr = 1,
                    RoomNo = "101",
                    BgColor = Color.Green,
                    Content = "OK 房",
                    Footer = "标房"
                },
                new RoomMapCell()
                {
                    Flr = 1,
                    RoomNo = "102",
                    BgColor = Color.Yellow,
                    Content = "陈",
                    Footer = "标房"
                },
                new RoomMapCell()
                {
                    Flr = 1,
                    RoomNo = "103",
                    BgColor = Color.Yellow,
                    Content = "123",
                    Footer = "标房"
                },
                new RoomMapCell()
                {
                    Flr = 1,
                    RoomNo = "104",
                    BgColor = Color.Green,
                    Content = "OK 房",
                    Footer = "标房"
                },
                new RoomMapCell()
                {
                    Flr = 1,
                    RoomNo = "105",
                    BgColor = Color.YellowGreen,
                    Content = "OK 房",
                    Footer = "标房"
                },
                new RoomMapCell()
                {
                    Flr = 1,
                    RoomNo = "106",
                    BgColor = Color.Red,
                    Content = "陈",
                    Footer = "标房"
                },
                new RoomMapCell()
                {
                    Flr = 1,
                    RoomNo = "107",
                    BgColor = Color.LightBlue,
                    Content = "123",
                    Footer = "标房"
                },
                new RoomMapCell()
                {
                    Flr = 1,
                    RoomNo = "108",
                    BgColor = Color.Green,
                    Content = "OK 房",
                    Footer = "标房"
                },

                new RoomMapCell()
                {
                    Flr = 2,
                    RoomNo = "201",
                    BgColor = Color.Green,
                    Content = "OK 房",
                    Footer = "标房"
                },
                new RoomMapCell()
                {
                    Flr = 2,
                    RoomNo = "202",
                    BgColor = Color.Yellow,
                    Content = "陈",
                    Footer = "标房"
                },
                new RoomMapCell()
                {
                    Flr = 2,
                    RoomNo = "203",
                    BgColor = Color.Yellow,
                    Content = "123",
                    Footer = "标房"
                },
                new RoomMapCell()
                {
                    Flr = 2,
                    RoomNo = "204",
                    BgColor = Color.Green,
                    Content = "OK 房",
                    Footer = "标房"
                },
                new RoomMapCell()
                {
                    Flr = 2,
                    RoomNo = "205",
                    BgColor = Color.YellowGreen,
                    Content = "OK 房",
                    Footer = "标房"
                },
                new RoomMapCell()
                {
                    Flr = 2,
                    RoomNo = "206",
                    BgColor = Color.Red,
                    Content = "陈",
                    Footer = "标房"
                },
                new RoomMapCell()
                {
                    Flr = 2,
                    RoomNo = "207",
                    BgColor = Color.LightBlue,
                    Content = "123",
                    Footer = "标房"
                },
                new RoomMapCell()
                {
                    Flr = 2,
                    RoomNo = "208",
                    BgColor = Color.Green,
                    Content = "OK 房",
                    Footer = "标房"
                },

            };

            this.Floors = new List<RoomFloor>(cells.GroupBy(c => new BF(c.Flr)).Select(kv => new RoomFloor(kv.Key, kv)));
        }

        public List<RoomFloor> Floors { get; private set; }
    }

    internal class BF
    {
        public BF(int f)
        {
            this.F = f;
        }

        public int F { get; private set; }

        public override string ToString()
        {
            return $"楼层 - {F}";
        }

        public override bool Equals(object obj)
        {
            if (obj is BF bf)
            {
                return bf.F == this.F;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return F;
        }
    }

    public class RoomMapCell
    {
        #region 绑定的属性
        public int Flr { get; set; }

        public string RoomNo { get; set; }

        public Color BgColor { get; set; }
        public Color FgColor { get; set; }

        public string Content { get; set; }

        public string Footer { get; set; }

        public ImageSource Image1 { get; set; }

        public ImageSource Image2 { get; set; }
        #endregion

        #region 图标
        private static readonly ImageSource DirtyIcon = GetIconSource("Assorted/recycle bin full.gif");
        private static readonly ImageSource ChainIcon = GetIconSource("Assorted/couple.gif");
        private static readonly ImageSource PersonIcon = GetIconSource("Assorted/person.gif");
        private static readonly ImageSource TeamIcon = GetIconSource("Assorted/group.gif");
        private static readonly ImageSource OthIcon = GetIconSource("Assorted/heart.gif");
        private static readonly ImageSource FixIcon = GetIconSource("Assorted/hammer.gif");
        private static readonly ImageSource LckIcon = GetIconSource("Assorted/lock.gif");
        private static readonly ImageSource CleanIcon = GetIconSource("Isometric/clean.png");

        private static ImageSource GetIconSource(string icon)
        {
            var res = "TestCollectionView.Icon." + icon.Replace('/', '.');
            return ImageSource.FromResource(res);
        }
        #endregion
    }
}
