# 🐛 Debug: Problema de Sintaxis Corregido

## 🚨 Error Original
```bash
# Línea problemática en workflow:
NEXT=$((steps.kata.outputs.number + 1))

# Error que producía:
/home/runner/work/_temp/56939bf8-8616-4f7e-b34f-bdbe34ee2950.sh: line 1: 
steps.kata.outputs.number + 1: syntax error: invalid arithmetic operator 
(error token is ".kata.outputs.number + 1")
```

## ✅ Solución Aplicada
```bash
# INCORRECTO - Variable de GitHub Actions no se expande:
NEXT=$((steps.kata.outputs.number + 1))

# CORRECTO - Expandir la variable primero:
CURRENT=${{ steps.kata.outputs.number }}
NEXT=$((CURRENT + 1))
```

## 🔧 Cambios Realizados

### En `.github/workflows/grade-kata.yml`:

#### Paso "Update progress on success":
```yaml
# Antes:
NEXT=$((steps.kata.outputs.number + 1))

# Ahora:
CURRENT=${{ steps.kata.outputs.number }}
NEXT=$((CURRENT + 1))
```

#### Paso "Unlock next kata":
```yaml  
# Antes:
NEXT=$((steps.kata.outputs.number + 1))

# Ahora:
CURRENT=${{ steps.kata.outputs.number }}
NEXT=$((CURRENT + 1))
```

## 🎯 Explicación del Problema

### GitHub Actions Variables
- `${{ steps.kata.outputs.number }}` → Se expande en **build time**
- Las operaciones bash `$((...))` se ejecutan en **runtime**
- Bash no entiende la sintaxis `steps.kata.outputs.number`

### Solución
1. **Expandir** la variable de GitHub Actions a una variable bash
2. **Usar** esa variable bash en operaciones aritméticas

## ✅ Verificación Local
```bash
# Test realizado - funciona correctamente:
CURRENT=1
NEXT=$((CURRENT + 1))  # ✅ NEXT=2

# El workflow ahora debería:
# 1. Detectar kata actual: 1
# 2. Calcular siguiente: 2  
# 3. Copiar template kata-2 a katas/
# 4. Commit y push automático
```

## 🚀 Estado del Sistema
- ✅ **Sintaxis corregida** en workflow
- ✅ **Logic verificada** localmente 
- ✅ **Template limpio** (solo kata-1)
- ✅ **Listo para GitHub Classroom**

El sistema ahora debería desbloquear automáticamente kata-2 cuando el estudiante complete kata-1. 🎓