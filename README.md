# RRHHSystems - Backend

Este es el backend de **RRHHSystems**, un sistema de recursos humanos para gestionar empleados, cargos, salarios, ponches, cuentas y nóminas. Este backend está desarrollado en **.NET Core 8** y utiliza **Entity Framework Core** como ORM, conectándose a una base de datos **SQL Server Express**.

## Tecnologías

Este proyecto utiliza las siguientes tecnologías:

- .NET Core 8
- Entity Framework Core
- SQL Server Express
- LINQ
- Repository Pattern

## Instalación

Para clonar y ejecutar este proyecto, necesitas [Git](https://git-scm.com) y [.NET SDK](https://dotnet.microsoft.com/download) instalados en tu máquina.

1. Clona el repositorio:

   ```bash
   git clone https://github.com/tu-usuario/RRHHSystems.git
   cd RRHHSystems/backend

2. Restaura las dependencias del proyecto::

   ```bash
    dotnet restore

## Endpoints

La API incluye los siguientes endpoints:

Account:
- POST /api/account/register - Registro de usuarios
- POST /api/account/login - Inicio de sesión de usuarios

Employees:
- GET /api/employees - Listar todos los empleados
- POST /api/employees - Crear un nuevo empleado
- PUT /api/employees/{id} - Actualizar un empleado
- DELETE /api/employees/{id} - Eliminar un empleado

Positions (Cargos):
- GET /api/positions - Listar todos los cargos
- POST /api/positions - Crear un nuevo cargo
- PUT /api/positions/{id} - Actualizar un cargo
- DELETE /api/positions/{id} - Eliminar un cargo

Payroll (Nóminas):
- GET /api/payrolls - Obtener lista de nóminas
- POST /api/payrolls - Generar nómina

`Nota: Los endpoints pueden requerir autenticación y roles específicos. Consulta la documentación interna para obtener detalles sobre permisos.`

## Estructura de Directorios
```
RRHHSystems/
│
├── Controllers/        # Controladores de la API
├── Models/             # Modelos de datos
├── Data/               # Contexto de base de datos y repositorios
├── Migrations/         # Migraciones de Entity Framework Core
├── Repositories/       # Implementaciones del patrón repositorio
└── appsettings.json    # Configuración de la aplicación
```


