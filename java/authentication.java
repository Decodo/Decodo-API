import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;
import java.net.URLConnection;
import java.nio.charset.StandardCharsets;
import java.util.Base64;
import java.util.stream.Collectors;

public class authentication {

	public static void main(String[] args) throws IOException {
		String userCredentials = "username:password"; // Your Smartproxy credentials
		String basicAuth = Base64.getEncoder().encodeToString(userCredentials.getBytes(StandardCharsets.UTF_8));

		URL url = new URL("https://api.decodo.com/v1/auth");
		
		URLConnection connection = url.openConnection();
		HttpURLConnection httpConn = (HttpURLConnection) connection;
		
		httpConn.setRequestProperty("User-Agent", "Mozilla/5.0");
		httpConn.setRequestProperty ("Authorization", "Basic "+basicAuth);
		httpConn.setRequestMethod("POST");
		
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
