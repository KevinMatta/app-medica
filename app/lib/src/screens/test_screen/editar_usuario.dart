// ignore_for_file: use_build_context_synchronously

import 'dart:convert';
import 'dart:ui';
import 'package:http/http.dart' as http;
import 'package:intl/intl.dart';

import 'package:flutter/material.dart';
import 'package:meditation_app/src/widgets/background.dart';
import 'package:meditation_app/utils/constants.dart';

class EditUser extends StatefulWidget {
  static String routeName = '/editUsuario-screen';
  final int? id;

  const EditUser({Key? key, this.id}) : super(key: key);

  @override
  State<EditUser> createState() => _EditUserState();
}

class _EditUserState extends State<EditUser> {
  final TextEditingController _usuarioController = TextEditingController();
  final TextEditingController _claveController = TextEditingController();
  final TextEditingController _correoController = TextEditingController();

  @override
  void initState() {
    super.initState();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(
          title: const Text('Agregar Usuario'),
          backgroundColor: kSecondaryColor,
          foregroundColor: Colors.white,
          leading: IconButton(
            icon: Icon(Icons.arrow_back_ios_outlined),
            onPressed: () => Navigator.of(context).pop(),
          ),
          toolbarHeight: 80,
        ),
        body: ClipRect(
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
        )));
  }

  Future<void> EditarUsuario(BuildContext context, String username,
      String password, String email, int id) async {
    final url = Uri.parse('$URL_API/Usuario/UsuarioActualizar');
    try {
      String requestBody = jsonEncode({
        'usua_Id': id,
        'usua_Usuario': username,
        'usua_Clave': password,
        'usua_RolId': 1,
      });
      final response = await http.put(url,
          headers: {'Content-Type': 'application/json'}, body: requestBody);
      final res = jsonDecode(response.body);
      if (res['code'] == 200) {
        print('Usuario editado exitosamente');
        print('Respuesta de la API: ${response.body}');
        ScaffoldMessenger.of(context).showSnackBar(
          SnackBar(
            content: Text('usuario editado exitosamente'),
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
          Boton(context, 'Guardar'),
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
    int? id = widget.id as int;
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
            print(
                'Nombre: $username, Clave: $password, Correo: $email, ID: $id');
            EditarUsuario(context, username, password, email, id);
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
