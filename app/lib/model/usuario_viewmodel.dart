class UsuarioViewModel {
  late int? usua_Id;
  String? usua_Usuario;
  String? usua_Clave;
  String? usua_Administrador;
  int? rol_Id;
  bool? usua_Estado;
  int? usua_Creacion;
  DateTime? usua_FechaCreacion;
  int? usua_Modificacion;
  DateTime? usua_FechaModificacion;
  String? usua_CorreoElectronico;
  String? usua_CodigoV;
  String? creacion;
  String? modificacion;
  String? rol_Descripcion;

  UsuarioViewModel({
    this.usua_Id,
    this.usua_Usuario,
    this.usua_Clave,
    this.usua_Administrador,
    this.rol_Id,
    this.usua_Estado,
    this.usua_Creacion,
    this.usua_FechaCreacion,
    this.usua_Modificacion,
    this.usua_FechaModificacion,
    this.usua_CorreoElectronico,
    this.usua_CodigoV,
    this.creacion,
    this.modificacion,
    this.rol_Descripcion,
  });

  UsuarioViewModel.fromJson(Map<String, dynamic> json) {
    usua_Id = json['usua_Id'];
    usua_Usuario = json['usua_Usuario'];
    usua_Clave = json['usua_Clave'];
    usua_Administrador = json['usua_Administrador'];
    rol_Id = json['rol_Id'];
    usua_Estado = json['usua_Estado'];
    usua_Creacion = json['usua_Creacion'];
    usua_FechaCreacion = DateTime.parse(json['usua_FechaCreacion']);
    usua_Modificacion = json['usua_Modificacion'];
    usua_FechaModificacion = json['usua_FechaModificacion'] != null
        ? DateTime.parse(json['usua_FechaModificacion'])
        : null;
    usua_CorreoElectronico = json['usua_CorreoElectronico'];
    usua_CodigoV = json['usua_CodigoV'];
    creacion = json['creacion'];
    modificacion = json['modificacion'];
    rol_Descripcion = json['rol_Descripcion'];
  }

  Map<String, dynamic> toJson() => {
        'usua_Id': usua_Id,
        'usua_Usuario': usua_Usuario,
        'usua_Administrador': usua_Administrador,
        'rol_Id': rol_Id,
        'usua_Estado': usua_Estado,
        'usua_Creacion': usua_Creacion,
        'usua_FechaCreacion': usua_FechaCreacion,
        'usua_Modificacion': usua_Modificacion,
        'usua_FechaModificacion': usua_FechaModificacion,
        'usua_CorreoElectronico': usua_CorreoElectronico,
        'usua_CodigoV': usua_CodigoV,
        'creacion': creacion,
        'modificacion': modificacion,
        'rol_Descripcion': rol_Descripcion,
      };

  @override
  String toString() {
    return 'UsuarioViewModel('
        'usua_Id: $usua_Id, '
        'usua_Usuario: $usua_Usuario, '
        'usua_Clave: $usua_Clave, '
        'usua_Administrador: $usua_Administrador, '
        'rol_Id: $rol_Id, '
        'usua_Estado: $usua_Estado, '
        'usua_Creacion: $usua_Creacion, '
        'usua_FechaCreacion: $usua_FechaCreacion, '
        'usua_Modificacion: $usua_Modificacion, '
        'usua_FechaModificacion: $usua_FechaModificacion, '
        'usua_CorreoElectronico: $usua_CorreoElectronico, '
        'usua_CodigoV: $usua_CodigoV, '
        'creacion: $creacion, '
        'modificacion: $modificacion, '
        'rol_Descripcion: $rol_Descripcion'
        ')';
  }
}
