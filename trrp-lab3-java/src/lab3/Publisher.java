package lab3;

import com.company.AppConfig;

import javax.xml.ws.Endpoint;

import static com.company.Main.CreateDBWithTables;

public class Publisher {
    public static void main(String... args) {
        CreateDBWithTables();
        AppConfig appConfig = AppConfig.load();
        Endpoint.publish("http://" + appConfig.rpcServer.host + ":" + appConfig.rpcServer.port + "/wss/printToPSQL", new PrintToPSQLImpl());
    }
}
