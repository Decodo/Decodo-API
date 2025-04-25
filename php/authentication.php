<?php

$url = 'https://api.decodo.com/v1/auth';

// Your smartproxy credentials

$auth = base64_encode("username:password");

$ch = curl_init();

curl_setopt($ch, CURLOPT_URL, $url);
curl_setopt($ch, CURLOPT_RETURNTRANSFER, 1);
curl_setopt($ch, CURLOPT_CUSTOMREQUEST, "POST");

$headers = array();
$headers[] = "Accept: application/json";
$headers[] = "Authorization: Basic $auth";
curl_setopt($ch, CURLOPT_HTTPHEADER, $headers);

$result = curl_exec($ch);
if (curl_errno($ch)) {
    echo 'Error:' . curl_error($ch);
}
curl_close($ch);
echo $result;
