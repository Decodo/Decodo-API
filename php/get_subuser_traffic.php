<?php

// Information obtained from authentication

$userId = '';
$token = '';
$username = 'b35g5sg4h345'; // Name of your subuser
$query = array(
  'type' => '', // Available types: 24h, month, 7days, custom. If custom type is selected, you must provide $from and $to parameters
  'from' => '', //yyyy-mm-dd
  'to' => ''
);
$url = 'https://api.decodo.com/v1/users/' . $userId . '/sub-users/' . $username . '/traffic?' . http_build_query($query, '', "&");

$ch = curl_init();

curl_setopt($ch, CURLOPT_URL, $url);
curl_setopt($ch, CURLOPT_RETURNTRANSFER, 1);
curl_setopt($ch, CURLOPT_CUSTOMREQUEST, "GET");

$headers = array();
$headers[] = "Accept: application/json";
$headers[] = "Authorization: Token $token";
curl_setopt($ch, CURLOPT_HTTPHEADER, $headers);

$result = curl_exec($ch);
if (curl_errno($ch)) {
    echo 'Error:' . curl_error($ch);
}
curl_close($ch);
echo $result;
