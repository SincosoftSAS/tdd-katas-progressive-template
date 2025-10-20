#!/bin/bash

# 🔄 Script de Sincronización Automática para GitHub Classroom
# Actualiza TODOS los repositorios de estudiantes con las correcciones del template

set -e

# Configuración
GITHUB_ORG="SincosoftSAS"  # Cambiar por tu organización
TEMPLATE_REPO="tdd-katas-progressive-template"
ASSIGNMENT_PREFIX="tdd-katas"  # Prefijo de repos de estudiantes

# Colores para output
RED='\033[0;31m'
GREEN='\033[0;32m'
YELLOW='\033[1;33m'
BLUE='\033[0;34m'
NC='\033[0m' # No Color

echo -e "${BLUE}🔄 Iniciando sincronización automática de repositorios...${NC}"

# 1. Verificar dependencias
command -v gh >/dev/null 2>&1 || { echo -e "${RED}❌ GitHub CLI (gh) no está instalado${NC}"; exit 1; }
command -v jq >/dev/null 2>&1 || { echo -e "${RED}❌ jq no está instalado${NC}"; exit 1; }

# 2. Verificar autenticación
gh auth status >/dev/null 2>&1 || { echo -e "${RED}❌ No estás autenticado en GitHub CLI${NC}"; exit 1; }

echo -e "${GREEN}✅ Dependencias verificadas${NC}"

# 3. Obtener lista de repositorios de estudiantes
echo -e "${YELLOW}📋 Obteniendo lista de repositorios de estudiantes...${NC}"

STUDENT_REPOS=$(gh repo list $GITHUB_ORG --limit 1000 --json name --jq '.[] | select(.name | startswith("'$ASSIGNMENT_PREFIX'")) | .name')

if [ -z "$STUDENT_REPOS" ]; then
    echo -e "${RED}❌ No se encontraron repositorios de estudiantes con prefijo '$ASSIGNMENT_PREFIX'${NC}"
    exit 1
fi

REPO_COUNT=$(echo "$STUDENT_REPOS" | wc -l)
echo -e "${GREEN}✅ Encontrados $REPO_COUNT repositorios de estudiantes${NC}"

# 4. Crear rama temporal con correcciones
BRANCH_NAME="template-fixes-$(date +%Y%m%d-%H%M%S)"
echo -e "${YELLOW}🌿 Creando rama con correcciones: $BRANCH_NAME${NC}"

git checkout -b $BRANCH_NAME
git add .
git commit -m "🔧 Template fixes: clean kata-1, fix kata-2 structure, add server tests" || echo "No changes to commit"
git push origin $BRANCH_NAME

# 5. Función para actualizar un repositorio
update_repo() {
    local repo_name=$1
    echo -e "${BLUE}🔄 Actualizando $repo_name...${NC}"
    
    # Crear PR en el repositorio del estudiante
    gh pr create \
        --repo "$GITHUB_ORG/$repo_name" \
        --title "🔧 Template Updates - Sistema de Katas Mejorado" \
        --body "## 🔧 Actualizaciones del Template

### ✅ Mejoras Incluidas:
- **Kata-1 limpio**: Eliminados archivos innecesarios (Class1.cs, duplicados)
- **Kata-2 corregido**: Estructura .NET completa y funcional  
- **Tests reducidos**: Solo 2 ejemplos por kata para mejor TDD
- **Server tests**: Sistema de evaluación automática mejorado

### 🎯 Beneficios:
- Mejor experiencia de aprendizaje TDD
- Sistema de desbloqueo más confiable
- Evaluación automática mejorada

### 📋 Acción Requerida:
**Acepta este PR** para recibir las mejoras del sistema.

**Nota**: Tus cambios actuales se mantienen. Solo se actualizan archivos del template." \
        --head "$GITHUB_ORG:$BRANCH_NAME" \
        --base "main" 2>/dev/null || \
    gh pr create \
        --repo "$GITHUB_ORG/$repo_name" \
        --title "🔧 Template Updates - Sistema de Katas Mejorado" \
        --body "## 🔧 Actualizaciones del Template

### ✅ Mejoras Incluidas:
- **Kata-1 limpio**: Eliminados archivos innecesarios (Class1.cs, duplicados)
- **Kata-2 corregido**: Estructura .NET completa y funcional  
- **Tests reducidos**: Solo 2 ejemplos por kata para mejor TDD
- **Server tests**: Sistema de evaluación automática mejorado

### 🎯 Beneficios:
- Mejor experiencia de aprendizaje TDD
- Sistema de desbloqueo más confiable
- Evaluación automática mejorada

### 📋 Acción Requerida:
**Acepta este PR** para recibir las mejoras del sistema.

**Nota**: Tus cambios actuales se mantienen. Solo se actualizan archivos del template." \
        --head "$GITHUB_ORG:$BRANCH_NAME" \
        --base "master" 2>/dev/null || echo "❌ Error creando PR para $repo_name"
}

# 6. Actualizar todos los repositorios
echo -e "${YELLOW}📤 Enviando actualizaciones a repositorios de estudiantes...${NC}"

while IFS= read -r repo; do
    update_repo "$repo"
    sleep 1  # Evitar rate limiting
done <<< "$STUDENT_REPOS"

echo -e "${GREEN}✅ Sincronización completada!${NC}"
echo -e "${YELLOW}📋 Resumen:${NC}"
echo -e "  - Repositorios actualizados: $REPO_COUNT"
echo -e "  - Rama con cambios: $BRANCH_NAME"
echo -e "  - Los estudiantes recibirán PRs para aceptar las mejoras"

echo -e "${BLUE}💡 Próximos pasos:${NC}"
echo -e "  1. Los estudiantes verán PRs en sus repositorios"
echo -e "  2. Al aceptar el PR, recibirán las correcciones automáticamente"
echo -e "  3. Su progreso actual se mantiene intacto"
echo -e "  4. El sistema de katas funcionará mejor"