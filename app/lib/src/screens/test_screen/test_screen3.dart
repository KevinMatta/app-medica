import 'package:flutter/material.dart';
import 'package:meditation_app/src/screens/login_screen/login_screen.dart';
import 'package:meditation_app/src/screens/test_screen/usuarios_screen.dart';
import 'package:meditation_app/utils/constants.dart';

class TestPage3 extends StatelessWidget {
  const TestPage3({Key? key}) : super(key: key);

  


  @override
  Widget build(BuildContext context) {
    return Stack(
    children: [
      // Center(child: Text('Test3', style: TextStyle(fontSize: 40, color: Colors.black)),)
      Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: [
            CircleAvatar(
              radius: 50,
              backgroundColor: Colors.white,
              backgroundImage: NetworkImage('https://th.bing.com/th/id/R.c3631c652abe1185b1874da24af0b7c7?rik=XBP%2fc%2fsPy7r3HQ&riu=http%3a%2f%2fpluspng.com%2fimg-png%2fpng-user-icon-circled-user-icon-2240.png&ehk=z4ciEVsNoCZtWiFvQQ0k4C3KTQ6wt%2biSysxPKZHGrCc%3d&risl=&pid=ImgRaw&r=0'),
            ),
            SizedBox(height: 16),
            Text(
              'Nombre de Usuario',
              style: TextStyle(fontSize: 24, fontWeight: FontWeight.bold),
            ),
            SizedBox(height: 8),
            Text(
              'Correo electrónico: usuario@example.com',
              style: TextStyle(fontSize: 16),
            ),
            SizedBox(height: 16),
             TextButton(
                style: ButtonStyle(
                  backgroundColor: MaterialStateProperty.all(Colors.red.shade400), 
                  foregroundColor: MaterialStateProperty.all(Colors.white),
                ),
                onPressed: () {
                  print('alo');
                  Navigator.pushNamed(context, LoginScreen.routeName);
                },
                child: Text('Cerrar Sesion', style: TextStyle(fontWeight: FontWeight.bold),),
            ),
            SizedBox(height: 16),
           TextButton(
                style: ButtonStyle(
                  backgroundColor: MaterialStateColor.resolveWith((states) => kSecondaryColor), 
                  foregroundColor: MaterialStateProperty.all(Colors.white),
                ),
                onPressed: () {
                  print('usuarios');
                  Navigator.pushNamed(context, UsuariosScreen.routeName);
                },
                child: Text('Usuarios', style: TextStyle(fontWeight: FontWeight.bold),),
            ),
          ],
        ),
      ),
    ],
  );
  }
}