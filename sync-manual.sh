#!/bin/bash

# 🔄 Script Manual Simplificado - Sin GitHub CLI
# Para ejecutar paso a paso

echo "🔄 SINCRONIZACIÓN MANUAL SIMPLIFICADA"
echo "======================================"

# 1. Configurar variables
GITHUB_ORG="SincosoftSAS"
ASSIGNMENT_PREFIX="tdd-katas"  # Cambiar según tu prefijo
TODAY=$(date +%Y%m%d-%H%M%S)
BRANCH_NAME="template-fixes-$TODAY"

echo "📋 Configuración:"
echo "  - Organización: $GITHUB_ORG"
echo "  - Prefijo repos: $ASSIGNMENT_PREFIX"
echo "  - Rama: $BRANCH_NAME"
echo ""

# 2. Crear rama con cambios
echo "🌿 Paso 1: Creando rama con correcciones..."
git checkout -b $BRANCH_NAME
git add .
git commit -m "🔧 Template fixes: clean kata-1, fix kata-2 structure, add server tests"
git push origin $BRANCH_NAME

echo "✅ Rama creada: $BRANCH_NAME"
echo ""

# 3. Generar comandos para ejecutar manualmente
echo "📤 Paso 2: Comandos para crear PRs manualmente"
echo "=============================================="
echo ""
echo "# Copia y ejecuta estos comandos uno por uno:"
echo ""

# Lista de repos ejemplo (cambiar por los reales)
EXAMPLE_REPOS=(
    "tdd-katas-student1"
    "tdd-katas-student2" 
    "tdd-katas-student3"
    # Agregar todos los repos de estudiantes aquí
)

for repo in "${EXAMPLE_REPOS[@]}"; do
    echo "# Para $repo:"
    echo "curl -X POST \\"
    echo "  -H \"Authorization: token YOUR_GITHUB_TOKEN\" \\"
    echo "  -H \"Accept: application/vnd.github.v3+json\" \\"
    echo "  \"https://api.github.com/repos/$GITHUB_ORG/$repo/pulls\" \\"
    echo "  -d '{"
    echo "    \"title\": \"🔧 Template Updates - Sistema de Katas Mejorado\","
    echo "    \"body\": \"## 🔧 Actualizaciones del Template\\n\\n### ✅ Mejoras Incluidas:\\n- **Kata-1 limpio**: Eliminados archivos innecesarios\\n- **Kata-2 corregido**: Estructura .NET completa\\n- **Tests reducidos**: Solo 2 ejemplos por kata\\n\\n### 📋 Acción Requerida:\\n**Acepta este PR** para recibir las mejoras.\","
    echo "    \"head\": \"$GITHUB_ORG:$BRANCH_NAME\","
    echo "    \"base\": \"main\""
    echo "  }'"
    echo ""
done

echo "💡 ALTERNATIVA MÁS FÁCIL:"
echo "========================"
echo "1. Ve a GitHub.com"
echo "2. Navega a cada repo de estudiante"
echo "3. Haz clic en 'New pull request'"
echo "4. Selecciona:"
echo "   - Base: main (o master)"
echo "   - Compare: $GITHUB_ORG:$BRANCH_NAME"
echo "5. Título: '🔧 Template Updates'"
echo "6. Descripción: 'Mejoras del sistema de katas'"