import 'package:flutter/material.dart';
import 'package:meditation_app/src/widgets/background.dart';
import 'package:meditation_app/src/widgets/register_form.dart';
import 'package:meditation_app/utils/constants.dart';

class RegistrarScreen extends StatelessWidget {
  const RegistrarScreen({Key? key}) : super(key: key);
  static String routeName = '/registrar-screen';
  @override
  Widget build(BuildContext context) {
    final Map<String, String> args =
        ModalRoute.of(context)?.settings.arguments as Map<String, String>;
    final String username = args['username'] ?? '';
    final String password = args['password'] ?? '';

    return MaterialApp(
      debugShowCheckedModeBanner: false,
      home: Scaffold(
        appBar: AppBar(
          title: const Text('Registrate'),
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
            Center(
                child: UserForm(
              username: username,
              password: password,
            ))
          ],
        ),
      ),
    );
  }
}
