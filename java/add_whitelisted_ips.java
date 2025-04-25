import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStream;
import java.io.OutputStreamWriter;
import java.net.HttpURLConnection;
import java.net.URL;
import java.net.URLConnection;
import java.util.stream.Collectors;

public class add_whitelisted_ips {

	public static void main(String[] args) throws IOException {
		// Details retrieved from the Authentication part.
		String userId = "";
		String token = "";
		
		String payload = "{\"IPAddressList\":[\"xx.xx.xx.xx\",\"xx.xx.xx.xx\"]}"; //Addition of only 1 IP is also possible
		
		URL url = new URL("https://api.decodo.com/v1/users/"+userId+"/whitelisted-ips");
		
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
