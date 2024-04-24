-- === ENFERMEDADES ===
INSERT INTO Medi.tbEnfermedades (Enfe_Descripcion, Enfe_Creacion, Enfe_FechaCreacion)
VALUES ('Diabetes tipo 2', 1, GETDATE()),
       ('Hipertensión arterial', 1, GETDATE()),
       ('Hipercolesterolemia', 1, GETDATE()),
       ('Artritis', 1, GETDATE()),
       ('Asma', 1, GETDATE()),
       ('Obesidad', 1, GETDATE()),
       ('Enfermedad cardiovascular', 1, GETDATE());
GO

-- === ESTADO DE SALUD ===
INSERT INTO Medi.tbEstadosSalud (EsSa_Descripcion, EsSa_Creacion, EsSa_FechaCreacion)
VALUES ('Excelente', 1, GETDATE()),
       ('Bueno', 1, GETDATE()),
       ('Regular', 1, GETDATE()),
       ('Malo', 1, GETDATE()),
       ('Muy malo', 1, GETDATE());
GO

-- === EJERCICIOS ===
INSERT INTO Medi.tbEjercios (Ejer_Descripcion, Ejer_TipoEjercicio, Ejer_Creacion, Ejer_FechaCreacion)
VALUES ('Caminata', 'Cardiovascular', 1, GETDATE()),
       ('Ciclismo', 'Cardiovascular', 1, GETDATE()),
       ('Natación', 'Cardiovascular', 1, GETDATE()),
       ('Yoga', 'Estiramiento', 1, GETDATE()),
       ('Pilates', 'Estiramiento', 1, GETDATE()),
       ('Flexiones de rodillas', 'Ejercicio de fuerza', 1, GETDATE()),
       ('Abdominales básicos', 'Ejercicio de fuerza', 1, GETDATE()),
       ('Sentadillas con barra', 'Ejercicio de fuerza', 1, GETDATE()),
       ('Press de banca', 'Ejercicio de fuerza', 1, GETDATE()),
       ('Peso muerto', 'Ejercicio de fuerza', 1, GETDATE()),
       ('Remo con barra', 'Ejercicio de fuerza', 1, GETDATE());
GO

-- === ALIMENTOS ===
INSERT INTO Medi.tbAlimentos (Alim_Descripcion, Alim_TipoComida, Alim_Calorias, Alim_Proteinas, Alim_Carbohidratos, Alim_Creacion, Alim_FechaCreacion)
VALUES ('Arroz integral', 'Almuerzo', 130.5, 2.5, 27.0, 1, GETDATE()),
       ('Pollo a la plancha', 'Almuerzo', 185.0, 25.0, 0.0, 1, GETDATE()),
       ('Ensalada verde', 'Almuerzo', 50.0, 1.5, 7.0, 1, GETDATE()),
       ('Manzana', 'Merienda', 95.0, 0.5, 25.0, 1, GETDATE()),
       ('Avena', 'Desayuno', 150.0, 5.0, 27.0, 1, GETDATE()),
       ('Salmón a la parrilla', 'Cena', 220.0, 25.0, 0.0, 1, GETDATE()),
       ('Brócoli al vapor', 'Almuerzo', 55.0, 3.0, 11.0, 1, GETDATE()),
       ('Espinacas salteadas con ajo', 'Almuerzo', 30.0, 3.0, 5.0, 1, GETDATE()),
       ('Huevo revuelto con espinacas', 'Desayuno', 70.0, 6.0, 1.0, 1, GETDATE()),
       ('Batata al horno', 'Almuerzo', 120.0, 2.0, 28.0, 1, GETDATE()),
       ('Guacamole con chips de maíz', 'Merienda', 240.0, 3.0, 12.0, 1, GETDATE()),
       ('Queso de cabra con nueces', 'Merienda', 80.0, 10.0, 2.0, 1, GETDATE()),
       ('Sardinas a la parrilla', 'Cena', 180.0, 22.0, 0.0, 1, GETDATE()),
       ('Tofu salteado con vegetales', 'Almuerzo', 160.0, 18.0, 2.0, 1, GETDATE()),
       ('Filete de salmón al horno', 'Cena', 240.0, 26.0, 0.0, 1, GETDATE()),
       ('Pollo al horno con hierbas', 'Almuerzo', 200.0, 28.0, 0.0, 1, GETDATE()),
       ('Ensalada de atún', 'Almuerzo', 180.0, 20.0, 0.0, 1, GETDATE()),
       ('Filete de ternera a la parrilla', 'Cena', 250.0, 26.0, 0.0, 1, GETDATE());
GO

-- === PERSONAS ===
INSERT INTO Gene.tbPersonas (Pers_Identidad, Pers_PrimerNombre, Pers_PrimerApellido, Pers_Sexo, Pers_Altura, Pers_Nacimiento, TiSa_Id, EsCi_Id, Ciud_Id, Pers_Creacion, Pers_FechaCreacion)
VALUES ('1234567890123', 'Juan', 'Perez', 'M', 1.75, '1990-05-15', 1, 1, '0501', 1, GETDATE()),
       ('9876543210987', 'Maria', 'Rodriguez', 'F', 1.65, '1985-10-20', 2, 2, '0501', 1, GETDATE()),
       ('4567890123456', 'Pedro', 'Gonzalez', 'M', 1.80, '1988-03-10', 3, 1, '0501', 1, GETDATE());
GO

-- === ENFERMEDADES POR PERSONAS ===
INSERT INTO Medi.tbEnfermedadesPorPersona (Enfe_Id, Pers_Identidad, EnPe_Estado, EnPe_Creacion, EnPe_FechaCreacion)
VALUES (1, '1234567890123', 1, 1, GETDATE()),  -- Juan Perez tiene Diabetes
       (2, '9876543210987', 1, 1, GETDATE()),  -- Maria Rodriguez tiene Hipertensión
       (3, '4567890123456', 1, 1, GETDATE()),  -- Pedro Gonzalez tiene Colesterol Alto
       (1, '9876543210987', 1, 1, GETDATE()),  -- Maria Rodriguez también tiene Diabetes
       (3, '1234567890123', 1, 1, GETDATE());  -- Juan Perez también tiene Colesterol Alto
GO

-- Registros de diagnóstico con estados de salud basados en el IMC
-- Juan Perez: IMC = peso / (altura * altura) = 80.5 / (1.75 * 1.75) = 26.29
-- Maria Rodriguez: IMC = peso / (altura * altura) = 75.0 / (1.65 * 1.65) = 27.55
-- Pedro Gonzalez: IMC = peso / (altura * altura) = 90.2 / (1.80 * 1.80) = 27.84

-- === DIAGNOSTICO ===
INSERT INTO Medi.tbDiagnosticos (Pers_Identidad, EsSa_Id, Diag_Peso, Diag_Estado, Diag_Creacion, Diag_FechaCreacion)
VALUES ('1234567890123', 3, 80.5, 1, 1, GETDATE()),  -- Juan Perez, estado de salud: Sobrepeso
       ('9876543210987', 4, 75.0, 1, 1, GETDATE()),  -- Maria Rodriguez, estado de salud: Obesidad grado I
       ('4567890123456', 4, 90.2, 1, 1, GETDATE());  -- Pedro Gonzalez, estado de salud: Obesidad grado I
GO


-- === DIETAS === 
-- Dieta para Juan Perez
INSERT INTO Medi.tbDietas (Diag_Id, Alim_Id, Diet_Detalle, Diet_Estado, Diet_Creacion, Diet_FechaCreacion)
-- Desayuno
VALUES (1, 6, 'Avena con frutas y nueces', 1, 1, GETDATE()),
-- Almuerzo
(1, 3, 'Pollo a la plancha con ensalada verde', 1, 1, GETDATE()),
-- Cena
(1, 7, 'Salmón a la parrilla con brócoli al vapor', 1, 1, GETDATE());

GO

-- Dieta para Maria Rodriguez
INSERT INTO Medi.tbDietas (Diag_Id, Alim_Id, Diet_Detalle, Diet_Estado, Diet_Creacion, Diet_FechaCreacion)
-- Desayuno
VALUES (2, 6, 'Avena', 1, 1, GETDATE()),
-- Almuerzo
(2, 4, 'Ensalada verde', 1, 1, GETDATE()),
-- Cena
(2, 7, 'Salmón a la parrilla', 1, 1, GETDATE());
GO

-- Dieta para Pedro Gonzalez
INSERT INTO Medi.tbDietas (Diag_Id, Alim_Id, Diet_Detalle, Diet_Estado, Diet_Creacion, Diet_FechaCreacion)
-- Desayuno
VALUES (3, 11, 'Batata al horno con aguacate', 1, 1, GETDATE()),
-- Almuerzo
(3, 12, 'Guacamole con chips de maíz', 1, 1, GETDATE()),
-- Cena
(3, 14, 'Sardinas a la parrilla', 1, 1, GETDATE());
GO


-- === ENTRENAMIENTOS ===
-- Entrenamientos para Juan Perez
INSERT INTO Medi.tbEntrenamientos (Diag_Id, Ejer_Id, Entr_Peso, Entr_Duracion, Entr_Repeticiones, Entr_Sets, Entr_Detalle, Entr_Estado, Entr_Creacion, Entr_FechaCreacion)
-- Caminata
VALUES (1, 1, NULL, 30, NULL, NULL, 'Caminata ligera en el parque', 1, 1, GETDATE()),
-- Abdominales básicos
(1, 7, NULL, NULL, 20, 3, 'Abdominales para fortalecer el core', 1, 1, GETDATE()),
-- Yoga
(1, 4, NULL, 45, NULL, NULL, 'Sesión de yoga para relajación y flexibilidad', 1, 1, GETDATE());
GO

-- Entrenamientos para Maria Rodriguez
INSERT INTO Medi.tbEntrenamientos (Diag_Id, Ejer_Id, Entr_Peso, Entr_Duracion, Entr_Repeticiones, Entr_Sets, Entr_Detalle, Entr_Estado, Entr_Creacion, Entr_FechaCreacion)
-- Natación
VALUES (2, 3, NULL, 45, NULL, NULL, 'Natación en piscina cubierta', 1, 1, GETDATE()),
-- Pilates
(2, 5, NULL, 60, NULL, NULL, 'Clase de pilates para mejorar la postura y la fuerza del core', 1, 1, GETDATE()),
-- Flexiones de rodillas
(2, 6, NULL, NULL, 15, 3, 'Flexiones de rodillas para fortalecer las piernas', 1, 1, GETDATE());
GO

-- Entrenamientos para Pedro Gonzalez
INSERT INTO Medi.tbEntrenamientos (Diag_Id, Ejer_Id, Entr_Peso, Entr_Duracion, Entr_Repeticiones, Entr_Sets, Entr_Detalle, Entr_Estado, Entr_Creacion, Entr_FechaCreacion)
-- Ciclismo
VALUES (3, 2, NULL, 60, NULL, NULL, 'Paseo en bicicleta por el parque', 1, 1, GETDATE()),
-- Sentadillas con barra
(3, 8, 20, NULL, 10, 3, 'Sentadillas con barra para fortalecer cuádriceps', 1, 1, GETDATE()),
-- Remo con barra
(3, 11, 30, NULL, 12, 3, 'Ejercicio de remo con barra para espalda', 1, 1, GETDATE());
GO