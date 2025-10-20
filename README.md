# 🎯 Viaje TDD - Katas Progresivos

¡Bienvenido a tu viaje personal de aprendizaje TDD! Domina el Desarrollo Dirigido por Pruebas completando katas uno a la vez.

## 📁 Estructura Simple

```
katas/
├── kata-1/          # 🔓 DESBLOQUEADO - ¡Empieza aquí!
│   ├── README.md    # Instrucciones  
│   ├── src/         # Tu código
│   └── tests/       # Pruebas
├── kata-2/          # 🔒 Se desbloquea cuando kata-1 esté completo
├── kata-3/          # 🔒 Y así sucesivamente...
└── ...
```

## 🚀 Empezando

```bash
# Trabaja en el kata actual
cd katas/kata-1

# Ejecuta las pruebas (¡deben fallar inicialmente - ¡eso es TDD!)
dotnet test

# Escribe código en src/ para hacer que las pruebas pasen
# Sigue: Rojo → Verde → Refactor

# ¡Cuando todas las pruebas pasen, kata-2 se desbloquea automáticamente!
```

## 💻 Trabajando en un Kata

### Flujo de Trabajo TDD (Rojo → Verde → Refactor)

1. **Leer**: Revisa el `README.md` del kata para instrucciones
2. **Rojo**: Ejecuta `dotnet test` - las pruebas deben fallar ❌
3. **Verde**: Escribe código mínimo para hacer que las pruebas pasen ✅
4. **Refactor**: Mejora el código manteniendo las pruebas en verde 🔄
5. **Repetir**: Hasta que todos los requisitos se cumplan

### Características Automáticas

- ✅ **Estado de Commit**: Ve los resultados directamente en GitHub
- 📋 **Issues Automáticos**: Obtén ayuda cuando las pruebas fallen  
- 🔓 **Desbloqueo Automático**: El siguiente kata aparece cuando el actual se completa
- 📊 **Seguimiento de Progreso**: `.github/progress.json` mantiene el puntaje

## 🔄 Flujo de Trabajo Simple

```bash
# 1. Trabaja en el kata actual
cd katas/kata-1

# 2. Sigue el ciclo TDD
dotnet test          # Ve las pruebas que fallan
# Escribe código en src/
dotnet test          # Ve las pruebas pasar

# 3. Sube cuando esté listo
git add .
git commit -m "Completa kata-1"
git push origin master

# 4. ¡El siguiente kata se desbloquea automáticamente! 🎉
```

## 📊 Tu Progreso

- **Kata actual**: Revisa `.github/progress.json`
- **Katas completados**: Mostrados en el mismo archivo
- **Retroalimentación visual**: Estado de commit en GitHub
- **Ayuda**: Issues creados automáticamente cuando las pruebas fallan

## 🎓 Objetivos de Aprendizaje

- Dominar el Desarrollo Dirigido por Pruebas (TDD)
- Aprender el ciclo Rojo-Verde-Refactor
- Experimentar desarrollo incremental
- Construir confianza con pruebas automatizadas

## 📚 Mejoras Opcionales

- **Hooks pre-commit**: Instala con `./install-hooks.sh` para retroalimentación local
- **Retroalimentación detallada**: Ve `FEEDBACK-SISTEMA.md` para todos los canales de retroalimentación

---

¡Feliz programación! 🚀💪