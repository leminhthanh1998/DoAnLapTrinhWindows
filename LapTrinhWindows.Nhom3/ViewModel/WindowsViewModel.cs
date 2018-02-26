using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhWindows.Nhom3
{
    class WindowsViewModel:BaseViewModel
    {
        #region public member

        /// <summary>
        /// Chieu rong toi thieu
        /// </summary>
        public double WindowMinimizeWidth { get; set; } = 300;
        /// <summary>
        /// Chieu cao toi thieu
        /// </summary>
        public double WindowMinimizeHeight { get; set; } = 300;

        /// <summary>
        /// Trang hien tai cua app
        /// </summary>
        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.Login;

        #endregion
    }
}
