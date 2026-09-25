# Sistema de Gestión de Biblioteca (SGB)

| | |
|---|---|
| **Versión** | 0.1 (en desarrollo) |
| **Fecha de lanzamiento** | Septiembre de 2026 |
| **Institución** | Biblioteca Popular Rivadavia |
| **Contexto** | Trabajo de Diploma – Ingeniería de Software – UAI |

## Descripción

El Sistema de Gestión de Biblioteca centraliza la información relacionada con los libros y sus préstamos en la Biblioteca Popular Rivadavia: los datos de los socios, el catálogo de libros y sus ejemplares, los préstamos y devoluciones realizados y las multas generadas por atraso. Reemplaza el registro manual en comprobantes de papel y planillas Excel, que provocaba inconsistencias en los datos y pérdida de ejemplares.

Sus funcionalidades principales son:

- **Gestión de préstamos (RF-001):** registro de préstamos, devoluciones y cobro de multas por atraso, con validación de la habilitación del socio y de la disponibilidad de los ejemplares.
- **Gestión de dashboards (RF-002):** indicadores sobre la actividad de préstamos, como los libros, temas y autores más solicitados.

Además incluye los módulos de seguridad: inicio de sesión, encriptado de contraseñas, perfiles de usuario, bitácora, backup y restore, dígitos verificadores y multi-idioma.

---

# Instalación rápida

## Requisitos previos

- Windows 10 o superior.
- SQL Server y SQL Server Management Studio (SSMS).
- .NET 8 SDK.
- Visual Studio 2022 o superior.

## 1. Crear la base de datos

Abrir SSMS, conectarse al servidor y ejecutar los scripts de la carpeta `BD_SQL` **en este orden**:

| Orden | Script | Contenido |
|---|---|---|
| 1 | `01_seguridad.sql` | Crea la base `bd_sgb`, las tablas de seguridad y el usuario administrador. |
| 2 | `02_negocio.sql` | Crea las tablas del negocio (socios, catálogo, préstamos, devoluciones y multas). |
| 3 | `03_carga_inicial.sql` | Carga los socios y el catálogo preexistentes de la biblioteca. |

Cada script se ejecuta una sola vez. Para empezar de cero, eliminar primero la base:

```sql
USE master;
ALTER DATABASE bd_sgb SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
DROP DATABASE bd_sgb;
```

## 2. Configurar la conexión

La cadena de conexión se lee desde un archivo `.env`, que **no se incluye en el repositorio**. Crearlo en la carpeta del proyecto `UI` con este contenido, reemplazando `Server` por el nombre del servidor que se usa en SSMS (`localhost`, `.\SQLEXPRESS`, etc.):

```env
DB_CONNECTION=Server=localhost;Database=bd_sgb;Trusted_Connection=True;TrustServerCertificate=True
```

En Visual Studio, seleccionar el archivo `.env` → Propiedades → **Copiar en el directorio de salida: Copiar si es posterior**.

## 3. Ejecutar el sistema

1. Abrir `SGB/SGB.sln` en Visual Studio.
2. Compilar la solución (las dependencias NuGet se restauran automáticamente).
3. Ejecutar el proyecto `UI`.

---

# Credenciales iniciales

```text
Usuario:    admin
Contraseña: Admin!123
```

> Se recomienda cambiar la contraseña desde la opción **Cambiar clave** después del primer inicio de sesión.

---

# Estructura del proyecto

El sistema sigue una arquitectura N-Tier de seis capas:

```text
UI         → Interfaz gráfica (Windows Forms)
BLL        → Lógica de negocio
MAP        → Mapeo entre los datos y las entidades
DAL        → Acceso a datos (ADO.NET)
BE         → Entidades de negocio
Servicios  → Servicios técnicos (seguridad, bitácora, idiomas, dígitos verificadores)
```

Dentro de BLL, MAP y DAL, las clases del negocio se encuentran en las carpetas `_NEG` y las de servicios técnicos en `_SER`.

---

# Tecnologías

- C# sobre .NET 8, aplicación de escritorio Windows Forms.
- SQL Server con ADO.NET (`Microsoft.Data.SqlClient`).
- `DotNetEnv` para la configuración de la conexión.
- `QuestPDF` para la exportación de reportes.

---

# Consideraciones de seguridad

- Las contraseñas se almacenan con hashing SHA-256.
- Todas las consultas SQL son parametrizadas para prevenir SQL Injection.
- Las operaciones sensibles quedan registradas en la bitácora.
- La integridad de los datos se controla mediante dígitos verificadores horizontales y verticales.
- El acceso a cada funcionalidad depende de los permisos del rol asignado al usuario.
