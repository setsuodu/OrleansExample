using System.IO;
using Google.Protobuf;

public class ProtobufferTool
{
    // 序列化protobuf
    public static byte[] Serialize(IMessage msg)
    {
        using (MemoryStream rawOutput = new MemoryStream())
        {
            CodedOutputStream output = new CodedOutputStream(rawOutput);
            output.WriteMessage(msg);
            output.Flush();
            byte[] result = rawOutput.ToArray();
            return result;
        }
    }

    // 反序列化protobuf
    public static T Deserialize<T>(byte[] dataBytes) where T : IMessage, new()
    {
        CodedInputStream stream = new CodedInputStream(dataBytes);
        T msg = new T();
        stream.ReadMessage(msg);
        return msg;
    }
}
