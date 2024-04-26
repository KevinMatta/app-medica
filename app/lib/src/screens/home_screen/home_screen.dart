import 'dart:math' as math;
import 'package:flutter/material.dart';
import 'package:meditation_app/config/size_config.dart';
import 'package:meditation_app/provider/base_view.dart';
import 'package:meditation_app/src/screens/discover_screen/discover_screen.dart';
import 'package:meditation_app/src/screens/player_screen/player_screen.dart';
// ignore: unused_import
import 'package:meditation_app/src/screens/premium_screen/premium_screen.dart';
import 'package:meditation_app/src/screens/profile_screen/profile_screen.dart';
import 'package:meditation_app/src/widgets/bottom_nav_bar.dart';
import 'package:meditation_app/utils/constants.dart';
import 'package:meditation_app/view/home_screen_view_model.dart';
import 'package:meditation_app/src/widgets/glass_container.dart';

import 'components/body.dart';

class HomeScreen extends StatelessWidget {
  static String routeName = '/home-screen';
  const HomeScreen({Key? key}) : super(key: key);

  Widget topWidget(double screenWidth) {
    return Transform.rotate(
      angle: -35 * math.pi / 180,
      child: Container(
        width: 1.2 * screenWidth,
        height: 1.2 * screenWidth,
        decoration: BoxDecoration(
          borderRadius: BorderRadius.circular(150),
          gradient: const LinearGradient(
            begin: Alignment(-0.2, -0.8),
            end: Alignment.bottomCenter,
            colors: [
              Color(0x007CBFCF),
              Color(0xB316BFC4),
            ],
          ),
        ),
      ),
    );
  }

  Widget bottomWidget(double screenWidth) {
    return Container(
      width: 1.5 * screenWidth,
      height: 1.5 * screenWidth,
      decoration: const BoxDecoration(
        shape: BoxShape.circle,
        gradient: LinearGradient(
          begin: Alignment(0.6, -1.1),
          end: Alignment(0.7, 0.8),
          colors: [
            Color(0xDB4BE8CC),
            Color(0x005CDBCF),
          ],
        ),
      ),
    );
  }

  @override
  Widget build(BuildContext context) {
    final screenSize = MediaQuery.of(context).size;
    SizeConfig().init(context);
    return BaseView<HomeScreenViewModel>(
        onModelReady: (model) => {},
        builder: (context, model, child) {
          return Scaffold(
            appBar: AppBar(
              backgroundColor: turqueza,
              title: const Text('Home'),
              centerTitle: true,
              toolbarHeight: 80,
            ),
            body: Stack(
              children: [
                Positioned(
                  top: -160,
                  left: -30,
                  child: topWidget(screenSize.width),
                ),
                Positioned(
                  bottom: -180,
                  left: -40,
                  child: bottomWidget(screenSize.width),
                ),
                GlassContainer(
                    theHeight: screenSize.height, theWidth: screenSize.width),
                PageView(
                  controller: model.pageController,
                  children: <Widget>[
                    Body(
                      model: model,
                    ),
                    DiscoverScreen(),
                    PlayerScreen(),
                    ProfileScreen(),
                  ],
                ),
              ],
            ),
            bottomNavigationBar: CustomBottomNavbar(context, model),
          );
        });
  }
}
