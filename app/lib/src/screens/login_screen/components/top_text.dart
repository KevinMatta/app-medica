import 'package:flutter/material.dart';
import 'package:meditation_app/src/screens/login_screen/animations/change_screen_animation.dart';
import 'package:meditation_app/utils/helper_functions.dart';

import 'login_content.dart';

class TopText extends StatefulWidget {
  const TopText({Key? key}) : super(key: key);

  @override
  State<TopText> createState() => _TopTextState();
}

class _TopTextState extends State<TopText> {
  @override
  void initState() {
    ChangeScreenAnimation.topTextAnimation.addStatusListener((status) {
      if (status == AnimationStatus.completed) {
        setState(() {});
      }
    });

    super.initState();
  }

  @override
  Widget build(BuildContext context) {
    return HelperFunctions.wrapWithAnimatedBuilder(
      animation: ChangeScreenAnimation.topTextAnimation,
      child: Text(
        ChangeScreenAnimation.currentScreen == Screens.createAccount
            ? 'Crear\nCuenta'
            : 'Iniciar\nSesion',
        style: const TextStyle(
          fontSize: 60,
          fontWeight: FontWeight.w600,
        ),
      ),
    );
  }
}
