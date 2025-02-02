# Proyecto_Ciclistas
Aplicación C# con Windows Forms conectada a una BBDD Oracle SQL

Este proyecto desarrollado en C# (Windows Forms) con Oracle SQL permite la gestión completa de competiciones de ciclismo, incluyendo el registro, edición y control de ciclistas y eventos.
O Funcionalidades Implementadas:

O Gestión de Competiciones:

    * Crear, editar y eliminar competiciones.
    * Listar competiciones en un ComboBox, mostrando ciudad y fecha.
    * Marcar competiciones como borradas en lugar de eliminarlas físicamente.

O Gestión de Ciclistas:

    * Registro individual y múltiple de ciclistas en una competición.
    * Edición y eliminación (borrado lógico) de ciclistas.
    * Control del estado de pago de la inscripción.
    * Filtrar ciclistas por competición seleccionada.
    * Asignación automática de dorsales con ObtenerMaxDorsal().

O Optimización y Mejoras:

    * Centralización de la conexión a la base de datos (Parametros.cs).
    * Modularización del código, separando la lógica en funciones y clases (Ciclista, Competicion).
    * Uso de transacciones SQL para garantizar la coherencia de datos.
    * Interfaz intuitiva, con validaciones y mensajes de confirmación.

Este sistema está completamente funcional y preparado para futuras mejoras, como exportación de datos, estadísticas y gestión de roles.
