import 'dart:convert';
import 'dart:js';
import 'package:http/http.dart' as http;
import 'package:flutter/material.dart';
import 'package:meditation_app/model/diagnostico_viewmodel.dart';
import 'package:meditation_app/model/salud_model.dart';
import 'package:meditation_app/utils/constants.dart';

class SaludDetalle {
  late var simon = 0;
  Future<void> healtfetch() async {
    String url = '$URL_API/Diagnostico/ListadoDiagDieta?Diag_Id=1';
      final response = await http.get(Uri.parse(url));

    try {
      // print('esto es el try');
      final res = jsonDecode(response.body);
      if (res['code'] == 200) {
        final List<dynamic> usuariosData = res['data'];
        // final List<DiagnosticoviewModel> usuarios = usuariosData.map((userData) {
        //   return DiagnosticoviewModel.fromJson(userData);
        // }).toList();
        // print(usuariosData);
        simon = usuariosData.length;
        // print(simon);
        
        
      } else {
        print('error: ${res['code']}');
        // ScaffoldMessenger.of(context).showSnackBar(
        //   SnackBar(
        //     content: Text('Error al cargar datos?'),
        //     backgroundColor: Colors.red,
        //     behavior: SnackBarBehavior.floating,
        //     shape: RoundedRectangleBorder(
        //       borderRadius: BorderRadius.circular(24),
        //     ),
        //     margin: EdgeInsets.only(
        //       top: 24,
        //       right: 20,
        //       left: 20,
        //     ),
        //     duration: Duration(seconds: 2),
        //   ),
        // );
      }
    } catch (error) {
      print('Error en la solicitud HTTP: $error');
      // ScaffoldMessenger.of(context).showSnackBar(
      //   SnackBar(
      //     content: Text('Error en la solicitud HTTP: $error'),
      //     backgroundColor: Colors.red,
      //     behavior: SnackBarBehavior.floating,
      //     shape: RoundedRectangleBorder(
      //       borderRadius: BorderRadius.circular(24),
      //     ),
      //     margin: EdgeInsets.only(
      //       top: 24,
      //       right: 20,
      //       left: 20,
      //     ),
      //     duration: Duration(seconds: 2),
      //   ),
      // );
    }
  }
  List<SaludModel> get healthData{ 
  return [
    SaludModel(
      icon: "assets/icons/ensalada.png",
      value: simon.toString(), 
      title: "Dietas"),
    SaludModel(
      icon: "assets/icons/pesas.png", value: "3", title: "Ejercicios"),
    ];
  }
 
}