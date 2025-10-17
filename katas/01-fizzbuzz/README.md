# Kata 01: FizzBuzz

## 🎯 Objetivo

Crear una función que implemente el clásico juego FizzBuzz, un ejercicio fundamental para aprender TDD (Test-Driven Development).

## 📝 Descripción del Problema

Escribe una función `fizzbuzz(n)` que:
- Recibe un número entero positivo `n`
- Devuelve un array con los números del 1 al `n`, pero:
  - Reemplaza múltiplos de 3 con `"Fizz"`
  - Reemplaza múltiplos de 5 con `"Buzz"`
  - Reemplaza múltiplos de 3 y 5 con `"FizzBuzz"`

## 🧪 Ejemplos

```javascript
fizzbuzz(5)  → [1, 2, "Fizz", 4, "Buzz"]
fizzbuzz(15) → [1, 2, "Fizz", 4, "Buzz", "Fizz", 7, 8, "Fizz", "Buzz", 11, "Fizz", 13, 14, "FizzBuzz"]
```

## 📋 Requisitos Paso a Paso

Sigue TDD: escribe el test primero (🔴 RED), luego la implementación mínima (🟢 GREEN), y finalmente refactoriza (🔵 REFACTOR).

### Paso 1: Casos básicos
- ✅ `fizzbuzz(1)` debe devolver `[1]`
- ✅ `fizzbuzz(2)` debe devolver `[1, 2]`

### Paso 2: Múltiplos de 3
- ✅ `fizzbuzz(3)` debe devolver `[1, 2, "Fizz"]`
- ✅ `fizzbuzz(6)` debe incluir `"Fizz"` en posiciones 3 y 6

### Paso 3: Múltiplos de 5
- ✅ `fizzbuzz(5)` debe incluir `"Buzz"` en posición 5
- ✅ `fizzbuzz(10)` debe incluir `"Buzz"` en posiciones 5 y 10

### Paso 4: Múltiplos de 3 y 5
- ✅ `fizzbuzz(15)` debe incluir `"FizzBuzz"` en posición 15
- ✅ `fizzbuzz(30)` debe incluir `"FizzBuzz"` en posiciones 15 y 30

## 🚀 Comenzar

### 1. Cambiar a la rama de esta kata

```bash
git checkout kata-01-fizzbuzz
```

### 2. Crear estructura de archivos

```bash
mkdir -p src tests
```

### 3. Crear archivo de implementación

```bash
cat > src/fizzbuzz.js << 'EOF'
/**
 * FizzBuzz implementation
 * @param {number} n - Upper limit
 * @returns {Array} - Array with FizzBuzz sequence
 */
function fizzbuzz(n) {
  // TODO: Implement FizzBuzz logic
  throw new Error('Not implemented');
}

module.exports = fizzbuzz;
EOF
```

### 4. Crear archivo de tests

```bash
cat > tests/fizzbuzz.test.js << 'EOF'
const fizzbuzz = require('../src/fizzbuzz');

describe('FizzBuzz', () => {
  test('should return [1] for input 1', () => {
    expect(fizzbuzz(1)).toEqual([1]);
  });

  test('should return [1, 2] for input 2', () => {
    expect(fizzbuzz(2)).toEqual([1, 2]);
  });

  // TODO: Add more tests following TDD
});
EOF
```

### 5. Instalar dependencias

```bash
npm install
```

### 6. Ejecutar tests

```bash
npm test
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

- [ ] Todos los tests locales pasan (`npm test`)
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
- [Jest Documentation](https://jestjs.io/docs/getting-started)
- [FizzBuzz Kata Original](http://codingdojo.org/kata/FizzBuzz/)

---

## 🚦 Workflow Recomendado

```bash
# 1. Escribir un test que falla (RED)
npm test  # ❌ Debe fallar

# 2. Escribir código mínimo para que pase (GREEN)
# ... editar src/fizzbuzz.js ...
npm test  # ✅ Debe pasar

# 3. Refactorizar (REFACTOR)
# ... mejorar código ...
npm test  # ✅ Sigue pasando

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
