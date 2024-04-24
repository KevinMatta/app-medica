import 'package:flutter/material.dart';
import 'package:meditation_app/utils/constants.dart';

class TestPage extends StatelessWidget {
  const TestPage({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) => Stack(
    children: [
      Center(child: Text('Test1', style: TextStyle(fontSize: 40, color: Colors.black)),)
    ],
  );
}