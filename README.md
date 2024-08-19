# ApiTarea

ApiTarea es un proyecto diseñado para proporcionar servicios relacionados con la gestión de tareas a través de una arquitectura en capas. Este proyecto está construido utilizando ASP.NET Core y sigue principios de arquitectura limpia, lo que facilita la separación de preocupaciones y la escalabilidad del sistema.

## 🏛️ Arquitectura del Proyecto

El proyecto se organiza en varias capas y bibliotecas de clases que se comunican entre sí para gestionar las operaciones de la API de gestión de tareas. A continuación se describen los componentes clave:

![Diagrama de Arquitectura]()

## ⚙️ Requisitos Previos

Antes de ejecutar el proyecto, asegúrate de tener instalados los siguientes requisitos:

- **.NET Core 8 SDK o superior**
- **SQL Server** o cualquier otro servidor compatible para la base de datos

## 🛠️ Instalación

1. **Clonar el repositorio:**

    ```bash
    git clone https://github.com/tuusuario/ApiTarea.git
    cd ApiTarea
    ```

2. **Restaurar dependencias:**

    Navega a la carpeta raíz del proyecto y ejecuta:

    ```bash
    dotnet restore
    ```

3. **Configurar la cadena de conexión de la base de datos:**

    Abre el archivo `appsettings.json` en la carpeta `ApiGestionarTarea` y actualiza la cadena de conexión de la base de datos según tu entorno.

4. **Aplicar migraciones y actualizar la base de datos:**

    Ejecuta el siguiente comando para aplicar las migraciones a la base de datos:

    ```bash
    dotnet ef database update --project Repositorio
    ```

    Alternativamente, si prefieres ejecutar la migración manualmente en tu PC, puedes utilizar los siguientes comandos en la consola del Package Manager (PMC) o en la terminal de comandos:

    Crear la migración inicial:

    ```bash
    Add-Migration InitialCreate -Project Repositorio
    ```

    Aplicar la migración a la base de datos:

    ```bash
    Update-Database -Project Repositorio
    ```

## 🚀 Ejecución

1. **Compilar el proyecto:**

    ```bash
    dotnet build
    ```

2. **Ejecutar la API:**

    ```bash
    dotnet run --project ApiGestionarTarea
    ```

    La API estará disponible en `https://localhost:5001` o `http://localhost:5000`.

## ⚡ Probar la API

Puedes probar la API utilizando la interfaz de Swagger proporcionada en el despliegue local. Swagger permite interactuar fácilmente con los endpoints y ver las respuestas de la API.

### Acceso a la Documentación de la API con Swagger

1. **URL de Swagger:**

    Puedes acceder a la documentación y probar los endpoints directamente desde [http://www.apitareasaldairdo.somee.com/swagger/index.html](http://www.apitareasaldairdo.somee.com/swagger/index.html).

## 🤝 Contribuciones

Si deseas contribuir a este proyecto, puedes hacer un fork del repositorio y enviar un pull request con tus mejoras o correcciones. Todas las contribuciones son bienvenidas.

## 📄 Licencia

Este proyecto está bajo la [MIT License](https://opensource.org/licenses/MIT).
