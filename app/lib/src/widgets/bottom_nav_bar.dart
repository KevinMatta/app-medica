// ignore_for_file: unused_import

import 'package:flutter/foundation.dart';
import 'package:flutter/material.dart';
import 'package:meditation_app/config/size_config.dart';
import 'package:meditation_app/src/screens/discover_screen/discover_screen.dart';
import 'package:meditation_app/src/screens/player_screen/player_screen.dart';
import 'package:meditation_app/view/home_screen_view_model.dart';

Container CustomBottomNavbar(BuildContext context, HomeScreenViewModel model) {
  Widget BottomNavbarItem(
      {required String text,
      required IconData icon,
      required bool isSelected,
      required int currentIndex}) {
    return GestureDetector(
      onTap: () {
        model.onTappedBar(currentIndex);
      },
      child: Container(
        //
        decoration: BoxDecoration(
          borderRadius: BorderRadius.circular(50),
          boxShadow: isSelected
              ? [
                  BoxShadow(
                    color: Color(0xff99589f).withOpacity(0.7),
                    spreadRadius: 10,
                    blurRadius: 15,
                    offset: Offset(-1, 5), // changes position of shadow
                  ),
                ]
              : [],
        ),
        padding: EdgeInsets.symmetric(horizontal: 18, vertical: 2),
        child: Column(
          mainAxisSize: MainAxisSize.min,
          children: <Widget>[
            Icon(
              icon,
              color: isSelected ? Colors.white : Color(0xff9796ae),
              size: 25,
            ),
            SizedBox(height: 4),
            Text(
              text,
              style: TextStyle(
                  color: isSelected ? Colors.white : Color(0xff9796ae),
                  fontFamily: 'Montserrat',
                  fontSize: 11,
                  letterSpacing: 0.06,
                  fontWeight: FontWeight.normal,
                  height: 1.2),
            ),
          ],
        ),
      ),
    );
  }

  return Container(
    width: 390,
    height: 80,
    decoration: BoxDecoration(
        color: Color(0xFF222247),
        borderRadius: BorderRadius.only(
          topLeft: Radius.circular(40),
          topRight: Radius.circular(40),
        )),
    child: Column(
      mainAxisAlignment: MainAxisAlignment.center,
      children: <Widget>[
        Container(
          padding: EdgeInsets.symmetric(horizontal: 16),
          child: Row(
            mainAxisAlignment: MainAxisAlignment.spaceEvenly,
            children: <Widget>[
              BottomNavbarItem(
                  icon: Icons.home,
                  text: 'Inicio',
                  isSelected: model.selectedIndex == 0,
                  currentIndex: 0),
              BottomNavbarItem(
                  icon: Icons.fastfood_outlined,
                  text: 'Dieta',
                  isSelected: model.selectedIndex == 1,
                  currentIndex: 1),
              BottomNavbarItem(
                  icon: Icons.fitness_center,
                  text: 'Ejercicios',
                  isSelected: model.selectedIndex == 2,
                  currentIndex: 2),
              BottomNavbarItem(
                  icon: Icons.account_circle_rounded,
                  text: 'Perfil',
                  isSelected: model.selectedIndex == 3,
                  currentIndex: 3),
            ],
          ),
        ),
      ],
    ),
  );
}
