## 🚀 Primeros pasos

1. **Clona este repositorio**
    ```bash
    git clone https://github.com/BitterSweetBoy/apigateway.git
    ```

2. **Configura las dependencias**
    - Asegúrate de tener instalado [.NET SDK](https://dotnet.microsoft.com/download).
    - Restaura los paquetes:
      ```bash
      dotnet restore
      ```

3. **Configura tus rutas y servicios**
    - Edita el archivo de configuración para definir los endpoints de tus microservicios.

4. **Ejecuta la aplicación**
    ```bash
    dotnet run
    ```
---
## 📁 Estructura del proyecto

```
apigateway/
│
├── Controllers/         # Controladores de rutas y lógica de gateway
├── Services/            # Servicios auxiliares y de integración
├── Models/              # Modelos de datos y DTOs
├── Program.cs           # Punto de entrada de la aplicación
├── appsettings.json     # Configuración de rutas y servicios
└── README.md
```
---
## 💡 Sobre el autor

Desarrollado con ❤️ por [BitterSweetBoy](https://github.com/BitterSweetBoy).

---
