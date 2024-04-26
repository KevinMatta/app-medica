import 'package:flutter/material.dart';

class ExerciseItemCard extends StatelessWidget {
  final String imageUrl;
  final String title;
  final String tipo;
  final String? tiempo;
  final String? peso;
  final String? repeticiones;
  final String? sets;

  const ExerciseItemCard({
    Key? key,
    required this.imageUrl,
    required this.title,
    required this.tipo,
    this.tiempo,
    this.peso,
    this.repeticiones,
    this.sets,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Container(
      width: double.infinity,
      height: 170,
      child: Card(
        elevation: 4,
        shape: RoundedRectangleBorder(
          borderRadius: BorderRadius.circular(10),
        ),
        color: Colors.black.withOpacity(0.5), // Fondo negro con opacidad
        child: Row(
          crossAxisAlignment: CrossAxisAlignment.center,
          children: [
            // Imagen
            Container(
              width: 120,
              height: 120,
              decoration: BoxDecoration(
                borderRadius: BorderRadius.only(
                  topLeft: Radius.circular(10),
                  bottomLeft: Radius.circular(10),
                ),
                // image: DecorationImage(
                //   image: NetworkImage(imageUrl),
                //   fit: BoxFit.cover,
                // ),
              ),
              child: Padding(
                padding:
                    EdgeInsets.all(8), // Agregar espacio alrededor de la imagen
                child: Container(
                  decoration: BoxDecoration(
                    borderRadius: BorderRadius.only(
                      topLeft: Radius.circular(10),
                      bottomLeft: Radius.circular(10),
                    ),
                    image: DecorationImage(
                      image: NetworkImage(imageUrl),
                      fit: BoxFit.cover,
                    ),
                  ),
                ),
              ),
            ),
            SizedBox(width: 10),
            Expanded(
              child: Column(
                mainAxisAlignment: MainAxisAlignment.center,
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  // Título
                  Text(
                    title,
                    style: TextStyle(
                      fontSize: 18,
                      fontWeight: FontWeight.bold,
                      color: Colors.white, // Texto blanco
                    ),
                  ),
                  SizedBox(height: 4),
                  // Tipo de ejercicio
                  Text(
                    'Tipo: $tipo',
                    style: TextStyle(
                      fontSize: 16,
                      color: Colors.white, // Texto blanco
                    ),
                  ),
                  SizedBox(height: 4),
                  // Duración o peso
                  tiempo != null
                      ? Text(
                          'Duración: $tiempo',
                          style: TextStyle(
                            fontSize: 16,
                            color: Colors.white, // Texto blanco
                          ),
                        )
                      : Text(
                          'Peso: $peso',
                          style: TextStyle(
                            fontSize: 16,
                            color: Colors.white, // Texto blanco
                          ),
                        ),
                  SizedBox(height: 4),
                  // Repeticiones
                  Text(
                    'Repeticiones: ${repeticiones ?? 'N/A'}',
                    style: TextStyle(
                      fontSize: 16,
                      color: Colors.white, // Texto blanco
                    ),
                  ),
                  SizedBox(height: 4),
                  // Sets
                  Text(
                    'Sets: ${sets ?? 'N/A'}',
                    style: TextStyle(
                      fontSize: 16,
                      color: Colors.white, // Texto blanco
                    ),
                  ),
                ],
              ),
            ),
          ],
        ),
      ),
    );
  }
}
