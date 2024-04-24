// ignore_for_file: use_build_context_synchronously

import 'dart:convert';
import 'dart:ui';
import 'package:http/http.dart' as http;
import 'package:intl/intl.dart';

import 'package:flutter/material.dart';
import 'package:meditation_app/src/widgets/background.dart';
import 'package:meditation_app/utils/constants.dart';

class AddUser extends StatelessWidget {
  static String routeName = '/usuarios-screen';
  AddUser({Key? key}) : super(key: key);

  final TextEditingController _usuarioController = TextEditingController();
  final TextEditingController _claveController = TextEditingController();
  final TextEditingController _correoController = TextEditingController();

  @override
  Widget build(BuildContext context) {
    return ClipRect(
        child: BackdropFilter(
      filter: ImageFilter.blur(sigmaX: 15.0, sigmaY: 15.0),
      child: Container(
          decoration:
              BoxDecoration(color: Colors.grey.shade200.withOpacity(0.5)),
          child: Container(
            decoration:
                BoxDecoration(color: Colors.grey.shade200.withOpacity(0.5)),
            child: Stack(
              children: [
                const CustomBackground(),
                _buildForm(context),
              ],
            ),
          )),
    ));
  }

  Future<void> registrarUsuario(BuildContext context, String username,
      String password, String email) async {
    final url = Uri.parse('$URL_API/Usuario/UsuarioCrear');
    try {
      String requestBody = jsonEncode({
        'usua_Usuario': username,
        'usua_Clave': password,
      });
      // Realizar la solicitud POST a la API
      final response = await http.post(url,
          headers: {'Content-Type': 'application/json'}, body: requestBody);

      if (response.statusCode == 200) {
        print('Usuario registrado exitosamente');
        print('Respuesta de la API: ${response.body}');
        ScaffoldMessenger.of(context).showSnackBar(
          SnackBar(
            content: Text('usuario registrado exitosamente'),
            backgroundColor: Colors.green,
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
      } else {
        print(
            'Error al registrar el usuario. Código de estado: ${response.statusCode} ${response.body}');
      }
    } catch (e) {
      print('Error al conectar con la API: $e');
    }
  }

  Widget _buildForm(BuildContext context) {
    return Positioned(
      top: 120,
      left: 0,
      right: 0,
      child: Column(
        children: [
          inputField('Nombre de Usuario', Icons.person, _usuarioController),
          inputField('Clave', Icons.lock, _claveController),
          inputField('Correo Electrónico', Icons.email, _correoController),
          Boton(context, 'Registrar'),
        ],
      ),
    );
  }

  Widget inputField(
      String hint, IconData iconData, TextEditingController controller) {
    return Padding(
      padding: const EdgeInsets.symmetric(horizontal: 36, vertical: 8),
      child: SizedBox(
        height: 50,
        child: Material(
          elevation: 8,
          shadowColor: Colors.black87,
          color: Colors.transparent,
          borderRadius: BorderRadius.circular(30),
          child: TextField(
            controller: controller,
            textAlignVertical: TextAlignVertical.bottom,
            decoration: InputDecoration(
              border: OutlineInputBorder(
                borderRadius: BorderRadius.circular(30),
                borderSide: BorderSide.none,
              ),
              filled: true,
              fillColor: Colors.white,
              hintText: hint,
              prefixIcon: Icon(iconData),
            ),
          ),
        ),
      ),
    );
  }

  Widget Boton(BuildContext context, String title) {
    return Padding(
      padding: const EdgeInsets.all(
          16.0), // Ajusta el valor del margen según sea necesario
      child: TextButton(
        style: ButtonStyle(
          backgroundColor:
              MaterialStateColor.resolveWith((states) => kSecondaryColor),
          foregroundColor: MaterialStateProperty.all(Colors.white),
        ),
        onPressed: () {
          String username = _usuarioController.text;
          String password = _claveController.text;
          String email = _correoController.text;

          if (username.isNotEmpty && password.isNotEmpty && email.isNotEmpty) {
            print('Nombre: $username, Clave: $password, Correo: $email');
            registrarUsuario(context, username, password, email);
          } else {
            ScaffoldMessenger.of(context).showSnackBar(
              SnackBar(
                content: Text('Por favor completa todos los campos'),
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
        },
        child: Text(
          'Usuarios',
          style: TextStyle(fontWeight: FontWeight.bold, fontSize: 18),
        ),
      ),
    );
  }
}
