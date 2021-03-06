# Cuentas por pagar 💰
_Esta es una aplicación de escritorio creada con WindowsForms (.NET Framework) utilizando el modelo Model-View-Controller (MVC) para un sistema de Cuentas por Pagar. En esta aplicación se podrán gestionar diferentes conceptos de pago, los proveedores y los documentos por pagar. También se realizaran los procesos como la generación del pago y el cierre. Nuestra aplicación también contiene un control de acceso basado en los diferentes privilegios del usuario; dependiendo del privilegio podrá realizar consultas, reportes, agregar datos, entre otras cosas._

## Funcionalidad 💻
_Al entrar en la aplicación se podrá ver el login en el que podrás iniciar sesión si ya tienes una cuenta creada. Una vez inicias sesión podrás ver la página de inicio y todos los mantenimientos disponibles. Dependiendo de los privilegios asignados a tu usuario (administrador o usuario normal) podrás tener acceso a agregar datos en los mantenimientos, crear reportes, ejecutar procesos, crear nuevos usuarios y realizar consultas._

_Entre los mantenimientos tenemos el de usuario, documentos por pagar, conceptos de pago, proveedores, parámetros y el de cierre. En cada uno se podrán editar, agregar y borrar datos. En cada uno podrá ver un DataGrid donde se van a presentar los datos y botones para navegar a través de los mismos._

## Instrucciones 📝
_Para obtener una copia del proyecto, favor clonar el repositorio._

_Una vez con la copia, ir al directorio db_scripts y ejecutar en sql server el script en db_scheme.sql._

_Luego se debe tener en cuenta el connection string de la base de datos que está en la variable de entorno "CxPagar_System\.env" y cambiar la parte de "Data Source" indicando el servidor correspondiente de tu máquina._

_Finalmente las credenciales por defecto para logearse en la aplicación al ejecutarla son:_
_- Username: admin_
_- Password: admin1234_

## Herramientas utilizadas 🔧
* Visual Studio 2022
* SQL Server
* C#
* WindowsForms (.NET Framework)
* Entity Framework

## Autores 👨‍💻
* **Adrian Mota** - [adrianmota](https://github.com/adrianmota)
* **Adriel De La Cruz** - [Adriel-dz11](https://github.com/Adriel-dz11)
* **Clara Inés Diaz** - [Ines-Dev-1103](https://github.com/Ines-Dev-1103)
*  **Saily Cabrera** - [sailymc](https://gist.github.com/sailymc)

## Imágenes
![image](https://user-images.githubusercontent.com/87541356/166089558-8454570d-74bc-4769-bef3-1e30c692ebdd.png)
![image](https://user-images.githubusercontent.com/87541356/166089569-ddfa0df6-6979-4681-9f28-a50158957d87.png)
![image](https://user-images.githubusercontent.com/87541356/166089639-6dade8ca-a5b4-4ba6-ab08-fd54503ef5fd.png)


