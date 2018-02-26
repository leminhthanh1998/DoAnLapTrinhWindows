using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace LapTrinhWindows.Nhom3
{
    /// <summary>
    /// 1 class ho tro cho cac hieu ung
    /// </summary>
    public static class StoryboardHelper
    {
        /// <summary>
        /// them hieu ung chuyen trang tu ben phai vao
        /// </summary>
        /// <param name="storyboard"></param>
        /// <param name="seccond"></param>
        /// <param name="offset"></param>
        /// <param name="decelerationRatio"></param>
        public static void AddSlideFromRight(this Storyboard storyboard, float seccond, double offset,
            float decelerationRatio = 0.9f)
        {
            var animation = new ThicknessAnimation()
            {
                Duration = new Duration(TimeSpan.FromSeconds(seccond)),
                From = new Thickness(offset, 0, -offset, 0),
                To = new Thickness(0),
                DecelerationRatio = decelerationRatio
            };
            //Dat target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));
            //them vao storyboard
            storyboard.Children.Add(animation);
        }

        /// <summary>
        /// them hieu ung chuyen trang ra ben trai
        /// </summary>
        /// <param name="storyboard"></param>
        /// <param name="seccond"></param>
        /// <param name="offset"></param>
        /// <param name="decelerationRatio"></param>
        public static void AddSlidetoLeft(this Storyboard storyboard, float seccond, double offset,
            float decelerationRatio = 0.9f)
        {
            var animation = new ThicknessAnimation()
            {
                Duration = new Duration(TimeSpan.FromSeconds(seccond)),
                From = new Thickness(-offset, 0, offset, 0),
                To = new Thickness(0),
                DecelerationRatio = decelerationRatio
            };
            //Dat target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));
            //them vao storyboard
            storyboard.Children.Add(animation);
        }
    }
}
