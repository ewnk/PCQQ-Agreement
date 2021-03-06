namespace QQ.Framework.Packets.Receive.Message
{
    /// <summary>
    /// </summary>
    public class Receive_0X0352 : ReceivePacket
    {
        /// <summary>
        /// </summary>
        public Receive_0X0352(byte[] byteBuffer, QQUser user)
            : base(byteBuffer, user, user.TXProtocol.SessionKey)
        {
        }

        protected override void ParseBody()
        {
            Decrypt(User.TXProtocol.SessionKey);
            Reader.ReadBytes(4);
        }
    }
}