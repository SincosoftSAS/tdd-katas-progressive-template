# Kata 5: Bowling Game

## Objetivo
Implementar un sistema de puntuación para bolos siguiendo TDD que calcule correctamente el puntaje según las reglas oficiales.

## Reglas del Bowling

### Estructura del Juego
- **10 frames** por juego
- Cada frame tiene **hasta 2 tiradas** (excepto el frame 10)
- **10 pines** por frame

### Puntuación Básica
- **Strike (X)**: Derribar todos los pines en la primera tirada
  - Puntos: 10 + próximas 2 tiradas
- **Spare (/)**: Derribar todos los pines en 2 tiradas
  - Puntos: 10 + próxima 1 tirada
- **Open**: No derribar todos los pines
  - Puntos: suma de pines derribados

### Frame 10 (Especial)
- Si hay strike o spare, se permite una tirada extra
- Máximo 3 tiradas en el frame 10

### Ejemplos de Puntuación

#### Juego Simple (sin strikes/spares)
```
Frame: 1  2  3  4  5  6  7  8  9  10
Tiradas: 3,4 2,5 1,6 4,3 2,6 3,5 1,7 2,6 4,4 3,5
Puntos: 7+12+19+26+34+42+50+58+66+74 = 74
```

#### Con Spare
```
Frame 1: 6,4 (spare) + próxima tirada (3) = 13
Frame 2: 3,2 = 5
Total Frame 1-2: 13 + 5 = 18
```

#### Con Strike
```
Frame 1: X (strike) + próximas 2 tiradas (3,4) = 17
Frame 2: 3,4 = 7
Total Frame 1-2: 17 + 7 = 24
```

## API Requerida

```csharp
public class BowlingGame
{
    public void Roll(int pins)        // Registra una tirada
    public int Score()                // Calcula el puntaje total
}
```

## 🔍 Casos de Prueba (Ejemplos)

Los tests incluidos son solo **ejemplos** para guiarte:
- ✅ Juego de canales: 20 × 0 pines → `0 puntos`
- ✅ Juego simple: 20 × 1 pin → `20 puntos`

**Nota**: El servidor ejecutará tests adicionales ocultos que evaluarán:
- Spares y strikes individuales
- Frame 10 especial (strikes/spares extra)
- Juego perfecto (300 puntos)
- Casos mixtos complejos
- Validaciones de reglas

## Enfoque TDD Sugerido

1. **Test más simple**: Juego de canales
2. **Agregar complejidad gradualmente**:
   - Tiradas normales
   - Un spare
   - Un strike
   - Frame 10 especial
   - Juego perfecto

## 💻 Archivos de Trabajo
- **Tu código**: `src/BowlingGame.cs` ← Implementa aquí
- **Tests ejemplo**: `tests/BowlingGameTests.cs` ← Solo 2 ejemplos

## Consejos de Implementación
- Mantén registro de todas las tiradas
- Calcula el score cuando sea solicitado
- Maneja el frame 10 como caso especial
- Usa TDD para cada caso incremental

## Criterio de Éxito
- Todos los tests pasan
- Maneja correctamente strikes, spares y frame 10
- Código limpio y bien estructurado
- Juego perfecto = 300 puntos