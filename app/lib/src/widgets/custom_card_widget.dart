import 'package:flutter/widgets.dart';
import 'package:meditation_app/constant/constant.dart';

class CustomCard extends StatelessWidget {
  final Widget child;
  final Color? color;
  final EdgeInsetsGeometry? padding;
  const CustomCard ({Key? key, this.color, this.padding, required this.child}) : super(key: key);

  @override 
  Widget build(BuildContext context){
    return Container(
      decoration: BoxDecoration(
        borderRadius: const BorderRadius.all(
          Radius.circular(8.0),
        ),
        color: color ?? negrotransparente,
      ),
      child: Padding(
        padding: padding ?? const EdgeInsets.all(12.0),
        child: child,
      ),
    );
  }
}