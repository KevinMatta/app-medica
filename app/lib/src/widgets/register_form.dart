import 'package:flutter/material.dart';
import 'package:meditation_app/utils/constants.dart';

class UserForm extends StatefulWidget {
  final String username;
  final String password;

  const UserForm({
    Key? key,
    required this.username,
    required this.password,
  }) : super(key: key);

  @override
  _UserFormState createState() => _UserFormState();
}

class _UserFormState extends State<UserForm> {
  TextEditingController _identidadController = TextEditingController();
  TextEditingController _primerNombreController = TextEditingController();
  TextEditingController _segundoNombreController = TextEditingController();
  TextEditingController _primerApellidoController = TextEditingController();
  TextEditingController _segundoApellidoController = TextEditingController();
  TextEditingController _alturaController = TextEditingController();
  TextEditingController _pesoController = TextEditingController();
  TextEditingController _fechaNacimientoController = TextEditingController();
  TextEditingController _tipoSangreController = TextEditingController();
  TextEditingController _ciudadController = TextEditingController();
  TextEditingController _enfermedadController = TextEditingController();

  String _selectedGender = '';
  String _selectedMaritalStatus = '';
  String _selectedCityId = '';
  String _selectedDiseaseId = '';

  final List<String> _generos = ['Masculino', 'Femenino'];
  final List<Map<String, dynamic>> _estadosCiviles = [
    {'id': '1', 'descripcion': 'Soltero'},
    {'id': '2', 'descripcion': 'Casado'},
    {'id': '3', 'descripcion': 'Viudo'},
    {'id': '4', 'descripcion': 'Divorciado'},
  ];

  final List<Map<String, dynamic>> _ciudades = [
    {'id': '1', 'descripcion': 'Ciudad 1'},
    {'id': '2', 'descripcion': 'Ciudad 2'},
    {'id': '3', 'descripcion': 'Ciudad 3'},
  ];

  final List<Map<String, dynamic>> _enfermedades = [
    {'id': '1', 'descripcion': 'Enfermedad 1'},
    {'id': '2', 'descripcion': 'Enfermedad 2'},
    {'id': '3', 'descripcion': 'Enfermedad 3'},
  ];

  @override
  Widget build(BuildContext context) {
    return SingleChildScrollView(
      padding: EdgeInsets.all(16),
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.stretch,
        children: [
          campoTexto('Identidad', Icons.credit_card, _identidadController),
          campoTexto('Primer Nombre', Icons.person, _primerNombreController),
          campoTexto('Segundo Nombre', Icons.person, _segundoNombreController),
          campoTexto(
              'Primer Apellido', Icons.person, _primerApellidoController),
          campoTexto(
              'Segundo Apellido', Icons.person, _segundoApellidoController),
          // SizedBox(height: 16),
          seleccionGenero(),
          campoTexto('Altura (cm)', Icons.height, _alturaController),
          campoTexto('Peso (kg)', Icons.line_weight, _pesoController),
          campoTexto('Fecha de Nacimiento', Icons.calendar_today,
              _fechaNacimientoController),
          campoTexto('Tipo de Sangre', Icons.bloodtype, _tipoSangreController),
          // SizedBox(height: 16),
          // seleccionEstadoCivil(),
          campoTexto('Ciudad', Icons.location_city, _ciudadController),
          // seleccionEnfermedad(),
          SizedBox(height: 16),
          boton(context, 'Guardar'),
        ],
      ),
    );
  }

  Widget campoTexto(
      String hint, IconData iconData, TextEditingController controller) {
    return Padding(
      padding: const EdgeInsets.symmetric(horizontal: 16, vertical: 8),
      child: SizedBox(
        height: 50,
        child: TextField(
          controller: controller,
          textAlignVertical: TextAlignVertical.bottom,
          decoration: InputDecoration(
            border: OutlineInputBorder(
              borderRadius: BorderRadius.circular(30),
              borderSide: BorderSide.none,
            ),
            filled: true,
            fillColor: Colors.white,
            hintText: hint,
            prefixIcon: Icon(iconData),
          ),
        ),
      ),
    );
  }

  Widget seleccionGenero() {
    return Padding(
      padding: const EdgeInsets.symmetric(horizontal: 16, vertical: 8),
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          SizedBox(height: 8),
          Container(
            decoration: BoxDecoration(
              borderRadius: BorderRadius.circular(30),
              color: Colors.white,
            ),
            child: Row(
              children: _generos.map((genero) {
                return Expanded(
                  child: RadioListTile(
                    title: Text(genero),
                    value: genero,
                    groupValue: _selectedGender,
                    onChanged: (value) {
                      setState(() {
                        _selectedGender = value.toString();
                      });
                    },
                  ),
                );
              }).toList(),
            ),
          ),
        ],
      ),
    );
  }

  Widget seleccionEstadoCivil() {
    return Padding(
      padding: const EdgeInsets.symmetric(horizontal: 16, vertical: 8),
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          Text(
            'Estado Civil',
            style: TextStyle(
              fontSize: 16,
              fontWeight: FontWeight.bold,
            ),
          ),
          SizedBox(height: 8),
          DropdownButtonFormField(
            value: _selectedMaritalStatus,
            onChanged: (value) {
              setState(() {
                _selectedMaritalStatus = value.toString();
              });
            },
            items: _estadosCiviles.map((estadoCivil) {
              return DropdownMenuItem(
                value: estadoCivil['id'],
                child: Text(estadoCivil['descripcion']),
              );
            }).toList(),
            decoration: InputDecoration(
              border: OutlineInputBorder(
                borderRadius: BorderRadius.circular(30),
                borderSide: BorderSide.none,
              ),
              filled: true,
              fillColor: Colors.white,
            ),
          ),
        ],
      ),
    );
  }

  Widget seleccionEnfermedad() {
    return Padding(
      padding: const EdgeInsets.symmetric(horizontal: 16, vertical: 8),
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          Text(
            'Enfermedad',
            style: TextStyle(
              fontSize: 16,
              fontWeight: FontWeight.bold,
            ),
          ),
          SizedBox(height: 8),
          DropdownButtonFormField(
            value: _selectedDiseaseId,
            onChanged: (value) {
              setState(() {
                _selectedDiseaseId = value.toString();
              });
            },
            items: _enfermedades.map((enfermedad) {
              return DropdownMenuItem(
                value: enfermedad['id'],
                child: Text(enfermedad['descripcion']),
              );
            }).toList(),
            decoration: InputDecoration(
              border: OutlineInputBorder(
                borderRadius: BorderRadius.circular(30),
                borderSide: BorderSide.none,
              ),
              filled: true,
              fillColor: Colors.white,
            ),
          ),
        ],
      ),
    );
  }

  Widget boton(BuildContext context, String title) {
    return Padding(
      padding: const EdgeInsets.all(16),
      child: TextButton(
        style: ButtonStyle(
          backgroundColor:
              MaterialStateColor.resolveWith((states) => kSecondaryColor),
          foregroundColor: MaterialStateProperty.all(Colors.white),
        ),
        onPressed: () {
          // Aquí puedes agregar la lógica para guardar los datos del usuario
        },
        child: Text(
          title,
          style: TextStyle(fontWeight: FontWeight.bold, fontSize: 18),
        ),
      ),
    );
  }
}
