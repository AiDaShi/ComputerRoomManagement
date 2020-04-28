using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerRoomManagement.LayminiuiTools
{
    /// <summary>
    /// 菜单表
    /// </summary>
    public class SystemMenuEntity
    {
        /// <summary>
        /// ID
        /// </summary>
        public long id { get; set; }

        /// <summary>
        /// 父级ID
        /// </summary>
        public long pid { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// 菜单图标
        /// </summary>
        public string icon { get; set; }
        /// <summary>
        /// 链接
        /// </summary>
        public string href { get; set; }
        /// <summary>
        /// 链接
        /// </summary>
        public string target { get; set; }
        /// <summary>
        /// 序号
        /// </summary>
        public int sort { get; set; }
        /// <summary>
        /// 是否菜单
        /// </summary>
        public bool status { get; set; }

    }
}
