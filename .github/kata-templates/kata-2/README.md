# 🎯 Kata 2: Calculator

## 📝 Descripción

Implementa una calculadora simple que puede realizar operaciones básicas. Este kata te ayuda a practicar TDD con múltiples métodos y validaciones.

## 🧮 Funcionalidades

Crea una clase `Calculator` con los siguientes métodos:

- `Add(int a, int b)` → Suma dos números
- `Subtract(int a, int b)` → Resta dos números  
- `Multiply(int a, int b)` → Multiplica dos números
- `Divide(int a, int b)` → Divide dos números (maneja división por cero)

## 📋 Ejemplos

```csharp
var calc = new Calculator();
calc.Add(2, 3)      // → 5
calc.Subtract(5, 2) // → 3  
calc.Multiply(3, 4) // → 12
calc.Divide(8, 2)   // → 4
calc.Divide(5, 0)   // → Lanza excepción
```

## 🔍 Casos de Prueba

- Operaciones básicas con números positivos
- Operaciones con números negativos
- División por cero debe lanzar `DivideByZeroException`
- Casos límite (0, números grandes)

## 💻 Archivos de Trabajo

- **Tu código**: `src/Calculator.cs`
- **Tests**: `tests/CalculatorTests.cs`

## 🔄 Ciclo TDD

1. **🔴 Red**: Escribe un test que falle
2. **🟢 Green**: Implementa código mínimo para que pase
3. **🔵 Refactor**: Mejora el código
4. **Repite** para cada método

## ✅ ¿Cuándo está completo?

- ✅ Todos los métodos implementados
- ✅ Manejo correcto de excepciones
- ✅ Tests exhaustivos
- ✅ Código limpio

¡Al completar, se desbloqueará el Kata 3! 🚀