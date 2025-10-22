# 📋 Sistema de Archivos Administrativos

## 🎯 Objetivo

Este documento explica cómo funciona el sistema de filtrado de archivos para asegurar que **solo los archivos necesarios** lleguen a los repositorios de estudiantes.

## 🔒 Archivos Excluidos (Solo Instructores)

Los siguientes archivos **NUNCA** se sincronizan a repos de estudiantes:

### 📜 Scripts Administrativos
- `sync-students.sh` - Script de sincronización manual
- `sync-manual.sh` - Script de sincronización alternativo
- `create-test-repo.sh` - Script para crear repos de prueba
- `install-hooks.sh` / `install-hooks.bat` - Instaladores de git hooks

### 📚 Documentación Interna
- `DEBUG-WORKFLOW.md` - Guía de debugging del workflow
- `GUIA-SINCRONIZACION.md` - Guía de sincronización para instructores
- `SISTEMA-DESBLOQUEO.md` - Documentación técnica del sistema
- `definicion.md` - Definiciones internas del proyecto
- `.adminignore` - Este mismo archivo de configuración

### 📁 Carpetas Administrativas
- `.github/kata-templates/` - Templates de katas futuras (se copian bajo demanda)
- `.github/backups/` - Respaldos del sistema
- `.github/hooks/` - Git hooks personalizados
- `.github/workflows/sync-to-students.yml` - Workflow de sincronización

### 🗂️ Archivos Temporales
- `*.backup` / `*.bak` - Archivos de respaldo
- `.admin/` - Carpeta administrativa
- `temp_repo/` - Carpeta temporal de clonación
- `student_repos.txt` - Lista temporal de repos

## ✅ Archivos Sincronizados (Estudiantes)

Los siguientes archivos **SÍ** se sincronizan a repos de estudiantes:

### 📚 Katas
- `katas/kata-X/` - Solo las katas desbloqueadas según progreso

### ⚙️ Sistema de Evaluación
- `.github/workflows/grade-kata.yml` - Workflow de auto-evaluación
- `.github/server-tests/` - Tests del servidor para evaluación
- `.github/progress.json` - Seguimiento de progreso del estudiante

### 📖 Documentación de Usuario
- `README.md` - Guía principal del proyecto

### 🔧 Configuración
- `.gitignore` - Exclusiones estándar de .NET

## 🔄 Cómo Funciona el Filtrado

### 1. Durante Sincronización Automática (GitHub Actions)

El workflow `.github/workflows/sync-to-students.yml`:

```bash
# 1. Lee patrones de .adminignore
# 2. Copia archivos necesarios del template
# 3. Elimina archivos administrativos explícitamente:

for admin_file in sync-students.sh sync-manual.sh ...; do
  rm -f "$admin_file"
done
```

### 2. Configuración en `.adminignore`

El archivo `.adminignore` contiene patrones de archivos a excluir:

```
# Comentario
nombre-archivo.sh
carpeta/
*.backup
```

## 🛠️ Mantenimiento

### Agregar Nuevo Archivo Administrativo

1. Crear el archivo en el template
2. Agregarlo a `.adminignore`
3. Agregarlo a la lista de limpieza en `sync-to-students.yml`

### Verificar Filtrado

1. Ejecutar sincronización en modo dry-run
2. Verificar que archivos administrativos no aparezcan
3. Confirmar sincronización si todo está correcto

## 📊 Resumen

| Categoría | Template | Estudiantes |
|-----------|----------|-------------|
| Scripts admin | ✅ Sí | ❌ No |
| Docs internas | ✅ Sí | ❌ No |
| Katas templates | ✅ Sí | ⚠️ Solo desbloqueadas |
| Workflow evaluación | ✅ Sí | ✅ Sí |
| Server tests | ✅ Sí | ✅ Sí |
| Progress tracking | ✅ Sí | ✅ Sí |
| README | ✅ Sí | ✅ Sí |

## 🔐 Seguridad

El filtrado asegura que:

- ✅ Estudiantes no vean soluciones de katas futuras
- ✅ Estudiantes no vean documentación interna
- ✅ Estudiantes no puedan ejecutar scripts de sincronización
- ✅ El sistema mantiene separación instructor/estudiante
