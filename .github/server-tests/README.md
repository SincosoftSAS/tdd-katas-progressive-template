# Server Tests - Sistema Genérico

Este directorio contiene las pruebas comprehensivas del servidor que se ejecutan para evaluar automáticamente el progreso de cada kata.

## 📁 Estructura

```
server-tests/
├── kata-1/
│   └── ServerTests.cs    # Pruebas comprehensivas para FizzBuzz
├── kata-2/
│   └── ServerTests.cs    # Pruebas comprehensivas para Calculator
├── kata-3/
│   └── ServerTests.cs    # Pruebas comprehensivas para [siguiente kata]
└── README.md
```

## 🎯 Cómo Funciona

### 1. Sistema Genérico
- **Archivo único**: Cada kata tiene un archivo `ServerTests.cs` genérico
- **Auto-detección**: El workflow detecta automáticamente el directorio de tests
- **Integración**: Se agrega como archivo adicional al proyecto, no reemplaza

### 2. Workflow Automático
```bash
# El workflow automáticamente:
1. Encuentra el directorio de tests del estudiante (*.Tests)
2. Copia ServerTests.cs al directorio de tests
3. Ejecuta TODOS los tests (estudiante + servidor)
4. Evalúa el resultado completo
```

### 3. Ventajas del Nuevo Sistema
- ✅ **Escalable**: Funciona para cualquier kata futura
- ✅ **Genérico**: No requiere hardcodear nombres específicos
- ✅ **No invasivo**: Conserva los tests del estudiante
- ✅ **Comprehensivo**: Ejecuta tanto tests del estudiante como del servidor

## 📝 Creando Server Tests para Nueva Kata

Para agregar una nueva kata (ej: kata-3):

1. **Crear directorio**: `mkdir kata-3`
2. **Crear archivo**: `kata-3/ServerTests.cs`
3. **Usar template**:

```csharp
using Xunit;
using FluentAssertions;

namespace [YourNamespace].Tests
{
    /// <summary>
    /// Tests completos ejecutados en el servidor para evaluación.
    /// Los estudiantes no ven estos tests - se agregan automáticamente durante la evaluación
    /// </summary>
    public class ServerTests
    {
        [Fact]
        public void YourTest_Scenario_ExpectedResult()
        {
            // Arrange
            // Act
            // Assert with FluentAssertions
            result.Should().Be(expected);
        }
    }
}
```

## � Requisitos

- **Namespace**: Debe coincidir con el namespace del proyecto del estudiante
- **Framework**: xUnit con FluentAssertions
- **Nombre de clase**: Siempre `ServerTests`
- **Archivo**: Siempre `ServerTests.cs`

## ⚡ Ejecución

El sistema ejecuta automáticamente:
1. Tests del estudiante (verificación básica)
2. Tests del servidor (evaluación comprehensiva)
3. Evaluación combinada para determinar el progreso

Los estudiantes solo ven sus propios tests, pero el servidor evalúa contra las pruebas comprehensivas.