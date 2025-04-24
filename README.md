<p align="center">
<a href="https://dashboard.decodo.com/?page=residential-proxies&utm_source=socialorganic&utm_medium=social&utm_campaign=resi_trial_GITHUB"><img src="https://github.com/user-attachments/assets/60bb48bd-8dcc-48b2-82c9-a218e1e4449c"></a>
</p>

[![](https://dcbadge.vercel.app/api/server/Ja8dqKgvbZ)](https://discord.gg/Ja8dqKgvbZ)

## List of contents

- [Introduction](#introduction)
- [Authentication](#authentication)
- [Get sub users](#get-sub-users)
- [Create subuser](#create-subuser)
- [Update subuser](#update-subuser)
- [Get sub user traffic](#get-sub-user-traffic)
- [Delete subuser](#delete-subuser)
- [Get whitelisted IPs](#get-whitelisted-ips)
- [Delete subuser](#delete-subuser)
- [Get whitelisted IPs](#get-whitelisted-ips)
- [Add whitelisted IPs](#add-whitelisted-ips)
- [Delete whitelisted IP](#delete-whitelisted-ip)
- [Get subscriptions](#get-subscriptions)
- [Get endpoints](#get-endpoints)
- [Get endpoints by type](#get-endpoints-by-type)
- [License](#license)

## Introduction

With Decodo API you will be able to access proxies and take full control over your account.

- Create, Update, Delete and set traffic limits for your proxy users
- Pull out reports for traffic usage
- Create and Delete whitelisted IPs to simplify authentication
- Filter and list all endpoints with ports
- Check the status of your current subscription

Need more API code examples or information? Visit our [main documentation](https://help.decodo.com/reference). <br />
Looking for something else? Visit our [General Repository](https://github.com/Decodo/Decodo/) for more fun.

## Authentication

API Link: https://api.decodo.com/v1/auth

### Request

`POST /auth/`

### Response
    
    HTTP/1.1 200 OK
    Content-Type: application/json
    {
    "user_id": "d3af2539-4259-4484-a355-062fd1111"
    "token": "sdfdsfeXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJ1c2VyX2lkIjoyODI0LCJ1c2VybmFtZSI6InBhdWxpdXN0YXIiLCJleHAiOjE"
    }
    
Take a note of or implement functionality to pass `user_id` and `token` parameters to other API calls as it will be required to navigate.

### Examples

| Programming Language | Example location         | Download |
| -------------------- | ------------------------ | -------- |
| Java                  | [java/authentication.java](https://github.com/Decodo/Decodo-API/blob/master/java/authentication.java) |``` curl https://raw.githubusercontent.com/Decodo/Decodo-API/master/java/authentication.java > authentication.java ``` |
| PHP                 | [php/authentication.php](https://github.com/Decodo/Decodo-API/blob/master/php/authentication.php)   | ``` curl https://raw.githubusercontent.com/Decodo/Decodo-API/master/php/authentication.php > authentication.php ``` |
| C#                 | [csharp/authentication.cs](https://github.com/Decodo/Decodo-API/blob/master/csharp/authentication.cs)   | ``` curl https://raw.githubusercontent.com/Decodo/Decodo-API/master/csharp/authentication.cs > authentication.cs ``` |

## Get sub users

API Link: https://api.decodo.com/v1/users/{userId}/sub-users

### Request

`GET users/:userId/sub-users`

### Response
    
    HTTP/1.1 200 OK
    Content-Type: application/json
    [
      0:{
        "id":24570
        "username":"name"
        "status":"active"
        "created_at":"2019-03-23 13:08"
        "traffic_limit":NULL
        "service_type":"residential_proxies"
      }
    ]

### Examples

| Programming Language | Example location         | Download |
| -------------------- | ------------------------ | -------- |
| Java                  | [java/get_subusers.java](https://github.com/Decodo/Decodo-API/blob/master/java/get_subusers.java) |``` curl https://raw.githubusercontent.com/Decodo/Decodo-API/master/java/get_subusers.java > get_subusers.java ``` |
| PHP                 | [php/get_subusers.php](https://github.com/Decodo/Decodo-API/blob/master/php/get_subusers.php)   | ``` curl https://raw.githubusercontent.com/Decodo/Decodo-API/master/php/get_subusers.php > get_subusers.php ``` |
| C#                 | [csharp/get_subusers.cs](https://github.com/Decodo/Decodo-API/blob/master/csharp/get_subusers.cs)   | ``` curl https://raw.githubusercontent.com/Decodo/Decodo-API/master/csharp/get_subusers.cs > get_subusers.cs ``` |

## Create subuser

API Link: https://api.Decodo.com/v1/users/{userId}/sub-users

### Request

`POST users/:userId/sub-users`

### Request body

`{"username":"","password":"","service_type":""}`

### Response
    
    HTTP/1.1 201 Created
    Content-Type: application/json
    {}

### Examples

| Programming Language | Example location         | Download |
| -------------------- | ------------------------ | -------- |
| Java                  | [java/create_subuser.java](https://github.com/Decodo/Decodo-API/blob/master/java/create_subuser.java) |``` curl https://raw.githubusercontent.com/Decodo/Decodo-API/master/java/create_subuser.java > create_subuser.java ``` |
| PHP                 | [php/create_subuser.php](https://github.com/Decodo/Decodo-API/blob/master/php/create_subuser.php)   | ``` curl https://raw.githubusercontent.com/Decodo/Decodo-API/master/php/create_subuser.php > create_subuser.php ``` |
| C#                 | [csharp/create_subuser.cs](https://github.com/Decodo/Decodo-API/blob/master/csharp/create_subuser.cs)   | ``` curl https://raw.githubusercontent.com/Decodo/Decodo-API/master/csharp/create_subuser.cs > create_subuser.cs ``` |

## Update subuser

API Link: https://api.decodo.com/v1/users/{userId}/sub-users

### Request

`PUT users/:userId/sub-users`

### Request body

`{"traffic_limit":0,"password":""}`

### Response
    
    HTTP/1.1 201 Created
    Content-Type: application/json
    {}

### Examples

| Programming Language | Example location         | Download |
| -------------------- | ------------------------ | -------- |
| Java                  | [java/update_subuser.java](https://github.com/Decodo/Decodo-API/blob/master/java/update_subuser.java) |``` curl https://raw.githubusercontent.com/Decodo/Decodo-API/master/java/update_subuser.java > update_subuser.java ``` |
| PHP                 | [php/update_subuser.php](https://github.com/Decodo/Decodo-API/blob/master/php/update_subuser.php)   | ``` curl https://raw.githubusercontent.com/Decodo/Decodo-API/master/php/update_subuser.php > update_subuser.php ``` |
| C#                 | [csharp/update_subuser.cs](https://github.com/Decodo/Decodo-API/blob/master/csharp/update_subuser.cs)   | ``` curl https://raw.githubusercontent.com/Decodo/Decodo-API/master/csharp/update_subuser.cs > update_subuser.cs ``` |

## Get sub user traffic

API Link: https://api.decodo.com/v1/users/{userId}/sub-users/{username}/traffic

### Request

`GET users/:userId/sub-users/:username/traffic`

### Response
    
    HTTP/1.1 200 OK
    Content-Type: application/json
    {
    "traffic":0.04
    }

### Examples

| Programming Language | Example location         | Download |
| -------------------- | ------------------------ | -------- |
| Java                  | [java/get_subuser_traffic.java](https://github.com/Decodo/Decodo-API/blob/master/java/get_subuser_traffic.java) |``` curl https://raw.githubusercontent.com/Decodo/Decodo-API/master/java/get_subuser_traffic.java > get_subuser_traffic.java ``` |
| PHP                 | [php/get_subuser_traffic.php](https://github.com/Decodo/Decodo-API/blob/master/php/get_subuser_traffic.php)   | ``` curl https://raw.githubusercontent.com/Decodo/Decodo-API/master/php/get_subuser_traffic.php > get_subuser_traffic.php ``` |
| C#                 | [csharp/get_subuser_traffic.cs](https://github.com/Decodo/Decodo-API/blob/master/csharp/get_subuser_traffic.cs)   | ``` curl https://raw.githubusercontent.com/Decodo/Decodo-API/master/csharp/get_subuser_traffic.cs > get_subuser_traffic.cs ``` |

## Delete subuser

API Link: https://api.decodo.com/v1/users/{userId}/sub-users/{sub_user_id}

### Request

`DELETE users/:userId/sub-users/:sub_user_id`

### Response
    
    HTTP/1.1 204 No Content
    Content-Type: application/json
    {}

### Examples

| Programming Language | Example location         | Download |
| -------------------- | ------------------------ | -------- |
| Java                  | [java/delete_subuser.java](https://github.com/Decodo/Decodo-API/blob/master/java/delete_subuser.java) |``` curl https://raw.githubusercontent.com/Decodo/Decodo-API/master/java/delete_subuser.java > delete_subuser.java ``` |
| PHP                 | [php/delete_subuser.php](https://github.com/Decodo/Decodo-API/blob/master/php/delete_subuser.php)   | ``` curl https://raw.githubusercontent.com/Decodo/Decodo-API/master/php/delete_subuser.php > delete_subuser.php ``` |
| C#                 | [csharp/delete_subuser.cs](https://github.com/Decodo/Decodo-API/blob/master/csharp/delete_subuser.cs)   | ``` curl https://raw.githubusercontent.com/Decodo/Decodo-API/master/csharp/delete_subuser.cs > delete_subuser.cs ``` |

## Get whitelisted IPs

API Link: https://api.decodo.com/v1/users/{userId}/whitelisted-ips

### Request

`GET users/:userId/whitelisted-ips`

### Response
    
    HTTP/1.1 200 OK
    Content-Type: application/json
    [
      0:{
        "id":69489
        "ip":"127.0.0.1"
        "enabled":true
        "created_at":"2019-05-22 12:44"
        }
    ]

### Examples

| Programming Language | Example location         | Download |
| -------------------- | ------------------------ | -------- |
| Java                  | [java/get_whitelisted_ips.java](https://github.com/Decodo/Decodo-API/blob/master/java/get_whitelisted_ips.java) |``` curl https://raw.githubusercontent.com/Decodo/Decodo-API/master/java/get_whitelisted_ips.java > get_whitelisted_ips.java ``` |
| PHP                 | [php/get_whitelisted_ips.php](https://github.com/Decodo/Decodo-API/blob/master/php/get_whitelisted_ips.php)   | ``` curl https://raw.githubusercontent.com/Decodo/Decodo-API/master/php/get_whitelisted_ips.php > get_whitelisted_ips.php ``` |
| C#                 | [csharp/get_whitelisted_ips.php](https://github.com/Decodo/Decodo-API/blob/master/csharp/get_whitelisted_ips.php)   | ``` curl https://raw.githubusercontent.com/Decodo/Decodo-API/master/csharp/get_whitelisted_ips.cs > get_whitelisted_ips.cs ``` |

## Add whitelisted IPs

API Link: https://api.decodo.com/v1/users/{userId}/whitelisted-ips

### Request

`POST users/:userId/whitelisted-ips`

### Request body

`{"IPAddressList":[null]}`

### Response
    
    HTTP/1.1 200 OK
    Content-Type: application/json
    {}

### Examples

| Programming Language | Example location         | Download |
| -------------------- | ------------------------ | -------- |
| Java                  | [java/add_whitelisted_ips.java](https://github.com/Decodo/Decodo-API/blob/master/java/add_whitelisted_ips.java) |``` curl https://raw.githubusercontent.com/Decodo/Decodo-API/master/java/add_whitelisted_ips.java > add_whitelisted_ips.java ``` |
| PHP                 | [php/add_whitelisted_ips.php](https://github.com/Decodo/Decodo-API/blob/master/php/add_whitelisted_ips.php)   | ``` curl https://raw.githubusercontent.com/Decodo/Decodo-API/master/php/add_whitelisted_ips.php > add_whitelisted_ips.php ``` |
| C#                 | [csharp/add_whitelisted_ips.php](https://github.com/Decodo/Decodo-API/blob/master/csharp/add_whitelisted_ips.cs)   | ``` curl https://raw.githubusercontent.com/Decodo/Decodo-API/master/csharp/add_whitelisted_ips.cs > add_whitelisted_ips.cs ``` |

## Delete whitelisted IP

API Link: https://api.decodo.com/v1/users/{userId}/whitelisted-ips/{id}

### Request

`DELETE users/:userId/whitelisted-ips/:id`

### Response
    
    HTTP/1.1 204 No Content
    Content-Type: application/json
    {}

### Examples

| Programming Language | Example location         | Download |
| -------------------- | ------------------------ | -------- |
| Java                  | [java/delete_whitelisted_ip.java](https://github.com/Decodo/Decodo-API/blob/master/java/delete_whitelisted_ip.java) |``` curl https://raw.githubusercontent.com/Decodo/Decodo-API/master/java/delete_whitelisted_ip.java > delete_whitelisted_ip.java ``` |
| PHP                 | [php/delete_whitelisted_ip.php](https://github.com/Decodo/Decodo-API/blob/master/php/delete_whitelisted_ip.php)   | ``` curl https://raw.githubusercontent.com/Decodo/Decodo-API/master/php/delete_whitelisted_ip.php > delete_whitelisted_ip.php ``` |
| C#                 | [csharp/delete_whitelisted_ip.cs](https://github.com/Decodo/Decodo-API/blob/master/csharp/delete_whitelisted_ip.cs)   | ``` curl https://raw.githubusercontent.com/Decodo/Decodo-API/master/csharp/delete_whitelisted_ip.cs > delete_whitelisted_ip.cs ``` |

## Get subscriptions

API Link: https://api.decodo.com/v1/users/{userId}/subscriptions

### Request

`GET users/:userId/subscriptions`

### Response
    
    HTTP/1.1 200 OK
    Content-Type: application/json
    {
    "traffic_limit":"50"
    "traffic_per_period":"0.15"
    "users_limit":3
    "ip_address_limit":2
    "valid_from":"2018-11-08"
    "valid_until":"2019-06-30"
    "service_type":"residential_proxies"
    }

### Examples

| Programming Language | Example location         | Download |
| -------------------- | ------------------------ | -------- |
| Java                  | [java/get_subscriptions.java](https://github.com/Decodo/Decodo-API/blob/master/java/get_subscriptions.java) |``` curl https://raw.githubusercontent.com/Decodo/Decodo-API/master/java/get_subscriptions.java > get_subscriptions.java ``` |
| PHP                 | [php/get_subscriptions.php](https://github.com/Decodo/Decodo-API/blob/master/php/get_subscriptions.php)   | ``` curl https://raw.githubusercontent.com/Decodo/Decodo-API/master/php/get_subscriptions.php > get_subscriptions.php ``` |
| C#                 | [csharp/get_subscriptions.cs](https://github.com/Decodo/Decodo-API/blob/master/csharp/get_subscriptions.php)   | ``` curl https://raw.githubusercontent.com/Decodo/Decodo-API/master/csharp/get_subscriptions.cs > get_subscriptions.cs ``` |

## Get endpoints

API Link: https://api.decodo.com/v1/endpoints

### Request

`GET endpoints`

### Response
    
    HTTP/1.1 200 OK
    Content-Type: application/json
    [
      0:{
        "type":"random"
        "available_locations":"148"
        "url":"endpoints/random"
      }
      1:{
        "type":"sticky"
        "available_locations":"62"
        "url":"endpoints/sticky"
      }
    ]

### Examples

| Programming Language | Example location         | Download |
| -------------------- | ------------------------ | -------- |
| Java                  | [java/get_endpoints.java](https://github.com/Decodo/Decodo-API/blob/master/java/get_endpoints.java) |``` curl https://raw.githubusercontent.com/Decodo/Decodo-API/master/java/get_endpoints.java > get_endpoints.java ``` |
| PHP                 | [php/get_endpoints.php](https://github.com/Decodo/Decodo-API/blob/master/php/get_endpoints.php)   | ``` curl https://raw.githubusercontent.com/Decodo/Decodo-API/master/php/get_endpoints.php > get_endpoints.php ``` |
| C#                 | [csharp/get_endpoints.cs](https://github.com/Decodo/Decodo-API/blob/master/csharp/get_endpoints.cs)   | ``` curl https://raw.githubusercontent.com/Decodo/Decodo-API/master/csharp/get_endpoints.cs > get_endpoints.cs ``` |

## Get endpoints by type

API Link: https://api.decodo.com/v1/endpoints/{type}

### Request

`GET endpoints/:type`

### Response
    
    HTTP/1.1 200 OK
    Content-Type: application/json
    [
      0:{
        "location":"Random"
        "hostname":"gate.decodo.com"
        "port_range":"7000"
      }
      1:{
        "location":"Canada"
        "hostname":"ca.decodo.com
        "port_range":"20000"
      }
    ]

### Examples

| Programming Language | Example location         | Download |
| -------------------- | ------------------------ | -------- |
| Java                  | [java/get_endpoints_by_type.java](https://github.com/Decodo/Decodo-API/blob/master/java/get_endpoints_by_type.java) |``` curl https://raw.githubusercontent.com/Decodo/Decodo-API/master/java/java/get_endpoints_by_type.java > get_endpoints_by_type.java ``` |
| PHP                 | [php/get_endpoints_by_type.php](https://github.com/Decodo/Decodo-API/blob/master/php/get_endpoints_by_type.php)   | ``` curl https://raw.githubusercontent.com/Decodo/Decodo-API/master/php/get_endpoints_by_type.php > get_endpoints_by_type.php ``` |
| C#                 | [csharp/get_endpoints_by_type.cs](https://github.com/Decodo/Decodo-API/blob/master/csharp/get_endpoints_by_type.cs)   | ``` curl https://raw.githubusercontent.com/Decodo/Decodo-API/master/csharp/get_endpoints_by_type.cs > get_endpoints_by_type.cs ``` |

## License

All code is released under [MIT License](https://github.com/Decodo/Decodo/blob/master/LICENSE)

## Need help?

Email - sales@decodo.com
<br><a href="https://decodo.com">Live chat 24/7</a>

