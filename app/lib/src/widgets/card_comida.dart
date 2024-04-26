import 'package:flutter/material.dart';

class FoodItemCard extends StatelessWidget {
  final String imageUrl;
  final String title;
  final String foodName;
  final String calorias;
  final String proteinas;
  final String carbohidratos;

  const FoodItemCard({
    Key? key,
    required this.imageUrl,
    required this.title,
    required this.foodName,
    required this.calorias,
    required this.proteinas,
    required this.carbohidratos,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Container(
      width: double.infinity,
      height: 140,
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
                image: DecorationImage(
                  image: NetworkImage(imageUrl),
                  fit: BoxFit.cover,
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
                  // Nombre de la comida
                  Text(
                    foodName,
                    style: TextStyle(
                      fontSize: 16,
                      color: Colors.white, // Texto blanco
                    ),
                  ),
                  SizedBox(height: 4),
                  // Datos nutricionales
                  Row(
                    children: [
                      _buildNutritionalInfo('Calorías', calorias),
                      SizedBox(width: 10),
                      _buildNutritionalInfo('Proteínas', proteinas),
                      SizedBox(width: 10),
                      _buildNutritionalInfo('Carbohidratos', carbohidratos),
                    ],
                  ),
                ],
              ),
            ),
          ],
        ),
      ),
    );
  }

  Widget _buildNutritionalInfo(String label, String value) {
    return Column(
      crossAxisAlignment: CrossAxisAlignment.start,
      children: [
        Text(
          label,
          style: TextStyle(
            fontSize: 12,
            color: Colors.grey[300], // Texto gris claro
          ),
        ),
        Text(
          value,
          style: TextStyle(
            fontSize: 14,
            fontWeight: FontWeight.bold,
            color: Colors.white, // Texto blanco
          ),
        ),
      ],
    );
  }
}
