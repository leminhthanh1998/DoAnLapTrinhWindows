using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace LapTrinhWindows.Nhom3
{
    public static class PageAnimations
    {
        /// <summary>
        /// Trang vao tu ben phai
        /// </summary>
        /// <param name="page"></param>
        /// <param name="seccond"></param>
        /// <returns></returns>
        public static async Task SlideFromRight(this Page page, float seccond)
        {
            //Tao 1 bien storyboard
            var sb = new Storyboard();
            //Add slide from right animation
            sb.AddSlideFromRight(seccond, page.WindowWidth);
            //Bat dau hieu ung
            sb.Begin(page);
            //Hien thi lai trang
            page.Visibility = Visibility.Visible;
           
            //Cho cho hoan tat
            await Task.Delay((int) (seccond*1000));
        }

        /// <summary>
        /// Trang ra ben trai
        /// </summary>
        /// <param name="page"></param>
        /// <param name="seccond"></param>
        /// <returns></returns>
        public static async Task SlideToLeft(this Page page, float seccond)
        {
            //Tao 1 bien storyboard
            var sb = new Storyboard();
            //Add slide from right animation
            sb.AddSlidetoLeft(seccond, page.WindowWidth);
            //Bat dau hieu ung
            sb.Begin(page);
            //Hien thi lai trang
            page.Visibility = Visibility.Visible;
           
            //Cho cho hoan tat
            await Task.Delay((int)(seccond * 1000));
        }
    }
}
