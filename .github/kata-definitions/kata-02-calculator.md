# Kata 02: String Calculator

## � Objetivo

Crear una calculadora de strings que suma números separados por delimitadores.

## � Requisitos

### Paso 1: String vacío y números simples ✅
```
Add("") → 0
Add("1") → 1
Add("1,2") → 3
```

### Paso 2: Múltiples números ✅
```
Add("1,2,3,4,5") → 15
```

### Paso 3: Delimitador newline �
```
Add("1\n2,3") → 6
```

### Paso 4: Delimitadores personalizados �
```
Add("//;\n1;2") → 3
```

### Paso 5: Números negativos �
```
Add("1,-2,3") → Exception: "Negatives not allowed: -2"
```

## � Comenzar

```bash
git checkout kata-02-calculator
mkdir -p StringCalculator StringCalculator.Tests
dotnet new classlib -n StringCalculator -o StringCalculator
dotnet new xunit -n StringCalculator.Tests -o StringCalculator.Tests
dotnet add StringCalculator.Tests reference StringCalculator
dotnet test
```

¡Éxito en tu segunda kata! �
