import 'package:flutter/material.dart';
import 'package:flutter/widgets.dart';
import 'package:meditation_app/data/salud_detalle.dart';
import 'package:meditation_app/src/widgets/custom_card_widget.dart';
import 'package:meditation_app/utils/responsive.dart';

class ActivityDetailsCard extends StatelessWidget{
  const ActivityDetailsCard({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context){
      final saludDetalle = SaludDetalle();
      saludDetalle.healtfetch();
    return GridView.builder(
        itemCount: saludDetalle.healthData.length,
      shrinkWrap: true,
      physics: const ScrollPhysics(),
      gridDelegate: SliverGridDelegateWithFixedCrossAxisCount(
        crossAxisCount: Responsive.isMobile(context) ? 2 : 4,
        crossAxisSpacing: Responsive.isMobile(context) ? 12 : 15,
        mainAxisSpacing: 12.0,
      ),
      itemBuilder: (context, index) => CustomCard(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          crossAxisAlignment: CrossAxisAlignment.center,
          children: [
            Image.asset(
              saludDetalle.healthData[index].icon,
              width: 48,
              height: 48,
            ),
            Padding(
              padding: const EdgeInsets.only(top: 15, bottom: 4),
              child: Text(
                saludDetalle.healthData[index].value,
                style: const TextStyle(
                  fontSize: 18,
                  color: Colors.white,
                  fontWeight: FontWeight.w600,
                ),
              ),
            ),
            Text(
              saludDetalle.healthData[index].title,
              style: const TextStyle(
                fontSize: 13,
                color: Colors.grey,
                fontWeight: FontWeight.normal,
              ),
            ),
          ],
        ),
      ),
    );
  }
}