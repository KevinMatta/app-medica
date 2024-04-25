import 'package:flutter/cupertino.dart';
import 'package:meditation_app/src/screens/discover_screen/discover_screen.dart';
// import 'package:meditation_app/src/screens/home_screen/home_screen.dart';
import 'package:meditation_app/src/screens/player_screen/player_screen.dart';
import 'package:meditation_app/src/screens/premium_screen/premium_screen.dart';
import 'package:meditation_app/src/screens/profile_screen/profile_screen.dart';
import 'package:meditation_app/src/screens/splash_screen/splash_screen.dart';
import 'package:meditation_app/src/screens/login_screen/login_screen.dart';
import 'package:meditation_app/src/screens/inicio_screen/home_screen.dart';
import 'package:meditation_app/src/screens/test_screen/registrar.dart';
import 'package:meditation_app/src/screens/test_screen/restablecer_contra.dart';
import 'package:meditation_app/src/screens/test_screen/usuarios_screen.dart';

final Map<String, WidgetBuilder> routes = {
  SplashScreen.routeName: (context) => SplashScreen(),
  HomeScreen.routeName: (context) => HomeScreen(),
  DiscoverScreen.routeName: (context) => DiscoverScreen(),
  PlayerScreen.routeName: (context) => PlayerScreen(),
  ProfileScreen.routeName: (context) => ProfileScreen(),
  PremiumScreen.routeName: (context) => PremiumScreen(),
  LoginScreen.routeName: (context) => LoginScreen(),
  UsuariosScreen.routeName:(context) => UsuariosScreen(),
  RegistrarScreen.routeName:(context) => RegistrarScreen(),
  RestablecerScreen.routeName:(context) => RestablecerScreen()
};
