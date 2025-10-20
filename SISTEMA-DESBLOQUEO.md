# 🔐 Sistema de Desbloqueo Progresivo

## 🎯 Comportamiento del Template

### Estado Inicial (Después de `Use this template`)
```
katas/
└── kata-1/     # ✅ ÚNICO kata disponible inicialmente
    ├── README.md
    ├── src/
    └── tests/
```

### Después de Completar Kata-1
```
katas/
├── kata-1/     # ✅ Completado
└── kata-2/     # 🆕 DESBLOQUEADO automáticamente
    ├── README.md
    ├── src/ 
    └── tests/
```

### Progresión Completa
```
katas/
├── kata-1/     # ✅ Completado
├── kata-2/     # ✅ Completado  
├── kata-3/     # 🆕 DESBLOQUEADO automáticamente
├── kata-4/     # 🔒 Aún bloqueado
└── kata-5/     # 🔒 Aún bloqueado
```

## ⚙️ Mecánica del Sistema

### 1. Template Inicial
- Solo `kata-1` en carpeta `katas/`
- Todas las demás katas están en `.github/kata-templates/`
- `progress.json` indica `"current_kata": 1`

### 2. Workflow de Desbloqueo
```yaml
# Cuando se completan los tests del kata actual:
1. Actualiza progress.json: current_kata++
2. Copia .github/kata-templates/kata-X a katas/kata-X  
3. Commit automático con el nuevo kata
4. Push al repositorio
```

### 3. Estados de Kata
- 🔒 **Bloqueado**: Solo existe en templates, no visible
- 🔓 **Desbloqueado**: Copiado a katas/, tests fallan (TDD)
- ✅ **Completado**: Tests pasan, marcado en progress.json

## 🚀 Flujo para Estudiantes

1. **Clona repo**: Solo ve `katas/kata-1/`
2. **Completa kata-1**: Hace que tests pasen 
3. **Push**: Workflow detecta completion
4. **Auto-unlock**: `kata-2` aparece mágicamente
5. **Repite**: Hasta completar todos los katas

## 🛠️ Para Instructores

### Agregar Nuevos Katas
```bash
# 1. Crear template
mkdir .github/kata-templates/kata-6
# ... agregar src/, tests/, README.md

# 2. Actualizar progress.json
jq '.total_katas = 6' .github/progress.json

# 3. El workflow manejará el resto automáticamente
```

### Verificar Estado
```bash
# Ver progreso actual
cat .github/progress.json

# Ver katas disponibles vs templates
ls katas/          # Katas desbloqueados
ls .github/kata-templates/  # Katas disponibles
```

## ✅ Estado Actual del Sistema

- ✅ Template limpio (solo kata-1)
- ✅ 4 templates listos (kata-2 a kata-5)
- ✅ Workflow configurado para desbloqueo
- ✅ Tests duales (ejemplo + servidor)
- ✅ Documentación completa

¡El sistema está listo para GitHub Classroom! 🎓