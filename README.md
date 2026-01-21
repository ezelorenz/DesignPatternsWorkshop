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


🛠️ Catálogo de Patrones🏗️ Patrones Creacionales (Creational)Se centran en cómo se instancian los objetos para desacoplar el sistema de su implementación.PatrónProblemática (Anti-Pattern)EstadoSingletonInstancias múltiples de recursos compartidos (DB).✅ ListoFactory MethodUso excesivo de switch/if para crear objetos.✅ ListoAbstract FactoryMezcla incoherente de familias de objetos (UI Windows/Mac).✅ ListoBuilderConstructores "telescópicos" con demasiados parámetros nulos.🚧 WIPPrototypeCreación costosa de objetos repetitivos (Performance).🚧 WIP🌉 Patrones Estructurales (Structural)Se centran en cómo componer clases y objetos para formar estructuras mayores.PatrónProblemática (Anti-Pattern)EstadoAdapterIncompatibilidad de interfaces con sistemas Legacy.🚧 WIPBridgeExplosión de clases por herencia multidimensional.🚧 WIPCompositeTratamiento desigual entre objetos simples y grupos.🚧 WIPDecoratorHerencia rígida para añadir funcionalidades extras.🚧 WIPFacadeComplejidad alta para el cliente al orquestar subsistemas.🚧 WIPProxyAcceso directo a objetos pesados sin control (Lazy/Cache).🚧 WIP📡 Patrones de Comportamiento (Behavioral)Se centran en la asignación de responsabilidades y comunicación entre objetos.PatrónProblemática (Anti-Pattern)EstadoChain of Resp.Anidación profunda de IFs para validaciones.⏳ PendienteCommandLógica de negocio acoplada a la UI (Botones).⏳ PendienteObserverAcoplamiento fuerte al notificar cambios a otros servicios.⏳ PendienteStateMáquinas de estado gestionadas con condicionales complejos.⏳ PendienteStrategyAlgoritmos intercambiables hardcodeados dentro de la clase.⏳ PendienteTemplate MethodDuplicación de código en algoritmos con pasos similares.⏳ Pendiente

```
