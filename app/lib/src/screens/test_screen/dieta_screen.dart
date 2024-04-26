import 'dart:convert';
import 'package:flutter/material.dart';
import 'package:meditation_app/src/widgets/card_comida.dart';
import 'package:meditation_app/utils/constants.dart';
import 'package:http/http.dart' as http;
import 'package:shared_preferences/shared_preferences.dart';

class DietasPage extends StatefulWidget {
  const DietasPage({Key? key}) : super(key: key);

  @override
  _DietasPageState createState() => _DietasPageState();
}

class _DietasPageState extends State<DietasPage> {
  List<Map<String, dynamic>> _comidas = [];
  int usua_Id = 0;
  int Diag_Id = 0;
  bool _isLoading = true;

  final Map<String, String> imagenes = {
    'Arroz integral':
        'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTGhz3ni2xpuCnq7HVt_0pciKKYdele3PcIK09Mns0ucQ&s',
    'Pollo a la plancha':
        'https://www.paulinacocina.net/wp-content/uploads/2023/06/pollo-a-la-plancha-receta.jpg',
    'Ensalada verde':
        'https://acomermadrid.com/wp-content/uploads/2023/02/Ensalada.png',
    'Manzana':
        'https://www.semillasypi.org.ar/images/vida_cotidiana/agricultura/Vida_cotidiana_portada_Manzanas.jpg',
    'Avena':
        'https://www.clara.es/medio/2023/09/21/avena-para-adelgazar_32517b42_230921110826_1200x630.jpg',
    'Salmón a la parrilla':
        'https://static.diabetesfoodhub.org/system/thumbs/system/images/recipes/ThinkstockPhotos-509422213_1_3847653377.jpg',
    'Brócoli al vapor':
        'https://imag.bonviveur.com/brocoli-al-vapor-con-vinagreta-de-frutos-secos.jpg',
    'Espinacas salteadas con ajo':
        'https://cdn2.cocinadelirante.com/sites/default/files/images/2020/04/espinacas-salteadas-con-ajo-y-limon.jpg',
    'Huevo revuelto con espinacas':
        'https://images.cookforyourlife.org/wp-content/uploads/2018/08/Spinach-And-Ricotta-Scrambled-Eggs-e1647546996405.jpg',
    'Batata al horno':
        'https://recetasdecocina.elmundo.es/wp-content/uploads/2022/08/boniato-al-horno.jpg',
    'Guacamole con chips de maíz':
        'https://www.guiadecocinafacil.com/wp-content/uploads/2012/01/cropped-6316db6d221fe44e5c71a0e46231725e.jpg',
    'Queso de cabra con nueces':
        'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSl70QqoztdfzwUvePlihJZkmap9i_mN2Y-r1eRUvOLRA&s',
    'Sardinas a la parrilla':
        'https://bbqlife.es/Recetas/Recetas-pescado-a-la-parrilla/img/sardinas-a-la-parrilla.jpg',
    'Tofu salteado con vegetales':
        'https://okdiario.com/img/2018/09/04/salteado-de-tofu.jpg',
    'Filete de salmón al horno':
        'https://ombligoparao.cl/wp-content/uploads/2023/04/Receta-de-Salmon-al-Horno.jpg',
    'Pollo al horno con hierbas':
        'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQC7oC40-LXDmdoVqbJHXdbKt47pA-3nVAR9VnJi-9JQQ&s',
    'Ensalada de atún':
        'https://www.gourmet.cl/wp-content/uploads/2021/10/ensalada-de-at%C3%BAn-internet-1.jpg',
    'Filete de ternera a la parrilla':
        'https://okdiario.com/img/recetas/2017/07/21/entrecot-de-ternera-a-la-brasa.jpg'
  };

  @override
  void initState() {
    super.initState();
    _cargarUsuaId();
  }

  Future<void> _cargarComidas() async {
    if (Diag_Id != 0) {
      final url =
          Uri.parse('$URL_API/Diagnostico/ListadoDiagDieta?Diag_Id=$Diag_Id');
      final response = await http.get(url);

      if (response.statusCode == 200) {
        final data = json.decode(response.body);
        final List<dynamic> res = data['data'];
        setState(() {
          _comidas = res.cast<Map<String, dynamic>>();
          _isLoading = false;
        });
      } else {
        print('Error al cargar las comidas: ${response.statusCode}');
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
          Diag_Id = res[0]['diag_Id'];
        } else {
          Diag_Id = 0;
        }
      });
    }
    _cargarComidas();
  }

  @override
  Widget build(BuildContext context) {
    if (_isLoading) {
      return Center(
        child: CircularProgressIndicator(), // Indicador de carga
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
                  'Comidas de la semana',
                  style: TextStyle(
                    fontSize: 24,
                    fontWeight: FontWeight.bold,
                    color: Colors.white,
                  ),
                ),
              ),
              SizedBox(height: 16),
              for (final comida in _comidas)
                FoodItemCard(
                  imageUrl: imagenes[comida['alim_Descripcion']] ?? '',
                  title: comida['alim_TipoComida'],
                  foodName: comida['alim_Descripcion'],
                  calorias: comida['alim_Calorias'],
                  proteinas: comida['alim_Proteinas'],
                  carbohidratos: comida['alim_Carbohidratos'],
                ),
            ],
          ),
        )
      ],
    );
  }
}
