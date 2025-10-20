# 📋 Tests del Servidor - Sistema de Evaluación

Esta carpeta contiene los **tests completos** que se ejecutan en el servidor para evaluar automáticamente el trabajo de los estudiantes.

## 🔒 Propósito

- **Estudiantes ven**: Solo 1-2 tests de ejemplo en cada kata
- **Servidor ejecuta**: Tests completos y exhaustivos para evaluación real
- **Beneficios**: Los estudiantes practican TDD sin conocer todos los casos, desarrollando pensamiento crítico

## 📁 Estructura

```
server-tests/
├── kata-1/
│   └── FizzBuzzServerTests.cs      # Tests completos para FizzBuzz
├── kata-2/
│   └── CalculatorServerTests.cs    # Tests completos para Calculator
├── kata-3/
│   └── LeapYearServerTests.cs      # Tests completos para LeapYear
├── kata-4/
│   └── StringCalculatorServerTests.cs  # Tests completos para String Calculator
└── kata-5/
    └── BowlingGameServerTests.cs   # Tests completos para Bowling Game
```

## 🎯 Filosofía del Sistema

### Para Estudiantes (Tests Ejemplo)
- ✅ **Guía inicial**: 1-2 tests muestran la dirección
- ✅ **TDD real**: Deben pensar en casos adicionales  
- ✅ **Aprendizaje**: Desarrollan intuición para casos edge

### Para Servidor (Tests Completos)
- 🔍 **Evaluación exhaustiva**: Todos los casos límite
- 🔍 **Casos negativos**: Validaciones y excepciones
- 🔍 **Cobertura completa**: Verificación de toda la funcionalidad

## 🚀 Implementación en Workflow

El workflow `grade-kata.yml` debería:
1. Ejecutar tests ejemplo (visibles al estudiante)
2. Si pasan, ejecutar tests del servidor (ocultos)
3. Determinar si el kata está completo basado en tests del servidor
4. Proporcionar feedback apropiado

## 💡 Ventajas del Enfoque

- **Práctica real de TDD**: Los estudiantes deben pensar en casos
- **Evaluación justa**: Tests completos aseguran calidad
- **Feedback constructivo**: Pueden saber que falta sin ver la solución
- **Escalabilidad**: Fácil agregar/modificar tests sin afectar experiencia estudiantil