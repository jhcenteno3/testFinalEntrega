# testFinalEntrega
Test Final en C# para la solucion de historias de los usuarios notas a ingresar, visualizar, ordenar, y buscar

Requerimientos:
Visual studio 2019 Community
.NET Core 3.1

El formulario posee la seleccion de usuario por cada uno de los casos.

Usuario 1: Puede Crear Notas.
Usuario 2: Puede Visualizar todas las notas (el ordenamiento se realiza haciendo click sobre la cabecera del DataGridView)
Usuario 3: Crear y Editar Notas (Se requiere visualizacion para seleccionar la nota que se desea editar)
Usuario 4: Puede Visualizar Notas y Buscar por el titulo y cuerpo de la nota.

Los permisos por usuario se realizaron en una variable global.
La cantidad de notas maximas que se pueden agregar son 100 ( variable global )
Listado general de permisos para todos los usuarios (variable global)
Caracteres a escapar para todas las inserciones de texto ('*', ' ', '\'')

Se agrega validacion de Formato de fecha.
Se agrega validacion de textos ingresados (no vacios, no nulos, no menores a 2 letras)
Limpiadores de campos generales
Validador de permisos por usuarios
