# 🏗️ Design Patterns Workshop: Refactoring to Clean Code

![.NET 8](https://img.shields.io/badge/.NET-8.0-512BD4?style=flat&logo=dotnet)
![Language](https://img.shields.io/badge/Language-C%23-239120?style=flat&logo=csharp)
![Status](https://img.shields.io/badge/Status-In%20Progress-yellow)

## 📖 Sobre el Proyecto

Bienvenido a **Design Patterns Workshop**. Este repositorio no es una simple colección de ejemplos teóricos. Es un laboratorio práctico de **refactorización**.

El objetivo es simular escenarios del mundo real ("The Horror" 😱) donde el código viola principios de diseño (SOLID, DRY, KISS), y transformarlos paso a paso aplicando el **Patrón de Diseño** arquitectónicamente correcto.

Aquí encontrarás el contraste directo entre:
* ❌ **Anti-Patrones:** Código acoplado, rígido y difícil de mantener (Spaghetti Code).
* ✅ **Soluciones Arquitectónicas:** Código limpio, desacoplado y escalable.

---

## 🚀 Estructura del Proyecto

Cada patrón tiene su propia carpeta que contiene el problema y (eventualmente) la solución refactorizada.

```text
DesignPatternsWorkshop/
├── 📂 Adapter_Problem/        # Escenario Legacy incompatible
├── 📂 Bridge_Problem/         # Explosión de clases por herencia
├── 📂 Builder_Problem/        # Constructores monstruosos
├── 📂 Factory_Problem/        # Lógica condicional excesiva
├── 📂 Singleton_Problem/      # Problemas de estado global
├── ... (y más)
└── Program.cs                 # Punto de entrada para ejecutar las demos
└── Program.cs                 # Punto de entrada para ejecutar las demos

### 🛠️ Catálogo de Patrones

**Patrones Creacionales (Creational)**

Se centran en cómo se instancian los objetos para desacoplar el sistema de su implementación.

- **Singleton** — Problemática: Instancias múltiples de recursos compartidos (DB). **Estado:** ✅ Listo
- **Factory Method** — Problemática: Uso excesivo de `switch`/`if` para crear objetos. **Estado:** ✅ Listo
- **Abstract Factory** — Problemática: Mezcla incoherente de familias de objetos (p. ej. UI Windows/Mac). **Estado:** ✅ Listo
- **Builder** — Problemática: Constructores "telescópicos" con demasiados parámetros y valores nulos. **Estado:** 🚧 WIP
- **Prototype** — Problemática: Creación costosa de objetos repetitivos (impacto en rendimiento). **Estado:** 🚧 WIP

**Patrones Estructurales (Structural)**

Se centran en cómo componer clases y objetos para formar estructuras mayores.

- **Adapter** — Problemática: Incompatibilidad de interfaces con sistemas Legacy. **Estado:** 🚧 WIP
- **Bridge** — Problemática: Explosión de clases por combinar múltiples dimensiones en herencia. **Estado:** 🚧 WIP
- **Composite** — Problemática: Tratamiento desigual entre objetos simples y grupos. **Estado:** 🚧 WIP
- **Decorator** — Problemática: Herencia rígida para añadir funcionalidades extras (explosión de clases). **Estado:** 🚧 WIP
- **Facade** — Problemática: Complejidad alta para el cliente al orquestar subsistemas. **Estado:** 🚧 WIP
- **Proxy** — Problemática: Acceso directo a objetos pesados sin control (sin caché/lazy). **Estado:** 🚧 WIP

**Patrones de Comportamiento (Behavioral)**

Se centran en la asignación de responsabilidades y comunicación entre objetos.

- **Chain of Responsibility** — Problemática: Anidación profunda de `if` para validaciones. **Estado:** ⏳ Pendiente
- **Command** — Problemática: Lógica de negocio acoplada a la UI (acciones/ botones). **Estado:** ⏳ Pendiente
- **Observer** — Problemática: Acoplamiento fuerte al notificar cambios a otros servicios. **Estado:** ⏳ Pendiente
- **State** — Problemática: Máquinas de estado gestionadas con condicionales complejos. **Estado:** ⏳ Pendiente
- **Strategy** — Problemática: Algoritmos intercambiables hardcodeados dentro de la clase. **Estado:** ⏳ Pendiente
- **Template Method** — Problemática: Duplicación de código en algoritmos con pasos similares. **Estado:** ⏳ Pendiente

```
