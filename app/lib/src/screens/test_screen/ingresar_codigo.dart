import 'package:flutter/material.dart';
import 'package:meditation_app/src/screens/test_screen/nueva-contra.dart';
import 'package:meditation_app/src/widgets/background.dart';
import 'package:meditation_app/utils/constants.dart';
import 'package:http/http.dart' as http;
import 'dart:convert';

class IngresarCodigo extends StatelessWidget {
  IngresarCodigo({Key? key}) : super(key: key);
  static String routeName = '/ingresar-codigo-screen';

  final TextEditingController _codigoController = TextEditingController();

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

  Future<void> _sendcodigo(BuildContext context) async {
    final url =
        'http://appmedica.somee.com/Usuario/validarCodigo?codigo=${_codigoController.text}';
    final response = await http.get(Uri.parse(url));
    final res = jsonDecode(response.body);
    if (res['code'] == 200) {
      Navigator.pushNamed(context, NuevaClave.routeName);
    } else {
      _showSnackBar(context, 'Codigo Incorrecto');
    }
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
              'Ingrese el codigo enviado a su correo para restablecer la contraseña',
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
                    hintText: 'Ingrese el codigo',
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
                  _sendcodigo(context);
                } else {
                  _showSnackBar(context, 'Por favor ingrese el codigo');
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
