class DiagnosticoviewModel{
   int? diag_Id;
   String? pers_Identidad;
   int? esSa_Id;
   String? diag_Peso;
   int? diag_Estado;
   int? diag_Creacion;
   DateTime? diag_FechaCreacion;
   int? diag_Modificacion;
   DateTime? diag_FechaModificacion;
   String? creacion;
   String? modificacion;
   String? esSa_Descripcion;
   String? nombre;
   String? pers_Altura;
   int? edad;
   int? alim_Id;
   String? alim_Descripcion;
   String? alim_TipoComida;
   double? alim_Calorias;
   String? alim_Proteinas;
   String? alim_Carbohidratos;
   int? entr_Id;
   String? ejer_Descripcion;
   String? ejer_Tipo;
   double? entr_Peso;
   double? entr_Duracion;
   String? entr_Repeticiones;
   int? entr_Sets;

 DiagnosticoviewModel (
  {
   this.diag_Id,
   this.pers_Identidad,
   this.esSa_Id,
   this.diag_Peso,
   this.diag_Estado,
   this.diag_Creacion,
   this.diag_FechaCreacion,
   this.diag_Modificacion,
   this.diag_FechaModificacion,
   this.creacion,
   this.modificacion,
   this.esSa_Descripcion,
   this.nombre,
   this.pers_Altura,
   this.edad,
   this.alim_Id,
   this.alim_Descripcion,
   this.alim_TipoComida,
   this.alim_Calorias,
   this.alim_Proteinas,
   this.alim_Carbohidratos,
   this.entr_Id,
   this.ejer_Descripcion,
   this.ejer_Tipo,
   this.entr_Peso,
   this.entr_Duracion,
   this.entr_Repeticiones,
   this.entr_Sets,
  });

   DiagnosticoviewModel.fromJson(Map<String, dynamic> json) {
   diag_Id = json['diag_Id'];
   pers_Identidad = json['pers_Identidad'];
   esSa_Id = json['esSa_Id'];
   diag_Peso = json['diag_Peso'];
   diag_Estado = json['diag_Estado'];
   diag_Creacion = json['diag_Creacion'];
   diag_FechaCreacion = json['diag_FechaCreacion'];
   diag_Modificacion = json['diag_Modificacion'];
   diag_FechaModificacion = json['diag_FechaModificacion'] != null
        ? DateTime.parse(json['diag_FechaModificacion'])
        : null;
   creacion = json['creacion'];
   modificacion = json['modificacion'];
   esSa_Descripcion = json['esSa_Descripcion'];
   nombre = json['nombre'];
   pers_Altura = json['pers_Altura'];
   edad = json['edad'];
   alim_Id = json['alim_Id'];
   alim_Descripcion = json['alim_Descripcion'];
   alim_TipoComida = json['alim_TipoComida'];
   alim_Calorias = json['alim_Calorias'];
   alim_Proteinas = json['alim_Proteinas'];
   alim_Carbohidratos = json['alim_Carbohidratos'];
   entr_Id = json['entr_Id'];
   ejer_Descripcion = json['ejer_Descripcion'];
   ejer_Tipo = json['ejer_Tipo'];
   entr_Peso = json['entr_Peso'];
   entr_Duracion = json['entr_Duracion'];
   entr_Repeticiones = json['entr_Repeticiones'];
   entr_Sets = json['entr_Sets'];
  }

  Map<String, dynamic> toJson() => {
        'diag_Id': diag_Id,
        'pers_Identidad': pers_Identidad,
        'esSa_Id': esSa_Id,
        'diag_Peso': diag_Peso,
        'diag_Estado': diag_Estado,
        'diag_Creacion': diag_Creacion,
        'diag_FechaCreacion': diag_FechaCreacion,
        'diag_Modificacion': diag_Modificacion,
        'creacion': creacion,
        'modificacion': modificacion,
        'esSa_Descripcion': esSa_Descripcion,
        'nombre': nombre,
        'pers_Altura': pers_Altura,
        'edad': edad,
        'alim_Id': alim_Id,
        'alim_Descripcion': alim_Descripcion,
        'alim_TipoComida': alim_TipoComida,
        'alim_Calorias': alim_Calorias,
        'alim_Proteinas': alim_Proteinas,
        'alim_Carbohidratos': alim_Carbohidratos,
        'entr_Id': entr_Id,
        'ejer_Descripcion': ejer_Descripcion,
        'ejer_Tipo': ejer_Tipo,
        'entr_Peso': entr_Peso,
        'entr_Duracion': entr_Duracion,
        'entr_Repeticiones': entr_Repeticiones,
        'entr_Sets': entr_Sets,
      };

  @override
  String toString() {
    return 'DiagnosticoviewModel('
        'diag_Id : $diag_Id'
        'pers_Identidad : $pers_Identidad,'
        'esSa_Id : $esSa_Id,'
        'esSa_Descripcion : $esSa_Descripcion,'
        'diag_Peso : $diag_Peso,'
        'diag_Estado : $diag_Estado,'
        'diag_Creacion : $diag_Creacion,'
        'diag_FechaCreacion : $diag_FechaCreacion,'
        'diag_Modificacion : $diag_Modificacion,'
        'creacion : $creacion,'
        'modificacion : $modificacion,'
        'nombre : $nombre,'
        'pers_Altura : $pers_Altura,'
        'edad : $edad,'
        'alim_Id : $alim_Id,'
        'alim_Descripcion : $alim_Descripcion,'
        'alim_TipoComida : $alim_TipoComida,'
        'alim_Calorias : $alim_Calorias,'
        'alim_Proteinas : $alim_Proteinas,'
        'alim_Carbohidratos : $alim_Carbohidratos,'
        'entr_Id : $entr_Id,'
        'ejer_Descripcion : $ejer_Descripcion,'
        'ejer_Tipo : $ejer_Tipo,'
        'entr_Peso : $entr_Peso,'
        'entr_Duracion : $entr_Duracion,'
        'entr_Repeticiones : $entr_Repeticiones,'
        'entr_Sets : $entr_Sets,'
        ')';
  }

}