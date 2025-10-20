# Kata 2: Calculator

## 🎯 Objetivo
Implementar una calculadora básica usando TDD (Test-Driven Development).

## 📋 Requisitos
Implementa una clase `Calculator` con los siguientes métodos:
- `Add(int a, int b)` - Suma dos números
- `Subtract(int a, int b)` - Resta dos números  
- `Multiply(int a, int b)` - Multiplica dos números
- `Divide(int a, int b)` - Divide dos números

## 🔴 Red → 🟢 Green → 🔵 Refactor
1. **Red**: Escribe un test que falle
2. **Green**: Escribe el código mínimo para que pase
3. **Refactor**: Mejora el código manteniendo los tests verdes

## 🚀 Empezar
1. Ejecuta `dotnet test` - verás tests fallando ❌
2. Implementa los métodos en `Calculator.cs`
3. Ejecuta `dotnet test` hasta que todos pasen ✅

## ⚠️ Casos Especiales
- ¿Qué pasa al dividir por cero?
- ¿Cómo manejar números negativos?
- ¿Overflow de enteros?

**¡Piensa en los casos edge mientras implementas!**