# SISTEMA DE VENTA DE CELULARES Y ACCESORIOS

### Descripción del sistema

El Sistema de Venta de Celulares y Accesorios es una solución de gestión e inteligencia comercial orientada a negocios dedicados a la comercialización de celulares, accesorios y servicios técnicos.

El sistema permite centralizar y administrar las operaciones principales de la empresa, incluyendo ventas, gestión de usuarios, control de stock, auditoría de eventos y seguridad del sistema, reemplazando procesos manuales y registros dispersos por una plataforma integrada y organizada.

Entre sus principales funcionalidades se encuentran:

- Gestión de usuarios y control de acceso.
- Inicio y cierre de sesión con auditoría de eventos.
- Control de bloqueo y desbloqueo de usuarios.
- Gestión de cambios de contraseña.
- Registro de eventos críticos mediante bitácora.
- Administración de operaciones comerciales y persistencia de datos.
- Prevención de SQL Injection mediante consultas parametrizadas.
- Seguridad basada en hashing SHA-256 para contraseñas.

El sistema fue desarrollado utilizando arquitectura en capas, separando responsabilidades entre interfaz gráfica, lógica de negocio, mapeadores, acceso a datos y servicios técnicos.

---

# Instalación rápida

## Requisitos previos

Antes de ejecutar el sistema, asegurarse de contar con:

- Windows 10 o superior.
- SQL Server instalado.
- .NET Framework / .NET compatible con la solución.
- Visual Studio 2022 o superior (recomendado).

---

## Configuración de la base de datos

1. Abrir SQL Server Management Studio.
2. Ejecutar los scripts SQL ubicados dentro de la carpeta:

```text
BD_SQL
```

3. Verificar que la base de datos haya sido creada correctamente.

---

## Configuración de conexión

La conexión a la base de datos se administra mediante variables de entorno utilizadas por la capa DAL.

Configurar la cadena de conexión correspondiente antes de ejecutar el sistema.

Ejemplo de configuración:

```text
Data Source=.;
Initial Catalog=bd_sgvcelulares;
Integrated Security=true;
TrustServerCertificate=true
```

---

## Ejecución del sistema

1. Abrir la solución del proyecto en Visual Studio.
2. Restaurar dependencias si fueran necesarias.
3. Compilar la solución.
4. Ejecutar el proyecto principal WinForms.

---

# Credenciales iniciales

## Usuario administrador inicial

```text
Usuario: admin
Contraseña: 12345678Admin
```

> La contraseña puede modificarse desde la funcionalidad “Cambiar Clave”.

---

# Consideraciones de seguridad

- Las contraseñas son almacenadas utilizando hashing SHA-256.
- El sistema implementa consultas SQL parametrizadas para evitar SQL Injection.
- Las operaciones sensibles son registradas automáticamente en la bitácora del sistema.
- Solo usuarios administradores pueden acceder a la auditoría de eventos.

---

# Estructura general del proyecto

El sistema se encuentra organizado mediante arquitectura en capas:

```text
UI   → Interfaz gráfica
BLL  → Lógica de negocio
MAP  → Mapeadores
DAL  → Acceso a datos
SER  → Servicios técnicos
BE   → Entidades de negocio
```
