# exam_fin
*Sistema de Organización de Productos*
*Estructura:*
Este proyecto esta conformado por las siguientes clases y carpetas:
*Clases:*
*FormUsuario:* Esta es una de las clases principales, esta es la que representa al primer formulario, esta contiene la lógica para poder comparar y verificar si el usuario y la contraseña de este son correctos. Dependiendo de esto la da o no acceso al usuario al siguiente formulario.
*DB_Libreria:* Esta es la segunda clase la cual representa al formulario que maneja la función de los botones de inserción, modificación, eliminación, búsqueda y entre otras cosas más del formulario.
*Conexión:* Esta es la clase principal del programa, en esta se encuentra toda la lógica y es la que conecta a las demás clases entre sí para que la aplicación trabaje correctamente entre los formularios y la base de datos de MySql.
*P_Articulos:* En esta clase solamente se declaran las propiedades de la misma clase.







*Funciones/Archivos:*
*Clase FormUsuario:*
*buttonIngreso_Click:* Esta función se encarga de verificar si el nombre de usuario y la contraseña son los correctos de lo contrario dará una alerta de usuario o contraseña incorrecta y borrara los datos en los textbox.
*Clase BD_Librería:* 
*button2_Click (botón insertar):* Este método maneja el evento de clic en un botón (button2). Su función principal es agregar un producto. Extrae los datos ingresados por el usuario desde varios textBox, asigna esos valores a las propiedades de un objeto Ar, y luego inserta ese objeto en una tabla tab. Finalmente, limpia los campos de entrada (textBox).
*buttonBuscar_Click:* Su función principal es buscar un registro basado en un código ingresado por el usuario. Toma el texto del textBoxBusq, luego intenta convertir el texto a un entero, si la conversión es exitosa, llama a la función Buscar de tab con el código, si se encuentra al menos un registro, muestra los datos en un DataGridView (DTabla) y si no se encuentra ningún registro, muestra un mensaje y limpia el DataGridView. Si el texto no es un número entero válido, muestra un mensaje de error.
*buttoMosT_Click:* Su función principal es mostrar todos los registros de la tabla de inventario en un DataGridView, llama a la función MostrarTabla de tab para obtener los datos de la tabla de inventario desde la base de datos, asigna los datos obtenidos al DataGridView (DTabla) y si ocurre una excepción al mostrar la tabla, muestra un mensaje de error con la descripción de la excepción.

*buttonModificar_Click:* Su función principal es modificar un registro existente en la base de datos,asigna los valores de los campos del formulario a las propiedades del objeto Ar (Codigo, Descripcion, PrecioCosto, PrecioVenta, Cantidad, Distribuidor), llama a la función Modificar de tab para actualizar el registro en la base de datos con los nuevos valores y luego limpia los campos del formulario (textBoxBusq, textBoxCant, textBoxDescrip, textBoxPrecioCost, textBoxPrecioVen, textBoxDist).

*buttonEliminar_Click:* Obtiene el valor del campo textBoxElimCod y lo guarda en la variable codigoTexto,
intenta convertir codigoTexto a un entero y lo guarda en codigoProducto si la conversión es exitosa,
si la conversión es exitosa, llama a la función Eliminar de tab pasando codigoProducto como argumento, después de eliminar el registro, obtiene la tabla actualizada llamando a MostrarTabla y asigna los datos al DataGridView (DTabla) y por ultimo limpia el campo textBoxElimCod.

*buttonSalir_Click:* Su función es simplemente salir de la base de datos regresando al usuario al FormUsuario.

*buttonPruebaCon_Click:* Crea una nueva instancia de la clase Conexion y la guarda en la variable conec luego
llama al método PruebaConexion de la instancia conec para verificar si la conexión a la base de datos es exitosa.


*Clase Conexión:*
*Conexión con la base de datos:* La variable connectionString contiene los detalles necesarios para conectarse a la base de datos MySQL, incluyendo el servidor (localhost), el nombre de la base de datos (exam), el usuario (root) y la contraseña (password) y la variable connection es declarada como un objeto de tipo MySqlConnection, que se usará para establecer y manejar la conexión con la base de datos MySQL utilizando la cadena de conexión especificada.

*public Conexión():* No puede faltar el respectivo constructor que será el cree la instancia del comando MySqlCommand con su parámetro Stringconnection.

*PruebaConexion():* Esta función es la que se encarga de verificar si la conexión entre el formulario o programa y la base de datos esta funcionando correctamente.
*Insertar():* Esta función es la que se encarga de insertar cada uno de los datos que el usuario ingrese en los textBox pasando estos datos a lenguaje sql convirtiendo estos datos a una consulta de sql que agrega estos datos a la base de datos.
*Modificar():* Esta función es la que se encarga de modificar los datos ya existentes, buscando al producto por su código PK tomando como referencia esto vuelve a convertir los datos del usuario a una consulta sql la cual modifica los datos de este producto.
*Eliminar():* Esta función se encarga de eliminar los datos de la base de datos de la misma manera buscando a dicho producto por su código, teniendo en cuenta esto lo pasa a una consulta de sql lo cual lleva a la eliminación de dichos datos.
*Buscar():* Esta función se encarga de buscar el producto por su código, verifica si algún producto esta registrado con dicho código, si lo esta muestra toda la información del producto en el DataGriewView y si no se encuentra ningún producto con este código despliega un mensaje indicándole al usuario que no existe algún producto con dicho código.
*MostarTabla():* Esta función se encarga de insertar una consulta en lenguaje sql la cual muestra los datos o la tabla en si en el DataGriewView.
*Clase P_Artículos:*
Esta clase representa un artículo en un sistema de inventario o gestión de productos. Contiene propiedades que describen diferentes aspectos del artículo, como su código, descripción, precios de costo y venta, cantidad disponible y el nombre del distribuidor. Además, inicializa automáticamente la fecha de ingreso del artículo con la fecha y hora actual cuando se crea una instancia de la clase.
*GRACIAS POR LEER :D*
