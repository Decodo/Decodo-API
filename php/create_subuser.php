<?php

// Information obtained from authentication

$userId = "";
$token = "";

$url = 'https://api.decodo.com/v1/users/' . $userId . '/sub-users';

$data = array(
  "username" => "",
  "password" => "",
  "traffic_limit" => 0, // Can be float
  "service_type" => "" // Possible values: residential_proxies, shared_proxies
);

$payload = json_encode($data);

$ch = curl_init();

curl_setopt($ch, CURLOPT_URL, $url);
curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
curl_setopt($ch, CURLOPT_CUSTOMREQUEST, "POST");

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
