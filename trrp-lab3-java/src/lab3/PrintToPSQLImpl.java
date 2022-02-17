package lab3;

import com.company.FirstNFLine;

import javax.jws.WebService;

import static com.company.Main.PrintToPostgreSQL;


@WebService(endpointInterface = "lab3.PrintToPSQLWebService")
public class PrintToPSQLImpl implements PrintToPSQLWebService {
    @Override
    public String printToPostgreSQL(FirstNFLine line) {
        PrintToPostgreSQL(line);
        return "НИЧЕГО СЕБЕ!!!! ДОБАВЛЕНА СТРОКА " + line.toString() + "! ЭТО ТОЧНО ВОЛШЕБСТВО!!!";
    }
}
