using System;

namespace ComputerRoomManagement.DTOModel
{
    public class PushMessageDTO
    {
        public string Id { get; internal set; }
        public object Name { get; internal set; }
        public object Detail { get; internal set; }
        public object Type { get; internal set; }
        public object ToUser { get; internal set; }
        public DateTime CreateTime { get; internal set; }
    }
}