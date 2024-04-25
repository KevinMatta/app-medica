import 'dart:convert';
import 'dart:ui';
import 'package:http/http.dart' as http;

import 'package:flutter/material.dart';
import 'package:meditation_app/constant/constant.dart';
import 'package:meditation_app/model/usuario_viewmodel.dart';
import 'package:meditation_app/src/screens/test_screen/agregar_usuario.dart';
import 'package:meditation_app/src/screens/test_screen/editar_usuario.dart';
import 'package:meditation_app/src/widgets/background.dart';
import 'package:meditation_app/utils/constants.dart';

class DismissibleExampleApp extends StatelessWidget {
  const DismissibleExampleApp({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      debugShowCheckedModeBanner: false,
      home: Scaffold(
        appBar: AppBar(
          title: const Text('Usuarios'),
          backgroundColor: turqueza,
          leading: IconButton(
            icon: Icon(Icons.arrow_back_ios_outlined),
            onPressed: () => Navigator.of(context).pop(),
          ),
          toolbarHeight: 80,
          actions: <Widget>[
            IconButton(
              icon: const Icon(Icons.person_add_alt_1_rounded),
              tooltip: 'Agregar usuario',
              onPressed: () {
                Navigator.push(context, MaterialPageRoute<void>(
                  builder: (BuildContext context) {
                    return Scaffold(
                      appBar: AppBar(
                        title: const Text('Agregar Usuario'),
                        backgroundColor: turqueza,
                        leading: IconButton(
                          icon: Icon(Icons.arrow_back_ios_outlined),
                          onPressed: () => Navigator.of(context).pop(),
                        ),
                        toolbarHeight: 80,
                      ),
                      body: AddUser(),
                    );
                  },
                ));
              },
            ),
            SizedBox(
              width:
                  15, // Ajusta el ancho del espacio en blanco según sea necesario
            ),
          ],
        ),
        body: Stack(
          children: [
            const CustomBackground(),
            const DismissibleExample(),
          ],
        ),
      ),
    );
  }
}

class DismissibleExample extends StatefulWidget {
  const DismissibleExample({Key? key}) : super(key: key);

  @override
  State<DismissibleExample> createState() => _DismissibleExampleState();
}

class _DismissibleExampleState extends State<DismissibleExample> {
  late List<UsuarioViewModel> users = [];

  @override
  void initState() {
    super.initState();
    getUsers().then((loadedUsers) {
      setState(() {
        users = loadedUsers;
      });
    });
  }

  Future<List<UsuarioViewModel>> getUsers() async {
    String url = '$URL_API/Usuario/Listado';

    try {
      final response = await http.get(Uri.parse(url));
      final res = jsonDecode(response.body);
      if (res['code'] == 200) {
        final List<dynamic> usuariosData = res['data'];
        final List<UsuarioViewModel> usuarios = usuariosData.map((userData) {
          return UsuarioViewModel.fromJson(userData);
        }).toList();
        return usuarios;
      } else {
        print('error: ${res['code']}');
        ScaffoldMessenger.of(context).showSnackBar(
          SnackBar(
            content: Text('Error al cargar datos?'),
            backgroundColor: Colors.red,
            behavior: SnackBarBehavior.floating,
            shape: RoundedRectangleBorder(
              borderRadius: BorderRadius.circular(24),
            ),
            margin: EdgeInsets.only(
              top: 24,
              right: 20,
              left: 20,
            ),
            duration: Duration(seconds: 2),
          ),
        );
        return [];
      }
    } catch (error) {
      print('Error en la solicitud HTTP: $error');
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(
          content: Text('Error en la solicitud HTTP: $error'),
          backgroundColor: Colors.red,
          behavior: SnackBarBehavior.floating,
          shape: RoundedRectangleBorder(
            borderRadius: BorderRadius.circular(24),
          ),
          margin: EdgeInsets.only(
            top: 24,
            right: 20,
            left: 20,
          ),
          duration: Duration(seconds: 2),
        ),
      );
      return [];
    }
  }

  @override
  Widget build(BuildContext context) {
    if (users == null) {
      // Muestra un indicador de carga mientras se cargan los datos
      return Center(child: CircularProgressIndicator());
    } else {
      return ClipRect(
        child: BackdropFilter(
          filter: ImageFilter.blur(sigmaX: 15.0, sigmaY: 15.0),
          child: Container(
            decoration:
                BoxDecoration(color: Colors.grey.shade200.withOpacity(0.5)),
            child: ListView.builder(
              itemCount: users.length,
              padding: const EdgeInsets.symmetric(vertical: 16),
              itemBuilder: (BuildContext context, int index) {
                return Dismissible(
                  background: Container(
                    // Icons.delete_forever_rounded
                    color: Colors.red.shade400,
                  ),
                  key: ValueKey<int?>(users[index].usua_Id),
                  direction: DismissDirection.endToStart,
                  // onDismissed: () {
                  // },
                  //coment
                  confirmDismiss: (DismissDirection direction) async {
                    Future<void> delete(int? id) async {
                        String url =
                            'http://appmedica.somee.com/Usuario/UsuarioEliminar/$id';
                        final response = await http.delete(
                          Uri.parse(url),
                          headers: {
                            'Content-Type': 'application/json; charset=UTF-8',
                          },
                        );
                        final res = jsonDecode(response.body);
                        if(res['code'] == '200'){
                            setState(() {
                            users.removeAt(index);
                          });
                          Navigator.of(context).pop(true);
                        }else {
                          Navigator.of(context).pop(false);
                        }
                        
                      }
                    final shouldDelete = await showDialog<bool>(
                      context: context,
                      builder: (BuildContext context) {
                        return AlertDialog(
                          backgroundColor: turqueza,
                          iconColor: negro,
                          title: const Text("Confirmar"),
                          content: const Text(
                              "¿Estás seguro de que deseas eliminar este elemento?"),
                          actions: <Widget>[
                            TextButton(
                              onPressed: () => delete(users[index].usua_Id),
                              child: const Text("ELIMINAR"),
                            ),
                            TextButton(
                              onPressed: () => Navigator.of(context).pop(false),
                              child: const Text("CANCELAR"),
                            ),
                          ],
                        );
                      },
                    );

                    return shouldDelete;
                  },
                  child: ListTile(
                      leading: Icon(Icons.person),
                      title: Text(
                        ' ${users[index].usua_Usuario}',
                      ),
                      onTap: () {
                        EditUser(users[index].usua_Id);
                        print("Elemento seleccionado: ${users[index].usua_Id}");
                      }),
                );
              },
            ),
          ),
        ),
      );
    }
  }
}
