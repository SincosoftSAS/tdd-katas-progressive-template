# 🎯 Kata 1: FizzBuzz

## 📝 Descripción

Implementa el clásico juego FizzBuzz. Es perfecto para practicar TDD porque tiene reglas claras y casos de prueba obvios.

## 🎮 Reglas del Juego

Crea una función que tome un número `n` y devuelva una lista de strings del 1 al n, donde:

- Los números divisibles por **3** se reemplazan por `"Fizz"`
- Los números divisibles por **5** se reemplazan por `"Buzz"`  
- Los números divisibles por **15** (3 y 5) se reemplazan por `"FizzBuzz"`
- Todos los demás números se mantienen como strings

## 📋 Ejemplos

```csharp
FizzBuzz(15) debería devolver:
["1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"]
```

## 🔍 Casos de Prueba

Tu implementación debe pasar estos casos:
- `FizzBuzz(1)` → `["1"]`
- `FizzBuzz(3)` → `["1", "2", "Fizz"]`
- `FizzBuzz(5)` → `["1", "2", "Fizz", "4", "Buzz"]`
- `FizzBuzz(15)` → Lista completa con "FizzBuzz" al final

## 💻 Archivos de Trabajo

- **Tu código**: `src/FizzBuzz.cs`
- **Tests**: `tests/FizzBuzzTests.cs`

## 🔄 Ciclo TDD

1. **🔴 Red**: Ejecuta `dotnet test` - debería fallar
2. **🟢 Green**: Escribe código mínimo en `src/FizzBuzz.cs` para que pase
3. **🔵 Refactor**: Mejora el código manteniendo los tests verdes
4. **Repite** hasta completar todos los casos

## 🚀 Comandos Útiles

```bash
# Ejecutar tests
dotnet test

# Ejecutar con más detalle
dotnet test --verbosity normal

# Compilar
dotnet build
```

## ✅ ¿Cuándo está completo?

El kata está completo cuando:
- ✅ Todos los tests pasan
- ✅ El código es limpio y legible
- ✅ Seguiste el ciclo TDD

¡Una vez completo, se desbloqueará automáticamente el siguiente kata! 🎉