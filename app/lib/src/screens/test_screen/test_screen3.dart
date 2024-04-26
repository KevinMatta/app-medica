import 'package:flutter/material.dart';
import 'package:meditation_app/src/screens/login_screen/login_screen.dart';
import 'package:meditation_app/src/screens/test_screen/usuarios_screen.dart';
import 'package:meditation_app/utils/constants.dart';
import 'package:shared_preferences/shared_preferences.dart';

class TestPage3 extends StatefulWidget {
  const TestPage3({Key? key}) : super(key: key);

  @override
  _TestPage3State createState() => _TestPage3State();
}

class _TestPage3State extends State<TestPage3> {
  String Usuario = '';
  String Correo = '';
  bool _isAdmin = false;
  bool _isLoading = true;

  @override
  void initState() {
    super.initState();
    _fetchData();
  }

  Future<void> _fetchData() async {
    final prefs = await SharedPreferences.getInstance();
    setState(() {
      Usuario = prefs.getString('usua_Usuario') ?? '';
      Correo = prefs.getString('usua_CorreoElectronico') ?? '';
      _isAdmin = prefs.getString('usua_Administrador') == 'Si';
      _isLoading = false;
    });
  }

  @override
  Widget build(BuildContext context) {
    if (_isLoading) {
      return Center(
        child: CircularProgressIndicator(),
      );
    }

    return Stack(
      children: [
        Center(
          child: Column(
            mainAxisAlignment: MainAxisAlignment.center,
            children: [
              CircleAvatar(
                radius: 50,
                backgroundColor: Colors.white,
                backgroundImage: NetworkImage(
                    'https://th.bing.com/th/id/R.c3631c652abe1185b1874da24af0b7c7?rik=XBP%2fc%2fsPy7r3HQ&riu=http%3a%2f%2fpluspng.com%2fimg-png%2fpng-user-icon-circled-user-icon-2240.png&ehk=z4ciEVsNoCZtWiFvQQ0k4C3KTQ6wt%2biSysxPKZHGrCc%3d&risl=&pid=ImgRaw&r=0'),
              ),
              SizedBox(height: 16),
              Text(
                Usuario,
                style: TextStyle(fontSize: 24, fontWeight: FontWeight.bold),
              ),
              SizedBox(height: 8),
              Text(
                'Correo electrónico: $Correo',
                style: TextStyle(fontSize: 16),
              ),
              SizedBox(height: 16),
              TextButton(
                style: ButtonStyle(
                  backgroundColor:
                      MaterialStateProperty.all(Colors.red.shade400),
                  foregroundColor: MaterialStateProperty.all(Colors.white),
                ),
                onPressed: () {
                  Navigator.pushNamed(context, LoginScreen.routeName);
                },
                child: Text(
                  'Cerrar Sesion',
                  style: TextStyle(fontWeight: FontWeight.bold),
                ),
              ),
              SizedBox(height: 16),
              _isAdmin
                  ? TextButton(
                      style: ButtonStyle(
                        backgroundColor: MaterialStateColor.resolveWith(
                            (states) => kSecondaryColor),
                        foregroundColor:
                            MaterialStateProperty.all(Colors.white),
                      ),
                      onPressed: () {
                        print('usuarios');
                        Navigator.pushNamed(context, UsuariosScreen.routeName);
                      },
                      child: Text(
                        'Usuarios',
                        style: TextStyle(fontWeight: FontWeight.bold),
                      ),
                    )
                  : SizedBox(),
            ],
          ),
        ),
      ],
    );
  }
}
