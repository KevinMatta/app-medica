
-- === DIAGNOSTICOS ===
CREATE OR ALTER PROCEDURE Medi.sp_Diagnosticos_listar
AS
BEGIN
	SELECT Diag_Id, d.Pers_Identidad, 
	CONCAT(Pers_PrimerNombre,' ', Pers_PrimerApellido) AS Nombre,
	p.Pers_Sexo, 
	p.Pers_Altura, 
	( GETDATE() - Pers_Nacimiento) AS Edad, 
	p.TiSa_Id, 
	t.TiSa_Descripcion,
	p.EsCi_Id, 
	d.EsSa_Id,
	e.EsSa_Descripcion,
	Diag_Peso
	FROM Medi.tbDiagnosticos d
	JOIN Gene.tbPersonas p ON p.Pers_Identidad = d.Pers_Identidad
	JOIN Medi.tbEstadosSalud e ON e.EsSa_Id = d.EsSa_Id
	JOIN Medi.tbTiposSangre t ON t.TiSa_Id = p.TiSa_Id
	JOIN Gene.tbEstadosCiviles esci ON esci.EsCi_Id = p.EsCi_Id
	WHERE d.Diag_Estado = 1 AND p.Pers_Estado = 1 AND e.EsSa_Estado = 1 AND t.TiSa_Estado = 1 AND EsCi_Estado = 1
END;


CREATE OR ALTER PROCEDURE Medi.sp_Diagnosticos_buscar
@Diag_Id INT 
AS
BEGIN
	SELECT Diag_Id, d.Pers_Identidad, 
	CONCAT(Pers_PrimerNombre,' ', Pers_PrimerApellido) AS Nombre,
	p.Pers_Sexo, 
	p.Pers_Altura, 
	( GETDATE() - Pers_Nacimiento) AS Edad, 
	p.TiSa_Id, 
	t.TiSa_Descripcion,
	p.EsCi_Id, 
	d.EsSa_Id,
	e.EsSa_Descripcion,
	Diag_Peso,
	usu1.Usua_Usuario AS Creacion,
	usu2.Usua_Usuario AS Modificacion
	FROM Medi.tbDiagnosticos d
	JOIN Gene.tbPersonas p ON p.Pers_Identidad = d.Pers_Identidad
	JOIN Medi.tbEstadosSalud e ON e.EsSa_Id = d.EsSa_Id
	JOIN Medi.tbTiposSangre t ON t.TiSa_Id = p.TiSa_Id
	JOIN Gene.tbEstadosCiviles esci ON esci.EsCi_Id = p.EsCi_Id
	JOIN Acce.tbUsuarios usu1 ON usu1.Usua_Id = d.Diag_Creacion
	JOIN Acce.tbUsuarios usu2 ON usu2.Usua_Id = d.Diag_Modificacion
	WHERE d.Diag_Estado = 1 AND p.Pers_Estado = 1 AND e.EsSa_Estado = 1 AND t.TiSa_Estado = 1 AND EsCi_Estado = 1 AND d.Diag_Id = @Diag_Id
END;


CREATE OR ALTER PROCEDURE Medi.sp_Diagnosticos_crear
@Pers_Identidad VARCHAR(13),
@EsSa_Id INT,
@Diag_Peso INT,
@Diag_Creacion INT,
@Diag_FechaCreacion DATETIME
AS
BEGIN
	INSERT INTO Medi.tbDiagnosticos(Pers_Identidad, EsSa_Id, Diag_Peso, Diag_Creacion, Diag_FechaCreacion)
	VALUES(@Pers_Identidad, @EsSa_Id, @Diag_Peso, @Diag_Creacion, @Diag_FechaCreacion)
END;


CREATE OR ALTER PROCEDURE Medi.sp_Diagnosticos_editar
@Diag_Id INT,
@Pers_Identidad VARCHAR(13),
@EsSa_Id INT,
@Diag_Peso INT,
@Diag_Modificacion INT,
@Diag_FechaModificacion DATETIME
AS
BEGIN
	UPDATE Medi.tbDiagnosticos
	SET Pers_Identidad = @Pers_Identidad, 
	EsSa_Id = @EsSa_Id,
	Diag_Peso = @Diag_Peso,
	Diag_Modificacion = @Diag_Modificacion,
	Diag_FechaModificacion = @Diag_FechaModificacion
	WHERE Diag_Id = Diag_Id
END;


CREATE OR ALTER PROCEDURE Medi.sp_Diagnosticos_eliminar
@Diag_Id INT,
@Diag_Modificacion INT,
@Diag_FechaModificacion DATETIME
AS
BEGIN
	UPDATE Medi.tbDiagnosticos
	SET 
	Diag_Estado = 1,
	Diag_Modificacion = @Diag_Modificacion,
	Diag_FechaModificacion = @Diag_FechaModificacion
	WHERE Diag_Id = @Diag_Id
END;


