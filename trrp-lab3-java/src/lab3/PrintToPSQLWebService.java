package lab3;

import com.company.FirstNFLine;

import javax.jws.WebMethod;
import javax.jws.WebService;
import javax.jws.soap.SOAPBinding;
@WebService
@SOAPBinding(style = SOAPBinding.Style.RPC)
public interface PrintToPSQLWebService {
    @WebMethod
    public String printToPostgreSQL(FirstNFLine line);
}
