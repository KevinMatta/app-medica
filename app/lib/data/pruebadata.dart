import 'package:http/http.dart' as http;
import 'dart:convert';
import 'package:fl_chart/fl_chart.dart';

  List<FlSpot> data = [];  
  String apiUrl = 'http://http://appmedica.somee.com/Diagnostico/Listado';

 

Future<void> fetchData() async {
    final response = await http.get(Uri.parse('http://appmedica.somee.com/Diagnostico/Listado'));

    if (response.statusCode == 200) {
      final List<dynamic> jsonData = jsonDecode(response.body);

      //covertir datos en FlSpot
      data = jsonData.map((item) => FlSpot(item['esSa_Id'], item['diag_Peso'])).toList();
    } else {
      throw Exception('Error al cargar los datos: ${response.statusCode}');
    }
  }