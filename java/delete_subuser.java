import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;
import java.net.URLConnection;
import java.util.stream.Collectors;

public class delete_subuser {

	public static void main(String[] args) throws IOException {
		// Details retrieved from the Authentication part.
		String userId = "";
		String token = "";
		int subuserId = 0; // Received from Get Subusers part.
		
		URL url = new URL("https://api.decodo.com/v1/users/"+userId+"/sub-users/"+subuserId);
				
		URLConnection connection = url.openConnection();
		HttpURLConnection httpConn = (HttpURLConnection) connection;
		
		
		httpConn.setRequestProperty("User-Agent", "Mozilla/5.0");
		httpConn.setRequestProperty ("Authorization", "Token "+token);
		httpConn.setRequestMethod("DELETE");

		
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
