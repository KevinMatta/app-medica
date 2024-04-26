import 'dart:convert';
import 'package:flutter/material.dart';
import 'package:http/http.dart' as http;
import 'package:fl_chart/fl_chart.dart';



class LineData{
 List<FlSpot> datas = [];
String apiUrl = 'http://appmedica.somee.com/Diagnostico/Listado';

Future<void> fetchData() async {
  final response = await http.get(Uri.parse(apiUrl));
  try{
    if (response.statusCode == 200) {
        List<dynamic> jsonData = jsonDecode(response.body);
      print(jsonData);
      //convertir datos en FlSpot
      datas = jsonData.map((item) => FlSpot(item['esSa_Id'], item['diag_Peso'])).toList();
      print(datas);
    } else {
      throw Exception('Error al cargar los datos: ${response.statusCode}');
    }
  }
  catch (err){
    print('Esto es el catch');
    print(err);
  }
}


  final spots = const [
    FlSpot(0,0),
    FlSpot(10, 75.62),
    FlSpot(20, 46.58),
    FlSpot(30, 42.97),
    FlSpot(40, 46.54),
    FlSpot(50, 99.72),
    FlSpot(60, 43.18),
  ];

  final leftTitle = {
    0: '0',
    20: '2K',
    40: '4K',
    60: '6K',
    80: '8K',
    100: '10K'
  };
  final bottomTitle = {
    0: 'Lun',
    10: 'Mar',
    20: 'Mie',
    30: 'Jue',
    40: 'Vie',
    50: 'Sab',
    60: 'Dom',
  };

}