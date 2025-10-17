# Kata 01: FizzBuzz

## 🎯 Objetivo

Crear un método que implemente el clásico juego FizzBuzz, un ejercicio fundamental para aprender TDD (Test-Driven Development).

## 📝 Descripción del Problema

Escribe un método `Generate(int n)` que:
- Recibe un número entero positivo `n`
- Devuelve una lista con los valores del 1 al `n`, pero:
  - Reemplaza múltiplos de 3 con `"Fizz"`
  - Reemplaza múltiplos de 5 con `"Buzz"`
  - Reemplaza múltiplos de 3 y 5 con `"FizzBuzz"`

## 🧪 Ejemplos

```csharp
Generate(5)  → ["1", "2", "Fizz", "4", "Buzz"]
Generate(15) → ["1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"]
```

## 📋 Requisitos Paso a Paso

Sigue TDD: escribe el test primero (🔴 RED), luego la implementación mínima (🟢 GREEN), y finalmente refactoriza (🔵 REFACTOR).

### Paso 1: Casos básicos
- ✅ `Generate(1)` debe devolver `["1"]`
- ✅ `Generate(2)` debe devolver `["1", "2"]`

### Paso 2: Múltiplos de 3
- ✅ `Generate(3)` debe devolver `["1", "2", "Fizz"]`
- ✅ `Generate(6)` debe incluir `"Fizz"` en posiciones 2 y 5 (índice 0-based)

### Paso 3: Múltiplos de 5
- ✅ `Generate(5)` debe incluir `"Buzz"` en posición 4
- ✅ `Generate(10)` debe incluir `"Buzz"` en posiciones 4 y 9

### Paso 4: Múltiplos de 3 y 5
- ✅ `Generate(15)` debe incluir `"FizzBuzz"` en posición 14
- ✅ `Generate(30)` debe incluir `"FizzBuzz"` en posiciones 14 y 29

## 🚀 Comenzar

### 1. Cambiar a la rama de esta kata

```bash
git checkout kata-01-fizzbuzz
```

### 2. Crear estructura de proyecto

```bash
# Crear proyecto de implementación
mkdir -p FizzBuzz
cat > FizzBuzz/FizzBuzz.cs << 'EOF'
namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        public List<string> Generate(int n)
        {
            // TODO: Implement FizzBuzz logic
            throw new NotImplementedException("FizzBuzz not implemented yet");
        }
    }
}
EOF

# Crear archivo de proyecto
cat > FizzBuzz/FizzBuzz.csproj << 'EOF'
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>
</Project>
EOF
```

### 3. Crear proyecto de tests

```bash
mkdir -p FizzBuzz.Tests
cat > FizzBuzz.Tests/FizzBuzzTests.cs << 'EOF'
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        private readonly FizzBuzzGenerator _generator = new();

        [Fact]
        public void Generate_WithOne_ReturnsListWithOne()
        {
            var result = _generator.Generate(1);
            Assert.Equal(new[] { "1" }, result);
        }

        [Fact]
        public void Generate_WithTwo_ReturnsListWithOneTwo()
        {
            var result = _generator.Generate(2);
            Assert.Equal(new[] { "1", "2" }, result);
        }

        // TODO: Add more tests following TDD
    }
}
EOF

# Crear archivo de proyecto de tests
cat > FizzBuzz.Tests/FizzBuzz.Tests.csproj << 'EOF'
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
    <IsPackable>false</IsPackable>
    <IsTestProject>true</IsTestProject>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="coverlet.collector" Version="6.0.0" />
    <PackageReference Include="Microsoft.NET.Test.Sdk" Version="17.8.0" />
    <PackageReference Include="xunit" Version="2.5.3" />
    <PackageReference Include="xunit.runner.visualstudio" Version="2.5.3" />
  </ItemGroup>

  <ItemGroup>
    <ProjectReference Include="..\FizzBuzz\FizzBuzz.csproj" />
  </ItemGroup>
</Project>
EOF
```

### 4. Crear solución

```bash
dotnet new sln -n FizzBuzz
dotnet sln add FizzBuzz/FizzBuzz.csproj
dotnet sln add FizzBuzz.Tests/FizzBuzz.Tests.csproj
```

### 5. Ejecutar tests

```bash
dotnet restore
dotnet build
dotnet test
```

## 💡 Pistas

1. **Comienza simple**: Primero haz que funcione para números sin Fizz/Buzz
2. **Un caso a la vez**: Implementa múltiplos de 3, luego de 5, luego ambos
3. **Orden importa**: Verifica múltiplos de 15 ANTES que múltiplos de 3 o 5
4. **Refactoriza**: Una vez que todos los tests pasen, limpia el código

## 🧪 Tests Visibles vs Ocultos

### Tests Visibles (en tu repositorio)
- ✅ Casos básicos (n=1, n=2)
- ✅ Múltiplos simples de 3 y 5
- ✅ Caso FizzBuzz (15)

### Tests Ocultos (se ejecutan en GitHub Actions) 🔒
- 🔒 Casos edge (n=0, números grandes)
- 🔒 Validación completa de secuencia
- 🔒 Casos especiales adicionales

**Nota**: No te preocupes por los tests ocultos al inicio. Si tu implementación es correcta según los tests visibles, probablemente pasará los ocultos también.

## ✅ Criterios de Éxito

- [ ] Todos los tests locales pasan (`dotnet test`)
- [ ] El código está limpio y refactorizado
- [ ] Push exitoso a GitHub
- [ ] GitHub Actions muestra todos los tests pasados (incluidos ocultos)
- [ ] **Se desbloquea automáticamente la Kata 02** 🔓

## 🎓 Conceptos de TDD que Aprenderás

1. **Red-Green-Refactor cycle**: El ritmo fundamental de TDD
2. **Incremental development**: Construir funcionalidad paso a paso
3. **Test first**: Escribir tests antes de implementación
4. **Refactoring**: Mejorar código sin cambiar comportamiento

## 📚 Recursos Adicionales

- [Introducción a TDD](https://en.wikipedia.org/wiki/Test-driven_development)
- [xUnit Documentation](https://xunit.net/docs/getting-started/netcore/cmdline)
- [FizzBuzz Kata Original](http://codingdojo.org/kata/FizzBuzz/)

---

## 🚦 Workflow Recomendado

```bash
# 1. Escribir un test que falla (RED)
dotnet test  # ❌ Debe fallar

# 2. Escribir código mínimo para que pase (GREEN)
# ... editar FizzBuzz/FizzBuzz.cs ...
dotnet test  # ✅ Debe pasar

# 3. Refactorizar (REFACTOR)
# ... mejorar código ...
dotnet test  # ✅ Sigue pasando

# 4. Repetir para siguiente requisito
```

## 📤 Enviar para Evaluación

```bash
# Cuando todos los tests locales pasen:
git add .
git commit -m "Implement FizzBuzz kata"
git push origin kata-01-fizzbuzz
```

**GitHub Actions** evaluará tu código con tests adicionales. Si pasas todos:
- ✅ Kata 01 completada
- 🎉 ¡Felicitaciones!
- 🔓 **Kata 02 se desbloqueará automáticamente**

---

¡Buena suerte con tu primera kata! 🚀💪
