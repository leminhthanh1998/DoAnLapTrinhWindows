using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace LapTrinhWindows.Nhom3
{
    public class BasePage : Page
    {
        #region Public member
        /// <summary>
        /// Hieu ung khi trang duoc load
        /// </summary>
        public PageAnimation PageLoadAnimation { get; set; } = PageAnimation.SlideFromRight;
        /// <summary>
        /// Hieu ung khi trang unload
        /// </summary>
        public PageAnimation PageUnloadAnimation { get; set; } = PageAnimation.SlideOutToLeft;
        /// <summary>
        /// Thoi hien thuc hien hieu ung
        /// </summary>
        public float SlideSeccond { get; set; } = 0.9f;

        #endregion

        #region Contructor

        public BasePage()
        {
            //Khi bat dau hieu ung thi phai an control truoc tien
            if (PageLoadAnimation != PageAnimation.None)
                Visibility = Visibility.Collapsed;
            Loaded += BasePage_Loaded;
        }

        #endregion

        #region Page load/unload

        private async void BasePage_Loaded(object sender, RoutedEventArgs e)
        {
            await AnimationIn();
        }

        private async Task AnimationIn()
        {
            //Chac chan chung ta co hieu ung de thuc hien
            if (PageLoadAnimation == PageAnimation.None)
                return;
            switch (PageLoadAnimation)
            {
                case PageAnimation.SlideFromRight:
                    await this.SlideFromRight(SlideSeccond);
                    break;
            }
        }

        #endregion
    }
}
