# 🎯 Kata 3: Leap Year

## 📝 Descripción

Determina si un año dado es un año bisiesto. Este kata es perfecto para practicar TDD con lógica condicional compleja.

## 📅 Reglas de Año Bisiesto

Un año es bisiesto si:
1. **Es divisible por 4** Y
2. **NO es divisible por 100** 
3. **EXCEPTO** si es divisible por 400

### 📋 Ejemplos

- **2000**: ✅ Bisiesto (divisible por 400)
- **1900**: ❌ No bisiesto (divisible por 100 pero no por 400)
- **2004**: ✅ Bisiesto (divisible por 4 y no por 100)
- **2001**: ❌ No bisiesto (no divisible por 4)

## 🔍 Casos de Prueba (Ejemplos)

Los tests incluidos son solo **ejemplos** para guiarte:
- ✅ Año divisible por 4: `2004` → `true`
- ✅ Año no divisible por 4: `2001` → `false`

**Nota**: El servidor ejecutará tests adicionales ocultos que evaluarán:
- Años divisibles por 100 pero no por 400 (ej: 1900)
- Años divisibles por 400 (ej: 2000)  
- Casos límite y validaciones extras

## 💻 Archivos de Trabajo

- **Tu código**: `src/LeapYear/LeapYearChecker.cs` ← Implementa aquí
- **Tests ejemplo**: `tests/LeapYear.Tests/LeapYearCheckerTests.cs` ← Solo 2 ejemplos

## 🔄 Ciclo TDD

1. **🔴 Red**: Escribe un test que falle
2. **🟢 Green**: Implementa código mínimo para que pase
3. **🔵 Refactor**: Mejora la lógica
4. **Repite** para cada regla

## ✅ ¿Cuándo está completo?

- ✅ Maneja todos los casos de bisiestos
- ✅ Lógica clara y correcta
- ✅ Tests exhaustivos
- ✅ Código limpio

¡Al completar, se desbloqueará el Kata 4! 🚀