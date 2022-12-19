// ignore_for_file: non_constant_identifier_names, prefer_interpolation_to_compose_strings

import 'dart:convert';
import 'dart:io';

import 'package:ebarbershop_mobile/utils/util.dart';
import 'package:flutter/cupertino.dart';
import 'package:http/http.dart';
import 'package:http/io_client.dart';
import 'package:provider/provider.dart';

class BaseProvider<T> with ChangeNotifier {

  static String? _endpoint;
  static String? _baseUrl;

  HttpClient client = HttpClient();
  IOClient? http;

  BaseProvider(String endpoint){
    _baseUrl = const String.fromEnvironment("baseUrl", defaultValue: "http://10.0.2.2:5192/api/");
    if(_baseUrl!.endsWith("/") == false){
      _baseUrl = _baseUrl! + "/";
    }
    
    _endpoint = endpoint;

    client.badCertificateCallback =(cert, host, port) => true;
    http = IOClient(client);
  }

  Future<List<T>> Get() async {

    var url = "${_baseUrl}${_endpoint}";

    var uri = Uri.parse(url);

     Map<String , String> headers = getHeaders();

     var response = await http!.get(uri , headers: headers);

     if(isValidResponseCode(response)){
      var data = jsonDecode(response.body);
      List<T> list = data.map((x) => fromJson(x)).cast<T>().toList(); 
      return list;
     }
     else{
      throw Exception("Wrong username or password");
     }
  }

  Future<T?> insert(request) async
  {
    var url = "$_baseUrl$_endpoint";
    var uri = Uri.parse(url);

    var headers = getHeaders();
    var jsonRequest = jsonEncode(request);
    var response = await http!.post(uri,headers: headers,body: jsonRequest);

    if(isValidResponseCode(response))
    {
      var data = jsonDecode(response.body);
      return fromJson(data) as T;
    }
    else{
      return null;
    }

  }

   Future<T?> update(id,request) async
  {
    var url = "$_baseUrl$_endpoint/$id";
    var uri = Uri.parse(url);

    var headers = getHeaders();
    var jsonRequest = jsonEncode(request);
    var response = await http!.put(uri,headers: headers,body: jsonRequest);

    if(isValidResponseCode(response))
    {
      var data = jsonDecode(response.body);
      return fromJson(data) as T;
    }
    else{
      return null;
    }

  }

   Future <T> Authenticate() async
  {
    var url = "${_baseUrl}${_endpoint}/Authenticate";
    var uri = Uri.parse(url);

    var headers = getHeaders();
    var response = await http!.get(uri , headers: headers);
    if(isValidResponseCode(response)){
      var data = jsonDecode(response.body);
      T user = fromJson(data) as T;
      return user;
    }
    else{
      throw Exception("Wrong username or password");
    }
  }

  T fromJson(x){
    throw Exception("override this method");
  }
  
    Map<String , String> getHeaders(){

    String username = Authorization.Username!;
    String passowrd = Authorization.Password!;

    String basicAuth = "Basic ${base64Encode(utf8.encode('$username:$passowrd'))}";

    var headers = {
      "Content-Type" : "application/json",
      "Authorization": basicAuth
    };

    return headers;
  }

  String getQueryString(Map params,
      {String prefix: '&', bool inRecursion: false}) {
    String query = '';
    params.forEach((key, value) {
      if (inRecursion) {
        if (key is int) {
          key = '[$key]';
        } else if (value is List || value is Map) {
          key = '.$key';
        } else {
          key = '.$key';
        }
      }
      if (value is String || value is int || value is double || value is bool) {
        var encoded = value;
        if (value is String) {
          encoded = Uri.encodeComponent(value);
        }
        query += '$prefix$key=$encoded';
      } else if (value is DateTime) {
        query += '$prefix$key=${(value as DateTime).toIso8601String()}';
      } else if (value is List || value is Map) {
        if (value is List) value = value.asMap();
        value.forEach((k, v) {
          query +=
              getQueryString({k: v}, prefix: '$prefix$key', inRecursion: true);
        });
      }
    });
    return query;
  }

  bool isValidResponseCode(Response response)
  {
    if(response.statusCode == 200){
      if(response.body != "")
      {
        return true;
      }
      else{
        return false;
      }
    }
    else if(response.statusCode == 204)
    return true;
    else if(response.statusCode == 400)
    throw Exception("Bad request");
    else if(response.statusCode == 401)
    throw Exception("Unauthorized");
    else if(response.statusCode == 403)
    throw Exception("Forbidden");
    else if(response.statusCode == 404)
    throw Exception("Not found");
    else
    throw Exception("Exception");
  }
}