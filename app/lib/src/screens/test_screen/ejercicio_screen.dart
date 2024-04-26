import 'dart:convert';
import 'package:flutter/material.dart';
import 'package:meditation_app/src/widgets/card_ejercicio.dart';
import 'package:meditation_app/utils/constants.dart';
import 'package:http/http.dart' as http;
import 'package:shared_preferences/shared_preferences.dart';

class EjerciciosPage extends StatefulWidget {
  const EjerciciosPage({Key? key}) : super(key: key);

  @override
  _EjerciciosPageState createState() => _EjerciciosPageState();
}

class _EjerciciosPageState extends State<EjerciciosPage> {
  List<Map<String, dynamic>> _ejercicios = [];
  int usua_Id = 0;
  int Diag_Id = 0;
  bool _isLoading = true;

  final Map<String, String> imagenes = {
    'Caminata':
        'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSTFy7MT6RswjDsF1CNHsm__gMWEke07L5C6s1wqQeGUw&s',
    'Ciclismo':
        'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSE5kA77gtrUaIYCFoc7X7k0YeG3uMcyxnjuBXFHmm-hQ&s',
    'Natación':
        'https://static.nike.com/a/images/f_auto/dpr_3.0,cs_srgb/h_500,c_limit/c3875a0d-d42c-4e0b-9822-bc27c8ac432a/los-cinco-principales-beneficios-de-la-nataci%C3%B3n.jpg',
    'Yoga':
        'https://static.nike.com/a/images/f_auto/dpr_3.0,cs_srgb/w_363,c_limit/ec763fcf-c56d-4a22-8ce9-f0f72d940bbb/at-home-yoga-for-beginners.jpg',
    'Pilates':
        'https://static.vecteezy.com/system/resources/previews/007/342/281/non_2x/woman-is-doing-flexibility-exercises-pilates-yoga-athletic-gymnastic-wellness-concept-sport-healthy-lifestyle-flat-simply-shapes-illustration-on-white-background-isolated-vector.jpg',
    'Flexiones de rodillas':
        'https://s3assets.skimble.com/assets/4141/skimble-workout-trainer-exercise-kneeling-diamond-push-ups-2_iphone.jpg',
    'Abdominales básicos':
        'https://static.vecteezy.com/system/resources/previews/003/250/200/non_2x/a-young-man-does-abs-exercises-sports-at-home-healthy-lifestyle-vector.jpg',
    'Sentadillas con barra':
        'https://vioksport.es/wp-content/uploads/2020/06/Sin-titulo-4-min-1.jpg',
    'Press de banca':
        'https://static.nike.com/a/images/f_auto,cs_srgb/w_1536,c_limit/3a51a21b-d4a4-4ff1-9a8f-e78a17260c52/image.jpg',
    'Peso muerto':
        'https://hips.hearstapps.com/hmg-prod/images/muscular-build-man-exercising-deadlift-with-barbell-royalty-free-image-1605800774.?crop=0.644xw:0.934xh;0.0734xw,0.0662xh&resize=1200:*',
    'Remo con barra':
        'https://images.squarespace-cdn.com/content/v1/5ebef943272c1041d83b1d15/1675572364280-ZG8PQSLM8KZ0N96GBGAU/Remo+Con+Barra.jpeg',
  };

  @override
  void initState() {
    super.initState();
    _cargarUsuaId();
  }

  Future<void> _cargarEjercicios() async {
    if (Diag_Id != 0) {
      final url =
          Uri.parse('$URL_API/Diagnostico/ListadoDiagEntre?Diag_Id=$Diag_Id');
      final response = await http.get(url);

      if (response.statusCode == 200) {
        final data = json.decode(response.body);
        final List<dynamic> res = data['data'];

        setState(() {
          _ejercicios = res.cast<Map<String, dynamic>>();
          _isLoading = false;
        });
      } else {
        print('Error al cargar los ejercicios: ${response.statusCode}');
      }
    }
  }

  Future<void> _cargarUsuaId() async {
    final prefs = await SharedPreferences.getInstance();
    setState(() {
      usua_Id = prefs.getInt('usua_Id') ?? 0;
    });
    _cargarDiagId();
  }

  Future<void> _cargarDiagId() async {
    final url = '$URL_API/Diagnostico/BuscarPersona?Usua_Id=$usua_Id';
    final response = await http.get(Uri.parse(url));
    if (response.statusCode == 200) {
      final data = json.decode(response.body);
      final List<dynamic> res = data['data'];

      setState(() {
        if (res.length > 0) {
          print(res.length);
          Diag_Id = res[0]['diag_Id'];
        } else {
          Diag_Id = 0;
        }
      });
    }
    _cargarEjercicios();
  }

  @override
  Widget build(BuildContext context) {
    if (_isLoading) {
      return Center(
        child: CircularProgressIndicator(),
      );
    }

    return Stack(
      children: [
        Center(
          child: ListView(
            padding: EdgeInsets.all(16),
            children: [
              Container(
                padding: EdgeInsets.all(16),
                decoration: BoxDecoration(
                  color: kSecondaryColor,
                  borderRadius: BorderRadius.circular(10),
                  boxShadow: [
                    BoxShadow(
                      color: Colors.grey.withOpacity(0.5),
                      spreadRadius: 2,
                      blurRadius: 5,
                      offset: Offset(0, 3),
                    ),
                  ],
                ),
                child: Text(
                  'Ejercicios de la Semana',
                  style: TextStyle(
                    fontSize: 24,
                    fontWeight: FontWeight.bold,
                    color: Colors.white,
                  ),
                ),
              ),
              SizedBox(height: 16),
              for (final ejercicio in _ejercicios)
                ExerciseItemCard(
                  imageUrl: imagenes[ejercicio['ejer_Descripcion']] ?? '',
                  title: ejercicio['ejer_Descripcion'] ?? '',
                  tipo: ejercicio['ejer_Tipo'] ?? '',
                  tiempo: ejercicio['entr_Duracion'] == null ||
                          ejercicio['entr_Duracion'] == 0
                      ? 'N/A'
                      : ejercicio['entr_Duracion'].toString(),
                  peso: ejercicio['entr_Peso'] == null ||
                          ejercicio['entr_Peso'] == 0
                      ? 'N/A'
                      : ejercicio['entr_Peso'].toString(),
                  repeticiones: ejercicio['entr_Repeticiones'] == null ||
                          ejercicio['entr_Repeticiones'] == 0
                      ? 'N/A'
                      : ejercicio['entr_Repeticiones'].toString(),
                  sets: ejercicio['entr_Sets'] == null ||
                          ejercicio['entr_Sets'] == 0
                      ? 'N/A'
                      : ejercicio['entr_Sets'].toString(),
                ),
            ],
          ),
        )
      ],
    );
  }
}
