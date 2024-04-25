import 'package:flutter/material.dart';
import 'package:meditation_app/utils/constants.dart';

class EjerciciosPage extends StatelessWidget {
  const EjerciciosPage({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) => Stack(
    children: [
      Center(child: Text('Ejercicios', style: TextStyle(fontSize: 40, color: Colors.black)),)
    ],
  );
}