namespace ComputerRoomManagement.Models
{
    public class Message
    {
        public object Id { get; internal set; }
        public object CreateTime { get; internal set; }
        public object Name { get; internal set; }
        public object Detail { get; internal set; }
        public object ToUser { get; internal set; }
        public object Type { get; internal set; }
    }
}