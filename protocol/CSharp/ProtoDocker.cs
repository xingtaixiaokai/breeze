 
namespace Proto4z  
{ 
 
    public class DockerPulse: Proto4z.IProtoObject //集群脉冲  
    {     
        //proto id   
        public const ushort protoID = 40007;  
        static public ushort getProtoID() { return 40007; } 
        static public string getProtoName() { return "DockerPulse"; } 
        //members   
        public DockerPulse()  
        { 
        } 
        public System.Collections.Generic.List<byte> __encode() 
        { 
            var data = new System.Collections.Generic.List<byte>(); 
            return data; 
        } 
        public int __decode(byte[] binData, ref int pos) 
        { 
            return pos; 
        } 
    } 
 
    public class CreateServiceInDocker: Proto4z.IProtoObject //创建并初始化一个service  
    {     
        //proto id   
        public const ushort protoID = 40001;  
        static public ushort getProtoID() { return 40001; } 
        static public string getProtoName() { return "CreateServiceInDocker"; } 
        //members   
        public ushort serviceType;  
        public ulong serviceID;  
        public uint dockerID;  
        public uint clientID;  
        public CreateServiceInDocker()  
        { 
            serviceType = 0;  
            serviceID = 0;  
            dockerID = 0;  
            clientID = 0;  
        } 
        public CreateServiceInDocker(ushort serviceType, ulong serviceID, uint dockerID, uint clientID) 
        { 
            this.serviceType = serviceType; 
            this.serviceID = serviceID; 
            this.dockerID = dockerID; 
            this.clientID = clientID; 
        } 
        public System.Collections.Generic.List<byte> __encode() 
        { 
            var data = new System.Collections.Generic.List<byte>(); 
            data.AddRange(Proto4z.BaseProtoObject.encodeUI16(this.serviceType)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeUI64(this.serviceID)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeUI32(this.dockerID)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeUI32(this.clientID)); 
            return data; 
        } 
        public int __decode(byte[] binData, ref int pos) 
        { 
            this.serviceType = Proto4z.BaseProtoObject.decodeUI16(binData, ref pos); 
            this.serviceID = Proto4z.BaseProtoObject.decodeUI64(binData, ref pos); 
            this.dockerID = Proto4z.BaseProtoObject.decodeUI32(binData, ref pos); 
            this.clientID = Proto4z.BaseProtoObject.decodeUI32(binData, ref pos); 
            return pos; 
        } 
    } 
 
    public class CreateServiceNotice: Proto4z.IProtoObject //服务创建好并初始化成功,广播给所有docker  
    {     
        //proto id   
        public const ushort protoID = 40002;  
        static public ushort getProtoID() { return 40002; } 
        static public string getProtoName() { return "CreateServiceNotice"; } 
        //members   
        public ushort serviceType;  
        public ulong serviceID;  
        public uint dockerID;  
        public uint clientID;  
        public CreateServiceNotice()  
        { 
            serviceType = 0;  
            serviceID = 0;  
            dockerID = 0;  
            clientID = 0;  
        } 
        public CreateServiceNotice(ushort serviceType, ulong serviceID, uint dockerID, uint clientID) 
        { 
            this.serviceType = serviceType; 
            this.serviceID = serviceID; 
            this.dockerID = dockerID; 
            this.clientID = clientID; 
        } 
        public System.Collections.Generic.List<byte> __encode() 
        { 
            var data = new System.Collections.Generic.List<byte>(); 
            data.AddRange(Proto4z.BaseProtoObject.encodeUI16(this.serviceType)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeUI64(this.serviceID)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeUI32(this.dockerID)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeUI32(this.clientID)); 
            return data; 
        } 
        public int __decode(byte[] binData, ref int pos) 
        { 
            this.serviceType = Proto4z.BaseProtoObject.decodeUI16(binData, ref pos); 
            this.serviceID = Proto4z.BaseProtoObject.decodeUI64(binData, ref pos); 
            this.dockerID = Proto4z.BaseProtoObject.decodeUI32(binData, ref pos); 
            this.clientID = Proto4z.BaseProtoObject.decodeUI32(binData, ref pos); 
            return pos; 
        } 
    } 
 
    public class DestroyServiceInDocker: Proto4z.IProtoObject //销毁一个Service  
    {     
        //proto id   
        public const ushort protoID = 40003;  
        static public ushort getProtoID() { return 40003; } 
        static public string getProtoName() { return "DestroyServiceInDocker"; } 
        //members   
        public ushort serviceType;  
        public ulong serviceID;  
        public DestroyServiceInDocker()  
        { 
            serviceType = 0;  
            serviceID = 0;  
        } 
        public DestroyServiceInDocker(ushort serviceType, ulong serviceID) 
        { 
            this.serviceType = serviceType; 
            this.serviceID = serviceID; 
        } 
        public System.Collections.Generic.List<byte> __encode() 
        { 
            var data = new System.Collections.Generic.List<byte>(); 
            data.AddRange(Proto4z.BaseProtoObject.encodeUI16(this.serviceType)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeUI64(this.serviceID)); 
            return data; 
        } 
        public int __decode(byte[] binData, ref int pos) 
        { 
            this.serviceType = Proto4z.BaseProtoObject.decodeUI16(binData, ref pos); 
            this.serviceID = Proto4z.BaseProtoObject.decodeUI64(binData, ref pos); 
            return pos; 
        } 
    } 
 
    public class DestroyServiceNotice: Proto4z.IProtoObject //已卸载并完成销毁,广播给所有docker  
    {     
        //proto id   
        public const ushort protoID = 40004;  
        static public ushort getProtoID() { return 40004; } 
        static public string getProtoName() { return "DestroyServiceNotice"; } 
        //members   
        public ushort serviceType;  
        public ulong serviceID;  
        public DestroyServiceNotice()  
        { 
            serviceType = 0;  
            serviceID = 0;  
        } 
        public DestroyServiceNotice(ushort serviceType, ulong serviceID) 
        { 
            this.serviceType = serviceType; 
            this.serviceID = serviceID; 
        } 
        public System.Collections.Generic.List<byte> __encode() 
        { 
            var data = new System.Collections.Generic.List<byte>(); 
            data.AddRange(Proto4z.BaseProtoObject.encodeUI16(this.serviceType)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeUI64(this.serviceID)); 
            return data; 
        } 
        public int __decode(byte[] binData, ref int pos) 
        { 
            this.serviceType = Proto4z.BaseProtoObject.decodeUI16(binData, ref pos); 
            this.serviceID = Proto4z.BaseProtoObject.decodeUI64(binData, ref pos); 
            return pos; 
        } 
    } 
 
    public class ShellForward: Proto4z.IProtoObject //壳子转发  
    {     
        //proto id   
        public const ushort protoID = 40005;  
        static public ushort getProtoID() { return 40005; } 
        static public string getProtoName() { return "ShellForward"; } 
        //members   
        public ShellForward()  
        { 
        } 
        public System.Collections.Generic.List<byte> __encode() 
        { 
            var data = new System.Collections.Generic.List<byte>(); 
            return data; 
        } 
        public int __decode(byte[] binData, ref int pos) 
        { 
            return pos; 
        } 
    } 
 
    public class ClientForward: Proto4z.IProtoObject //client转发  
    {     
        //proto id   
        public const ushort protoID = 40006;  
        static public ushort getProtoID() { return 40006; } 
        static public string getProtoName() { return "ClientForward"; } 
        //members   
        public ClientForward()  
        { 
        } 
        public System.Collections.Generic.List<byte> __encode() 
        { 
            var data = new System.Collections.Generic.List<byte>(); 
            return data; 
        } 
        public int __decode(byte[] binData, ref int pos) 
        { 
            return pos; 
        } 
    } 
 
} 
 
 
