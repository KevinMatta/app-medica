import 'package:flutter/material.dart';
import 'package:meditation_app/utils/responsive.dart';
import 'package:meditation_app/src/widgets/dashboard_widget.dart';

class TestPage2 extends StatelessWidget {
  const TestPage2({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
     final isDesktop = Responsive.isDesktop(context);

    return Stack(
      children: [
      
      SafeArea(
        child: Row(
          children: [
            if (!isDesktop)
            Expanded(
              flex: 7,
              child: DashboardWidget(),
            ),
            
          ],
        ),
      ),],
    );
  }
}