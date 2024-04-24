import 'package:meditation_app/src/widgets/activity_details_card.dart';
import 'package:meditation_app/src/widgets/line_chart_card.dart';
import 'package:flutter/material.dart';


class DashboardWidget extends StatelessWidget {
  const DashboardWidget({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return SingleChildScrollView(
      child: Padding(
        padding: const EdgeInsets.symmetric(horizontal: 18),
        child: Column(
          children: [
           
            const SizedBox(height: 18),
            const ActivityDetailsCard(),
            const SizedBox(height: 18),
            const LineChartCard(),
            
          ],
        ),
      ),
    );
  }
}