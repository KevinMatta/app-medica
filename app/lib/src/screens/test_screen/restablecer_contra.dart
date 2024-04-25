import 'package:flutter/material.dart';
import 'package:meditation_app/src/screens/test_screen/editar_usuario.dart';
import 'package:meditation_app/src/widgets/background.dart';
import 'package:meditation_app/utils/constants.dart';

class RestablecerScreen extends StatelessWidget {
  const RestablecerScreen({Key? key}) : super(key: key);
  static String routeName = '/restablecer-screen';
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      debugShowCheckedModeBanner: false,
      home: Scaffold(
        appBar: AppBar(
          title: const Text('Restablecer Contraseña'),
          backgroundColor: turqueza,
          leading: IconButton(
            icon: Icon(Icons.arrow_back_ios_outlined),
            onPressed: () => Navigator.of(context).pop(),
          ),
          toolbarHeight: 80,
        ),
        body: Stack(
          children: [
            const CustomBackground(),
            Center(
              child: Text('Restablecer',
                  style: TextStyle(fontSize: 40, color: Colors.black)),
            )
          ],
        ),
      ),
    );
  }
}
