import 'package:flutter/material.dart';
import 'package:meditation_app/src/screens/login_screen/login_screen.dart';
import 'package:meditation_app/src/widgets/background.dart';
import 'package:meditation_app/utils/constants.dart';
import 'package:http/http.dart' as http;
import 'dart:convert';

import 'package:shared_preferences/shared_preferences.dart';

class NuevaClave extends StatefulWidget {
  NuevaClave({Key? key}) : super(key: key);
  static String routeName = '/nueva-contra-screen';

  @override
  _NuevaClaveState createState() => _NuevaClaveState();
}

class _NuevaClaveState extends State<NuevaClave> {
  final TextEditingController _codigoController = TextEditingController();
  int id = 0;

  @override
  void initState() {
    super.initState();
    getID(context);
  }

  Future<void> cambiarContra(BuildContext context) async {
    final url = '$URL_API/Usuario/RestablacerContrasena';
    final response = await http.put(Uri.parse(url), body: {
      'usua_Id': id.toString(),
      'usua_Clave': _codigoController.text,
    });
    final res = jsonDecode(response.body);
    if (res['code'] == 200) {
      print(id);
      print(res);
      Navigator.pushNamed(context, LoginScreen.routeName);
    } else {
      _showSnackBar(context, 'Error al restablecer la contraseña');
    }
  }

  Future<void> getID(BuildContext context) async {
    final prefs = await SharedPreferences.getInstance();
    setState(() {
      id = prefs.getInt('usua_Id') ?? 0;
    });
  }

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      debugShowCheckedModeBanner: false,
      home: Scaffold(
        appBar: AppBar(
          title: const Text('Restablecer Contraseña'),
          backgroundColor: kSecondaryColor,
          foregroundColor: Colors.white,
          leading: IconButton(
            icon: Icon(Icons.arrow_back_ios_outlined),
            onPressed: () => Navigator.of(context).pop(),
          ),
          toolbarHeight: 80,
        ),
        body: Stack(
          children: [
            const CustomBackground(),
            _buildForm(context),
          ],
        ),
      ),
    );
  }

  void _showSnackBar(BuildContext context, String message) {
    ScaffoldMessenger.of(context).showSnackBar(
      SnackBar(
        content: Text(message),
        backgroundColor: Colors.red,
        behavior: SnackBarBehavior.floating,
        shape: RoundedRectangleBorder(
          borderRadius: BorderRadius.circular(24),
        ),
        margin: EdgeInsets.only(
          top: 24,
          right: 20,
          left: 20,
        ),
        duration: Duration(seconds: 2),
      ),
    );
  }

  Widget _buildForm(BuildContext context) {
    return Positioned(
      top: 120,
      left: 0,
      right: 0,
      child: Column(
        children: [
          Container(
            padding: EdgeInsets.all(16),
            decoration: BoxDecoration(
              color: Colors.white,
              borderRadius: BorderRadius.circular(20),
            ),
            margin: EdgeInsets.symmetric(horizontal: 20),
            child: Text(
              'Ingrese su nueva contraseña',
              textAlign: TextAlign.center,
              style: TextStyle(fontSize: 16, color: Colors.black),
            ),
          ),
          Padding(
            padding: const EdgeInsets.symmetric(horizontal: 36, vertical: 8),
            child: SizedBox(
              height: 50,
              child: Material(
                elevation: 8,
                shadowColor: Colors.black87,
                color: Colors.transparent,
                borderRadius: BorderRadius.circular(30),
                child: TextField(
                  controller: _codigoController,
                  textAlignVertical: TextAlignVertical.bottom,
                  decoration: InputDecoration(
                    border: OutlineInputBorder(
                      borderRadius: BorderRadius.circular(30),
                      borderSide: BorderSide.none,
                    ),
                    filled: true,
                    fillColor: Colors.white,
                    hintText: 'Ingrese su nueva clave',
                    prefixIcon: Icon(Icons.key_rounded),
                  ),
                ),
              ),
            ),
          ),
          Padding(
            padding: const EdgeInsets.all(16.0),
            child: TextButton(
              style: ButtonStyle(
                backgroundColor:
                    MaterialStateColor.resolveWith((states) => kSecondaryColor),
                foregroundColor: MaterialStateProperty.all(Colors.white),
              ),
              onPressed: () {
                String codigo = _codigoController.text;

                if (codigo.isNotEmpty) {
                  print('codigo: $codigo');
                  cambiarContra(context);
                } else {
                  _showSnackBar(
                      context, 'Por favor ingrese su nueva contraseña');
                }
              },
              child: Text(
                'Verificar',
                style: TextStyle(fontWeight: FontWeight.bold, fontSize: 18),
              ),
            ),
          ),
        ],
      ),
    );
  }
}
