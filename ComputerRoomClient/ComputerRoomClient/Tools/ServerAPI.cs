using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using SystemLibrary.Model;
using Refit;

namespace ComputerRoomClient.Tools
{
    public interface ServerAPI
    {
        /// <summary>
        /// 添加系统信息
        /// </summary>
        /// <param name="computer"></param>
        /// <returns></returns>
        [Post("/api/Health/AddMessage")]
        [Headers("Content-Type: application/json")]
        Task<ResposeName<ComputerInfo>> AddMessage([Body] ComputerInfo computer);

        /// <summary>
        /// 添加名称
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        [Post("/api/Setting")]
        Task<ResposeName<string>> AddName(string Name);
    }
}
