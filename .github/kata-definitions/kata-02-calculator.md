# Kata 02: String Calculator

## ÌæØ Objetivo

Crear una calculadora de strings que suma n√∫meros separados por delimitadores.

## Ì≥ù Requisitos

### Paso 1: String vac√≠o y n√∫meros simples ‚úÖ
```
Add("") ‚Üí 0
Add("1") ‚Üí 1
Add("1,2") ‚Üí 3
```

### Paso 2: M√∫ltiples n√∫meros ‚úÖ
```
Add("1,2,3,4,5") ‚Üí 15
```

### Paso 3: Delimitador newline Ì¥í
```
Add("1\n2,3") ‚Üí 6
```

### Paso 4: Delimitadores personalizados Ì¥í
```
Add("//;\n1;2") ‚Üí 3
```

### Paso 5: N√∫meros negativos Ì¥í
```
Add("1,-2,3") ‚Üí Exception: "Negatives not allowed: -2"
```

## Ì∫Ä Comenzar

```bash
git checkout kata-02-calculator
mkdir -p StringCalculator StringCalculator.Tests
dotnet new classlib -n StringCalculator -o StringCalculator
dotnet new xunit -n StringCalculator.Tests -o StringCalculator.Tests
dotnet add StringCalculator.Tests reference StringCalculator
dotnet test
```

¬°√âxito en tu segunda kata! Ì∫Ä
