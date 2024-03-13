# Instructions
- Criar um adapter que recebe um FileLogger como dependência e implementa ILogger
- O Log() deve chamar LogFile()
- Colocar na função main() a criação do Adapter e a chamada de adapter.Log();

# Team
- Laís Lisboa

# Example Reference

```csharp
public class Program
{
    public static void Main()
    {

        AuthService auth = new AuthService();
        ConnectionAuthAdapter adapter = new ConnectionAuthAdapter(auth);
        Connect(adapter);

    }

    public static string Connect(IConnection connection){
        return connection.GetRequest();
    }
}

public interface IConnection{
    string GetRequest();
}

class AuthService{
    public string GetUserToken(){
        return "User Token - 112bn3rbvbev1b1";
    }
}

class ConnectionAuthAdapter : IConnection{

    AuthService auth;

    public ConnectionAuthAdapter(AuthService auth){
        this.auth = auth;
    }

    public string GetRequest(){
        return "Connection Request 100012\n" + auth.GetUserToken();
    }
}
```