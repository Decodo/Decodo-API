<?php

// Information obtained from authentication

$userId = "";
$token = "";
$subUserId = 0; // Retrieved from Get Subusers

$url = 'https://api.decodo.com/v1/users/' . $userId . '/sub-users/' . $subUserId;

$data = array(
  "password" => "",
  "traffic_limit" => 0 // Optional parameter
);

$payload = json_encode($data);

$ch = curl_init();

curl_setopt($ch, CURLOPT_URL, $url);
curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
curl_setopt($ch, CURLOPT_CUSTOMREQUEST, "PUT");

$headers = array();
$headers[] = "Accept: application/json";
$headers[] = "Content-Type: application/json";
$headers[] = "Authorization: Token $token";
curl_setopt($ch, CURLOPT_HTTPHEADER, $headers);
curl_setopt($ch, CURLOPT_POSTFIELDS, $payload);

$result = curl_exec($ch);
if (curl_errno($ch)) {
    echo "Error: " . curl_error($ch);
}
curl_close($ch);
echo $result;
