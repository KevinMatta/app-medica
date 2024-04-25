// ignore_for_file: unused_import

import 'package:flutter/material.dart';
import 'package:meditation_app/provider/getit.dart';
import 'package:meditation_app/routes/routes.dart';
import 'package:meditation_app/service/navigation_service.dart';
import 'package:meditation_app/src/screens/login_screen/login_screen.dart';
import 'package:meditation_app/src/screens/splash_screen/splash_screen.dart';
import 'package:meditation_app/src/screens/test_screen/usuarios_screen.dart';

class MyApp extends StatelessWidget {
  const MyApp({Key? key}) : super(key: key);

  // This widget is the root of your application.
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Medit8',
      navigatorKey: getIt<NavigationService>().navigatorKey,
      debugShowCheckedModeBanner: false,
      themeMode: ThemeMode.system,
      theme: ThemeData(
        textTheme: TextTheme(
          displayLarge: TextStyle(
            fontStyle: FontStyle.normal,
            fontWeight: FontWeight.bold,
            fontSize: 32,
            color: Color(0xFF464646),
          ),
          displayMedium: TextStyle(
            fontStyle: FontStyle.normal,
            fontWeight: FontWeight.w700,
            fontSize: 18,
            color: Color(0xFF464646),
          ),
        ),
      ),
      routes: routes,
      // initialRoute: SplashScreen.routeName,
      initialRoute: LoginScreen.routeName,
    );
  }
}
