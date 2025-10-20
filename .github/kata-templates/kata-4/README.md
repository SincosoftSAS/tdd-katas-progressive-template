# Kata 4: String Calculator

## Objetivo
Implementar una calculadora de cadenas siguiendo TDD que puede sumar números separados por delimitadores.

## Reglas del Kata

### Iteración 1: Funcionalidad Básica
1. **Input vacío**: `Calculate("")` debe retornar `0`
2. **Un número**: `Calculate("1")` debe retornar `1`
3. **Dos números**: `Calculate("1,2")` debe retornar `3`
4. **Múltiples números**: `Calculate("1,2,3,4,5")` debe retornar `15`

### Iteración 2: Delimitadores
1. **Nuevas líneas**: `Calculate("1\n2,3")` debe retornar `6`
2. **Delimitador personalizado**: `Calculate("//;\n1;2")` debe retornar `3`
   - Format: `//[delimiter]\n[numbers...]`

### Iteración 3: Validaciones
1. **Números negativos**: Lanzar excepción con mensaje "Negatives not allowed: [números]"
   - `Calculate("1,-2,3,-4")` → Exception: "Negatives not allowed: -2, -4"

### Iteración 4: Reglas Avanzadas
1. **Ignorar números > 1000**: `Calculate("2,1001")` debe retornar `2`
2. **Delimitadores de múltiples caracteres**: `Calculate("//[***]\n1***2***3")` debe retornar `6`

## 🔍 Casos de Prueba (Ejemplos)

Los tests incluidos son solo **ejemplos** para guiarte:
- ✅ Cadena vacía: `""` → `0`
- ✅ Dos números: `"1,2"` → `3`

**Nota**: El servidor ejecutará tests adicionales ocultos que evaluarán:
- Números únicos y múltiples
- Delimitadores personalizados y nuevas líneas
- Números negativos (excepciones)
- Números > 1000 (ignorar)
- Delimitadores multi-carácter

## Enfoque TDD
1. **Red**: Escribe un test que falle
2. **Green**: Implementa el código mínimo para que pase
3. **Refactor**: Mejora el código manteniendo los tests verdes

## 💻 Archivos de Trabajo
- **Tu código**: `src/StringCalculator.cs` ← Implementa aquí  
- **Tests ejemplo**: `tests/StringCalculatorTests.cs` ← Solo 2 ejemplos

## Consejos
- Comienza con el caso más simple
- Refactoriza frecuentemente
- Mantén los tests legibles y específicos
- Un test por regla de negocio

## Criterio de Éxito
- Todos los tests pasan
- Código limpio y legible
- Cobertura completa de todas las reglas