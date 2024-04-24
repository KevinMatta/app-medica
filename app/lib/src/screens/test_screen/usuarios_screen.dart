import 'package:flutter/material.dart';
import 'package:meditation_app/src/widgets/dissmisable_item.dart';

class UsuariosScreen extends StatelessWidget {
  static String routeName = '/usuarios-screen';
  const UsuariosScreen({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return DismissibleExampleApp();
  }
}