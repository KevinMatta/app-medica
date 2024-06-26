import 'dart:math' as math;
import 'package:flutter/material.dart';
import 'package:meditation_app/src/screens/login_screen/components/center_widget/center_widget.dart';
import 'package:meditation_app/src/widgets/glass_container.dart';

class CustomBackground extends StatelessWidget {
  const CustomBackground({Key? key}) : super(key: key);


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
    return Scaffold(
      extendBody: true,
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
          CenterWidget(size: screenSize),
          GlassContainer(
              theWidth: screenSize.width, theHeight: screenSize.height),
        ],
      ),
    );
  }
}