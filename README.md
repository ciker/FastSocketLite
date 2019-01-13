# FastSocketList
FastSocket.Net(https://github.com/ihaoqihao/FastSocket.Net)을 .NET Core 포팅 버전
  
app.config  
```
<?xml version="1.0"?>
<configuration>

  <configSections>
    <section name="socketServer"
             type="Sodao.FastSocket.Server.Config.SocketServerConfig, FastSocket.Server"/>
  </configSections>

  <socketServer>
    <servers>
      <server name="demo1"
              port="9999"
              socketBufferSize="8192"
              messageBufferSize="8192"
              maxMessageSize="102400"
              maxConnections="20000"
              serviceType="service type"
              protocol="thrift|commandLine|custom protocol type"/>
    </servers>
  </socketServer>

</configuration>
```  