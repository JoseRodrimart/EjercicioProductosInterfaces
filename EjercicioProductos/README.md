### Interfaz de gestión de productos informáticos
Interfaz desarrollada en C#, haciendo uso de Winforms. La aplicación sigue el patrón de arquitectura MVC. El modelo de datos se gestiona en tiempo de ejecución, una lista de la entidad Product se almacena en el controlador, el cual ofrece todas las funciones necesarias para la gestión de los eventos.

La vista gira en torno a un DataGridView, el cual gestionamos a través de su dataSource u origen de datos. Este origen de datos consiste en una lista reactiva almacenada en el controlador, que funciona gracias a la implementación del patrón de diseño Observador, haciendo uso de la interfaz [INotifyProperty](https://docs.microsoft.com/es-es/dotnet/api/system.componentmodel.inotifypropertychanged?view=net-6.0).

Se dispone de utilidades de gestión tales como filtro mútliple de todos los campos disponibles y ordenación ascendente y descentente.

Se ofrece también una funcinalidad de importación y exportación basado en ficheros CSV. Las imágenes son serializadas y almacenadas en Base64 en forma de String en el campo correspondiente del CSV.