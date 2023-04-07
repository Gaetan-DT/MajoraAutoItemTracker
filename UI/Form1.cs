﻿using MajoraAutoItemTracker.Model.CheckLogic;
using MajoraAutoItemTracker.Model.Enum;
using MajoraAutoItemTracker.Model.Item;
using MajoraAutoItemTracker.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Xml.Linq;
using Brush = System.Drawing.Brush;
using Brushes = System.Drawing.Brushes;
using Color = System.Drawing.Color;

namespace MajoraAutoItemTracker
{
    public partial class Form1 : Form
    {
        private const int CST_RECT_WIDTH_HEIGHT = 40;
        MemoryListener mMemoryListener = null;
        private List<CheckLogicCategory> _checkLogicCategories;
        private List<CheckLogic> _checkLogics;
        private PictureBoxZoomMoveController<CheckLogicZone> _pictureBoxZoomMoveController;
        private List<ItemLogic> _itemLogics;
        private Bitmap _itemSpriteMono;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Log("Attaching to modloader");
            ModLoader64Wrapper modLoader64Wrapper = new ModLoader64Wrapper();
            MajoraMemoryDataObserver majoraMemoryDataObserver = new MajoraMemoryDataObserver();
            Log("Initializing thread");
            mMemoryListener = new MemoryListener(modLoader64Wrapper, majoraMemoryDataObserver, CallBackMemoryListener);
            mMemoryListener.Start();
            Log("Thread started");
            majoraMemoryDataObserver.CurrentLinkTransformation.Subscribe(foo =>
            {
                Debug.WriteLine("Update link transformatin: " + foo);
            });
        }

        private void BtnStopListener_Click(object sender, EventArgs e)
        {
            mMemoryListener.Stop();
            mMemoryListener = null;
            Log("Thread Stoped");
        }

        private void CallBackMemoryListener(String message)
        {
            this.Invoke((MethodInvoker)delegate
            {
                if (message != null)
                    this.Log(message);
            });
            // Open a Stream and decode a PNG image

            /** Stream ImgOcarinaSource = new FileStream("mm_items_mono.png", FileMode.Open, FileAccess.Read, FileShare.Read);
            PngBitmapDecoder decoder = new PngBitmapDecoder(ImgOcarinaSource, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.Default);
            BitmapSource bitmapSource = decoder.Frames[0];

            // Draw the Image
            Image myImage = new Bitmap();
            myImage.Source = bitmapSource;
            myImage.Stretch = Stretch.None;
            myImage.Margin = new Thickness(20); **/
            //Debug.WriteLine(System.IO.Directory.GetCurrentDirectory());

            // Image PngOcarina = Image.FromFile(@"..\..\UI\Itemicons\mm_items_mono.png");

            /** Bitmap bitmapOcarina = new Bitmap(PngOcarina);
            Image croppedOcarina = bitmapOcarina.Clone(new Rectangle(0, 0, 42, 42), bitmapOcarina.PixelFormat);
            this.ImgOcarina.Image = croppedOcarina;            

            Bitmap bitmapBow = new Bitmap(PngOcarina);
            Image croppedBow = bitmapBow.Clone(new Rectangle(42, 0, 42, 42), bitmapBow.PixelFormat);
            this.ImgBow.Image = croppedBow;

            Bitmap bitmapFireArrow = new Bitmap(PngOcarina);
            Image croppedFireArrow = bitmapFireArrow.Clone(new Rectangle(84, 0, 42, 42), bitmapFireArrow.PixelFormat);
            this.ImgFireArrow.Image = croppedFireArrow;

            Bitmap bitmapIceArrow = new Bitmap(PngOcarina);
            Image croppedIceArrow = bitmapIceArrow.Clone(new Rectangle(126, 0, 42, 42), bitmapIceArrow.PixelFormat);
            this.ImgIceArrow.Image = croppedIceArrow;

            Bitmap bitmapLightArrow = new Bitmap(PngOcarina);
            Image croppedLightArrow = bitmapLightArrow.Clone(new Rectangle(168, 0, 42, 42), bitmapLightArrow.PixelFormat);
            this.ImgLightArrow.Image = croppedLightArrow;

            Bitmap bitmapScrubTrade = new Bitmap(PngOcarina);
            Image croppedScrubTrade = bitmapScrubTrade.Clone(new Rectangle(336, 84, 42, 42), bitmapScrubTrade.PixelFormat);
            this.ImgScrubTrade.Image = croppedScrubTrade;

            Bitmap bitmapBomb = new Bitmap(PngOcarina);
            Image croppedBomb = bitmapBomb.Clone(new Rectangle(252, 0, 42, 42),bitmapBomb.PixelFormat);
            this.ImgBomb.Image = croppedBomb;

            Bitmap bitmapBombchu = new Bitmap(PngOcarina);
            Image croppedBombchu = bitmapBombchu.Clone(new Rectangle(294, 0, 42, 42), bitmapBombchu.PixelFormat);
            this.ImgBombchu.Image = croppedBombchu;

            Bitmap bitmapStick = new Bitmap(PngOcarina);
            Image croppedStick = bitmapStick.Clone(new Rectangle(336, 0 , 42, 42),bitmapStick.PixelFormat);
            this.ImgStick.Image = croppedStick;

            Bitmap bitmapNuts = new Bitmap(PngOcarina);
            Image croppedNuts = bitmapNuts.Clone(new Rectangle(378, 0, 42, 42), bitmapNuts.PixelFormat);
            this.ImgNuts.Image = croppedNuts;

            Bitmap bitmapBeans = new Bitmap(PngOcarina);
            Image croppedBeans = bitmapBeans.Clone(new Rectangle(420,0, 42, 42),bitmapNuts.PixelFormat);
            this.ImgBeans.Image = croppedBeans;

            Bitmap bitmapKey = new Bitmap(PngOcarina);
            Image croppedKey = bitmapKey.Clone(new Rectangle(546, 84, 42, 42), bitmapKey.PixelFormat);
            this.ImgKeyMama.Image = croppedKey; **/


        }

        private void LoadCheckCategory()
        {
           var filepath = Application.StartupPath + @"\Resource\CheckLogic\" + CheckLogicCategory.CST_DEFAULT_FILE_NAME;
            var JsonStr = File.ReadAllText(filepath);
            _checkLogicCategories = CheckLogicCategory.fromJson(JsonStr);
            _checkLogics = CheckLogic.FromHeader(_checkLogicCategories);

        }
        
        private void LoadAllItemImage()
        {
            var filepath = Application.StartupPath + @"\Resource\Itemicons\mm_items_mono.png";
            _itemSpriteMono = new Bitmap (Image.FromFile(filepath));

        }

        private void LoadItemLogic()
        {
            var filepath = Application.StartupPath + @"\Resource\Mappings\" + ItemLogicMethod.CST_DEFAULT_FILE_NAME;
            _itemLogics = ItemLogicMethod.Deserialize(filepath);
        }

        private void DrawAllItems()
        {
            foreach (var item in _itemLogics)
            {
                DrawItem(item);
            }
        }

        private void DrawItem(ItemLogic itemLogic)
        {
            if (itemLogic.propertyName == null || itemLogic.propertyName == "")
                return;
            var pictureboxItem = ((System.Reflection.TypeInfo)GetType()).GetDeclaredField(itemLogic.propertyName).GetValue(this) as PictureBox;
            var posX = itemLogic.variants[0].positionX * 42;
            var posY = itemLogic.variants[0].positionY * 42;
            pictureboxItem.Image = _itemSpriteMono.Clone(new Rectangle(posX, posY, 42, 42), _itemSpriteMono.PixelFormat);
        }

        private void DrawSquareCategory()
        {
            foreach (var checkLogicCategory in _checkLogicCategories)
            {
                _pictureBoxZoomMoveController.AddRect(
                    checkLogicCategory.SquarePositionX - CST_RECT_WIDTH_HEIGHT/2,
                    checkLogicCategory.SquarePositionY - CST_RECT_WIDTH_HEIGHT/2,
                    CST_RECT_WIDTH_HEIGHT, CST_RECT_WIDTH_HEIGHT, 
                    CheckLogicZoneMethod.FromString(checkLogicCategory.Name)
                );
            }
        }


        private void Log(String message)
        {            
            tboxDebug.AppendText(message + "\r\n");
            Debug.WriteLine(message);
        }


        /*private void pictureBox2_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            // Debug.WriteLine(coordinates.X + " " + coordinates.Y);

            foreach(var checkLogicCategory in _checkLogicCategories)
            {
                var scaleX = checkLogicCategory.SquarePositionX * Map.Size.Width / 6000;
                var scaleY = checkLogicCategory.SquarePositionY * Map.Size.Height / 5555;
                if (coordinates.X >= scaleX -10 && coordinates.X <= scaleX +10 && 
                    coordinates.Y >= scaleY -10 && coordinates.Y <= scaleY +10)
                {
                    RefreshCheckListForCategory(checkLogicCategory);
                    CheckList.DisplayMember = "Id";
                    //Debug.WriteLine("On a cliqué sur la catégorie " + checkLogicCategory.Name);
                }
            }
        }*/

        private void RefreshCheckListForCategory(CheckLogicZone checkLogicZone)
        {
            CheckList.Items.Clear();

            foreach ( var checkLogic in _checkLogics) // recuperer tout les checks dans la catégorie
            {
                if (checkLogic.Zone == checkLogicZone)
                {
                    CheckList.Items.Add(checkLogic);
                }
            }
        }

        private void ImgBeans_Click(object sender, EventArgs e)
        {

        }

       /* private void Map_Paint(object sender, PaintEventArgs e)
        {
            DrawSquareCategory(e);
        } */

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAllItemImage();
            LoadItemLogic();
            LoadCheckCategory();
            _pictureBoxZoomMoveController = new PictureBoxZoomMoveController<CheckLogicZone>(mapMm);
            _pictureBoxZoomMoveController.SetSrcImage(Image.FromFile(Application.StartupPath + @"\Resource\Map\82k78q66tcha1.png"));
            _pictureBoxZoomMoveController.OnGraphicPathClick += RefreshCheckListForCategory;
            DrawSquareCategory();
            DrawAllItems();
        }

        private void CheckList_DrawItem(object sender, DrawItemEventArgs e)
        {
            var checkLogic = (CheckLogic)CheckList.Items[e.Index];

            Brush brush = Brushes.Red;

            if (checkLogic.IsClaim)
            {
                brush = Brushes.Gray;
                
            }
            else if (checkLogic.IsAvailable)
            {
                brush = Brushes.Green;
            }

            e.Graphics.DrawString(checkLogic.Id, e.Font, brush, e.Bounds, StringFormat.GenericDefault);
        }

        private void CheckList_MouseClick(object sender, MouseEventArgs e)
        {
            var checkList = (CheckLogic)CheckList.SelectedItem;
            checkList.IsClaim = !checkList.IsClaim;
            CheckList.Invalidate();
        }
    }
}
