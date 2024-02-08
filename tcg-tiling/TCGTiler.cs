using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Numerics;
using tcg_tiling.Utils;

namespace tcg_tiling
{
    public partial class TCGTiler : Form
    {
        public TCGTiler()
        {
            InitializeComponent();
        }

        private void FindCardFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                FolderName.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void GenButton_Click(object sender, EventArgs e)
        {
            // Card standard
            Card card;
            if (MTGRadio.Checked) { card = Card.MTG; }
            else if (YGORadio.Checked) { card = Card.YGO; }
            else if (CustomCardRadio.Checked) { card = new Card() { height = int.Parse(cardHeight.Text), width = int.Parse(cardWidth.Text)  }; }
            else { return; }

            // Page standard
            Page page;
            if (A0Radio.Checked) { page = Page.A0; }
            else if (A1Radio.Checked) { page = Page.A1; }
            else if (A2Radio.Checked) { page = Page.A2; }
            else if (A3Radio.Checked) { page = Page.A3; }
            else if (A4Radio.Checked) { page = Page.A4; }
            else if (A5Radio.Checked) { page = Page.A5; }
            else if (A6Radio.Checked) { page = Page.A6; }
            else if (A7Radio.Checked) { page = Page.A7; }
            else if (CustomPageRadio.Checked) { page = new Page() { height = int.Parse(pageHeight.Text), width = int.Parse(pageWidth.Text) }; }
            else { return; }

            if (!Directory.Exists(FolderName.Text)) return;

            string curDir = Directory.GetCurrentDirectory();
            string loadDir = FolderName.Text;
            string batchName = BatchName.Text;
            string saveDir = $"{curDir}/{batchName}";

            string[] bmpCards = Card.LoadCards(loadDir, card);

            int verQt = page.height / card.height;
            int verWhtSpc = page.height % card.height;
            int verSpcng = verWhtSpc / (verQt + 2);

            int horQt = page.width / card.width;
            int horWhtSpc = page.width % card.width;
            int horSpcng = horWhtSpc / (horQt + 2);

            GenProgress.Maximum = horQt * verQt;
            List<IntVector2> posVectorLs = new List<IntVector2>();
            for (int i=0;i<verQt;i++) // Rows
            {
                for (int j=0;j<horQt;j++) // Collumns
                {
                    GenProgress.PerformStep();
                    posVectorLs.Add(new IntVector2()
                    {
                        x = (horSpcng*(i+1)) + (card.width*i),
                        y = (verSpcng*(j+1)) + (card.height*j)
                    });
                }
            }

            GenProgress.Value = 0;
            int pageCount = (int)Math.Ceiling((double)(bmpCards.Count() / (horQt * verQt)));
            GenProgress.Maximum = pageCount;
            List<Bitmap> bmpPages = Page.GeneratePage(bmpCards, posVectorLs, pageCount, page, card);

            if (!Directory.Exists(saveDir)) Directory.CreateDirectory(saveDir);
            for (int i=0; i<bmpPages.Count; i++)
            {
                bmpPages[i].Save($"{saveDir}/{i}.png", ImageFormat.Png);
                GenProgress.PerformStep();
            }

        }
    }
    public class Card
    {
        public int height { get; set; }
        public int width { get; set; }

        public static Card MTG = new Card() { height = 1050, width = 750 };
        public static Card YGO = new Card() { height = 975, width = 675 };

        public static string[] LoadCards(string dir, Card standard) 
        {
            return Directory.GetFiles(dir, "*", SearchOption.AllDirectories);
            //List<Bitmap> cards = new List<Bitmap>();

            //foreach (var path in filePaths)
            //{
            //    using Image img = Image.FromFile(path);
            //    Bitmap bmp = (Bitmap)img;
            //    if (bmp.Height != standard.height || bmp.Width != standard.width) { bmp = ResizeImage(img, standard.width, standard.height); }
            //    cards.Add(bmp);
            //}

            //return cards;
        }

        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <param name="width">The width to resize to.</param>
        /// <param name="height">The height to resize to.</param>
        /// <returns>The resized image.</returns>
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
    }
    public class Page
    {
        public int height { get; set; }
        public int width { get; set; }

        public static Page A0 = new Page { height = 14043, width = 9933 };
        public static Page A1 = new Page { height = 9933, width = 7016 };
        public static Page A2 = new Page { height = 7016, width = 4960 };
        public static Page A3 = new Page { height = 4960, width = 3508 };
        public static Page A4 = new Page { height = 3508, width = 2480 };
        public static Page A5 = new Page { height = 2480, width = 1748 };
        public static Page A6 = new Page { height = 1748, width = 1240 };
        public static Page A7 = new Page { height = 1240, width = 874 };

        public static Bitmap GenerateEmpty(int height, int width)
        {
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics graph = Graphics.FromImage(bmp))
            {
                Rectangle ImageSize = new Rectangle(0, 0, width, height);
                graph.FillRectangle(Brushes.White, ImageSize);
            }
            return bmp;
        }

        public static List<Bitmap> GeneratePage(string[] cards, List<IntVector2> vecPos, int pageCount, Page page, Card card)
        {
            int itr = 0;
            List<Bitmap> pages = new List<Bitmap>();
            for (int p = 0; p < pageCount; p++)
            {
                Bitmap nPage = GenerateEmpty(page.height, page.width);
                for (int c = 0; c < vecPos.Count; c++)
                {
                    Image nCard = Image.FromFile(cards[itr]);
                    if (nCard.Height != card.height || nCard.Width != card.width) { nCard = Card.ResizeImage(nCard, card.width, card.height); }
                    using Graphics grp = Graphics.FromImage(nPage);
                    grp.DrawImage(
                        nCard,
                        vecPos[c].x,
                        vecPos[c].y,
                        card.width,
                        card.height);
                    itr++;
                }
                pages.Add(nPage);
            }
            return pages;
        }
    }
}