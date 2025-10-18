# 📊 Mi Progreso en TDD Katas

¡Bienvenido a tu viaje de aprendizaje de TDD! 🚀

---

## 🎯 Estado Actual

**Kata Actual:** Kata 01 - FizzBuzz  
**Katas Completadas:** 0 / 5  
**Nivel:** Principiante 🥚

---

## 📚 Roadmap de Katas

### ✅ Katas Completadas
_¡Aún no has completado ninguna kata! Comienza con Kata 01._

---

### 🎯 Kata Actual

#### 📌 Kata 01: FizzBuzz
**Estado:** 🔓 Desbloqueada (En Progreso)  
**Dificultad:** ⭐ Fácil  
**Tiempo Estimado:** 30-45 minutos  
**Conceptos:** Números, condicionales, múltiplos

**¿Qué aprenderás?**
- Escribir tests primero (TDD)
- Ciclo Red-Green-Refactor
- Manejo de condicionales
- Tests parametrizados

**Archivos:**
- `FizzBuzz/FizzBuzz.cs` - Tu implementación
- `FizzBuzz.Tests/FizzBuzzTests.cs` - Tests visibles
- Tests ocultos se ejecutan en CI

**Comandos:**
```bash
# Ejecutar tests localmente
dotnet test

# Ver cobertura
dotnet test --collect:"XPlat Code Coverage"
```

**¿Cómo saber si terminaste?**
- ✅ Todos los tests locales pasan (`dotnet test`)
- ✅ Push a `main`
- ✅ GitHub Actions marca checks en verde
- ✅ Recibirás PR automático con la siguiente kata

---

### 🔒 Próximas Katas

#### 📌 Kata 02: String Calculator
**Estado:** 🔒 Bloqueada  
**Se desbloquea:** Al completar Kata 01  
**Dificultad:** ⭐⭐ Media  
**Tiempo Estimado:** 45-60 minutos  
**Conceptos:** Parsing, strings, manejo de errores, TDD incremental

---

#### 📌 Kata 03: Leap Year
**Estado:** 🔒 Bloqueada  
**Se desbloquea:** Al completar Kata 02  
**Dificultad:** ⭐ Fácil  
**Tiempo Estimado:** 20-30 minutos  
**Conceptos:** Lógica booleana, años bisiestos, reglas de negocio

---

#### 📌 Kata 04: Roman Numerals
**Estado:** 🔒 Bloqueada  
**Se desbloquea:** Al completar Kata 03  
**Dificultad:** ⭐⭐⭐ Difícil  
**Tiempo Estimado:** 60-90 minutos  
**Conceptos:** Conversión de numerales, algoritmos, refactoring

---

#### 📌 Kata 05: Bowling Game
**Estado:** 🔒 Bloqueada  
**Se desbloquea:** Al completar Kata 04  
**Dificultad:** ⭐⭐⭐⭐ Muy Difícil  
**Tiempo Estimado:** 90-120 minutos  
**Conceptos:** Estado complejo, scoring avanzado, diseño orientado a objetos

---

## 🏆 Sistema de Logros

### Insignias Disponibles

- [ ] 🥚 **First Steps** - Completa Kata 01
- [ ] 🐣 **Getting Started** - Completa 2 katas
- [ ] 🐥 **On a Roll** - Completa 3 katas consecutivas
- [ ] 🦅 **TDD Practitioner** - Completa 4 katas
- [ ] 🏅 **TDD Master** - Completa todas las katas

### Estadísticas

| Métrica | Valor |
|---------|-------|
| Katas Completadas | 0 / 5 |
| Tests Escritos | - |
| Commits Realizados | - |
| Racha Actual | 0 días |
| Fecha de Inicio | - |

---

## 📖 Recursos

### 🎓 TDD Basics
- **Red-Green-Refactor**: Escribe test (rojo) → Implementa mínimo (verde) → Mejora código (refactor)
- **Baby Steps**: Avanza en pequeños incrementos
- **Test First**: Siempre escribe el test antes del código

### 🛠️ Comandos Útiles

```bash
# Ver tu progreso
cat PROGRESS.md

# Ejecutar tests
dotnet test

# Ver tests con detalle
dotnet test --logger "console;verbosity=detailed"

# Ejecutar solo un test específico
dotnet test --filter "FullyQualifiedName~FizzBuzzTests.Test_N_3_Should_Return_Fizz"

# Ver cobertura
dotnet test --collect:"XPlat Code Coverage"

# Ver branches disponibles
git branch -a

# Cambiar a la siguiente kata (cuando se desbloquee)
git fetch origin
git checkout kata-02-calculator
```

### 📚 Documentación
- [xUnit Documentation](https://xunit.net/)
- [.NET Testing Guide](https://docs.microsoft.com/dotnet/core/testing/)
- [TDD by Example (Kent Beck)](https://www.amazon.com/Test-Driven-Development-Kent-Beck/dp/0321146530)

---

## ❓ FAQ

**¿Cuándo se desbloquea la siguiente kata?**  
Automáticamente cuando todos tus tests (visibles y ocultos) pasen en GitHub Actions.

**¿Cómo sé si mis tests están pasando?**  
Revisa el check verde/rojo en tu último commit en GitHub, o ejecuta `dotnet test` localmente.

**¿Puedo ver los tests ocultos?**  
No, están en el template y se ejecutan solo en CI. Esto simula requisitos reales de negocio.

**¿Qué pasa si me atasco?**  
1. Revisa las instrucciones de la kata en el README
2. Ejecuta `dotnet test` para ver qué tests fallan
3. Lee el mensaje de error con atención
4. Implementa la solución más simple que funcione
5. Refactoriza después

**¿Puedo saltarme una kata?**  
No, el sistema es progresivo. Cada kata construye sobre las anteriores.

**¿Cuánto tiempo debería tomar cada kata?**  
Es variable, pero los tiempos estimados son orientativos. ¡No hay prisa! Lo importante es aprender.

---

## 🎯 Próximos Pasos

1. ✅ Lee las instrucciones en el README principal
2. ✅ Abre `FizzBuzz/FizzBuzz.cs`
3. ✅ Revisa los tests en `FizzBuzz.Tests/FizzBuzzTests.cs`
4. ✅ Ejecuta `dotnet test` (verás tests fallando - ¡eso es normal!)
5. ✅ Implementa la solución siguiendo TDD
6. ✅ Push a main cuando todos los tests pasen
7. ✅ Espera el PR automático con la siguiente kata

---

## 💡 Consejos

- 🧪 **Ejecuta tests frecuentemente** - Cada 2-3 minutos
- 📝 **Commits pequeños** - Cada vez que un test pase
- 🔴 **Red primero** - Asegúrate que el test falle antes de implementar
- 🟢 **Green mínimo** - Implementa lo mínimo para que pase
- ♻️ **Refactor confiado** - Los tests te protegen
- 🚫 **No hagas trampa** - No modifiques los tests visibles
- 📚 **Lee los errores** - Los mensajes de error son tus amigos

---

## 🌟 Motivación

> "The only way to go fast, is to go well."  
> — Robert C. Martin (Uncle Bob)

¡Estás aprendiendo una habilidad que te acompañará toda tu carrera! 🚀

El TDD no es solo sobre tests - es sobre:
- ✅ **Confianza** en tu código
- ✅ **Diseño** emergente y limpio
- ✅ **Documentación** viviente
- ✅ **Feedback** inmediato
- ✅ **Refactoring** sin miedo

---

**¡Buena suerte en tu viaje de TDD!** 🎉

_Este archivo se actualiza automáticamente cuando completas katas._

---

<sub>Última actualización: Al iniciar el curso | Kata actual: 01 | Estado: En progreso</sub>
