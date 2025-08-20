#  AnimeManager - Proyecto .NET MAUI Blazor Hybrid

Este proyecto fue creado como parte de una práctica educativa para aprender a desarrollar aplicaciones multiplataforma con **.NET MAUI Blazor Hybrid**, utilizando patrones de arquitectura simples, componentes visuales modernos (Bootstrap 5), y lógica de negocio separada.

El objetivo fue construir una pequeña app de escritorio donde se pueda **gestionar una colección de animes** y usuarios, con login básico.

---

## 🧠 ¿Qué hace la aplicación?

- Muestra una galería de animes en formato de **cards** con imagen, título, género y año. Para un usuario común sin privilegios.
- Permite realizar un **ABM (Alta, Baja, Modificación)** de animes si el usuario se loguea.
- También permite gestionar usuarios con su propia vista y lista.
- Las imágenes de los animes se leen desde **archivos locales** (`wwwroot/images/animes`).
- El menú principal cambia dinámicamente si el usuario está logueado o no.
- El sistema está **hardcodeado**, es decir, **no guarda los datos en una base de datos ni en archivos**: todo se mantiene en memoria mientras se ejecuta la app.

---

## 🛠️ ¿Cómo funciona el login?

- Se accede desde el menú lateral, opción **"Iniciar sesión"**.
- Podés usar cualquier **email y nombre** (no hay validación real).
- Una vez logueada, se habilitan los botones para agregar, editar o eliminar animes.
- En el menú se muestra un saludo y la opción **"Cerrar sesión"**.

---

## 📌 Sobre el hardcodeo

Este proyecto **no usa una base de datos real**. En cambio:

- Los animes están precargados en una lista dentro del archivo `AnimeService.cs`.
- Los usuarios también están gestionados en memoria, mediante `UsuarioService.cs`.
- No se persiste nada al cerrar la app.
> En un proyecto real, estos datos se guardarían en una base de datos o archivo externo.

---

