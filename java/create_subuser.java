import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStream;
import java.io.OutputStreamWriter;
import java.net.HttpURLConnection;
import java.net.URL;
import java.net.URLConnection;
import java.util.stream.Collectors;

public class create_subuser {

	public static void main(String[] args) throws IOException {
		// Details retrieved from Authentication part.
		String userId = "";
		String token = "";
		
		// Details for your new subuser
		String payload = "{\"username\":\"sub_username\",\"password\":\"sub_password\",\"traffic_limit\":0, \"service_type\":\"residential_proxies\"}";
		
		// Possible service types: residential_proxies, shared_proxies
		
		URL url = new URL("https://api.smartproxy.com/v1/users/"+userId+"/sub-users");
		
		URLConnection connection = url.openConnection();
		HttpURLConnection httpConn = (HttpURLConnection) connection;
		
		
		httpConn.setRequestProperty("User-Agent", "Mozilla/5.0");
		httpConn.setRequestProperty ("Authorization", "Token "+token);
		httpConn.setRequestMethod("POST");
		httpConn.setRequestProperty("Content-Type", "application/json; charset=UTF-8");
		httpConn.setRequestProperty("Accept", "application/json");

		httpConn.setDoOutput(true);
		OutputStream outStream = httpConn.getOutputStream();
		OutputStreamWriter outStreamWriter = new OutputStreamWriter(outStream, "UTF-8");
		outStreamWriter.write(payload);
		outStreamWriter.flush();
		outStreamWriter.close();
		outStream.close();
		
		if (200 <= httpConn.getResponseCode() && httpConn.getResponseCode() <= 299) {
		    BufferedReader br = new BufferedReader(new InputStreamReader(httpConn.getInputStream()));
			System.out.print(br.lines().collect(Collectors.joining()));
		} else {
		    BufferedReader br = new BufferedReader(new InputStreamReader(httpConn.getErrorStream()));
			System.out.print(br.lines().collect(Collectors.joining()));
		}
		
		httpConn.disconnect();
		
	}
}
