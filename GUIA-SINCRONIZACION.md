# 🔄 Guía de Sincronización Manual - Actualizaciones del Template

## 🎯 Problema Resuelto
Has identificado problemas en el template actual:
- ✅ **Kata-1**: Archivos innecesarios (Class1.cs), múltiples clases, demasiados tests
- ✅ **Kata-2**: Estructura .NET incorrecta, genera errores
- ✅ **Tests servidor**: Faltaban para evaluación automática

## 🔧 Correcciones Aplicadas

### Kata-1 (Limpiado):
```
katas/kata-1/
├── src/FizzBuzz/
│   └── FizzBuzzGenerator.cs     # ✅ Solo esta clase
└── tests/FizzBuzz.Tests/
    └── FizzBuzzGeneratorTests.cs # ✅ Solo 2 tests ejemplo
```

### Kata-2 (Corregido):
```
.github/kata-templates/kata-2/
├── Kata2.sln                    # ✅ Solución .NET completa
├── src/Calculator/Calculator/
│   └── Calculator.cs            # ✅ 4 métodos con NotImplementedException
└── tests/Calculator.Tests/Calculator.Tests/
    └── CalculatorTests.cs       # ✅ Solo 2 tests ejemplo
```

### Tests Servidor (Agregados):
```
.github/server-tests/
├── kata-1/FizzBuzzServerTests.cs     # ✅ 10 tests completos
└── kata-2/CalculatorServerTests.cs   # ✅ 10 tests completos
```

## 🚀 Opciones de Sincronización

### Opción 1: Script Automático (Recomendado)
```bash
# Ejecutar desde el directorio del template:
./sync-students.sh
```

**¿Qué hace?**
- 🔍 Encuentra todos los repos de estudiantes automáticamente
- 📤 Crea PRs en cada repositorio con las correcciones
- 🎯 Los estudiantes solo necesitan aceptar el PR
- ✅ Mantiene el progreso actual de cada estudiante

### Opción 2: Manual por Repositorio
Si prefieres control manual:

```bash
# 1. Crear rama con correcciones
git checkout -b template-fixes-manual
git add .
git commit -m "🔧 Template fixes: clean kata-1, fix kata-2"
git push origin template-fixes-manual

# 2. Para cada repo de estudiante:
gh pr create \
  --repo "SincosoftSAS/student-repo-name" \
  --title "🔧 Template Updates" \
  --body "Correcciones del template..." \
  --head "SincosoftSAS:template-fixes-manual" \
  --base "main"
```

### Opción 3: Sin Sincronización (Nuevo Template)
Si prefieres empezar con template limpio:
1. ✅ El template actual ya está corregido
2. 🆕 Nuevas asignaciones usarán la versión corregida
3. 📚 Estudiantes actuales continúan con su versión

## 📋 Recomendación

**Usa Opción 1 (Script Automático)** porque:
- ✅ No pierdes estudiantes actuales
- ✅ Todos reciben las mejoras
- ✅ Proceso automatizado y confiable
- ✅ Los estudiantes solo aceptan un PR

## 🔍 Verificación Post-Sincronización

Después de sincronizar, verificar que:
```bash
# 1. Template tiene solo kata-1 inicialmente
ls katas/  # Debe mostrar solo: kata-1/

# 2. Kata-2 template está listo
ls .github/kata-templates/  # Debe mostrar: kata-2/ kata-3/ kata-4/ kata-5/

# 3. Tests servidor existen
ls .github/server-tests/  # Debe mostrar: kata-1/ kata-2/

# 4. Workflow funciona
cat .github/workflows/grade-kata.yml | grep "CURRENT=\${{ steps.kata.outputs.number }}"
```

## 💡 Resultado Final
- 🎓 **100 estudiantes** reciben correcciones sin perder progreso
- 🔧 **Template perfecto** para nuevos estudiantes  
- 🤖 **Sistema automático** funcional y confiable
- 📊 **Evaluación justa** con tests servidor completos